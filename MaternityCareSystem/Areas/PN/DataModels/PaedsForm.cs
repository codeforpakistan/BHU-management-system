using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PaedsForm
    {
        public int PaedsFormId { get; set; }
        [Required(ErrorMessage="Select Patient")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        [Required(ErrorMessage ="Enter Chief Complaint")]
        public string ChiefComplaint { get; set; }
        public string IllnessHistory { get; set; }
        public string CurrentMedication { get; set; }
        public bool BCG { get; set; }
        public Nullable<System.DateTime> PolioDate1 { get; set; }
        public Nullable<System.DateTime> PolioDate2 { get; set; }
        public Nullable<System.DateTime> PolioDate3 { get; set; }
        public Nullable<System.DateTime> PolioDate4 { get; set; }
        public Nullable<System.DateTime> DPTDate1 { get; set; }
        public Nullable<System.DateTime> DPTDate2 { get; set; }
        public Nullable<System.DateTime> DPTDate3 { get; set; }
        public Nullable<System.DateTime> DPTDate4 { get; set; }
        public Nullable<System.DateTime> HepBDate1 { get; set; }
        public Nullable<System.DateTime> HepBDate2 { get; set; }
        public Nullable<System.DateTime> HepBDate3 { get; set; }
        public Nullable<System.DateTime> HepADate1 { get; set; }
        public Nullable<System.DateTime> HepADate2 { get; set; }
        public Nullable<System.DateTime> HepADate3 { get; set; }
        public string Other { get; set; }
        public Nullable<System.DateTime> OtherDate { get; set; }
    }
}