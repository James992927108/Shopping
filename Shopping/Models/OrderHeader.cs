using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    [DisplayName("訂單主文件")]
    [DisplayColumn("DisplayName")]
    public class OrderHeader
    {
        [Key]
        public int Id { get; set; }
        public Member Member { get; set; }
        public string ContactName { get; set; }
        public string ContactPhoneNo { get; set; }
        public string ContactAddress { get; set; }
        public int TotalPrice { get; set; }
        public string Memo { get; set; }
        public DateTime BuyOn { get; set; }
        public string DisplayName
        {
            get { return this.Member.Name + "於" + this.BuyOn + "訂購的商品"; }
        }
    }
}