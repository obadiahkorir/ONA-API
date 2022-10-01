using Microsoft.SharePoint.Client;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using ONAAPI.Connections;
using ONAAPI.Models;
using ONAAPI.Models.BeneficiaryFAO;
using ONAAPI.Models.ClientSatisfactorySurvey;
using ONAAPI.Models.SPTTraining;
using ONAAPI.Models.VillageMapping;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ONAAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public async Task TestingData(int? FormId)
        {
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
                HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/"+FormId+"? format=json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var DataArray = JsonConvert.DeserializeObject<JArray>(responseBody).Root.ToList();

                    ListCollection listCollection = SharePointConnectionConfig.SPClientContext.Web.Lists;
                    SharePointConnectionConfig.SPClientContext.Load(listCollection, lists => lists.Include(list => list.Title).Where(list => list.Title == FormId.ToString()));
                    SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                    if (listCollection.Count == 0)
                    {
                        //Create the List
                        ListCreationInformation creationInfo = new ListCreationInformation();
                        creationInfo.Title = FormId.ToString();
                        creationInfo.Description = FormId.ToString();
                        creationInfo.TemplateType = (int)ListTemplateType.GenericList;
                        List newList = SharePointConnectionConfig.SPClientContext.Web.Lists.Add(creationInfo);
                        SharePointConnectionConfig.SPClientContext.Load(newList);
                        SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                    }
                    else
                    {
                        List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(FormId.ToString());
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem myItem = dataList.AddItem(itemInfo);
                        SharePointConnectionConfig.SPClientContext.Load(dataList);
                        SharePointConnectionConfig.SPClientContext.ExecuteQuery();

                        foreach (JObject jObject in DataArray)
                        {
                            foreach (JProperty prop in jObject.Properties())
                            {
                                try
                                {

                                    //Load Fields Collections
                                    FieldCollection fieldCollection = dataList.Fields;
                                    SharePointConnectionConfig.SPClientContext.Load(fieldCollection);
                                    SharePointConnectionConfig.SPClientContext.ExecuteQuery();

                                    // Create Field
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

                                    // fill the fields with the required information;
                                    var FieldValue = prop.Value.ToString().Trim();
                                    if (resultFieldName == "_id")
                                    {
                                        myItem["Title"] = FieldValue;
                                    }
                                    myItem[resultFieldName] = FieldValue;
                                    myItem.Update();

                                    SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Internal server Error" + ex.Message.ToString());
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Internal server Error" );
                }
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }
        }
        public async Task GetSPTrainingOnaData()
        {

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
                HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/675585?format=json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    List<SPTrainingRoot> training = new List<SPTrainingRoot>();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    dynamic json = JsonConvert.DeserializeObject<ExpandoObject>(responseBody, new ExpandoObjectConverter());
                    foreach (var value in json.values)
                    {
                        Console.WriteLine($"{value.Key}: {value.Value}");
                    }

                    training = JsonConvert.DeserializeObject<List<SPTrainingRoot>>(responseBody);
                    foreach (var datadetail in training)
                    {
                        // Sharepoint Online
                        List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(SharepointLibrary);
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem myItem = dataList.AddItem(itemInfo);
                        SharePointConnectionConfig.SPClientContext.Load(dataList);
                        SharePointConnectionConfig.SPClientContext.ExecuteQuery();


                        //Load Fields Collections
                        FieldCollection fields = dataList.Fields;
                        SharePointConnectionConfig.SPClientContext.Load(fields);
                        SharePointConnectionConfig.SPClientContext.ExecuteQuery();


                        try
                        {
                            foreach (Field f in fields)
                            {
                                Console.WriteLine(f.StaticName.ToString() + " - " + f.TypeDisplayName.ToString() + "\n");
                            }
                            // fill the fields with the required information;
                            myItem["Title"] = datadetail._id;
                            myItem["IDNo"] = datadetail._id;
                            myItem["EndDate"] = datadetail.end;
                            myItem["StartDate"] = datadetail.start;
                            myItem["SubmissionTime"] = datadetail._submission_time;
                            myItem["AnyOtherComments"] = datadetail.Any_other_comments;
                            myItem["PleaseexplainyourresponseAbove"] = datadetail.Please_explain_your_response_above;
                            myItem["WouldYouRecommendthisCourse"] = datadetail.Would_you_recommend_course_to_colleagues;
                            myItem["WhatDidYouLikeMost"] = datadetail.What_did_you_like_mo_about_this_training;
                            myItem["TheVenueComfortable"] = datadetail.The_venue_meeting_r_uate_and_comfortable;
                            myItem["TheTimeAllocated"] = datadetail.The_time_allocated_f_ining_was_sufficient;
                            myItem["TheTrainersPrepared"] = datadetail.The_trainers_were_we_answer_any_question;
                            myItem["TheContentOrganised"] = datadetail.The_content_of_the_c_d_and_easy_to_follow;
                            myItem["ThePresenterswereEngaging"] = datadetail.The_presenters_were_engaging;
                            myItem["ThePresentationMaterials"] = datadetail.The_presentation_materials_were_relevant;
                            myItem["ParticipationandInteraction"] = datadetail.Participation_and_in_tion_were_encouraged;
                            myItem["TheObjectivesMet"] = datadetail.The_objectives_of_the_training_were_met;
                            myItem["TheObjectivesDefined"] = datadetail.The_objectives_of_th_were_clearly_defined;
                            myItem.Update();

                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(datadetail);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }
        }

        public async Task GetVillageMappingOnaData()
        {

            string SharepointUserName = ConfigurationManager.AppSettings["S_USERNAME"];
            string SharepointPassword = ConfigurationManager.AppSettings["S_PWD"];
            string SharepointDomain = ConfigurationManager.AppSettings["S_DOMAIN"];
            string SharepointURL = ConfigurationManager.AppSettings["S_URL"];
            string SharepointLibrary = ConfigurationManager.AppSettings["S_VillageMapping"];
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
                HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/692648?format=json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    List<VillageMappingRoot> training = new List<VillageMappingRoot>();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    training = JsonConvert.DeserializeObject<List<VillageMappingRoot>>(responseBody);
                    foreach (var datadetail in training)
                    {
                        // Sharepoint Online
                        List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(SharepointLibrary);
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem myItem = dataList.AddItem(itemInfo);

                        try
                        {

                            // fill the fields with the required information;
                            myItem["Title"] = datadetail._id;
                            myItem["IDNo"] = datadetail._id;
                            myItem["SubmissionTime"] = datadetail._submission_time;
                            myItem["EnterADate"] = datadetail.Enter_a_date;
                            myItem["NameOfTheRespondent"] = datadetail.Name_of_the_respondent;
                            myItem["LocationName"] = datadetail.Location_Name;
                            myItem["VillageName"] = datadetail.Village_Name;
                            myItem["Start"] = datadetail.start;
                            myItem["End"] = datadetail.end;
                            myItem["VersionName"] = datadetail._version;
                            myItem["InstanceID"] = datadetail.MetaInstanceID;
                            myItem["LastEdited"] = datadetail._date_modified;
                            myItem["SubmittedBy"] = datadetail._submitted_by;
                            myItem["MediaAttachment"] = datadetail._media_all_received;
                            myItem.Update();

                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(datadetail);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }
        }
        public async Task GetBeneficiaryFAOOnaData()
        {

            string SharepointUserName = ConfigurationManager.AppSettings["S_USERNAME"];
            string SharepointPassword = ConfigurationManager.AppSettings["S_PWD"];
            string SharepointDomain = ConfigurationManager.AppSettings["S_DOMAIN"];
            string SharepointURL = ConfigurationManager.AppSettings["S_URL"];
            string SharepointLibrary = ConfigurationManager.AppSettings["S_BeneficairyFAO"];
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
                HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/671353?format=json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    List<BeneficiaryFaoRoot> training = new List<BeneficiaryFaoRoot>();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    training = JsonConvert.DeserializeObject<List<BeneficiaryFaoRoot>>(responseBody);
                    foreach (var datadetail in training)
                    {
                        // Sharepoint Online
                        List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(SharepointLibrary);
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem myItem = dataList.AddItem(itemInfo);

                        try
                        {

                            // fill the fields with the required information;
                            myItem["IDNo"] = datadetail._id;
                            myItem["Title"] = datadetail._id;
                            myItem["SubmissionTime"] = datadetail._submission_time;
                            myItem["SurveyDate"] = datadetail.BeforeStartingDate;
                            myItem["InterviewerName"] = datadetail.BeforeStartingInterviewer;
                            myItem["CanWeStartInterview"] = datadetail.IntroductionInterviewStart;
                            myItem["RespondentsName"] = datadetail.DemocgraphyRespondentName;
                            myItem["GenderofRespondent"] = datadetail.DemocgraphyGender;
                            myItem["MaritalStatus"] = datadetail.DemocgraphyMaritalStatus;
                            myItem["AssistancePackageFAO"] = datadetail.DemocgraphyAssistance;
                            myItem["OtherAssistanceFAO"] = datadetail.DemocgraphyOthers;
                            myItem["ReceiveInforFAOProject"] = datadetail.DemocgraphyInformation;
                            myItem["OtherInforMethod"] = datadetail.DemocgraphyOtherMethod;
                            myItem["PreferedCommMethod"] = datadetail.DemocgraphyMethodCommunication;
                            myItem["OtherCommMethod"] = datadetail.DemocgraphyOtherMethodCommunication;
                            myItem["MessageFaoRadio"] = datadetail.DemocgraphyReceiveInformation;
                            myItem["YesMessageWasON"] = datadetail.DemocgraphySubjectMessage;
                            myItem["HowgetIntouchFAO"] = datadetail.DemocgraphyAwareGetIntouch;
                            myItem["YesHowGetIntouch"] = datadetail.DemocgraphyHow;
                            myItem["OtherMenthodIntouch"] = datadetail.DemocgraphyWhichMethod;
                            myItem["ReasonsBeTargetted"] = datadetail.DemocgraphyReasonsTargeted;
                            myItem["IfOtherMention"] = datadetail.DemocgraphyReasonsToBe;
                            myItem["TargetingInlusiveGroups"] = datadetail.DemocgraphyTargetingProcess1;
                            myItem["TargettingProcTransparent"] = datadetail.DemocgraphyTargetingProcess2;
                            myItem["CapturedMostVulnerable"] = datadetail.DemocgraphyTargetingProcess3;
                            myItem["TargettingProcessFair"] = datadetail.DemocgraphyTargetingProcess4;
                            myItem["CapturedInfluenceSpecial"] = datadetail.DemocgraphyTargetingProcess5;
                            myItem["CashSufficientNeeds"] = datadetail.DemocgraphyCashSufficient;
                            myItem["CashReceivedImmediate"] = datadetail.DemocgraphyTimeReceived;
                            myItem["RecoverHouseholdProduction"] = datadetail.DemocgraphyRecoverProduction;
                            myItem["IfNoWhy"] = datadetail.DemocgraphyNotRecover;
                            myItem["IfOtherMentionRecover"] = datadetail.DemocgraphyOtherPleaseMention;
                            myItem["RecoverOveralAssistance"] = datadetail.DemocgraphyAssistanceProvided;
                            myItem["IfYesHowRecoverAssistance"] = datadetail.DemocgraphyDetailsProvided;
                            myItem["IfOtherRecoverOverall"] = datadetail.DemocgraphyOtherRecovery;
                            myItem["ChallengesGettingAssistance"] = datadetail.DemocgraphyChallengesFace;
                            myItem["IfYesWhatAreThey"] = datadetail.DemocgraphyChallengesUsingGetting;
                            myItem["IfOtherMentionChallenges"] = datadetail.DemocgraphyOtherChallenge;
                            myItem["SatisfiedAssistanceFAO"] = datadetail.DemocgraphySatisfiedAssistance;
                            myItem["IfNoDescribe"] = datadetail.DemocgraphyOtherSatisfied;
                            myItem["AssistanceOtherOrganizations"] = datadetail.DemocgraphyReceiveAssistance;
                            myItem["IfYesSelectAssistance"] = datadetail.DemocgraphyReceivedOrganization;
                            myItem["IfOtherMentionAssistance"] = datadetail.DemocgraphyReceivedFrom;
                            myItem["TrainingsFromFAO"] = datadetail.DemocgraphyTrainingReceived;
                            myItem["IfOtherTrainingsMention"] = datadetail.DemocgraphyOtherTraining;
                            // myItem["InstanceID"] = datadetail.MetaInstanceID;
                            // myItem["LastEdited"] = datadetail._last_edited;
                            myItem["SubmittedBy"] = datadetail._submitted_by;
                            //myItem["Versions"] = datadetail._version;
                            myItem["MediaAttachments"] = datadetail._media_all_received;
                            myItem.Update();

                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(datadetail);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }
        }
        public async Task GetClientSatisfactoryOnaData()
        {

            string SharepointUserName = ConfigurationManager.AppSettings["S_USERNAME"];
            string SharepointPassword = ConfigurationManager.AppSettings["S_PWD"];
            string SharepointDomain = ConfigurationManager.AppSettings["S_DOMAIN"];
            string SharepointURL = ConfigurationManager.AppSettings["S_URL"];
            string SharepointLibrary = ConfigurationManager.AppSettings["S_ClientSurvey"];
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
                HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/669692?format=json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    List<ClientSurveyRoot> training = new List<ClientSurveyRoot>();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    training = JsonConvert.DeserializeObject<List<ClientSurveyRoot>>(responseBody);
                    foreach (var datadetail in training)
                    {
                        // Sharepoint Online
                        List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(SharepointLibrary);
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem myItem = dataList.AddItem(itemInfo);

                        try
                        {

                            // fill the fields with the required information;
                            myItem["Title"] = datadetail._id;
                            myItem["_id"] = datadetail._id;
                            myItem["_submission_time"] = datadetail._submission_time;
                            myItem["Date_of_the_survey"] = datadetail.Date_of_the_survey;
                            myItem["Region"] = datadetail.GroupJq4dn68Region;
                            myItem["District"] = datadetail.GroupJq4dn68District;
                            myItem["RecordYourCurrentLocation"] = datadetail.GroupJq4dn68RecordYourCurrentLocation;
                            myItem["RespondentsFullNames"] = datadetail.GroupJq4dn68RespondentsFullNames;
                            myItem["RespondentsAge"] = datadetail.GroupJq4dn68RespondentsAge;
                            myItem["HowWouldYouDescriService"] = datadetail.GroupCl8mp02HowWouldYouDescriServiceYouReceived;
                            myItem["HowLongDidYouOviderInMinutes"] = datadetail.GroupCl8mp022HowLongDidYouOviderInMinutes;
                            myItem["AreYouSatisfiedWaitingTime"] = datadetail.GroupCl8mp02AreYouSatisfiedWithThisWaitingTime;
                            myItem["AreYouSatisfiedFacility"] = datadetail.GroupCl8mp02AreYouSatisfiedWiHNutritionFacility;
                            myItem["AreSatisfiedProvider"] = datadetail.GroupCl8mp02AreYouSatisfiedWiLthServiceProvider;
                            myItem["AreSatisfiedConsultation"] = datadetail.GroupCl8mp02AreYouSatisfiedWiIngTheConsultation;
                            myItem["SatisfiedServiceProvider"] = datadetail.GroupCl8mp026AreYouSatisfiedWLthServiceProvider;
                            myItem["FarHealthFacility"] = datadetail.GroupCl8mp02HowFarDidYouTravTheHealthFacility;
                            myItem["ServiceHealthFacility"] = datadetail.GroupCl8mp02WhichServicesDidYThisHealthFacility;
                            myItem["AreYouPregnant"] = datadetail.GroupTz2jo84AreYouPregnant;
                            myItem["LongHaveYouBe"] = datadetail.GroupTz2jo84HowLongHaveYouBeNPregnantInMonths;
                            myItem["FirstPregnancy"] = datadetail.GroupTz2jo84IsThisYourFirstPregnancy;
                            myItem["NoManyChildren"] = datadetail.GroupTz2jo84IfNOHowManyChildrenDoYouHave;
                            myItem["FirstARForPregnancy"] = datadetail.GroupTz2jo84IsThisYourFirstARForThisPregnancy;
                            myItem["VisitThisHealthCenter"] = datadetail.GroupTz2jo84IncludingThisVisitOThisHealthCenter;
                            myItem["RegisteredForAntena"] = datadetail.GroupTz2jo84HaveYouRegisteredForAntena;
                            myItem["ManyAntHealthFacility"] = datadetail.GroupTz2jo84IfYesHowManyAntThatHealthFacility;
                            myItem["HealthFacilityToday"] = datadetail.GroupTz2jo84WhyDidYouChooseTEalthFacilityToday;
                            myItem["DuringVisitFacility"] = datadetail.GroupTz2jo84DuringThisVisitDVeryInTheFacility;
                            myItem["RememberFiveDiet"] = datadetail.GroupTz2jo84DoYouRememberFiveYourDietListThem;
                            myItem["ProvidedIronTablets"] = datadetail.GroupTz2jo84WereYouProvidedAnAndOrIronTablets;
                            myItem["PrescribAnoyingEffects"] = datadetail.GroupTz2jo84IfYouWerePrescribNnoyingSideEffects;
                            myItem["ProviderDizziness"] = datadetail.GroupTz2jo84DidTheProviderDisAcheDizzinessEtc;
                            myItem["ReceiveToday"] = datadetail.GroupTz2jo84HaveYouEverReceivHaveReceivedToday;
                            myItem["VisitToxoidInjection"] = datadetail.GroupTz2jo84DuringThisVisitOrNusToxoidInjection;
                            myItem["IncludingTetanuInjection"] = datadetail.GroupTz2jo84IncludingAnyTetanuNusToxoidInjection;
                            myItem["DuringWPNCDelivery"] = datadetail.GroupTz2jo84DuringYourVisitWPNCAfterDelivery;
                            myItem["PleaseCheckBeneficiary"] = datadetail.Please_check_if_the_beneficiar;
                            myItem["DeliverYourLastBaby"] = datadetail.GroupOp6hb65WhereDidYouDeliverYourLastBaby;
                            myItem["InitiateYourLastBaby"] = datadetail.GroupOp6hb65WhenDidYouInitiatEdingYourLastBaby;
                            myItem["CounseledBreastfeeding"] = datadetail.GroupOp6hb65WereYouCounseledOLusiveBreastfeeding;
                            myItem["CurrentlyBreastfeeding"] = datadetail.GroupOp6hb65AreYouCurrentlyPrLusiveBreastfeeding;
                            myItem["InformedAbANCVisit"] = datadetail.GroupOp6hb65WereYouInformedAbANCOrAnyPNCVisit;
                            myItem["InformedStillPregnant"] = datadetail.GroupOp6hb65WereYouInformedAbWereStillPregnant;
                            myItem["InformedMedicalAdvice"] = datadetail.GroupOp6hb65WereYouInformedAbEkingMedicalAdvice;
                            myItem["PleaseCheckMothers"] = datadetail.Please_check_if_Mothers_of_Wel;
                            myItem["GivenAnySupplementation"] = datadetail.GroupZh6eu36WereYouGivenAnyVInASupplementation;
                            myItem["PrescribedLastMonths"] = datadetail.GroupZh6eu36WereYouPrescribedInTheLast6Months;
                            myItem["InformedImmunization"] = datadetail.GroupZh6eu36WereYouInformedOfAnceOfImmunization;
                            myItem["ChildHisImmunization"] = datadetail.GroupZh6eu36HasTheChildCompletedHisImmunization;
                            myItem["ChildWeighChild"] = datadetail.GroupZh6eu36IfYourChildSWeigOfYourChild;
                            myItem["HowOldIsYourChild"] = datadetail.GroupZh6eu36HowOldIsYourChild;
                            myItem["EastfeedingHerBaby"] = datadetail.GroupZh6eu36IfTheChildIsLessEastfeedingHerBaby;
                            myItem["ManySachetsToday"] = datadetail.GroupZh6eu36HowManySachetsOfUrChildGivenToday;
                            myItem["AmountRationCard"] = datadetail.GroupZh6eu36IsTheAmountOfRUFNOnTheRationCard;
                            myItem["MuchTheDifference"] = datadetail.GroupZh6eu36HowMuchIsTheDifference;
                            myItem["YourChildEverMissed"] = datadetail.GroupZh6eu36HasYourChildEverMissedAn;
                            myItem["HowManyTimes"] = datadetail.GroupZh6eu36IfYesHowManyTimes;
                            myItem["ReasonTreatment"] = datadetail.GroupZh6eu36TellMeTheReasonSForTreatmentBefore;
                            myItem["YouParticipated"] = datadetail.GroupZh6eu36HaveYouParticipatedInAnyG;
                            myItem["DidGroupDiscussion"] = datadetail.GroupZh6eu36IfNotWhyDidYouNAGroupDiscussion;
                            myItem["WereDiscussion"] = datadetail.GroupZh6eu36IfYesWhatWereThEyDiscussionTopics;
                            myItem["ChildAdmitted"] = datadetail.GroupXi3jw21HaveYourChildAdmittedDiarr;
                            myItem["WereAdminister"] = datadetail.GroupXi3jw21IfYesWereYouShoOwToAdministerORS;
                            myItem["CounseledSickChild"] = datadetail.GroupXi3jw21WereYouCounseledOForYourSickChild;
                            myItem["CounseledDisposal"] = datadetail.GroupXi3jw21WereYouCounseledOSolidWasteDisposal;
                            myItem["DernessOrSwelling"] = datadetail.GroupXi3jw21WereYouAskedIfYoNdernessOrSwelling;
                            myItem["AdvisedBreathing"] = datadetail.GroupXi3jw21WereYouAdvisedToRapidBreathingEtc;
                            myItem["start"] = datadetail.start;
                            myItem["end"] = datadetail.end;
                            //myItem["InstanceID"] = datadetail.MetaInstanceID;
                            //myItem["LastEdited"] = datadetail._edited;
                            //myItem["_version"] = datadetail._version;
                            //myItem["_media_all_received"] = datadetail._media_all_received;
                            myItem.Update();

                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(datadetail);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }
        }
        public async Task GetCashForWorkBeneficiariesOnaData()
        {

            string SharepointUserName = ConfigurationManager.AppSettings["S_USERNAME"];
            string SharepointPassword = ConfigurationManager.AppSettings["S_PWD"];
            string SharepointDomain = ConfigurationManager.AppSettings["S_DOMAIN"];
            string SharepointURL = ConfigurationManager.AppSettings["S_URL"];
            string SharepointLibrary = ConfigurationManager.AppSettings["S_BeneficiariesSurvey"];
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
                HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/669529?format=json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    List<CashBeneficiariesSurveyRoot> training = new List<CashBeneficiariesSurveyRoot>();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    training = JsonConvert.DeserializeObject<List<CashBeneficiariesSurveyRoot>>(responseBody);
                    foreach (var datadetail in training)
                    {
                        // Sharepoint Online
                        List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(SharepointLibrary);
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem myItem = dataList.AddItem(itemInfo);

                        try
                        {
                            // fill the fields with the required information;
                            myItem["Title"] = datadetail._id;
                            myItem["IDNo"] = datadetail._id;
                            myItem["ReviewDate"] = datadetail._submission_time;
                            myItem["ReviewStatus"] = datadetail.start;
                            myItem["ReviewComment"] = datadetail.end;
                            myItem["SubmissionTime"] = datadetail._submission_time;
                            myItem["Date"] = datadetail.GroupGq7ez50Date;
                            myItem["Region"] = datadetail.GroupGq7ez50Region;
                            myItem["CurrentLocation"] = datadetail.GroupGq7ez50RecordYourCurrentLocation;
                            myItem["Interviewer"] = datadetail.GroupGq7ez50InterviewerStaffName;
                            myItem["Village"] = datadetail.GroupGq7ez50VillageSite;
                            myItem["District"] = datadetail.GroupGq7ez50District;
                            myItem["BeneficiaryName"] = datadetail.GroupRw3tq65BeneficiarySName;
                            myItem["HouseholdID"] = datadetail.GroupRw3tq65HouseholdID;
                            myItem["RelationshipHHead"] = datadetail.GroupRw3tq65WhatIsYourRelationshipToT;
                            myItem["OtherSpecify"] = datadetail.GroupDu7pd14IfOtherSpecify;
                            myItem["HHeadGender"] = datadetail.GroupRw3tq65Gender;
                            myItem["CivilStatus"] = datadetail.GroupRw3tq65CivilStatus;
                            myItem["BeneficiaryAge"] = datadetail.GroupRw3tq65BeneficiarySAge;
                            myItem["BeneficiaryEducationLevel"] = datadetail.GroupRw3tq65HighestEducationLeLOfTheBeneficiary;
                            myItem["OccupationHead"] = datadetail.GroupRw3tq65OccupationOfTheHouseholdHead;
                            myItem["Under18YearsHousehold"] = datadetail.GroupRw3tq65HowManyPeopleUndeReInYourHousehold;
                            myItem["Over18YearsHousehold"] = datadetail.GroupRw3tq65HowManyPeopleOverDIncludingYourself;
                            myItem["AssistanceFromSC"] = datadetail.GroupRw3tq65WhatTypesOfAssistanceHave;
                            myItem["OtherAssistanceSpecify"] = datadetail.GroupRw3tq65OtherPleaseSpecify;
                            myItem["MemberDisability"] = datadetail.GroupKe4kl81IsThereAnyMemberOfThisHo;
                            myItem["YesHowMany"] = datadetail.GroupKe4kl81AIfYesHowMany;
                            myItem["KindOfDisability"] = datadetail.GroupKe4kl81PleaseSpecifyTheKindOfDis;
                            myItem["OtherDisability"] = datadetail.GroupDu7pd14IfOthersPleaseSpecify001;
                            myItem["DisabilityPreventHH"] = datadetail.GroupKe4kl81DoesThisDisabilityAringForThemselves;
                            myItem["PregnantLactMother"] = datadetail.GroupKe4kl81DoesThisHouseholdOrLactatingMother;
                            myItem["ChildSupport"] = datadetail.GroupKe4kl81DoesThisHouseholdNutritionalSupport;
                            myItem["EligibilityCretaria"] = datadetail.GroupOw5du92WereYouInformedOfEriaForTheProject;
                            myItem["SelectionCreteria"] = datadetail.GroupOw5du92HowSatisfiedAreYoHForAWorkProject;
                            myItem["CommunityInvolved"] = datadetail.GroupOw5du92WasTheCommunityInESelectionCriteria;
                            myItem["FemaleInvolved"] = datadetail.GroupOw5du92WereFemalesInvolveESelectionCriteria;
                            myItem["VerificationProcess"] = datadetail.GroupOw5du92WasThereAVerificaListedBeneficiaries;
                            myItem["VerificationStatisfied"] = datadetail.GroupOw5du92IfYesHowSatisfieVerificationProcess;
                            myItem["CommunityVerifications"] = datadetail.GroupOw5du92WasTheCommunityInVerificationProcess;
                            myItem["CashSCMonthly"] = datadetail.GroupUf4uz74WhatIsTheAmountOFromSCEveryMonth;
                            myItem["NoOfMonths"] = datadetail.GroupUf4uz74HowManyMonthsDidTheMoneyInMonths;
                            myItem["SatisfiedCashSC"] = datadetail.GroupUf4uz74HowSatisfiedAreYoYouReceiveFromSC;
                            myItem["AmountConsistent"] = datadetail.GroupUf4uz74WasTheAmountOfCashAlways;
                            myItem["MuchDifference"] = "";
                            myItem["SatisfiedMobilePlat"] = datadetail.GroupUf4uz74HowSatisfiedAreYoIngMobilePlatforms;
                            myItem["ChallengesCashMobile"] = datadetail.GroupUf4uz74DidYouExperienceAnyChallen;
                            myItem["YesSpecifyChalleng"] = "";
                            myItem["PurposeCommunicated"] = datadetail.GroupUf4uz74WasThePurposeOfTCommunicatedToYou;
                            myItem["IdentificationPrioritization"] = datadetail.GroupPo8no70WasTheCommunityInEOfWorkActivities;
                            myItem["PersonallyInvolved"] = datadetail.GroupPo8no70WereYouPERSONALLYEOfWorkActivities;
                            myItem["WorkActivities"] = datadetail.GroupPo8no70HowSatisfiedWereYSForTheCashGrant;
                            myItem["SelectedActivities"] = datadetail.GroupPo8no70DoYouThinkTheSelAlToYourCommunity;
                            myItem["SpentExpenses"] = datadetail.GroupSe2im73WhichOfTheFollowiHooseAllThatApply;
                            myItem["Rent"] = datadetail.GroupSe2im73Rent;
                            myItem["Water"] = datadetail.GroupSe2im73Water;
                            myItem["Food"] = datadetail.GroupSe2im73Food;
                            myItem["Electricity"] = datadetail.GroupSe2im73Electricity;
                            myItem["MedicalCare"] = datadetail.GroupSe2im73MedicalCareIncludingMedicine;
                            myItem["Transportation"] = datadetail.GroupSe2im73Transportation;
                            myItem["Communications"] = datadetail.GroupSe2im73CommunicationsExPhones;
                            myItem["DeptPayments"] = datadetail.GroupSe2im73DebtPayment;
                            myItem["ProductiveAssets"] = datadetail.GroupSe2im73ProductiveAssets;
                            myItem["BusinessStarUp"] = datadetail.GroupSe2im73BusinessStartUpExpansion;
                            myItem["ShelterMaintenance"] = datadetail.GroupSe2im73ShelterMaintenance;
                            myItem["Education"] = datadetail.GroupSe2im73Education;
                            myItem["InformationSC"] = datadetail.GroupEe1uv94WereYouProvidedWiIdeToTheCommunity;
                            myItem["InformationProvided"] = datadetail.GroupEe1uv94IfYesHowWasThisInformati;
                            myItem["OtherSpecifiy001"] = datadetail.GroupDu7pd14OtherPleaseSpecify001;
                            myItem["ProjectCommunication"] = datadetail.GroupEe1uv94HowSatisfiedWereYGWithTheCommunity;
                            myItem["MessageClear"] = datadetail.GroupEe1uv94WasTheMessageClear;
                            myItem["MessageNotClear"] = "";
                            myItem["ExpectedEntitlements"] = datadetail.GroupEe1uv94DidYouAsAnIndiviXpectedEntitlements;
                            myItem["CommunicationMode"] = datadetail.GroupEe1uv94WhatModeOfCommunicationWou001;
                            myItem["OtherComSpecify"] = "";
                            myItem["FrequencyCommunicate"] = datadetail.GroupEe1uv94HowSatisfiedWereYGWithBeneficiaries;
                            myItem["RecomFreqCommu"] = datadetail.GroupEe1uv94WhatWouldBeYourRNWithBeneficiaries;
                            myItem["ComplaintFeedback"] = datadetail.GroupDu7pd14AreYouAwareOfAnyCanUseToReachSCI;
                            myItem["ConcernsCompaints"] = datadetail.GroupDu7pd14HowDoYouShareYourConcerns;
                            myItem["IfOtherSpecify"] = datadetail.GroupDu7pd14IfOthersPleaseSpecify001;
                            myItem["StatisifedMethComp"] = datadetail.GroupDu7pd14HowSatisfiedAreYoBackOnTheActivity;
                            myItem["SCInformActivity"] = datadetail.GroupDu7pd14HowDidTheSCInformActivity;
                            myItem["ComplainCashProject"] = datadetail.GroupDu7pd14HaveYouEverHadAAshForWorkProject;
                            myItem["ActivityOtherSpecify"] = datadetail.GroupDu7pd14OtherSpecify004;
                            myItem["ShareConcerns"] = datadetail.GroupDu7pd14HowDidYouShareYoElectAllThatApply;
                            myItem["OtherSpecifyPlease"] = datadetail.GroupDu7pd14OtherPleaseSpecify001;
                            myItem["WhyShareConcern"] = datadetail.GroupDu7pd14WhyDoYouShareYourConcerns;
                            myItem["ifOtherConcernSpecify"] = datadetail.GroupDu7pd14IfOtherSpecify;
                            myItem["SCRespond"] = datadetail.GroupDu7pd14IfYesDidSCRespoComplaintYouRaised;
                            myItem["ResolutionTime"] = datadetail.GroupDu7pd14HowSatisfiedWereYSolveYourComplaint;
                            myItem["BeneficiariesRole"] = datadetail.GroupVs0ed43WhatRoleDidBenefiElectAllThatApply;
                            myItem["FemaleBeneficiaries"] = datadetail.GroupVs0ed43HowSatisfiedWereYFemaleBeneficiaries;
                            myItem["SatisfiedChildren"] = datadetail.GroupVs0ed43HowSatisfiedWereYLdrenByTheProgram;
                            myItem["SatisfiedDisability"] = datadetail.GroupVs0ed43HowSatisfiedWereYIlityByTheProgram;
                            myItem["EncounteredChallenge"] = datadetail.GroupUe2qo54DidYouEncounterAnHooseAllThatApply;
                            myItem["ExperiencedDelays"] = datadetail.GroupUe2qo54HaveYouEverExperiDistributionOfCash;
                            myItem["CommunicatedDelays"] = datadetail.GroupUe2qo54HadSCCommunicatedEDelaysBeforeHand;
                            myItem["ResolvedLater"] = datadetail.GroupUe2qo54WasTheIssueLaterResolved;
                            myItem["Start"] = datadetail.start;
                            myItem["End"] = datadetail.end;
                            myItem["Versions"] = datadetail._version;
                            myItem.Update();

                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(datadetail);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }
        }
        public async Task GetTools2NutritionAssesmentOnaData()
        {

            string SharepointUserName = ConfigurationManager.AppSettings["S_USERNAME"];
            string SharepointPassword = ConfigurationManager.AppSettings["S_PWD"];
            string SharepointDomain = ConfigurationManager.AppSettings["S_DOMAIN"];
            string SharepointURL = ConfigurationManager.AppSettings["S_URL"];
            string SharepointLibrary = ConfigurationManager.AppSettings["S_ToolsNutrition"];
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
                HttpResponseMessage response = await _client.GetAsync("https://api.ona.io/api/v1/data/669396?format=json");
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    List<ToolsNutritionAssesmentRoot> training = new List<ToolsNutritionAssesmentRoot>();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    training = JsonConvert.DeserializeObject<List<ToolsNutritionAssesmentRoot>>(responseBody);
                    foreach (var datadetail in training)
                    {
                        // Sharepoint Online
                        List dataList = SharePointConnectionConfig.SPClientContext.Web.Lists.GetByTitle(SharepointLibrary);
                        ListItemCreationInformation itemInfo = new ListItemCreationInformation();
                        ListItem myItem = dataList.AddItem(itemInfo);

                        try
                        {
                            // fill the fields with the required information;
                            myItem["Title"] = datadetail._id;
                            myItem["IDNo"] = datadetail._id;
                            myItem["SubmissionTime"] = datadetail._submission_time;
                            myItem["EnteraDate"] = datadetail.Enter_a_date;
                            myItem["Location"] = datadetail.Location;
                            myItem["ResearcherName"] = datadetail.Name_of_the_researcher;
                            myItem["CurrentLocation"] = datadetail.Record_your_current_location;
                            myItem["MeetingDiscussion"] = datadetail.GroupLg92i15DuringTheMeetingIonOfProgramSites;
                            myItem["MeetingCreteria"] = datadetail.GroupLg92i15DuringTheMeetingNteerIdentification;
                            myItem["MeetingCommunity"] = datadetail.GroupLg92i15DuringTheMeetingButionParticipation;
                            myItem["MinutesSigned"] = datadetail.GroupLg92i15AreThereMinutesDeTionMeetingTemplet;
                            myItem["SignedAgreement"] = datadetail.GroupLg92i15IsThereASignedAgSightEstablishment;
                            myItem["ADayNotice"] = datadetail.GroupEk2tj38WereCommunityMembeAtionToTheMeeting;
                            myItem["PlannedProjectAct"] = datadetail.GroupEk2tj38WasTheCommunityInDBeforeTheMeeting;
                            myItem["ContributionsParticipations"] = datadetail.GroupEk2tj38WasTheCommunityInButionParticipation;
                            myItem["CMAReportFormat"] = datadetail.GroupEk2tj38IsThereAReportDePointsInCMFormat;
                            myItem["MonthlySiteMobil"] = datadetail.GroupAo0ms64DoTheCMCNVsHaveDSensitizationPlan;
                            myItem["ReportActiveCase"] = datadetail.GroupAo0ms64DoCNVsReportOnAcTracingEveryMonth;
                            myItem["ReportCommunityLevel"] = datadetail.GroupAo0ms64DoCNVsReportOnCoLementedEveryMonth;
                            myItem["CNVsVisitQuaterly"] = datadetail.GroupAo0ms64DoCNVsVisitEachHAstOncePerQuarter;
                            myItem["CommunityMobilizerReport"] = datadetail.GroupAo0ms64DoesTheCommunityMIlizationActivities;
                            myItem["CommunityMobilizerMoniter"] = datadetail.GroupAo0ms64DoesTheCommunityMCtivitiesEveryWeek;
                            myItem["NeedbasedTraining"] = datadetail.GroupYm9df60AreAllOrganizedTrainingNeedBased;
                            myItem["ChildrenConsulted"] = datadetail.GroupYm9df60AreChildrenAlwaysChildrenSTraining;
                            myItem["TORTrainingPlan"] = datadetail.GroupYm9df60IsThereAToRTrainNdADetailedBudget;
                            myItem["GenderEthnicity"] = datadetail.GroupYm9df60IsTheSelectionOfGGenderEthnicity;
                            myItem["DisabledParticipants"] = datadetail.GroupYm9df60IsThereAProvisionIsabledParticipants;
                            myItem["ModeOfFacilitations"] = datadetail.GroupYm9df60IsTheModeOfFacilAlwaysParticipatory;
                            myItem["TraininerKnowledgeable"] = datadetail.GroupYm9df60AreTheTrainerResEableOnTheSubject;
                            myItem["PretestConducted"] = datadetail.GroupYm9df60ArePreTestAlwayNingOfTheTraining;
                            myItem["StandardTrainingManual"] = datadetail.GroupYm9df60DoTheTrainingsAlwHeTechnicalAdvisor;
                            myItem["TrainingNoofDays"] = datadetail.GroupYm9df60DoTrainingsAlwaysAnualDoesNotExist;
                            myItem["SkillsPlannedDeveloped"] = datadetail.GroupYm9df60IsAnActionPlanFAfterTheTraining;
                            myItem["TrainingCourseEvaluated"] = datadetail.GroupYm9df60DoParticipantsAlwaEnueAndFacilitator;
                            myItem["TrainingReport10Days"] = datadetail.GroupYm9df60DoTheTrainingTeamSAfterTheTraining;
                            myItem["ReportFeedback"] = datadetail.GroupYm9df60DoesTheReportAlwaPhotosTestimonies;
                            myItem["SetActionsPlans"] = datadetail.GroupYm9df60IsThereFollowUpDTheSetActionPlans;
                            myItem["TrainingDatabase"] = datadetail.GroupYm9df60IsThereFollowUpDTheSetActionPlans;
                            myItem["Start"] = datadetail.start;
                            myItem["End"] = datadetail.end;
                            myItem["Versions"] = datadetail._version;
                            myItem.Update();

                            SharePointConnectionConfig.SPClientContext.ExecuteQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(datadetail);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            else
            {
                Console.WriteLine("Internal server Error");
            }
        }
    }
}
