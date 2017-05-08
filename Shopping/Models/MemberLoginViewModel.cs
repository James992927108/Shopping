using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class MemberLoginViewModel
    {
        [DisplayName("Member Account:")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Please enter a valid email address")]
        [Required(ErrorMessage = "Please key {0}")]
        public string email { get; set; }

        [DisplayName("Member Password:")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please key {0}")]
        public string password { get; set; }
    }
}