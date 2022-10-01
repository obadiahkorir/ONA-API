using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONAAPI.Models.SPTTraining
{
    public class SPTrainingRoot
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
            public List<object> _attachments { get; set; }
            public List<object> _geolocation { get; set; }
            public int _media_count { get; set; }
            public int _total_media { get; set; }
            public string FormhubUuid { get; set; }
            public object _submitted_by { get; set; }
            public DateTime _date_modified { get; set; }
            public string MetaInstanceID { get; set; }
            public DateTime _submission_time { get; set; }
            public string _xform_id_string { get; set; }
            public string Any_other_comments { get; set; }
            public string _bamboo_dataset_id { get; set; }
            public bool _media_all_received { get; set; }
            public string The_presenters_were_engaging { get; set; }
            public string Please_explain_your_response_above { get; set; }
            public string The_objectives_of_the_training_were_met { get; set; }
            public string The_presentation_materials_were_relevant { get; set; }
            public string The_trainers_were_we_answer_any_question { get; set; }
            public string The_venue_meeting_r_uate_and_comfortable { get; set; }
            public string What_did_you_like_mo_about_this_training { get; set; }
            public string Would_you_recommend_course_to_colleagues { get; set; }
            public string Participation_and_in_tion_were_encouraged { get; set; }
            public string The_content_of_the_c_d_and_easy_to_follow { get; set; }
            public string The_objectives_of_th_were_clearly_defined { get; set; }
            public string The_time_allocated_f_ining_was_sufficient { get; set; }
        }
}