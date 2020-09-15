using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGearsShop.Models
{
    public class UserRole
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "RoleName")]
        [Required(ErrorMessage = "Missing Role Name")]
        public string RoleName { get; set; }
    }
}
