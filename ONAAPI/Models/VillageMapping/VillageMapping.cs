using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONAAPI.Models.VillageMapping
{
    public class VillageMappingRoot
    {
        public int _id { get; set; }
        public DateTime end { get; set; }
        public List<object> _tags { get; set; }
        public string _uuid { get; set; }
        public DateTime start { get; set; }
        public List<object> _notes { get; set; }
        public bool _edited { get; set; }
        public string _status { get; set; }
        public string _version { get; set; }
        public double _duration { get; set; }
        public int _xform_id { get; set; }
        public string __version__ { get; set; }
        public string Enter_a_date { get; set; }
        public string Village_Name { get; set; }
        public List<object> _attachments { get; set; }
        public List<double?> _geolocation { get; set; }
        public int _media_count { get; set; }
        public int _total_media { get; set; }
        public string FormhubUuid { get; set; }
        public string Location_Name { get; set; }
        public object _submitted_by { get; set; }
        public DateTime _date_modified { get; set; }
        public string MetaInstanceID { get; set; }
        public DateTime _submission_time { get; set; }
        public string _xform_id_string { get; set; }
        public string _bamboo_dataset_id { get; set; }
        public bool _media_all_received { get; set; }
        public string Name_of_the_respondent { get; set; }
        public string Record_your_current_location { get; set; }
    }
}