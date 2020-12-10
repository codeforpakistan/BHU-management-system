using MaternityCareSystem.Areas.PN.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Models.ProcModels
{
    public class PrenatalPE
    {
        public List<PreNatal_PhysicalExamination> preNatal_PhysicalExaminations { get; set; }
        public List<PreNatal_LabTest> preNatal_LabTests { get; set; }

        public List<PreNatal_Medication>  preNatal_Medications { get; set; }
        public List<PreNatal_Counsel>  preNatal_Counsels { get; set; }
    }
}