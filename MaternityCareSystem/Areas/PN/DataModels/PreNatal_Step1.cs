using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PreNatal_Step1
    {
        public int PreNatalStep1Id { get; set; }
        [Display(Name = "Patient Name")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> LastMestrualDate { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> EDD { get; set; }
        public string Para { get; set; }
        public string Gravida { get; set; }
        public Nullable<int> Abortions { get; set; }
        public string LastBabyBorn { get; set; }
        public string EGA { get; set; }

    
    }
}