using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoginWeb.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string userName { get; set; }
        [Required]
        public string passWord { get; set; }
    }
}