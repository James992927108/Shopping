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

        [DisplayName("訂購會員")]
        [Required]
        public Member Member { get; set; }

        [DisplayName("收件人姓名")]
        [Required(ErrorMessage = "請輸入收件人姓名")]
        [MaxLength(40, ErrorMessage = "請輸入收件人姓名40")]
        [Description("訂購的人並不一定是收到商品的人")]
        public string ContactName { get; set; }

        [DisplayName("聯絡電話")]
        [Required(ErrorMessage = "請輸入你的電話")]
        [MaxLength(25, ErrorMessage = "電話長度不可以超過10")]
        [DataType(DataType.PhoneNumber)]
        public string ContactPhoneNo { get; set; }

        [DisplayName("寄送位置")]
        [Required(ErrorMessage = "請輸入商品寄送地址")]
        public string ContactAddress { get; set; }

        [DisplayName("訂單金額")]
        [Required]
        [DataType(DataType.Currency)]
        [Description("價格隨寄送方式變動")]
        public int TotalPrice { get; set; }

        [DisplayName("訂單備註")]
        [DataType(DataType.MultilineText)]
        public string Memo { get; set; }

        [DisplayName("訂單時間")]
        public DateTime BuyOn { get; set; }

        public string DisplayName
        {
            get { return this.Member.Name + "於" + this.BuyOn + "訂購的商品"; }
        }
    }
}