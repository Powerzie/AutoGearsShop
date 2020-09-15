using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoGearsShop.Models
{
    public class UserVM
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "RoleName")]
        [Required(ErrorMessage = "Missing User Name")]
        public string UserName { get; set; }

    }
}
