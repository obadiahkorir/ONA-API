using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ONAAPI.Models
{
    public class ToolsNutritionAssesmentRoot
    {
        public int _id { get; set; }
        public DateTime end { get; set; }
        public List<object> _tags { get; set; }
        public string _uuid { get; set; }
        public DateTime start { get; set; }
        public List<object> _notes { get; set; }
        public bool _edited { get; set; }
        public string _status { get; set; }
        public string Location { get; set; }
        public string _version { get; set; }
        public double _duration { get; set; }
        public int _xform_id { get; set; }
        public string __version__ { get; set; }
        public string Enter_a_date { get; set; }
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
        public bool _media_all_received { get; set; }
        public string Name_of_the_researcher { get; set; }
        public string Record_your_current_location { get; set; }

        [JsonProperty("group_ym9df60/Are_all_organized_training_need_based")]
        public string GroupYm9df60AreAllOrganizedTrainingNeedBased { get; set; }

        [JsonProperty("group_eu23s30/Are_all_staff_who_co_group_U5_and_PLW_")]
        public string GroupEu23s30AreAllStaffWhoCoGroupU5AndPLW { get; set; }

        [JsonProperty("group_ym9df60/Is_the_selection_of_g_gender_ethnicity")]
        public string GroupYm9df60IsTheSelectionOfGGenderEthnicity { get; set; }

        [JsonProperty("group_eu23s30/Is_there_a_documente_screening_activity")]
        public string GroupEu23s30IsThereADocumenteScreeningActivity { get; set; }

        [JsonProperty("group_lg92i15/During_the_meeting_bution_participation")]
        public string GroupLg92i15DuringTheMeetingButionParticipation { get; set; }

        [JsonProperty("group_lg92i15/During_the_meeting_ion_of_program_sites")]
        public string GroupLg92i15DuringTheMeetingIonOfProgramSites { get; set; }

        [JsonProperty("group_lg92i15/During_the_meeting_nteer_identification")]
        public string GroupLg92i15DuringTheMeetingNteerIdentification { get; set; }

        [JsonProperty("group_ym9df60/Are_children_always_children_s_training")]
        public string GroupYm9df60AreChildrenAlwaysChildrenSTraining { get; set; }

        [JsonProperty("group_ym9df60/Are_pre_test_alway_ning_of_the_training")]
        public string GroupYm9df60ArePreTestAlwayNingOfTheTraining { get; set; }

        [JsonProperty("group_ym9df60/Does_the_report_alwa_photos_testimonies")]
        public string GroupYm9df60DoesTheReportAlwaPhotosTestimonies { get; set; }

        [JsonProperty("group_ym9df60/Is_an_action_plan_f_after_the_training_")]
        public string GroupYm9df60IsAnActionPlanFAfterTheTraining { get; set; }

        [JsonProperty("group_ao0ms64/Do_CNVs_report_on_ac_tracing_every_month")]
        public string GroupAo0ms64DoCNVsReportOnAcTracingEveryMonth { get; set; }

        [JsonProperty("group_ao0ms64/Do_the_CM_CNVs_have_d_sensitization_plan")]
        public string GroupAo0ms64DoTheCMCNVsHaveDSensitizationPlan { get; set; }

        [JsonProperty("group_ek2tj38/Is_there_a_report_de_points_in_CM_format")]
        public string GroupEk2tj38IsThereAReportDePointsInCMFormat { get; set; }

        [JsonProperty("group_eu23s30/Does_the_team_always_the_whole_exercise_")]
        public string GroupEu23s30DoesTheTeamAlwaysTheWholeExercise { get; set; }

        [JsonProperty("group_eu23s30/Is_screening_always_ing_MUAC_measurement")]
        public string GroupEu23s30IsScreeningAlwaysIngMUACMeasurement { get; set; }

        [JsonProperty("group_ke7ml37/Are_there_learning_m_ng_and_field_visits")]
        public string GroupKe7ml37AreThereLearningMNgAndFieldVisits { get; set; }

        [JsonProperty("group_ke7ml37/Is_there_a_timetabl_es_agreed_in_advance")]
        public string GroupKe7ml37IsThereATimetablEsAgreedInAdvance { get; set; }

        [JsonProperty("group_lg92i15/Is_there_a_signed_ag_sight_establishment")]
        public string GroupLg92i15IsThereASignedAgSightEstablishment { get; set; }

        [JsonProperty("group_ym9df60/Are_the_trainer_res_eable_on_the_subject")]
        public string GroupYm9df60AreTheTrainerResEableOnTheSubject { get; set; }

        [JsonProperty("group_ym9df60/Do_trainings_always_anual_does_not_exist")]
        public string GroupYm9df60DoTrainingsAlwaysAnualDoesNotExist { get; set; }

        [JsonProperty("group_ym9df60/Is_there_a_training_cipants_ever_trained")]
        public string GroupYm9df60IsThereATrainingCipantsEverTrained { get; set; }

        [JsonProperty("group_ao0ms64/Do_CNVs_report_on_Co_lemented_every_month")]
        public string GroupAo0ms64DoCNVsReportOnCoLementedEveryMonth { get; set; }

        [JsonProperty("group_ao0ms64/Do_CNVs_visit_each_h_ast_once_per_quarter")]
        public string GroupAo0ms64DoCNVsVisitEachHAstOncePerQuarter { get; set; }

        [JsonProperty("group_ao0ms64/Does_the_community_m_ctivities_every_week")]
        public string GroupAo0ms64DoesTheCommunityMCtivitiesEveryWeek { get; set; }

        [JsonProperty("group_ao0ms64/Does_the_community_m_ilization_activities")]
        public string GroupAo0ms64DoesTheCommunityMIlizationActivities { get; set; }

        [JsonProperty("group_ek2tj38/Was_the_community_in_bution_participation")]
        public string GroupEk2tj38WasTheCommunityInButionParticipation { get; set; }

        [JsonProperty("group_ek2tj38/Was_the_community_in_community_volunteers")]
        public string GroupEk2tj38WasTheCommunityInCommunityVolunteers { get; set; }

        [JsonProperty("group_ek2tj38/Was_the_community_in_d_before_the_meeting")]
        public string GroupEk2tj38WasTheCommunityInDBeforeTheMeeting { get; set; }

        [JsonProperty("group_ek2tj38/Were_community_membe_ation_to_the_meeting")]
        public string GroupEk2tj38WereCommunityMembeAtionToTheMeeting { get; set; }

        [JsonProperty("group_eu23s30/Are_all_identified_m_ven_a_referral_slip_")]
        public string GroupEu23s30AreAllIdentifiedMVenAReferralSlip { get; set; }

        [JsonProperty("group_eu23s30/Is_there_a_documente_e_screening_exercise")]
        public string GroupEu23s30IsThereADocumenteEScreeningExercise { get; set; }

        [JsonProperty("group_ke7ml37/Are_seconded_staff_a_and_post_evaluation_")]
        public string GroupKe7ml37AreSecondedStaffAAndPostEvaluation { get; set; }

        [JsonProperty("group_ke7ml37/Are_seconded_staff_a_ith_clear_objectives")]
        public string GroupKe7ml37AreSecondedStaffAIthClearObjectives { get; set; }

        [JsonProperty("group_ke7ml37/Does_secondment_alwa_g_quality_benchmarks")]
        public string GroupKe7ml37DoesSecondmentAlwaGQualityBenchmarks { get; set; }

        [JsonProperty("group_lg92i15/Are_there_minutes_de_tion_meeting_templet")]
        public string GroupLg92i15AreThereMinutesDeTionMeetingTemplet { get; set; }

        [JsonProperty("group_ym9df60/Do_participants_alwa_enue_and_facilitator")]
        public string GroupYm9df60DoParticipantsAlwaEnueAndFacilitator { get; set; }

        [JsonProperty("group_ym9df60/Do_the_training_team_s_after_the_training")]
        public string GroupYm9df60DoTheTrainingTeamSAfterTheTraining { get; set; }

        [JsonProperty("group_ym9df60/Do_the_trainings_alw_he_technical_advisor")]
        public string GroupYm9df60DoTheTrainingsAlwHeTechnicalAdvisor { get; set; }

        [JsonProperty("group_ym9df60/Do_the_trainings_alw_r_of_25_participants")]
        public string GroupYm9df60DoTheTrainingsAlwROf25Participants { get; set; }

        [JsonProperty("group_ym9df60/Is_the_mode_of_facil_always_participatory")]
        public string GroupYm9df60IsTheModeOfFacilAlwaysParticipatory { get; set; }

        [JsonProperty("group_ym9df60/Is_there_a_ToR_train_nd_a_detailed_budget")]
        public string GroupYm9df60IsThereAToRTrainNdADetailedBudget { get; set; }

        [JsonProperty("group_ym9df60/Is_there_a_provision_isabled_participants")]
        public string GroupYm9df60IsThereAProvisionIsabledParticipants { get; set; }

        [JsonProperty("group_ym9df60/Is_there_follow_up_d_the_set_action_plans")]
        public string GroupYm9df60IsThereFollowUpDTheSetActionPlans { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row/group_cf2mb67_row_column")]
        public string GroupCl6az80GroupCf2mb67RowGroupCf2mb67RowColumn { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row/group_im4zq41_row_column")]
        public string GroupCl6az80GroupIm4zq41RowGroupIm4zq41RowColumn { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row/group_ma06v81_row_column")]
        public string GroupCl6az80GroupMa06v81RowGroupMa06v81RowColumn { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row/group_ut8xm76_row_column")]
        public string GroupCl6az80GroupUt8xm76RowGroupUt8xm76RowColumn { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row/group_vx6ag31_row_column")]
        public string GroupCl6az80GroupVx6ag31RowGroupVx6ag31RowColumn { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row/group_xi6qy55_row_column")]
        public string GroupCl6az80GroupXi6qy55RowGroupXi6qy55RowColumn { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row/group_yy0wg80_row_column")]
        public string GroupCl6az80GroupYy0wg80RowGroupYy0wg80RowColumn { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row/group_hl9xq53_row_column")]
        public string GroupEe92z69GroupHl9xq53RowGroupHl9xq53RowColumn { get; set; }

        [JsonProperty("group_ee92z69/group_kj8ye01_row/group_kj8ye01_row_column")]
        public string GroupEe92z69GroupKj8ye01RowGroupKj8ye01RowColumn { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row/group_np9az10_row_column")]
        public string GroupEe92z69GroupNp9az10RowGroupNp9az10RowColumn { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row/group_uo6vb74_row_column")]
        public string GroupEe92z69GroupUo6vb74RowGroupUo6vb74RowColumn { get; set; }

        [JsonProperty("group_gn8tz78/group_dd2gt20_row/group_dd2gt20_row_column")]
        public string GroupGn8tz78GroupDd2gt20RowGroupDd2gt20RowColumn { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row/group_hl6wr53_row_column")]
        public string GroupGn8tz78GroupHl6wr53RowGroupHl6wr53RowColumn { get; set; }

        [JsonProperty("group_gn8tz78/group_ht6se71_row/group_ht6se71_row_column")]
        public string GroupGn8tz78GroupHt6se71RowGroupHt6se71RowColumn { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row/group_ri7rs20_row_column")]
        public string GroupGn8tz78GroupRi7rs20RowGroupRi7rs20RowColumn { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row/group_ym4ue63_row_column")]
        public string GroupGn8tz78GroupYm4ue63RowGroupYm4ue63RowColumn { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row/group_zb27l63_row_column")]
        public string GroupGn8tz78GroupZb27l63RowGroupZb27l63RowColumn { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row/group_aw4hv76_row_column")]
        public string GroupTi2rf69GroupAw4hv76RowGroupAw4hv76RowColumn { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row/group_lj2zd13_row_column")]
        public string GroupZl34f75GroupLj2zd13RowGroupLj2zd13RowColumn { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row/group_cf2mb67_row_column_2")]
        public string GroupCl6az80GroupCf2mb67RowGroupCf2mb67RowColumn2 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row/group_im4zq41_row_column_2")]
        public string GroupCl6az80GroupIm4zq41RowGroupIm4zq41RowColumn2 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row/group_ma06v81_row_column_1")]
        public string GroupCl6az80GroupMa06v81RowGroupMa06v81RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row/group_ma06v81_row_column_2")]
        public string GroupCl6az80GroupMa06v81RowGroupMa06v81RowColumn2 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row/group_ma06v81_row_column_4")]
        public string GroupCl6az80GroupMa06v81RowGroupMa06v81RowColumn4 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row/group_ut8xm76_row_column_2")]
        public string GroupCl6az80GroupUt8xm76RowGroupUt8xm76RowColumn2 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row/group_vx6ag31_row_column_2")]
        public string GroupCl6az80GroupVx6ag31RowGroupVx6ag31RowColumn2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row/group_xi6qy55_row_column_2")]
        public string GroupCl6az80GroupXi6qy55RowGroupXi6qy55RowColumn2 { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row/group_yy0wg80_row_column_2")]
        public string GroupCl6az80GroupYy0wg80RowGroupYy0wg80RowColumn2 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row/group_hl9xq53_row_column_2")]
        public string GroupEe92z69GroupHl9xq53RowGroupHl9xq53RowColumn2 { get; set; }

        [JsonProperty("group_ee92z69/group_kj8ye01_row/group_kj8ye01_row_column_2")]
        public string GroupEe92z69GroupKj8ye01RowGroupKj8ye01RowColumn2 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row/group_np9az10_row_column_2")]
        public string GroupEe92z69GroupNp9az10RowGroupNp9az10RowColumn2 { get; set; }

        [JsonProperty("group_gn8tz78/group_dd2gt20_row/group_dd2gt20_row_column_2")]
        public string GroupGn8tz78GroupDd2gt20RowGroupDd2gt20RowColumn2 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row/group_hl6wr53_row_column_2")]
        public string GroupGn8tz78GroupHl6wr53RowGroupHl6wr53RowColumn2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ht6se71_row/group_ht6se71_row_column_2")]
        public string GroupGn8tz78GroupHt6se71RowGroupHt6se71RowColumn2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row/group_ri7rs20_row_column_2")]
        public string GroupGn8tz78GroupRi7rs20RowGroupRi7rs20RowColumn2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row/group_ym4ue63_row_column_2")]
        public string GroupGn8tz78GroupYm4ue63RowGroupYm4ue63RowColumn2 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row/group_zb27l63_row_column_2")]
        public string GroupGn8tz78GroupZb27l63RowGroupZb27l63RowColumn2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row/group_aw4hv76_row_column_2")]
        public string GroupTi2rf69GroupAw4hv76RowGroupAw4hv76RowColumn2 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row/group_lj2zd13_row_column_2")]
        public string GroupZl34f75GroupLj2zd13RowGroupLj2zd13RowColumn2 { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_1/group_cf2mb67_row_1_column")]
        public string GroupCl6az80GroupCf2mb67Row1GroupCf2mb67Row1Column { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_2/group_cf2mb67_row_2_column")]
        public string GroupCl6az80GroupCf2mb67Row2GroupCf2mb67Row2Column { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_3/group_cf2mb67_row_3_column")]
        public string GroupCl6az80GroupCf2mb67Row3GroupCf2mb67Row3Column { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_1/group_im4zq41_row_1_column")]
        public string GroupCl6az80GroupIm4zq41Row1GroupIm4zq41Row1Column { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_2/group_im4zq41_row_2_column")]
        public string GroupCl6az80GroupIm4zq41Row2GroupIm4zq41Row2Column { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_3/group_im4zq41_row_3_column")]
        public string GroupCl6az80GroupIm4zq41Row3GroupIm4zq41Row3Column { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_1/group_ma06v81_row_1_column")]
        public string GroupCl6az80GroupMa06v81Row1GroupMa06v81Row1Column { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_2/group_ma06v81_row_2_column")]
        public string GroupCl6az80GroupMa06v81Row2GroupMa06v81Row2Column { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_3/group_ma06v81_row_3_column")]
        public string GroupCl6az80GroupMa06v81Row3GroupMa06v81Row3Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_1/group_ut8xm76_row_1_column")]
        public string GroupCl6az80GroupUt8xm76Row1GroupUt8xm76Row1Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_2/group_ut8xm76_row_2_column")]
        public string GroupCl6az80GroupUt8xm76Row2GroupUt8xm76Row2Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_3/group_ut8xm76_row_3_column")]
        public string GroupCl6az80GroupUt8xm76Row3GroupUt8xm76Row3Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_4/group_ut8xm76_row_4_column")]
        public string GroupCl6az80GroupUt8xm76Row4GroupUt8xm76Row4Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_5/group_ut8xm76_row_5_column")]
        public string GroupCl6az80GroupUt8xm76Row5GroupUt8xm76Row5Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_6/group_ut8xm76_row_6_column")]
        public string GroupCl6az80GroupUt8xm76Row6GroupUt8xm76Row6Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_7/group_ut8xm76_row_7_column")]
        public string GroupCl6az80GroupUt8xm76Row7GroupUt8xm76Row7Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_8/group_ut8xm76_row_8_column")]
        public string GroupCl6az80GroupUt8xm76Row8GroupUt8xm76Row8Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_9/group_ut8xm76_row_9_column")]
        public string GroupCl6az80GroupUt8xm76Row9GroupUt8xm76Row9Column { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_1/group_vx6ag31_row_1_column")]
        public string GroupCl6az80GroupVx6ag31Row1GroupVx6ag31Row1Column { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_2/group_vx6ag31_row_2_column")]
        public string GroupCl6az80GroupVx6ag31Row2GroupVx6ag31Row2Column { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_3/group_vx6ag31_row_3_column")]
        public string GroupCl6az80GroupVx6ag31Row3GroupVx6ag31Row3Column { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_4/group_vx6ag31_row_4_column")]
        public string GroupCl6az80GroupVx6ag31Row4GroupVx6ag31Row4Column { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_5/group_vx6ag31_row_5_column")]
        public string GroupCl6az80GroupVx6ag31Row5GroupVx6ag31Row5Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_1/group_xi6qy55_row_1_column")]
        public string GroupCl6az80GroupXi6qy55Row1GroupXi6qy55Row1Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_2/group_xi6qy55_row_2_column")]
        public string GroupCl6az80GroupXi6qy55Row2GroupXi6qy55Row2Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_3/group_xi6qy55_row_3_column")]
        public string GroupCl6az80GroupXi6qy55Row3GroupXi6qy55Row3Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_4/group_xi6qy55_row_4_column")]
        public string GroupCl6az80GroupXi6qy55Row4GroupXi6qy55Row4Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_5/group_xi6qy55_row_5_column")]
        public string GroupCl6az80GroupXi6qy55Row5GroupXi6qy55Row5Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_6/group_xi6qy55_row_6_column")]
        public string GroupCl6az80GroupXi6qy55Row6GroupXi6qy55Row6Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_7/group_xi6qy55_row_7_column")]
        public string GroupCl6az80GroupXi6qy55Row7GroupXi6qy55Row7Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_8/group_xi6qy55_row_8_column")]
        public string GroupCl6az80GroupXi6qy55Row8GroupXi6qy55Row8Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_9/group_xi6qy55_row_9_column")]
        public string GroupCl6az80GroupXi6qy55Row9GroupXi6qy55Row9Column { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row_1/group_yy0wg80_row_1_column")]
        public string GroupCl6az80GroupYy0wg80Row1GroupYy0wg80Row1Column { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row_2/group_yy0wg80_row_2_column")]
        public string GroupCl6az80GroupYy0wg80Row2GroupYy0wg80Row2Column { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_1/group_hl9xq53_row_1_column")]
        public string GroupEe92z69GroupHl9xq53Row1GroupHl9xq53Row1Column { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_2/group_hl9xq53_row_2_column")]
        public string GroupEe92z69GroupHl9xq53Row2GroupHl9xq53Row2Column { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_3/group_hl9xq53_row_3_column")]
        public string GroupEe92z69GroupHl9xq53Row3GroupHl9xq53Row3Column { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_4/group_hl9xq53_row_4_column")]
        public string GroupEe92z69GroupHl9xq53Row4GroupHl9xq53Row4Column { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_5/group_hl9xq53_row_5_column")]
        public string GroupEe92z69GroupHl9xq53Row5GroupHl9xq53Row5Column { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_1/group_np9az10_row_1_column")]
        public string GroupEe92z69GroupNp9az10Row1GroupNp9az10Row1Column { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_2/group_np9az10_row_2_column")]
        public string GroupEe92z69GroupNp9az10Row2GroupNp9az10Row2Column { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_3/group_np9az10_row_3_column")]
        public string GroupEe92z69GroupNp9az10Row3GroupNp9az10Row3Column { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_4/group_np9az10_row_4_column")]
        public string GroupEe92z69GroupNp9az10Row4GroupNp9az10Row4Column { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_5/group_np9az10_row_5_column")]
        public string GroupEe92z69GroupNp9az10Row5GroupNp9az10Row5Column { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row/group_uo6vb74_row_column_001")]
        public string GroupEe92z69GroupUo6vb74RowGroupUo6vb74RowColumn001 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_1/group_uo6vb74_row_1_column")]
        public string GroupEe92z69GroupUo6vb74Row1GroupUo6vb74Row1Column { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_2/group_uo6vb74_row_2_column")]
        public string GroupEe92z69GroupUo6vb74Row2GroupUo6vb74Row2Column { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_3/group_uo6vb74_row_3_column")]
        public string GroupEe92z69GroupUo6vb74Row3GroupUo6vb74Row3Column { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_1/group_hl6wr53_row_1_column")]
        public string GroupGn8tz78GroupHl6wr53Row1GroupHl6wr53Row1Column { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_2/group_hl6wr53_row_2_column")]
        public string GroupGn8tz78GroupHl6wr53Row2GroupHl6wr53Row2Column { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_3/group_hl6wr53_row_3_column")]
        public string GroupGn8tz78GroupHl6wr53Row3GroupHl6wr53Row3Column { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_4/group_hl6wr53_row_4_column")]
        public string GroupGn8tz78GroupHl6wr53Row4GroupHl6wr53Row4Column { get; set; }

        [JsonProperty("group_gn8tz78/group_ht6se71_row_1/group_ht6se71_row_1_column")]
        public string GroupGn8tz78GroupHt6se71Row1GroupHt6se71Row1Column { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_1/group_ri7rs20_row_1_column")]
        public string GroupGn8tz78GroupRi7rs20Row1GroupRi7rs20Row1Column { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_2/group_ri7rs20_row_2_column")]
        public string GroupGn8tz78GroupRi7rs20Row2GroupRi7rs20Row2Column { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_3/group_ri7rs20_row_3_column")]
        public string GroupGn8tz78GroupRi7rs20Row3GroupRi7rs20Row3Column { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_1/group_ym4ue63_row_1_column")]
        public string GroupGn8tz78GroupYm4ue63Row1GroupYm4ue63Row1Column { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_2/group_ym4ue63_row_2_column")]
        public string GroupGn8tz78GroupYm4ue63Row2GroupYm4ue63Row2Column { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_3/group_ym4ue63_row_3_column")]
        public string GroupGn8tz78GroupYm4ue63Row3GroupYm4ue63Row3Column { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_1/group_zb27l63_row_1_column")]
        public string GroupGn8tz78GroupZb27l63Row1GroupZb27l63Row1Column { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_2/group_zb27l63_row_2_column")]
        public string GroupGn8tz78GroupZb27l63Row2GroupZb27l63Row2Column { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_3/group_zb27l63_row_3_column")]
        public string GroupGn8tz78GroupZb27l63Row3GroupZb27l63Row3Column { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_1/group_aw4hv76_row_1_column")]
        public string GroupTi2rf69GroupAw4hv76Row1GroupAw4hv76Row1Column { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_2/group_aw4hv76_row_2_column")]
        public string GroupTi2rf69GroupAw4hv76Row2GroupAw4hv76Row2Column { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_3/group_aw4hv76_row_3_column")]
        public string GroupTi2rf69GroupAw4hv76Row3GroupAw4hv76Row3Column { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_4/group_aw4hv76_row_4_column")]
        public string GroupTi2rf69GroupAw4hv76Row4GroupAw4hv76Row4Column { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_5/group_aw4hv76_row_5_column")]
        public string GroupTi2rf69GroupAw4hv76Row5GroupAw4hv76Row5Column { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_6/group_aw4hv76_row_6_column")]
        public string GroupTi2rf69GroupAw4hv76Row6GroupAw4hv76Row6Column { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_7/group_aw4hv76_row_7_column")]
        public string GroupTi2rf69GroupAw4hv76Row7GroupAw4hv76Row7Column { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_1/group_lj2zd13_row_1_column")]
        public string GroupZl34f75GroupLj2zd13Row1GroupLj2zd13Row1Column { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_2/group_lj2zd13_row_2_column")]
        public string GroupZl34f75GroupLj2zd13Row2GroupLj2zd13Row2Column { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_3/group_lj2zd13_row_3_column")]
        public string GroupZl34f75GroupLj2zd13Row3GroupLj2zd13Row3Column { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_4/group_lj2zd13_row_4_column")]
        public string GroupZl34f75GroupLj2zd13Row4GroupLj2zd13Row4Column { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_1/group_cf2mb67_row_1_column_2")]
        public string GroupCl6az80GroupCf2mb67Row1GroupCf2mb67Row1Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_2/group_cf2mb67_row_2_column_2")]
        public string GroupCl6az80GroupCf2mb67Row2GroupCf2mb67Row2Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_3/group_cf2mb67_row_3_column_2")]
        public string GroupCl6az80GroupCf2mb67Row3GroupCf2mb67Row3Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_1/group_im4zq41_row_1_column_2")]
        public string GroupCl6az80GroupIm4zq41Row1GroupIm4zq41Row1Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_2/group_im4zq41_row_2_column_2")]
        public string GroupCl6az80GroupIm4zq41Row2GroupIm4zq41Row2Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_3/group_im4zq41_row_3_column_2")]
        public string GroupCl6az80GroupIm4zq41Row3GroupIm4zq41Row3Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_1/group_ma06v81_row_1_column_1")]
        public string GroupCl6az80GroupMa06v81Row1GroupMa06v81Row1Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_1/group_ma06v81_row_1_column_2")]
        public string GroupCl6az80GroupMa06v81Row1GroupMa06v81Row1Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_1/group_ma06v81_row_1_column_4")]
        public string GroupCl6az80GroupMa06v81Row1GroupMa06v81Row1Column4 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_2/group_ma06v81_row_2_column_1")]
        public string GroupCl6az80GroupMa06v81Row2GroupMa06v81Row2Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_2/group_ma06v81_row_2_column_2")]
        public string GroupCl6az80GroupMa06v81Row2GroupMa06v81Row2Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_2/group_ma06v81_row_2_column_3")]
        public string GroupCl6az80GroupMa06v81Row2GroupMa06v81Row2Column3 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_2/group_ma06v81_row_2_column_4")]
        public string GroupCl6az80GroupMa06v81Row2GroupMa06v81Row2Column4 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_3/group_ma06v81_row_3_column_1")]
        public string GroupCl6az80GroupMa06v81Row3GroupMa06v81Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_3/group_ma06v81_row_3_column_2")]
        public string GroupCl6az80GroupMa06v81Row3GroupMa06v81Row3Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_3/group_ma06v81_row_3_column_4")]
        public string GroupCl6az80GroupMa06v81Row3GroupMa06v81Row3Column4 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_1/group_ut8xm76_row_1_column_2")]
        public string GroupCl6az80GroupUt8xm76Row1GroupUt8xm76Row1Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_10/group_ut8xm76_row_10_column")]
        public string GroupCl6az80GroupUt8xm76Row10GroupUt8xm76Row10Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_11/group_ut8xm76_row_11_column")]
        public string GroupCl6az80GroupUt8xm76Row11GroupUt8xm76Row11Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_12/group_ut8xm76_row_12_column")]
        public string GroupCl6az80GroupUt8xm76Row12GroupUt8xm76Row12Column { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_2/group_ut8xm76_row_2_column_2")]
        public string GroupCl6az80GroupUt8xm76Row2GroupUt8xm76Row2Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_3/group_ut8xm76_row_3_column_2")]
        public string GroupCl6az80GroupUt8xm76Row3GroupUt8xm76Row3Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_4/group_ut8xm76_row_4_column_2")]
        public string GroupCl6az80GroupUt8xm76Row4GroupUt8xm76Row4Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_5/group_ut8xm76_row_5_column_2")]
        public string GroupCl6az80GroupUt8xm76Row5GroupUt8xm76Row5Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_6/group_ut8xm76_row_6_column_2")]
        public string GroupCl6az80GroupUt8xm76Row6GroupUt8xm76Row6Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_7/group_ut8xm76_row_7_column_2")]
        public string GroupCl6az80GroupUt8xm76Row7GroupUt8xm76Row7Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_8/group_ut8xm76_row_8_column_2")]
        public string GroupCl6az80GroupUt8xm76Row8GroupUt8xm76Row8Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_9/group_ut8xm76_row_9_column_2")]
        public string GroupCl6az80GroupUt8xm76Row9GroupUt8xm76Row9Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_1/group_vx6ag31_row_1_column_2")]
        public string GroupCl6az80GroupVx6ag31Row1GroupVx6ag31Row1Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_2/group_vx6ag31_row_2_column_2")]
        public string GroupCl6az80GroupVx6ag31Row2GroupVx6ag31Row2Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_3/group_vx6ag31_row_3_column_2")]
        public string GroupCl6az80GroupVx6ag31Row3GroupVx6ag31Row3Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_4/group_vx6ag31_row_4_column_2")]
        public string GroupCl6az80GroupVx6ag31Row4GroupVx6ag31Row4Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_5/group_vx6ag31_row_5_column_2")]
        public string GroupCl6az80GroupVx6ag31Row5GroupVx6ag31Row5Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_1/group_xi6qy55_row_1_column_2")]
        public string GroupCl6az80GroupXi6qy55Row1GroupXi6qy55Row1Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_10/group_xi6qy55_row_10_column")]
        public string GroupCl6az80GroupXi6qy55Row10GroupXi6qy55Row10Column { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_2/group_xi6qy55_row_2_column_2")]
        public string GroupCl6az80GroupXi6qy55Row2GroupXi6qy55Row2Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_3/group_xi6qy55_row_3_column_2")]
        public string GroupCl6az80GroupXi6qy55Row3GroupXi6qy55Row3Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_4/group_xi6qy55_row_4_column_2")]
        public string GroupCl6az80GroupXi6qy55Row4GroupXi6qy55Row4Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_5/group_xi6qy55_row_5_column_2")]
        public string GroupCl6az80GroupXi6qy55Row5GroupXi6qy55Row5Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_6/group_xi6qy55_row_6_column_2")]
        public string GroupCl6az80GroupXi6qy55Row6GroupXi6qy55Row6Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_7/group_xi6qy55_row_7_column_2")]
        public string GroupCl6az80GroupXi6qy55Row7GroupXi6qy55Row7Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_8/group_xi6qy55_row_8_column_2")]
        public string GroupCl6az80GroupXi6qy55Row8GroupXi6qy55Row8Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_9/group_xi6qy55_row_9_column_2")]
        public string GroupCl6az80GroupXi6qy55Row9GroupXi6qy55Row9Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row_1/group_yy0wg80_row_1_column_2")]
        public string GroupCl6az80GroupYy0wg80Row1GroupYy0wg80Row1Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row_2/group_yy0wg80_row_2_column_2")]
        public string GroupCl6az80GroupYy0wg80Row2GroupYy0wg80Row2Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_1/group_hl9xq53_row_1_column_2")]
        public string GroupEe92z69GroupHl9xq53Row1GroupHl9xq53Row1Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_2/group_hl9xq53_row_2_column_2")]
        public string GroupEe92z69GroupHl9xq53Row2GroupHl9xq53Row2Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_3/group_hl9xq53_row_3_column_2")]
        public string GroupEe92z69GroupHl9xq53Row3GroupHl9xq53Row3Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_4/group_hl9xq53_row_4_column_2")]
        public string GroupEe92z69GroupHl9xq53Row4GroupHl9xq53Row4Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_5/group_hl9xq53_row_5_column_2")]
        public string GroupEe92z69GroupHl9xq53Row5GroupHl9xq53Row5Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_1/group_np9az10_row_1_column_2")]
        public string GroupEe92z69GroupNp9az10Row1GroupNp9az10Row1Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_2/group_np9az10_row_2_column_2")]
        public string GroupEe92z69GroupNp9az10Row2GroupNp9az10Row2Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_3/group_np9az10_row_3_column_2")]
        public string GroupEe92z69GroupNp9az10Row3GroupNp9az10Row3Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_4/group_np9az10_row_4_column_2")]
        public string GroupEe92z69GroupNp9az10Row4GroupNp9az10Row4Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_5/group_np9az10_row_5_column_2")]
        public string GroupEe92z69GroupNp9az10Row5GroupNp9az10Row5Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_1/group_hl6wr53_row_1_column_2")]
        public string GroupGn8tz78GroupHl6wr53Row1GroupHl6wr53Row1Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_2/group_hl6wr53_row_2_column_2")]
        public string GroupGn8tz78GroupHl6wr53Row2GroupHl6wr53Row2Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_3/group_hl6wr53_row_3_column_2")]
        public string GroupGn8tz78GroupHl6wr53Row3GroupHl6wr53Row3Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_4/group_hl6wr53_row_4_column_2")]
        public string GroupGn8tz78GroupHl6wr53Row4GroupHl6wr53Row4Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ht6se71_row_1/group_ht6se71_row_1_column_2")]
        public string GroupGn8tz78GroupHt6se71Row1GroupHt6se71Row1Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_1/group_ri7rs20_row_1_column_2")]
        public string GroupGn8tz78GroupRi7rs20Row1GroupRi7rs20Row1Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_2/group_ri7rs20_row_2_column_2")]
        public string GroupGn8tz78GroupRi7rs20Row2GroupRi7rs20Row2Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_3/group_ri7rs20_row_3_column_2")]
        public string GroupGn8tz78GroupRi7rs20Row3GroupRi7rs20Row3Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_1/group_ym4ue63_row_1_column_2")]
        public string GroupGn8tz78GroupYm4ue63Row1GroupYm4ue63Row1Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_2/group_ym4ue63_row_2_column_2")]
        public string GroupGn8tz78GroupYm4ue63Row2GroupYm4ue63Row2Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_3/group_ym4ue63_row_3_column_2")]
        public string GroupGn8tz78GroupYm4ue63Row3GroupYm4ue63Row3Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_1/group_zb27l63_row_1_column_2")]
        public string GroupGn8tz78GroupZb27l63Row1GroupZb27l63Row1Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_2/group_zb27l63_row_2_column_2")]
        public string GroupGn8tz78GroupZb27l63Row2GroupZb27l63Row2Column2 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_3/group_zb27l63_row_3_column_2")]
        public string GroupGn8tz78GroupZb27l63Row3GroupZb27l63Row3Column2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_1/group_aw4hv76_row_1_column_1")]
        public string GroupTi2rf69GroupAw4hv76Row1GroupAw4hv76Row1Column1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_1/group_aw4hv76_row_1_column_2")]
        public string GroupTi2rf69GroupAw4hv76Row1GroupAw4hv76Row1Column2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_2/group_aw4hv76_row_2_column_2")]
        public string GroupTi2rf69GroupAw4hv76Row2GroupAw4hv76Row2Column2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_3/group_aw4hv76_row_3_column_2")]
        public string GroupTi2rf69GroupAw4hv76Row3GroupAw4hv76Row3Column2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_4/group_aw4hv76_row_4_column_2")]
        public string GroupTi2rf69GroupAw4hv76Row4GroupAw4hv76Row4Column2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_5/group_aw4hv76_row_5_column_2")]
        public string GroupTi2rf69GroupAw4hv76Row5GroupAw4hv76Row5Column2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_6/group_aw4hv76_row_6_column_2")]
        public string GroupTi2rf69GroupAw4hv76Row6GroupAw4hv76Row6Column2 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_7/group_aw4hv76_row_7_column_2")]
        public string GroupTi2rf69GroupAw4hv76Row7GroupAw4hv76Row7Column2 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_1/group_lj2zd13_row_1_column_2")]
        public string GroupZl34f75GroupLj2zd13Row1GroupLj2zd13Row1Column2 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_2/group_lj2zd13_row_2_column_2")]
        public string GroupZl34f75GroupLj2zd13Row2GroupLj2zd13Row2Column2 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_3/group_lj2zd13_row_3_column_2")]
        public string GroupZl34f75GroupLj2zd13Row3GroupLj2zd13Row3Column2 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_4/group_lj2zd13_row_4_column_2")]
        public string GroupZl34f75GroupLj2zd13Row4GroupLj2zd13Row4Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_10/group_ut8xm76_row_10_column_2")]
        public string GroupCl6az80GroupUt8xm76Row10GroupUt8xm76Row10Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_11/group_ut8xm76_row_11_column_2")]
        public string GroupCl6az80GroupUt8xm76Row11GroupUt8xm76Row11Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_12/group_ut8xm76_row_12_column_2")]
        public string GroupCl6az80GroupUt8xm76Row12GroupUt8xm76Row12Column2 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_10/group_xi6qy55_row_10_column_2")]
        public string GroupCl6az80GroupXi6qy55Row10GroupXi6qy55Row10Column2 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_1/group_uo6vb74_row_1_column_001")]
        public string GroupEe92z69GroupUo6vb74Row1GroupUo6vb74Row1Column001 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_2/group_uo6vb74_row_2_column_001")]
        public string GroupEe92z69GroupUo6vb74Row2GroupUo6vb74Row2Column001 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_3/group_uo6vb74_row_3_column_001")]
        public string GroupEe92z69GroupUo6vb74Row3GroupUo6vb74Row3Column001 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row/group_im4zq41_row_column_1")]
        public string GroupCl6az80GroupIm4zq41RowGroupIm4zq41RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row/group_ma06v81_row_column_3")]
        public string GroupCl6az80GroupMa06v81RowGroupMa06v81RowColumn3 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row/group_np9az10_row_column_1")]
        public string GroupEe92z69GroupNp9az10RowGroupNp9az10RowColumn1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row/group_ri7rs20_row_column_1")]
        public string GroupGn8tz78GroupRi7rs20RowGroupRi7rs20RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_1/group_ma06v81_row_1_column_3")]
        public string GroupCl6az80GroupMa06v81Row1GroupMa06v81Row1Column3 { get; set; }

        [JsonProperty("group_cl6az80/group_ma06v81_row_3/group_ma06v81_row_3_column_3")]
        public string GroupCl6az80GroupMa06v81Row3GroupMa06v81Row3Column3 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_3/group_hl9xq53_row_3_column_1")]
        public string GroupEe92z69GroupHl9xq53Row3GroupHl9xq53Row3Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_3/group_np9az10_row_3_column_1")]
        public string GroupEe92z69GroupNp9az10Row3GroupNp9az10Row3Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_1/group_ri7rs20_row_1_column_1")]
        public string GroupGn8tz78GroupRi7rs20Row1GroupRi7rs20Row1Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_2/group_ri7rs20_row_2_column_1")]
        public string GroupGn8tz78GroupRi7rs20Row2GroupRi7rs20Row2Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ri7rs20_row_3/group_ri7rs20_row_3_column_1")]
        public string GroupGn8tz78GroupRi7rs20Row3GroupRi7rs20Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row/group_cf2mb67_row_column_1")]
        public string GroupCl6az80GroupCf2mb67RowGroupCf2mb67RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row/group_ut8xm76_row_column_1")]
        public string GroupCl6az80GroupUt8xm76RowGroupUt8xm76RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row/group_vx6ag31_row_column_1")]
        public string GroupCl6az80GroupVx6ag31RowGroupVx6ag31RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row/group_xi6qy55_row_column_1")]
        public string GroupCl6az80GroupXi6qy55RowGroupXi6qy55RowColumn1 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row/group_hl9xq53_row_column_1")]
        public string GroupEe92z69GroupHl9xq53RowGroupHl9xq53RowColumn1 { get; set; }

        [JsonProperty("group_ee92z69/group_kj8ye01_row/group_kj8ye01_row_column_1")]
        public string GroupEe92z69GroupKj8ye01RowGroupKj8ye01RowColumn1 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row/group_uo6vb74_row_column_1")]
        public string GroupEe92z69GroupUo6vb74RowGroupUo6vb74RowColumn1 { get; set; }

        [JsonProperty("group_gn8tz78/group_dd2gt20_row/group_dd2gt20_row_column_1")]
        public string GroupGn8tz78GroupDd2gt20RowGroupDd2gt20RowColumn1 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row/group_hl6wr53_row_column_1")]
        public string GroupGn8tz78GroupHl6wr53RowGroupHl6wr53RowColumn1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ht6se71_row/group_ht6se71_row_column_1")]
        public string GroupGn8tz78GroupHt6se71RowGroupHt6se71RowColumn1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row/group_ym4ue63_row_column_1")]
        public string GroupGn8tz78GroupYm4ue63RowGroupYm4ue63RowColumn1 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row/group_zb27l63_row_column_1")]
        public string GroupGn8tz78GroupZb27l63RowGroupZb27l63RowColumn1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row/group_aw4hv76_row_column_1")]
        public string GroupTi2rf69GroupAw4hv76RowGroupAw4hv76RowColumn1 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row/group_lj2zd13_row_column_1")]
        public string GroupZl34f75GroupLj2zd13RowGroupLj2zd13RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_1/group_cf2mb67_row_1_column_1")]
        public string GroupCl6az80GroupCf2mb67Row1GroupCf2mb67Row1Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_2/group_cf2mb67_row_2_column_1")]
        public string GroupCl6az80GroupCf2mb67Row2GroupCf2mb67Row2Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_1/group_ut8xm76_row_1_column_1")]
        public string GroupCl6az80GroupUt8xm76Row1GroupUt8xm76Row1Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_2/group_ut8xm76_row_2_column_1")]
        public string GroupCl6az80GroupUt8xm76Row2GroupUt8xm76Row2Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_3/group_ut8xm76_row_3_column_1")]
        public string GroupCl6az80GroupUt8xm76Row3GroupUt8xm76Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_4/group_ut8xm76_row_4_column_1")]
        public string GroupCl6az80GroupUt8xm76Row4GroupUt8xm76Row4Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_5/group_ut8xm76_row_5_column_1")]
        public string GroupCl6az80GroupUt8xm76Row5GroupUt8xm76Row5Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_6/group_ut8xm76_row_6_column_1")]
        public string GroupCl6az80GroupUt8xm76Row6GroupUt8xm76Row6Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_7/group_ut8xm76_row_7_column_1")]
        public string GroupCl6az80GroupUt8xm76Row7GroupUt8xm76Row7Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_8/group_ut8xm76_row_8_column_1")]
        public string GroupCl6az80GroupUt8xm76Row8GroupUt8xm76Row8Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_9/group_ut8xm76_row_9_column_1")]
        public string GroupCl6az80GroupUt8xm76Row9GroupUt8xm76Row9Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_1/group_vx6ag31_row_1_column_1")]
        public string GroupCl6az80GroupVx6ag31Row1GroupVx6ag31Row1Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_2/group_vx6ag31_row_2_column_1")]
        public string GroupCl6az80GroupVx6ag31Row2GroupVx6ag31Row2Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_3/group_vx6ag31_row_3_column_1")]
        public string GroupCl6az80GroupVx6ag31Row3GroupVx6ag31Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_4/group_vx6ag31_row_4_column_1")]
        public string GroupCl6az80GroupVx6ag31Row4GroupVx6ag31Row4Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_vx6ag31_row_5/group_vx6ag31_row_5_column_1")]
        public string GroupCl6az80GroupVx6ag31Row5GroupVx6ag31Row5Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_1/group_xi6qy55_row_1_column_1")]
        public string GroupCl6az80GroupXi6qy55Row1GroupXi6qy55Row1Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_2/group_xi6qy55_row_2_column_1")]
        public string GroupCl6az80GroupXi6qy55Row2GroupXi6qy55Row2Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_3/group_xi6qy55_row_3_column_1")]
        public string GroupCl6az80GroupXi6qy55Row3GroupXi6qy55Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_4/group_xi6qy55_row_4_column_1")]
        public string GroupCl6az80GroupXi6qy55Row4GroupXi6qy55Row4Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_6/group_xi6qy55_row_6_column_1")]
        public string GroupCl6az80GroupXi6qy55Row6GroupXi6qy55Row6Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_7/group_xi6qy55_row_7_column_1")]
        public string GroupCl6az80GroupXi6qy55Row7GroupXi6qy55Row7Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_8/group_xi6qy55_row_8_column_1")]
        public string GroupCl6az80GroupXi6qy55Row8GroupXi6qy55Row8Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_9/group_xi6qy55_row_9_column_1")]
        public string GroupCl6az80GroupXi6qy55Row9GroupXi6qy55Row9Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_1/group_hl9xq53_row_1_column_1")]
        public string GroupEe92z69GroupHl9xq53Row1GroupHl9xq53Row1Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_2/group_hl9xq53_row_2_column_1")]
        public string GroupEe92z69GroupHl9xq53Row2GroupHl9xq53Row2Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_4/group_hl9xq53_row_4_column_1")]
        public string GroupEe92z69GroupHl9xq53Row4GroupHl9xq53Row4Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_hl9xq53_row_5/group_hl9xq53_row_5_column_1")]
        public string GroupEe92z69GroupHl9xq53Row5GroupHl9xq53Row5Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_1/group_np9az10_row_1_column_1")]
        public string GroupEe92z69GroupNp9az10Row1GroupNp9az10Row1Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_2/group_np9az10_row_2_column_1")]
        public string GroupEe92z69GroupNp9az10Row2GroupNp9az10Row2Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_4/group_np9az10_row_4_column_1")]
        public string GroupEe92z69GroupNp9az10Row4GroupNp9az10Row4Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_np9az10_row_5/group_np9az10_row_5_column_1")]
        public string GroupEe92z69GroupNp9az10Row5GroupNp9az10Row5Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_1/group_uo6vb74_row_1_column_1")]
        public string GroupEe92z69GroupUo6vb74Row1GroupUo6vb74Row1Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_2/group_uo6vb74_row_2_column_1")]
        public string GroupEe92z69GroupUo6vb74Row2GroupUo6vb74Row2Column1 { get; set; }

        [JsonProperty("group_ee92z69/group_uo6vb74_row_3/group_uo6vb74_row_3_column_1")]
        public string GroupEe92z69GroupUo6vb74Row3GroupUo6vb74Row3Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_1/group_hl6wr53_row_1_column_1")]
        public string GroupGn8tz78GroupHl6wr53Row1GroupHl6wr53Row1Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_2/group_hl6wr53_row_2_column_1")]
        public string GroupGn8tz78GroupHl6wr53Row2GroupHl6wr53Row2Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_3/group_hl6wr53_row_3_column_1")]
        public string GroupGn8tz78GroupHl6wr53Row3GroupHl6wr53Row3Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_hl6wr53_row_4/group_hl6wr53_row_4_column_1")]
        public string GroupGn8tz78GroupHl6wr53Row4GroupHl6wr53Row4Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ht6se71_row_1/group_ht6se71_row_1_column_1")]
        public string GroupGn8tz78GroupHt6se71Row1GroupHt6se71Row1Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_2/group_zb27l63_row_2_column_1")]
        public string GroupGn8tz78GroupZb27l63Row2GroupZb27l63Row2Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_3/group_zb27l63_row_3_column_1")]
        public string GroupGn8tz78GroupZb27l63Row3GroupZb27l63Row3Column1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_3/group_aw4hv76_row_3_column_1")]
        public string GroupTi2rf69GroupAw4hv76Row3GroupAw4hv76Row3Column1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_4/group_aw4hv76_row_4_column_1")]
        public string GroupTi2rf69GroupAw4hv76Row4GroupAw4hv76Row4Column1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_6/group_aw4hv76_row_6_column_1")]
        public string GroupTi2rf69GroupAw4hv76Row6GroupAw4hv76Row6Column1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_7/group_aw4hv76_row_7_column_1")]
        public string GroupTi2rf69GroupAw4hv76Row7GroupAw4hv76Row7Column1 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_1/group_lj2zd13_row_1_column_1")]
        public string GroupZl34f75GroupLj2zd13Row1GroupLj2zd13Row1Column1 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_3/group_lj2zd13_row_3_column_1")]
        public string GroupZl34f75GroupLj2zd13Row3GroupLj2zd13Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_10/group_ut8xm76_row_10_column_1")]
        public string GroupCl6az80GroupUt8xm76Row10GroupUt8xm76Row10Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_11/group_ut8xm76_row_11_column_1")]
        public string GroupCl6az80GroupUt8xm76Row11GroupUt8xm76Row11Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_ut8xm76_row_12/group_ut8xm76_row_12_column_1")]
        public string GroupCl6az80GroupUt8xm76Row12GroupUt8xm76Row12Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_10/group_xi6qy55_row_10_column_1")]
        public string GroupCl6az80GroupXi6qy55Row10GroupXi6qy55Row10Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row/group_yy0wg80_row_column_1")]
        public string GroupCl6az80GroupYy0wg80RowGroupYy0wg80RowColumn1 { get; set; }

        [JsonProperty("group_cl6az80/group_cf2mb67_row_3/group_cf2mb67_row_3_column_1")]
        public string GroupCl6az80GroupCf2mb67Row3GroupCf2mb67Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_1/group_im4zq41_row_1_column_1")]
        public string GroupCl6az80GroupIm4zq41Row1GroupIm4zq41Row1Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_2/group_im4zq41_row_2_column_1")]
        public string GroupCl6az80GroupIm4zq41Row2GroupIm4zq41Row2Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_im4zq41_row_3/group_im4zq41_row_3_column_1")]
        public string GroupCl6az80GroupIm4zq41Row3GroupIm4zq41Row3Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_xi6qy55_row_5/group_xi6qy55_row_5_column_1")]
        public string GroupCl6az80GroupXi6qy55Row5GroupXi6qy55Row5Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row_1/group_yy0wg80_row_1_column_1")]
        public string GroupCl6az80GroupYy0wg80Row1GroupYy0wg80Row1Column1 { get; set; }

        [JsonProperty("group_cl6az80/group_yy0wg80_row_2/group_yy0wg80_row_2_column_1")]
        public string GroupCl6az80GroupYy0wg80Row2GroupYy0wg80Row2Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_1/group_ym4ue63_row_1_column_1")]
        public string GroupGn8tz78GroupYm4ue63Row1GroupYm4ue63Row1Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_2/group_ym4ue63_row_2_column_1")]
        public string GroupGn8tz78GroupYm4ue63Row2GroupYm4ue63Row2Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_ym4ue63_row_3/group_ym4ue63_row_3_column_1")]
        public string GroupGn8tz78GroupYm4ue63Row3GroupYm4ue63Row3Column1 { get; set; }

        [JsonProperty("group_gn8tz78/group_zb27l63_row_1/group_zb27l63_row_1_column_1")]
        public string GroupGn8tz78GroupZb27l63Row1GroupZb27l63Row1Column1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_2/group_aw4hv76_row_2_column_1")]
        public string GroupTi2rf69GroupAw4hv76Row2GroupAw4hv76Row2Column1 { get; set; }

        [JsonProperty("group_ti2rf69/group_aw4hv76_row_5/group_aw4hv76_row_5_column_1")]
        public string GroupTi2rf69GroupAw4hv76Row5GroupAw4hv76Row5Column1 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_2/group_lj2zd13_row_2_column_1")]
        public string GroupZl34f75GroupLj2zd13Row2GroupLj2zd13Row2Column1 { get; set; }

        [JsonProperty("group_zl34f75/group_lj2zd13_row_4/group_lj2zd13_row_4_column_1")]
        public string GroupZl34f75GroupLj2zd13Row4GroupLj2zd13Row4Column1 { get; set; }
    }
}