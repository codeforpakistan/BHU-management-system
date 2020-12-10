using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public  class DoctorInfo
    {
        public int DoctorId { get; set; }
        [Required]
        public string DoctorName { get; set; }
        public string Phone { get; set; }
        public bool IsAvailable { get; set; }
        public string Address { get; set; }
        public int? SpecializationId { get; set; }
        public string Name { get; set; }

    }
}