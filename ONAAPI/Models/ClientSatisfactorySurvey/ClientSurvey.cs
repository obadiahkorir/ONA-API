using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONAAPI.Models.ClientSatisfactorySurvey
{
    public class ClientSurveyRoot
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
        public List<double> _geolocation { get; set; }
        public int _media_count { get; set; }
        public int _total_media { get; set; }

        [JsonProperty("formhub/uuid")]
        public string FormhubUuid { get; set; }
        public object _submitted_by { get; set; }
        public DateTime _date_modified { get; set; }

        [JsonProperty("meta/instanceID")]
        public string MetaInstanceID { get; set; }
        public DateTime _submission_time { get; set; }
        public string _xform_id_string { get; set; }
        public string Date_of_the_survey { get; set; }
        public string _bamboo_dataset_id { get; set; }
        public bool _media_all_received { get; set; }

        [JsonProperty("group_jq4dn68/Region")]
        public string GroupJq4dn68Region { get; set; }

        [JsonProperty("group_jq4dn68/District")]
        public string GroupJq4dn68District { get; set; }

        [JsonProperty("group_jq4dn68/Health_Facility")]
        public string GroupJq4dn68HealthFacility { get; set; }

        [JsonProperty("group_jq4dn68/Respondents_age")]
        public string GroupJq4dn68RespondentsAge { get; set; }
        public string Please_check_if_Mothers_of_Wel { get; set; }
        public string Please_check_if_the_beneficiar { get; set; }

        [JsonProperty("group_tz2jo84/Are_you_Pregnant")]
        public string GroupTz2jo84AreYouPregnant { get; set; }

        [JsonProperty("group_jq4dn68/Respondents_Gender")]
        public string GroupJq4dn68RespondentsGender { get; set; }

        [JsonProperty("group_jq4dn68/Respondents_full_names")]
        public string GroupJq4dn68RespondentsFullNames { get; set; }

        [JsonProperty("group_jq4dn68/Record_your_current_location")]
        public string GroupJq4dn68RecordYourCurrentLocation { get; set; }

        [JsonProperty("group_tz2jo84/Is_this_your_first_pregnancy")]
        public string GroupTz2jo84IsThisYourFirstPregnancy { get; set; }

        [JsonProperty("group_tz2jo84/Have_you_registered_for_Antena")]
        public string GroupTz2jo84HaveYouRegisteredForAntena { get; set; }

        [JsonProperty("group_xi3jw21/Have_your_child_admitted_diarr")]
        public string GroupXi3jw21HaveYourChildAdmittedDiarr { get; set; }

        [JsonProperty("group_op6hb65/Have_you_ever_breast_your_last_baby")]
        public string GroupOp6hb65HaveYouEverBreastYourLastBaby { get; set; }

        [JsonProperty("group_tz2jo84/If_NO_how_many_children_do_you_have")]
        public string GroupTz2jo84IfNOHowManyChildrenDoYouHave { get; set; }

        [JsonProperty("group_op6hb65/Where_did_you_deliver_your_last_baby")]
        public string GroupOp6hb65WhereDidYouDeliverYourLastBaby { get; set; }

        [JsonProperty("group_cl8mp02/_2_How_long_did_you_ovider_in_minutes")]
        public object GroupCl8mp022HowLongDidYouOviderInMinutes { get; set; }

        [JsonProperty("group_tz2jo84/During_your_visit_w_PNC_after_delivery")]
        public string GroupTz2jo84DuringYourVisitWPNCAfterDelivery { get; set; }

        [JsonProperty("group_tz2jo84/Did_the_provider_dis_ache_dizziness_etc")]
        public string GroupTz2jo84DidTheProviderDisAcheDizzinessEtc { get; set; }

        [JsonProperty("group_tz2jo84/During_this_visit_d_nk_during_pregnancy")]
        public string GroupTz2jo84DuringThisVisitDNkDuringPregnancy { get; set; }

        [JsonProperty("group_xi3jw21/Were_you_advised_to_rapid_breathing_etc")]
        public string GroupXi3jw21WereYouAdvisedToRapidBreathingEtc { get; set; }

        [JsonProperty("group_cl8mp02/Are_you_satisfied_with_this_waiting_time")]
        public string GroupCl8mp02AreYouSatisfiedWithThisWaitingTime { get; set; }

        [JsonProperty("group_cl8mp02/How_far_did_you_trav_the_health_facility")]
        public string GroupCl8mp02HowFarDidYouTravTheHealthFacility { get; set; }

        [JsonProperty("group_op6hb65/Were_you_informed_ab_were_still_pregnant")]
        public string GroupOp6hb65WereYouInformedAbWereStillPregnant { get; set; }

        [JsonProperty("group_tz2jo84/Do_you_remember_five_your_diet_List_them")]
        public string GroupTz2jo84DoYouRememberFiveYourDietListThem { get; set; }

        [JsonProperty("group_tz2jo84/During_this_visit_d_very_in_the_facility")]
        public string GroupTz2jo84DuringThisVisitDVeryInTheFacility { get; set; }

        [JsonProperty("group_tz2jo84/Have_you_ever_receiv_have_received_today")]
        public string GroupTz2jo84HaveYouEverReceivHaveReceivedToday { get; set; }

        [JsonProperty("group_tz2jo84/Were_you_provided_an_and_or_Iron_tablets")]
        public string GroupTz2jo84WereYouProvidedAnAndOrIronTablets { get; set; }

        [JsonProperty("group_xi3jw21/Were_you_counseled_o_for_your_sick_child")]
        public string GroupXi3jw21WereYouCounseledOForYourSickChild { get; set; }

        [JsonProperty("group_cl8mp02/Are_you_satisfied_wi_h_nutrition_facility")]
        public string GroupCl8mp02AreYouSatisfiedWiHNutritionFacility { get; set; }

        [JsonProperty("group_cl8mp02/Are_you_satisfied_wi_ing_the_consultation")]
        public string GroupCl8mp02AreYouSatisfiedWiIngTheConsultation { get; set; }

        [JsonProperty("group_cl8mp02/Are_you_satisfied_wi_lth_service_provider")]
        public string GroupCl8mp02AreYouSatisfiedWiLthServiceProvider { get; set; }

        [JsonProperty("group_cl8mp02/How_would_you_descri_service_you_received")]
        public string GroupCl8mp02HowWouldYouDescriServiceYouReceived { get; set; }

        [JsonProperty("group_cl8mp02/Which_services_did_y_this_health_facility")]
        public string GroupCl8mp02WhichServicesDidYThisHealthFacility { get; set; }

        [JsonProperty("group_op6hb65/Are_you_currently_pr_lusive_Breastfeeding")]
        public string GroupOp6hb65AreYouCurrentlyPrLusiveBreastfeeding { get; set; }

        [JsonProperty("group_op6hb65/Were_you_counseled_o_lusive_breastfeeding")]
        public string GroupOp6hb65WereYouCounseledOLusiveBreastfeeding { get; set; }

        [JsonProperty("group_op6hb65/Were_you_informed_ab_ANC_or_any_PNC_visit")]
        public string GroupOp6hb65WereYouInformedAbANCOrAnyPNCVisit { get; set; }

        [JsonProperty("group_op6hb65/Were_you_informed_ab_eking_medical_advice")]
        public string GroupOp6hb65WereYouInformedAbEkingMedicalAdvice { get; set; }

        [JsonProperty("group_op6hb65/When_did_you_initiat_eding_your_last_baby")]
        public string GroupOp6hb65WhenDidYouInitiatEdingYourLastBaby { get; set; }

        [JsonProperty("group_tz2jo84/During_this_visit_or_nus_toxoid_injection")]
        public string GroupTz2jo84DuringThisVisitOrNusToxoidInjection { get; set; }

        [JsonProperty("group_tz2jo84/How_long_have_you_be_n_pregnant_in_months")]
        public object GroupTz2jo84HowLongHaveYouBeNPregnantInMonths { get; set; }

        [JsonProperty("group_tz2jo84/If_you_were_prescrib_nnoying_side_effects")]
        public string GroupTz2jo84IfYouWerePrescribNnoyingSideEffects { get; set; }

        [JsonProperty("group_tz2jo84/Including_any_Tetanu_nus_Toxoid_injection")]
        public object GroupTz2jo84IncludingAnyTetanuNusToxoidInjection { get; set; }

        [JsonProperty("group_tz2jo84/Including_this_visit_o_this_health_center")]
        public object GroupTz2jo84IncludingThisVisitOThisHealthCenter { get; set; }

        [JsonProperty("group_tz2jo84/Is_this_your_first_a_r_for_this_pregnancy")]
        public string GroupTz2jo84IsThisYourFirstARForThisPregnancy { get; set; }

        [JsonProperty("group_tz2jo84/Why_did_you_choose_t_ealth_facility_today")]
        public string GroupTz2jo84WhyDidYouChooseTEalthFacilityToday { get; set; }

        [JsonProperty("group_xi3jw21/Were_you_asked_if_yo_nderness_or_swelling")]
        public string GroupXi3jw21WereYouAskedIfYoNdernessOrSwelling { get; set; }

        [JsonProperty("group_xi3jw21/Were_you_counseled_o_solid_waste_disposal")]
        public string GroupXi3jw21WereYouCounseledOSolidWasteDisposal { get; set; }

        [JsonProperty("group_cl8mp02/_6Are_you_satisfied_w_lth_service_provider")]
        public string GroupCl8mp026AreYouSatisfiedWLthServiceProvider { get; set; }

        [JsonProperty("group_zh6eu36/How_old_is_your_child")]
        public object GroupZh6eu36HowOldIsYourChild { get; set; }

        [JsonProperty("group_zh6eu36/How_much_is_the_difference")]
        public object GroupZh6eu36HowMuchIsTheDifference { get; set; }

        [JsonProperty("group_zh6eu36/Has_your_child_ever_missed_an_")]
        public string GroupZh6eu36HasYourChildEverMissedAn { get; set; }

        [JsonProperty("group_zh6eu36/Have_you_participated_in_any_g")]
        public string GroupZh6eu36HaveYouParticipatedInAnyG { get; set; }

        [JsonProperty("group_zh6eu36/Did_you_immunize_your_child_so_far")]
        public string GroupZh6eu36DidYouImmunizeYourChildSoFar { get; set; }

        [JsonProperty("group_zh6eu36/If_your_child_s_weig_of_your_child_")]
        public string GroupZh6eu36IfYourChildSWeigOfYourChild { get; set; }

        [JsonProperty("group_zh6eu36/Has_the_weight_of_yo_from_the_last_visit")]
        public string GroupZh6eu36HasTheWeightOfYoFromTheLastVisit { get; set; }

        [JsonProperty("group_zh6eu36/How_many_sachets_of_ur_child_given_today")]
        public string GroupZh6eu36HowManySachetsOfUrChildGivenToday { get; set; }

        [JsonProperty("group_zh6eu36/If_yes_what_were_th_ey_discussion_topics")]
        public string GroupZh6eu36IfYesWhatWereThEyDiscussionTopics { get; set; }

        [JsonProperty("group_zh6eu36/Were_you_prescribed_in_the_last_6_months")]
        public string GroupZh6eu36WereYouPrescribedInTheLast6Months { get; set; }

        [JsonProperty("group_zh6eu36/has_the_child_completed_his_immunization")]
        public string GroupZh6eu36HasTheChildCompletedHisImmunization { get; set; }

        [JsonProperty("group_zh6eu36/If_the_child_is_less_eastfeeding_her_baby")]
        public string GroupZh6eu36IfTheChildIsLessEastfeedingHerBaby { get; set; }

        [JsonProperty("group_zh6eu36/Is_the_amount_of_RUF_n_on_the_ration_card")]
        public string GroupZh6eu36IsTheAmountOfRUFNOnTheRationCard { get; set; }

        [JsonProperty("group_zh6eu36/Tell_me_the_reason_s_for_treatment_before")]
        public string GroupZh6eu36TellMeTheReasonSForTreatmentBefore { get; set; }

        [JsonProperty("group_zh6eu36/Were_you_given_any_v_in_A_supplementation")]
        public string GroupZh6eu36WereYouGivenAnyVInASupplementation { get; set; }

        [JsonProperty("group_zh6eu36/Were_you_informed_of_ance_of_immunization")]
        public string GroupZh6eu36WereYouInformedOfAnceOfImmunization { get; set; }

        [JsonProperty("group_zh6eu36/Who_brought_the_chil_tion_health_facility")]
        public string GroupZh6eu36WhoBroughtTheChilTionHealthFacility { get; set; }

        [JsonProperty("group_tz2jo84/If_Yes_how_many_Ant_that_health_facility")]
        public string GroupTz2jo84IfYesHowManyAntThatHealthFacility { get; set; }

        [JsonProperty("group_zh6eu36/If_not_why_did_you_n_a_group_discussion")]
        public string GroupZh6eu36IfNotWhyDidYouNAGroupDiscussion { get; set; }

        [JsonProperty("group_zh6eu36/If_yes_how_many_times")]
        public object GroupZh6eu36IfYesHowManyTimes { get; set; }

        [JsonProperty("group_xi3jw21/if_yes_Were_you_sho_ow_to_administer_ORS")]
        public string GroupXi3jw21IfYesWereYouShoOwToAdministerORS { get; set; }
    }
}