using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    public class OrderHeader
    {

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