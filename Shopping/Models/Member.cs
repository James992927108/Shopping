using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public DateTime RegisterOn { get; set; }
        public string AuthCode { get; set; }
    }
}