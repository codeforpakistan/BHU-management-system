using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class GynaeForm
    {
        public int GynaeFormId { get; set; }
        [Display(Name = "Patient Name")]
        [Required(ErrorMessage ="Select Patient")]
        public int? PatientId { get; set; }
        public string PatientName { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> LastMenstrualDate { get; set; }
        [Required(ErrorMessage ="Enter History")]
        public string History { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> LastMenstrualBegin { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> LastMenstrualEnd { get; set; }
        public bool NumberOfDaysBleeding { get; set; }
        public Nullable<int> Dayss { get; set; }
        public bool BleedingCondition { get; set; }
        public bool Pain { get; set; }
        public string PainNotes { get; set; }
        public string CycleHistory { get; set; }
        public string Para { get; set; }
        public string Gravida { get; set; }
        public Nullable<int> Abortions { get; set; }
        public string LastBabyBorn { get; set; }
        public bool Infertility { get; set; }
        public Nullable<decimal> MarriedYears { get; set; }
        public string Husband { get; set; }
        public string HistoryAndTestsWife { get; set; }
        public string OtherMedicalHistory { get; set; }
        public string CurrentMedication { get; set; }
        public bool ComplaintPain { get; set; }
        public bool ComplaintBleeding { get; set; }
        public bool ComplaintDischarge { get; set; }
        public bool ComplaintUrineBurning { get; set; }
        public bool ComplaintSeizures { get; set; }
        public bool ComplaintFits { get; set; }
    }
}