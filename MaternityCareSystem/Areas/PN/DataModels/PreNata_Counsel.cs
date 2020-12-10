using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PreNatal_Counsel
    {
       
        public int PreNatalcounselId { get; set; }
        [Display(Name ="Patient Name")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        public string VisitNo { get; set; }
        public string CheckupOf { get; set; }
        public bool DangerSigns { get; set; }
        public bool Hgb { get; set; }
        public bool Protein { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> NextVisitDate { get; set; }
        public string NextVisitNotes { get; set; }
        public bool RecordExist { get; set; }
    }
}