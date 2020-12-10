using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PreNatal_Medication
    {
      
        public int PreNatalMedicationId { get; set; }
        [Display(Name = "Patient Name")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        public string VisitNo { get; set; }
        [Required(ErrorMessage ="Select checkup type")]
        public string CheckupOf { get; set; }
        public bool PreNatalVitamins { get; set; }
        public bool TT { get; set; }
        public bool Calcium { get; set; }
        public bool HepBVaccine { get; set; }
        public bool ReviewDangerSigns { get; set; }
        public string Advice { get; set; }

        public bool RecordExist { get; set; }
    }
}