using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONAAPI.Models.BeneficiaryFAO
{
    public class BeneficiaryFaoRoot
    {
        public int _id { get; set; }
        public List<object> _tags { get; set; }
        public string _uuid { get; set; }
        public List<object> _notes { get; set; }
        public bool _edited { get; set; }
        public string _status { get; set; }
        public string _version { get; set; }
        public string _duration { get; set; }
        public int _xform_id { get; set; }
        public List<object> _attachments { get; set; }
        public List<object> _geolocation { get; set; }
        public int _media_count { get; set; }
        public int _total_media { get; set; }

        [JsonProperty("formhub/uuid")]
        public string FormhubUuid { get; set; }
        public string _submitted_by { get; set; }
        public DateTime _date_modified { get; set; }

        [JsonProperty("meta/instanceID")]
        public string MetaInstanceID { get; set; }
        public DateTime _submission_time { get; set; }
        public string _xform_id_string { get; set; }
        public string _bamboo_dataset_id { get; set; }

        [JsonProperty("democgraphy/gender")]
        public string DemocgraphyGender { get; set; }
        public bool _media_all_received { get; set; }

        [JsonProperty("before_starting/date")]
        public string BeforeStartingDate { get; set; }

        [JsonProperty("democgraphy/assistance")]
        public string DemocgraphyAssistance { get; set; }

        [JsonProperty("democgraphy/information")]
        public string DemocgraphyInformation { get; set; }

        [JsonProperty("democgraphy/time_received")]
        public string DemocgraphyTimeReceived { get; set; }

        [JsonProperty("democgraphy/marital_status")]
        public string DemocgraphyMaritalStatus { get; set; }

        [JsonProperty("democgraphy/other_training")]
        public string DemocgraphyOtherTraining { get; set; }

        [JsonProperty("before_starting/interviewer")]
        public string BeforeStartingInterviewer { get; set; }

        [JsonProperty("democgraphy/cash_sufficient")]
        public string DemocgraphyCashSufficient { get; set; }

        [JsonProperty("democgraphy/challenges_face")]
        public string DemocgraphyChallengesFace { get; set; }

        [JsonProperty("democgraphy/respondent_name")]
        public string DemocgraphyRespondentName { get; set; }

        [JsonProperty("democgraphy/subject_message")]
        public string DemocgraphySubjectMessage { get; set; }

        [JsonProperty("democgraphy/details_provided")]
        public string DemocgraphyDetailsProvided { get; set; }

        [JsonProperty("democgraphy/reasons_targeted")]
        public string DemocgraphyReasonsTargeted { get; set; }

        [JsonProperty("introduction/interview_start")]
        public string IntroductionInterviewStart { get; set; }

        [JsonProperty("democgraphy/aware_get_intouch")]
        public string DemocgraphyAwareGetIntouch { get; set; }

        [JsonProperty("democgraphy/training_received")]
        public string DemocgraphyTrainingReceived { get; set; }

        [JsonProperty("democgraphy/receive_assistance")]
        public string DemocgraphyReceiveAssistance { get; set; }

        [JsonProperty("democgraphy/recover_production")]
        public string DemocgraphyRecoverProduction { get; set; }

        [JsonProperty("democgraphy/targeting_process1")]
        public string DemocgraphyTargetingProcess1 { get; set; }

        [JsonProperty("democgraphy/targeting_process2")]
        public string DemocgraphyTargetingProcess2 { get; set; }

        [JsonProperty("democgraphy/targeting_process3")]
        public string DemocgraphyTargetingProcess3 { get; set; }

        [JsonProperty("democgraphy/targeting_process4")]
        public string DemocgraphyTargetingProcess4 { get; set; }

        [JsonProperty("democgraphy/targeting_process5")]
        public string DemocgraphyTargetingProcess5 { get; set; }

        [JsonProperty("democgraphy/assistance_provided")]
        public string DemocgraphyAssistanceProvided { get; set; }

        [JsonProperty("democgraphy/receive_information")]
        public string DemocgraphyReceiveInformation { get; set; }

        [JsonProperty("democgraphy/method_communication")]
        public string DemocgraphyMethodCommunication { get; set; }

        [JsonProperty("democgraphy/satisfied_assistance")]
        public string DemocgraphySatisfiedAssistance { get; set; }

        [JsonProperty("democgraphy/how")]
        public string DemocgraphyHow { get; set; }

        [JsonProperty("democgraphy/others")]
        public string DemocgraphyOthers { get; set; }

        [JsonProperty("democgraphy/other_method")]
        public string DemocgraphyOtherMethod { get; set; }

        [JsonProperty("democgraphy/which_method")]
        public string DemocgraphyWhichMethod { get; set; }

        [JsonProperty("democgraphy/reasons_to_be")]
        public string DemocgraphyReasonsToBe { get; set; }

        [JsonProperty("democgraphy/received_from")]
        public string DemocgraphyReceivedFrom { get; set; }

        [JsonProperty("democgraphy/other_recovery")]
        public string DemocgraphyOtherRecovery { get; set; }

        [JsonProperty("democgraphy/other_challenge")]
        public string DemocgraphyOtherChallenge { get; set; }

        [JsonProperty("democgraphy/other_please_mention")]
        public string DemocgraphyOtherPleaseMention { get; set; }

        [JsonProperty("democgraphy/received_organization")]
        public string DemocgraphyReceivedOrganization { get; set; }

        [JsonProperty("democgraphy/other_method_communication")]
        public string DemocgraphyOtherMethodCommunication { get; set; }

        [JsonProperty("democgraphy/not_recover")]
        public string DemocgraphyNotRecover { get; set; }

        [JsonProperty("democgraphy/challenges_using_getting")]
        public string DemocgraphyChallengesUsingGetting { get; set; }
        public DateTime? _last_edited { get; set; }

        [JsonProperty("meta/deprecatedID")]
        public string MetaDeprecatedID { get; set; }

        [JsonProperty("democgraphy/other_satisfied")]
        public string DemocgraphyOtherSatisfied { get; set; }
    }
}