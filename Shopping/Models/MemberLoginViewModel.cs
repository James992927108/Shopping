﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class MemberLoginViewModel
    {
        [DisplayName("會員帳號")]
        [DataType(DataType.EmailAddress,ErrorMessage = "請輸入你的email地址")]
        [Required(ErrorMessage = "請輸入{0}")]
        public string email { get; set; }

        [DisplayName("會員密碼")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "請輸入{0}")]
        public string password { get; set; }
    }
}