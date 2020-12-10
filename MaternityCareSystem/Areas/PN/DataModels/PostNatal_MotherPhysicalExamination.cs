using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PostNatal_MotherPhysicalExamination
    {
        public int PostNatalMotherPhysicalExamId { get; set; }
        [Required(ErrorMessage ="Select Patient")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        public Nullable<System.DateTime> InfantDOB { get; set; }
        public bool DeliveryHospital { get; set; }
        public bool DeliveryMaternityHome { get; set; }
        public bool DeliveryHome { get; set; }
        public string DeliveryCondition { get; set; }
        public string DeliveryTerm { get; set; }
        public bool SkilledBirthAttendant { get; set; }
        public bool Episiotomy { get; set; }
        public string InfantCondition { get; set; }
        [Required]
        public string Notes { get; set; }
        public bool Bleeding { get; set; }
        public bool Discharge { get; set; }
        public string DischargeType { get; set; }
        public bool UrinationPain { get; set; }
        public bool UrinationDifficulty { get; set; }
        public string UrinationDifficultyType { get; set; }
        public bool Fever { get; set; }
        public bool Pain { get; set; }
        public string PainAbdomen { get; set; }
        public bool Appetite { get; set; }
        public string OtherConcerns { get; set; }
        public bool TakePrenatalVitamins { get; set; }
        public string OtherMedication { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Temperature { get; set; }
        public Nullable<decimal> Pulse { get; set; }
        public Nullable<decimal> BP { get; set; }
        public string Heent { get; set; }
        public bool HeartMurmur { get; set; }
        public string HeartRate { get; set; }
        public string HeartRythm { get; set; }
        public string Abdomen { get; set; }
        public bool AbdomenBowelSound { get; set; }
        public string FundalHeight { get; set; }
        public string Tender { get; set; }
        public string Mass { get; set; }
        public string MassQuality { get; set; }
        public bool BreastLeftNormal { get; set; }
        public bool BreastLeftAbnormal { get; set; }
        public bool BreastLeftMass { get; set; }
        public bool BreastLeftErythema { get; set; }
        public bool BreastLeftTender { get; set; }
        public bool BreastLeftDischargeMilk { get; set; }
        public bool BreastLeftPus { get; set; }
        public bool BreastLeftOther { get; set; }
        public bool BreastRightNormal { get; set; }
        public bool BreastRightAbnormal { get; set; }
        public bool BreastRightMass { get; set; }
        public bool BreastRightErythema { get; set; }
        public bool BreastRightTender { get; set; }
        public bool BreastRightDischargeMilk { get; set; }
        public bool BreastRightPus { get; set; }
        public bool BreastRightOther { get; set; }
        public bool CsectionIncisionWellHealed { get; set; }
        public bool CsectionIncisionNotwellhealed { get; set; }
        public bool CsectionIncisionOpening { get; set; }
        public string WoundDischarge { get; set; }
        public bool VagExamNormal { get; set; }
        public bool VagExamBloodyDischarge { get; set; }
        public bool VagExamNoDischarge { get; set; }
        public bool VagExamTearHealing { get; set; }
        public bool VagExamNoHealing { get; set; }
        public bool VagExamSwollen { get; set; }
        public bool VagExamTender { get; set; }
        public bool VagExamNoTender { get; set; }
        public string LungsCondition { get; set; }
        public bool LungLeftWheezes { get; set; }
        public bool LungLeftRhonchi { get; set; }
        public bool LungLeftRales { get; set; }
        public bool LungLeftPoorAirEntry { get; set; }
        public bool LungLeftOther { get; set; }
        public bool LungRightWheezes { get; set; }
        public bool LungRightRhonchi { get; set; }
        public bool LungRightRales { get; set; }
        public bool LungRightPoorAirEntry { get; set; }
        public bool LungRightOther { get; set; }
    }
}