using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public  class PreNatal_LabTest
    {
        
        public int TestId { get; set; }
        [Display(Name = "Patient Name")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        public string VisitNo { get; set; }
        [Required(ErrorMessage = "Select checkup type")]
        public string CheckupOf { get; set; }
        public string CurrentEgaWeek { get; set; }
        public string Hgb { get; set; }
        public string BloodGroup { get; set; }
        public bool HepB { get; set; }
        public string Protein { get; set; }
        public string Glucose { get; set; }
        public string BloodSugar { get; set; }
        public string WBC { get; set; }
        public string GramStain { get; set; }
        public string Keytone { get; set; }
        public string Blood { get; set; }
        public bool Nitrite { get; set; }
        public string SpecificGravity { get; set; }
        public string PrenatalUltrasound { get; set; }
        public bool RecordExist { get; set; }
    }
}