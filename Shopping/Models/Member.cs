using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    [DisplayName("會員信息")]
    [DisplayColumn("Name")]
    public class Member
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("會員帳號")]
        [Required(ErrorMessage = "請輸入Email帳號")]
        [MaxLength(250, ErrorMessage = "Email長度不超過250")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("會員密碼")]
        [Required(ErrorMessage = "請輸入密碼")]
        [MaxLength(40, ErrorMessage = "密碼長度不超過40")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("中文姓名")]
        [Required(ErrorMessage = "請輸入中文姓名")]
        [MaxLength(5, ErrorMessage = "中文姓名長度不超過5")]
        public string Name { get; set; }

        [DisplayName("網路匿名")]
        [Required(ErrorMessage = "請輸入網路匿名")]
        [MaxLength(10, ErrorMessage = "網路匿名長度不超過10")]
        public string Nickname { get; set; }

        [DisplayName("會員註冊時間")]
        public DateTime RegisterOn { get; set; }

        [DisplayName("會員請用認證碼")]
        [MaxLength(36)]
        [Description("AuthCode = null 代表已通過")]
        public string AuthCode { get; set; }
    }
}