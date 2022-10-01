using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONAAPI.Models
{
    public class CashBeneficiariesSurveyRoot
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
            public string _bamboo_dataset_id { get; set; }

            [JsonProperty("group_gq7ez50/Date")]
            public string GroupGq7ez50Date { get; set; }

            [JsonProperty("group_se2im73/Food")]
            public int GroupSe2im73Food { get; set; }

            [JsonProperty("group_se2im73/Rent")]
            public object GroupSe2im73Rent { get; set; }
            public bool _media_all_received { get; set; }

            [JsonProperty("group_se2im73/Water")]
            public object GroupSe2im73Water { get; set; }

            [JsonProperty("group_gq7ez50/Region")]
            public string GroupGq7ez50Region { get; set; }

            [JsonProperty("group_rw3tq65/Gender")]
            public string GroupRw3tq65Gender { get; set; }

            [JsonProperty("group_gq7ez50/District")]
            public string GroupGq7ez50District { get; set; }

            [JsonProperty("group_se2im73/Education")]
            public object GroupSe2im73Education { get; set; }

            [JsonProperty("group_se2im73/Electricity")]
            public object GroupSe2im73Electricity { get; set; }

            [JsonProperty("group_gq7ez50/Village_Site")]
            public string GroupGq7ez50VillageSite { get; set; }

            [JsonProperty("group_rw3tq65/Civil_status")]
            public string GroupRw3tq65CivilStatus { get; set; }

            [JsonProperty("group_rw3tq65/Household_ID")]
            public string GroupRw3tq65HouseholdID { get; set; }

            [JsonProperty("group_se2im73/Debt_payment")]
            public object GroupSe2im73DebtPayment { get; set; }

            [JsonProperty("group_se2im73/Transportation")]
            public object GroupSe2im73Transportation { get; set; }

            [JsonProperty("group_rw3tq65/Beneficiary_s_age")]
            public string GroupRw3tq65BeneficiarySAge { get; set; }

            [JsonProperty("group_se2im73/Productive_assets")]
            public object GroupSe2im73ProductiveAssets { get; set; }

            [JsonProperty("group_rw3tq65/Beneficiary_s_Name")]
            public string GroupRw3tq65BeneficiarySName { get; set; }

            [JsonProperty("group_se2im73/Shelter_maintenance")]
            public object GroupSe2im73ShelterMaintenance { get; set; }

            [JsonProperty("group_ee1uv94/Was_the_message_clear")]
            public string GroupEe1uv94WasTheMessageClear { get; set; }

            [JsonProperty("group_rw3tq65/Other_please_specify_")]
            public string GroupRw3tq65OtherPleaseSpecify { get; set; }

            [JsonProperty("group_gq7ez50/Interviewer_staff_Name")]
            public string GroupGq7ez50InterviewerStaffName { get; set; }

            [JsonProperty("group_du7pd14/Other_please_specify_001")]
            public string GroupDu7pd14OtherPleaseSpecify001 { get; set; }

            [JsonProperty("group_se2im73/Communications_ex_phones")]
            public object GroupSe2im73CommunicationsExPhones { get; set; }

            [JsonProperty("group_se2im73/Business_start_up_expansion")]
            public object GroupSe2im73BusinessStartUpExpansion { get; set; }

            [JsonProperty("group_gq7ez50/Record_your_current_location")]
            public string GroupGq7ez50RecordYourCurrentLocation { get; set; }

            [JsonProperty("group_ue2qo54/Was_the_issue_later_resolved")]
            public string GroupUe2qo54WasTheIssueLaterResolved { get; set; }

            [JsonProperty("group_ee1uv94/If_yes_how_was_this_informati")]
            public string GroupEe1uv94IfYesHowWasThisInformati { get; set; }

            [JsonProperty("group_du7pd14/How_did_the_SC_inform_activity")]
            public string GroupDu7pd14HowDidTheSCInformActivity { get; set; }

            [JsonProperty("group_du7pd14/How_do_you_share_your_concerns")]
            public string GroupDu7pd14HowDoYouShareYourConcerns { get; set; }

            [JsonProperty("group_du7pd14/Why_do_you_share_your_concerns")]
            public string GroupDu7pd14WhyDoYouShareYourConcerns { get; set; }

            [JsonProperty("group_ee1uv94/How_do_you_prefer_to_receive_i")]
            public string GroupEe1uv94HowDoYouPreferToReceiveI { get; set; }

            [JsonProperty("group_ee1uv94/What_mode_of_communication_wou")]
            public string GroupEe1uv94WhatModeOfCommunicationWou { get; set; }

            [JsonProperty("group_ee1uv94/Which_mode_of_communication_di")]
            public string GroupEe1uv94WhichModeOfCommunicationDi { get; set; }

            [JsonProperty("group_ke4kl81/Is_there_any_member_of_this_ho")]
            public string GroupKe4kl81IsThereAnyMemberOfThisHo { get; set; }

            [JsonProperty("group_rw3tq65/What_is_your_relationship_to_t")]
            public string GroupRw3tq65WhatIsYourRelationshipToT { get; set; }

            [JsonProperty("group_rw3tq65/What_types_of_assistance_have_")]
            public string GroupRw3tq65WhatTypesOfAssistanceHave { get; set; }

            [JsonProperty("group_uf4uz74/Did_you_experience_any_challen")]
            public string GroupUf4uz74DidYouExperienceAnyChallen { get; set; }

            [JsonProperty("group_uf4uz74/Was_the_amount_of_cash_always_")]
            public string GroupUf4uz74WasTheAmountOfCashAlways { get; set; }

            [JsonProperty("group_se2im73/Medical_care_including_medicine")]
            public object GroupSe2im73MedicalCareIncludingMedicine { get; set; }

            [JsonProperty("group_rw3tq65/Occupation_of_the_household_head")]
            public string GroupRw3tq65OccupationOfTheHouseholdHead { get; set; }

            [JsonProperty("group_ee1uv94/What_mode_of_communication_wou_001")]
            public string GroupEe1uv94WhatModeOfCommunicationWou001 { get; set; }

            [JsonProperty("group_ke4kl81/Does_this_household_nutritional_support")]
            public string GroupKe4kl81DoesThisHouseholdNutritionalSupport { get; set; }

            [JsonProperty("group_ke4kl81/Does_this_household_or_lactating_mother")]
            public string GroupKe4kl81DoesThisHouseholdOrLactatingMother { get; set; }

            [JsonProperty("group_uf4uz74/How_many_months_did_the_money_in_months")]
            public int GroupUf4uz74HowManyMonthsDidTheMoneyInMonths { get; set; }

            [JsonProperty("group_du7pd14/Have_you_ever_had_a_ash_for_work_project")]
            public string GroupDu7pd14HaveYouEverHadAAshForWorkProject { get; set; }

            [JsonProperty("group_du7pd14/If_yes_did_SC_respo_complaint_you_raised")]
            public string GroupDu7pd14IfYesDidSCRespoComplaintYouRaised { get; set; }

            [JsonProperty("group_ee1uv94/Are_the_project_s_mo_marginalized_groups")]
            public string GroupEe1uv94AreTheProjectSMoMarginalizedGroups { get; set; }

            [JsonProperty("group_ow5du92/If_yes_how_satisfie_verification_process")]
            public string GroupOw5du92IfYesHowSatisfieVerificationProcess { get; set; }

            [JsonProperty("group_po8no70/Were_you_PERSONALLY_e_of_work_activities")]
            public string GroupPo8no70WereYouPERSONALLYEOfWorkActivities { get; set; }

            [JsonProperty("group_ue2qo54/Had_SC_communicated_e_delays_before_hand")]
            public string GroupUe2qo54HadSCCommunicatedEDelaysBeforeHand { get; set; }

            [JsonProperty("group_uf4uz74/How_satisfied_are_yo_you_receive_from_SC")]
            public string GroupUf4uz74HowSatisfiedAreYoYouReceiveFromSC { get; set; }

            [JsonProperty("group_uf4uz74/Was_the_purpose_of_t_communicated_to_you")]
            public string GroupUf4uz74WasThePurposeOfTCommunicatedToYou { get; set; }

            [JsonProperty("group_uf4uz74/What_is_the_amount_o_from_SC_every_month")]
            public int GroupUf4uz74WhatIsTheAmountOFromSCEveryMonth { get; set; }

            [JsonProperty("group_vs0ed43/What_role_did_female_play_in_the_program")]
            public string GroupVs0ed43WhatRoleDidFemalePlayInTheProgram { get; set; }

            [JsonProperty("group_du7pd14/Are_you_aware_of_any_can_use_to_reach_SCI")]
            public string GroupDu7pd14AreYouAwareOfAnyCanUseToReachSCI { get; set; }

            [JsonProperty("group_du7pd14/How_did_you_share_yo_elect_all_that_apply")]
            public string GroupDu7pd14HowDidYouShareYoElectAllThatApply { get; set; }

            [JsonProperty("group_du7pd14/How_satisfied_are_yo_back_on_the_activity")]
            public string GroupDu7pd14HowSatisfiedAreYoBackOnTheActivity { get; set; }

            [JsonProperty("group_du7pd14/How_satisfied_were_y_nd_to_your_complaint")]
            public string GroupDu7pd14HowSatisfiedWereYNdToYourComplaint { get; set; }

            [JsonProperty("group_du7pd14/How_satisfied_were_y_solve_your_complaint")]
            public string GroupDu7pd14HowSatisfiedWereYSolveYourComplaint { get; set; }

            [JsonProperty("group_du7pd14/What_would_be_your_r_solve_your_complaint")]
            public string GroupDu7pd14WhatWouldBeYourRSolveYourComplaint { get; set; }

            [JsonProperty("group_ee1uv94/Did_you_as_an_indivi_xpected_entitlements")]
            public string GroupEe1uv94DidYouAsAnIndiviXpectedEntitlements { get; set; }

            [JsonProperty("group_ee1uv94/How_satisfied_were_y_g_with_beneficiaries")]
            public string GroupEe1uv94HowSatisfiedWereYGWithBeneficiaries { get; set; }

            [JsonProperty("group_ee1uv94/How_satisfied_were_y_g_with_the_community")]
            public string GroupEe1uv94HowSatisfiedWereYGWithTheCommunity { get; set; }

            [JsonProperty("group_ee1uv94/How_satisfied_were_y_mmunicating_with_you")]
            public string GroupEe1uv94HowSatisfiedWereYMmunicatingWithYou { get; set; }

            [JsonProperty("group_ee1uv94/Were_you_provided_wi_ide_to_the_community")]
            public string GroupEe1uv94WereYouProvidedWiIdeToTheCommunity { get; set; }

            [JsonProperty("group_ee1uv94/What_would_be_your_r_n_with_beneficiaries")]
            public string GroupEe1uv94WhatWouldBeYourRNWithBeneficiaries { get; set; }

            [JsonProperty("group_ke4kl81/Does_this_disability_aring_for_themselves")]
            public string GroupKe4kl81DoesThisDisabilityAringForThemselves { get; set; }

            [JsonProperty("group_ow5du92/How_satisfied_are_yo_h_for_a_work_project")]
            public string GroupOw5du92HowSatisfiedAreYoHForAWorkProject { get; set; }

            [JsonProperty("group_ow5du92/Was_the_community_in_e_selection_criteria")]
            public string GroupOw5du92WasTheCommunityInESelectionCriteria { get; set; }

            [JsonProperty("group_ow5du92/Was_the_community_in_verification_process")]
            public string GroupOw5du92WasTheCommunityInVerificationProcess { get; set; }

            [JsonProperty("group_ow5du92/Was_there_a_verifica_listed_beneficiaries")]
            public string GroupOw5du92WasThereAVerificaListedBeneficiaries { get; set; }

            [JsonProperty("group_ow5du92/Were_females_involve_e_selection_criteria")]
            public string GroupOw5du92WereFemalesInvolveESelectionCriteria { get; set; }

            [JsonProperty("group_ow5du92/Were_you_informed_of_eria_for_the_project")]
            public string GroupOw5du92WereYouInformedOfEriaForTheProject { get; set; }

            [JsonProperty("group_po8no70/Do_you_think_the_sel_al_to_your_community")]
            public string GroupPo8no70DoYouThinkTheSelAlToYourCommunity { get; set; }

            [JsonProperty("group_po8no70/How_satisfied_were_y_s_for_the_cash_grant")]
            public string GroupPo8no70HowSatisfiedWereYSForTheCashGrant { get; set; }

            [JsonProperty("group_po8no70/Was_the_community_in_e_of_work_activities")]
            public string GroupPo8no70WasTheCommunityInEOfWorkActivities { get; set; }

            [JsonProperty("group_rw3tq65/Highest_education_le_l_of_the_beneficiary")]
            public string GroupRw3tq65HighestEducationLeLOfTheBeneficiary { get; set; }

            [JsonProperty("group_rw3tq65/How_many_people_over_d_including_yourself")]
            public int GroupRw3tq65HowManyPeopleOverDIncludingYourself { get; set; }

            [JsonProperty("group_rw3tq65/How_many_people_unde_re_in_your_household")]
            public int GroupRw3tq65HowManyPeopleUndeReInYourHousehold { get; set; }

            [JsonProperty("group_se2im73/Which_of_the_followi_hoose_all_that_apply")]
            public string GroupSe2im73WhichOfTheFollowiHooseAllThatApply { get; set; }

            [JsonProperty("group_ue2qo54/Did_you_encounter_an_hoose_all_that_apply")]
            public string GroupUe2qo54DidYouEncounterAnHooseAllThatApply { get; set; }

            [JsonProperty("group_ue2qo54/Have_you_ever_experi_distribution_of_cash")]
            public string GroupUe2qo54HaveYouEverExperiDistributionOfCash { get; set; }

            [JsonProperty("group_uf4uz74/How_satisfied_are_yo_ing_mobile_platforms")]
            public string GroupUf4uz74HowSatisfiedAreYoIngMobilePlatforms { get; set; }

            [JsonProperty("group_vs0ed43/How_satisfied_were_y_female_beneficiaries")]
            public string GroupVs0ed43HowSatisfiedWereYFemaleBeneficiaries { get; set; }

            [JsonProperty("group_vs0ed43/How_satisfied_were_y_ficiaries_in_general")]
            public string GroupVs0ed43HowSatisfiedWereYFiciariesInGeneral { get; set; }

            [JsonProperty("group_vs0ed43/How_satisfied_were_y_ility_by_the_program")]
            public string GroupVs0ed43HowSatisfiedWereYIlityByTheProgram { get; set; }

            [JsonProperty("group_vs0ed43/How_satisfied_were_y_ldren_by_the_program")]
            public string GroupVs0ed43HowSatisfiedWereYLdrenByTheProgram { get; set; }

            [JsonProperty("group_vs0ed43/What_role_did_benefi_elect_all_that_apply")]
            public string GroupVs0ed43WhatRoleDidBenefiElectAllThatApply { get; set; }

            [JsonProperty("group_du7pd14/If_other_specify")]
            public string GroupDu7pd14IfOtherSpecify { get; set; }

            [JsonProperty("group_du7pd14/other_specify_004")]
            public string GroupDu7pd14OtherSpecify004 { get; set; }

            [JsonProperty("group_ke4kl81/a_If_yes_how_many")]
            public int? GroupKe4kl81AIfYesHowMany { get; set; }

            [JsonProperty("group_ke4kl81/Please_specify_the_kind_of_dis")]
            public string GroupKe4kl81PleaseSpecifyTheKindOfDis { get; set; }

            [JsonProperty("group_du7pd14/If_others_please_specify_001")]
            public string GroupDu7pd14IfOthersPleaseSpecify001 { get; set; }
        }
}