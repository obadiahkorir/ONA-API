using Microsoft.SharePoint.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ONAAPI.Connections;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;

namespace ONAAPI
{
    public class Worker
    {
        public async void StartProcessing(CancellationToken cancellationToken = default(CancellationToken), string FormNumber=null , string ProjectNumber = null)
        {
            string Errorfilepath = ConfigurationManager.AppSettings["Error"];
            try
            {
                HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
                string SharepointUserName = ConfigurationManager.AppSettings["S_USERNAME"];
                string SharepointPassword = ConfigurationManager.AppSettings["S_PWD"];
                string SharepointDomain = ConfigurationManager.AppSettings["S_DOMAIN"];
                string SharepointURL = ConfigurationManager.AppSettings["S_URL"];
                string SharepointLibrary = ConfigurationManager.AppSettings["S_DefaultLibrary"];
                string sMainFolder = ConfigurationManager.AppSettings["S_MainFolder"];
                string sSubFolder = ConfigurationManager.AppSettings["S_SubFolder"];
                string FolderPath = ConfigurationManager.AppSettings["FolderPath"];
                string UploadingFolder = ConfigurationManager.AppSettings["UploadingFolder"];
                bool bbConnected = SharePointConnectionConfig.Connect(SharepointURL, SharepointUserName, SharepointPassword, SharepointDomain);

                if (bbConnected)
                {
                    HttpClient _client = new HttpClient();
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.DefaultConnectionLimit = 9999;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                                           | SecurityProtocolType.Tls11
                                                           | SecurityProtocolType.Tls12
                                                           | SecurityProtocolType.Ssl3;
                    _client.DefaultRequestHeaders.Accept.Clear();
                    _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    _client.DefaultRequestHeaders.Add("Authorization", "Token 3a0cea84cc42941b8de1e402e48154f6bc293f25");
                    HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/" + FormNumber + "? format=json");
                    response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        var DataArray = JsonConvert.DeserializeObject<JArray>(responseBody).Root.ToList();

                        //Create SubSite
                        var web = SharePointConnectionConfig.SPClientContext.Web;
                        SharePointConnectionConfig.SPClientContext.Load(web, w => w.Webs);
                        SharePointConnectionConfig.SPClientContext.ExecuteQuery();


                        var SharepointSubSite = SharepointURL + FormNumber;
                        // use a simple linq query to get any sub webs with the URL we want to check
                        var subWeb = (from w in web.Webs where w.Url == SharepointSubSite select w).SingleOrDefault();
                        if (subWeb == null)
                        {
                            Web subSiteWeb = SharePointConnectionConfig.SPClientContext.Web;
                            WebCreationInformation webCreationInformation = new WebCreationInformation()
                            {
                                WebTemplate = "STS#3",
                                Title = FormNumber,
                                Url = FormNumber,
                                Language = 1033,
                                UseSamePermissionsAsParentSite = true
                            };

                            subSiteWeb = SharePointConnectionConfig.SPClientContext.Web.Webs.Add(webCreationInformation);
                            SharePointConnectionConfig.SPClientContext.Load(subSiteWeb);
                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                        }

                        //Connect to Project Site
                        bool subsiteConnected = SharePointConnectionConfig.Connect(SharepointSubSite, SharepointUserName, SharepointPassword, SharepointDomain);
                        if (subsiteConnected)
                        {
                            ListCollection listCollection = SharePointConnectionConfig.SPClientContext.Web.Lists;
                            SharePointConnectionConfig.SPClientContext.Load(listCollection, lists => lists.Include(list => list.Title).Where(list => list.Title == FormNumber));
                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                            if (listCollection.Count == 0)
                            {
                                //Create the List
                                ListCreationInformation creationInfo = new ListCreationInformation();
                                creationInfo.Title = FormNumber.ToString();
                                creationInfo.Description = FormNumber.ToString();
                                creationInfo.TemplateType = (int)ListTemplateType.GenericList;
                                List newList = SharePointConnectionConfig.SPClientContext.Web.Lists.Add(creationInfo);
                                SharePointConnectionConfig.SPClientContext.Load(newList);
                                SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                            }

                            foreach (JObject jObject in DataArray)
                            {
                                List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(FormNumber.ToString());
                                ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                                ListItem myItem = dataList.AddItem(itemInfo);
                                SharePointConnectionConfig.SPClientContext.Load(dataList);
                                SharePointConnectionConfig.SPClientContext.ExecuteQuery();

                                foreach (JProperty prop in jObject.Properties())
                                {
                                    try
                                    {
                                        // Load field from list using internal name or display name
                                        var FieldNameDetails = prop.Name.ToString().Trim();
                                        var resultFieldName = Regex.Replace(FieldNameDetails, @"[^0-9a-zA-Z]+", "_");
                                        resultFieldName = string.Join("", resultFieldName.Take(25));

                                        SharePointConnectionConfig.SPClientContext.Load(dataList.Fields, fCol => fCol.Include(f => f.InternalName).Where(field => field.InternalName == "" + resultFieldName + ""));
                                        SharePointConnectionConfig.SPClientContext.ExecuteQuery();

                                        if (dataList.Fields != null && dataList.Fields.Count == 0)
                                        {
                                            string FieldName = "<Field Type=\"Note\" DisplayName=\"" + resultFieldName.Trim() + "\" Required=\"FALSE\" EnforceUniqueValues=\"FALSE\" Indexed=\"FALSE\" StaticName=\"" + resultFieldName.Trim() + "\" Name=\"" + resultFieldName.Trim() + "\"></Field>";
                                            Field newfield = dataList.Fields.AddFieldAsXml(FieldName, true, AddFieldOptions.DefaultValue);
                                            FieldNumber fldNumber = SharePointConnectionConfig.SPClientContext.CastTo<FieldNumber>(newfield);
                                            fldNumber.Update();
                                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();

                                        }

                                        var FieldValue = prop.Value.ToString().Trim();
                                        CamlQuery oQuery = new CamlQuery();
                                        oQuery.ViewXml = @"<View><Query><Where>
                                             <Eq>
                                             <FieldRef Name='Title' />
                                             <Value Type='Text'>" + FieldValue + "</Value></Eq></Where></Query></View>";

                                        ListItemCollection oItems = dataList.GetItems(oQuery);
                                        SharePointConnectionConfig.SPClientContext.Load(oItems);
                                        SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                                        ListItem oItemdata = oItems.FirstOrDefault();
                                        if (oItemdata != null)
                                        {
                                            // Update Data
                                            myItem[resultFieldName] = FieldValue;
                                            oItemdata.Update();
                                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                                            break;
                                        }
                                        else
                                        {
                                            //Insert New Data
                                            if (resultFieldName == "_id")
                                            {
                                                myItem["Title"] = FieldValue;
                                            }
                                            myItem[resultFieldName] = FieldValue;
                                            myItem.Update();
                                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();

                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Internal server Error" + ex.Message.ToString());
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sharepoint Project SubSite Could not be Connected.Kindly try again later..Ensure that Username and Passwords are Correct");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ona Data could not be loaded..Kindly provide a valid Form and Project Id");
                    }
                }
                else
                {
                    Console.WriteLine("Sharepoint Site could not be connected. Kindly try again later..Ensure that Username and Passwords are Correct");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an issue exporting data to sharepoint" + ex.Message.ToString());
            }
        }
    }
}