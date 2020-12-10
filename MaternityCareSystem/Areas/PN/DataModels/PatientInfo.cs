using MaternityCareSystem.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Webdiyer.WebControls.Mvc;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PatientInfo
    {
        public int PatientId { get; set; }
        public Int64 MrNumber { get; set; }
        [Required]
        [Display(Name ="Patient Name")]
        public string PatientName { get; set; }

        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> DOB { get; set; }
        [Display(Name = "Patient Age")]
        public string PatientAge { get; set; }
        public string GuardianRelation { get; set; }
        public string Gender { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }

    }

    public class PatientInfoPaging
    {
        public List<PatientInfo> Patients { get; set; }
        public int TotalRecords { get; set; }
        public int PageSize { get; set; }
        public int PageNo { get; set; }
    }
}