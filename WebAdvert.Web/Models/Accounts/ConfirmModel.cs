﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class ConfirmModel
    {

        [Display(Name ="Email")]
        [EmailAddress]
        [Required(ErrorMessage = "This is required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="This is required")]
        public string  Code { get; set; }

    }
}
