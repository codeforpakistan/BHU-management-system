using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class Gynae_PhysicalExamination
    {
        public int GynaePhysicalExamId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        [Required]
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Temperature { get; set; }
        public Nullable<decimal> Pulse { get; set; }
        public Nullable<decimal> BP { get; set; }
        public string Thyroid { get; set; }
        public string Size { get; set; }
        public bool HeartMurmur { get; set; }
        public string HeartRate { get; set; }
        public string HeartRythm { get; set; }
        public string Abdomen { get; set; }
        public bool AbdomenBowelSound { get; set; }
        public string VaginalExamination { get; set; }
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
        public string SpeculumExam { get; set; }
        public string CarvixAppearance { get; set; }
        public string MotionTenderness { get; set; }
        public string Uterus { get; set; }
        public string UterusNl { get; set; }
        public string AdnexaLeft { get; set; }
        public string AdnexaRight { get; set; }
        public string AdnexaDescription { get; set; }
        public string lungscondition { get; set; }
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