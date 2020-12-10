using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MaternityCareSystem.Models.ProcModels
{
    public class RolesViewModel
    {
        public string Id { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public bool IsLocked { get; set; }

    }
}