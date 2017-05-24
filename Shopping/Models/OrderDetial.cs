using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    [DisplayName("訂單明細")]
    [DisplayColumn("Name")]
    public class OrderDetial
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("訂單主文件")]
        [Required]
        public OrderHeader OrderHeader { get; set; }

        [DisplayName("訂購商品")]
        [Required]
        public Product Product { get; set; }

        [DisplayName("商品售價")]
        [Required(ErrorMessage = "請輸入商品價格")]
        [Range(99,10000, ErrorMessage = "商品價格介於99~10000之間")]
        [Description("商品價格可能異動")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [DisplayName("選購數量")]
        [Required]
        public int Amount { get; set; }
    }
}