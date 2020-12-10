using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PreNatal_PhysicalExamination
    {
        public int PreNatalPhysicalExamId { get; set; }
        [Required(ErrorMessage ="Select Patient")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> PreNatalVisitId { get; set; }
        [Required(ErrorMessage = "Select Visit")]
        public string VisitNo { get; set; }
        public string CurrentEGAWeek { get; set; }
        [Required(ErrorMessage = "Enter Weight")]
        public Nullable<decimal> Weight { get; set; }
        [Required(ErrorMessage ="Enter Height")]
        public Nullable<decimal> Height { get; set; }
        [Required(ErrorMessage = "Enter Temperature")]
        public Nullable<decimal> Temperature { get; set; }
        [Required(ErrorMessage = "Enter Pulse")]
        public Nullable<decimal> Pulse { get; set; }
        [Required(ErrorMessage = "Enter BP")]
        public Nullable<decimal> BP { get; set; }
        public string GeneralAppearance { get; set; }
        public bool HeartMurmur { get; set; }
        public bool HeartRate { get; set; }
        public string Lungs { get; set; }
        public string Abdomen { get; set; }
        public bool AbdomenBowelSounds { get; set; }
        public Nullable<decimal> FundalHeight { get; set; }
        public bool AppropriateForGestationalAge { get; set; }
        public bool SmallForGestationalAge { get; set; }
        public bool LargeForGestationalAge { get; set; }
        public bool VagExamNone { get; set; }
        public bool VagExamMass { get; set; }
        public bool VagExamTender { get; set; }
        public bool VagDischargeYellow { get; set; }
        public bool VagDischargeWhite { get; set; }
        public bool VagDischargeGreen { get; set; }
        public bool VagDischargeBleeding { get; set; }
        public bool VagDischargeNone { get; set; }
        public bool ComplaintPain { get; set; }
        public bool ComplaintBleeding { get; set; }
        public bool ComplaintDischarge { get; set; }
        public bool ComplaintUrineBurning { get; set; }
        public bool ComplaintSeizures { get; set; }
        public bool ComplaintFits { get; set; }
        public bool ComplaintFever { get; set; }
        public string PreNataVisit1Notes { get; set; }
        public bool BirthingKit { get; set; }
        public string FetalPosition { get; set; }
        public bool FetalMovement { get; set; }
        public string Edema { get; set; }
        public bool RecordExist { get; set; }
    }
}