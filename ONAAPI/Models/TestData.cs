using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONAAPI.Models
{
   
    public class Attachment
    {
        public int id { get; set; }
        public string name { get; set; }
        public int xform { get; set; }
        public string filename { get; set; }
        public int instance { get; set; }
        public string mimetype { get; set; }
        public string download_url { get; set; }
        public string small_download_url { get; set; }
        public string medium_download_url { get; set; }
    }

    public class Root
    {
        public int _id { get; set; }
        public List<object> _tags { get; set; }
        public string _uuid { get; set; }
        public List<object> _notes { get; set; }
        public bool _edited { get; set; }
        public string _status { get; set; }
        public string _version { get; set; }
        public DateTime end_time { get; set; }
        public double _duration { get; set; }
        public int _xform_id { get; set; }
        public DateTime start_time { get; set; }
        public List<Attachment> _attachments { get; set; }
        public List<double> _geolocation { get; set; }
        public int _media_count { get; set; }
        public int _total_media { get; set; }

        [JsonProperty("formhub/uuid")]
        public string FormhubUuid { get; set; }

        [JsonProperty("section1/geo")]
        public string Section1Geo { get; set; }
        public string _submitted_by { get; set; }

        [JsonProperty("section1/date")]
        public string Section1Date { get; set; }

        [JsonProperty("section1/hhid")]
        public int Section1Hhid { get; set; }

        [JsonProperty("section2/name")]
        public string Section2Name { get; set; }
        public DateTime _date_modified { get; set; }

        [JsonProperty("section1/hhgps")]
        public string Section1Hhgps { get; set; }

        [JsonProperty("section1/state")]
        public string Section1State { get; set; }

        [JsonProperty("section3/phone")]
        public string Section3Phone { get; set; }

        [JsonProperty("section4/notes")]
        public string Section4Notes { get; set; }

        [JsonProperty("meta/instanceID")]
        public string MetaInstanceID { get; set; }

        [JsonProperty("section2/hhboys")]
        public int Section2Hhboys { get; set; }

        [JsonProperty("section2/hhsize")]
        public int Section2Hhsize { get; set; }
        public DateTime _submission_time { get; set; }
        public string _xform_id_string { get; set; }

        [JsonProperty("section1/address")]
        public string Section1Address { get; set; }

        [JsonProperty("section2/hhgirls")]
        public int Section2Hhgirls { get; set; }

        [JsonProperty("section3/contact")]
        public string Section3Contact { get; set; }

        [JsonProperty("section4/hh_roof")]
        public string Section4HhRoof { get; set; }

        [JsonProperty("section4/hh_wall")]
        public string Section4HhWall { get; set; }

        [JsonProperty("section2/hhadults")]
        public int Section2Hhadults { get; set; }

        [JsonProperty("section4/hh_floor")]
        public string Section4HhFloor { get; set; }

        [JsonProperty("section4/hh_light")]
        public string Section4HhLight { get; set; }

        [JsonProperty("section4/hh_other")]
        public string Section4HhOther { get; set; }
        public string _bamboo_dataset_id { get; set; }

        [JsonProperty("section1/hhpicture")]
        public string Section1Hhpicture { get; set; }

        [JsonProperty("section4/hh_toilet")]
        public string Section4HhToilet { get; set; }
        public bool _media_all_received { get; set; }

        [JsonProperty("section2/hhposition")]
        public string Section2Hhposition { get; set; }

        [JsonProperty("section4/hh_comparison")]
        public string Section4HhComparison { get; set; }
    }


}