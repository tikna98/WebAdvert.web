using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel
    {
        [Required]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(6,ErrorMessage ="Password must be of 6 chars")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confrim Password")]
        [Compare("Password", ErrorMessage = "Password must be of 6 chars")]
        public string ConfirmPassword { get; set; }
    }
}
