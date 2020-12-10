using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Areas.PN.DataModels
{
    public class Specialization
    {
        public int SpecializationId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}