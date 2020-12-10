using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class PreNatal_Step2
    {
        public int PreNatalStep2Id { get; set; }
        [Display(Name = "Patient Name")]
        public Nullable<int> PatientId { get; set; }
        public string PatientName { get; set; }
       
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}")]
        public Nullable<System.DateTime> DateOfDelivery { get; set; }

        public bool CompBleeding { get; set; }
        public bool CompBP { get; set; }
        public bool CompStillBirth { get; set; }
        public bool CompHeavyBleeding { get; set; }
        public bool CompKidneyProblem { get; set; }
        public bool CompAnemia { get; set; }
        public bool CompCSection { get; set; }
        public bool CompEclampsia { get; set; }
        public bool CompFever { get; set; }
        public bool CompForcepsVaccum { get; set; }
        public bool CompPreEcplampsia { get; set; }
        public bool CompTwins { get; set; }
        public bool CompTear { get; set; }
        public bool CompSugar { get; set; }
        public bool CompTetanusImmunization { get; set; }
        public bool homeDelivery { get; set; }
        public bool MaternityHomeDelivery { get; set; }
        public bool HospitalDelivery { get; set; }
        public string Notes { get; set; }
    }
}