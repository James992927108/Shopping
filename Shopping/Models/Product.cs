using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models
{
    [DisplayName("商品信息")]
    [DisplayColumn("Name")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("商品類別")]
        [Required]
        public ProductCategory ProductCategory { get; set; }

        [DisplayName("商品名稱")]
        [Required(ErrorMessage = "請輸入商品名稱")]
        [MaxLength(60, ErrorMessage = "商品名稱不可超過60個字")]
        public string Name { get; set; }

        [DisplayName("商品簡介")]
        [Required(ErrorMessage = "請輸入商品簡介")]
        [MaxLength(250, ErrorMessage = "商品簡介請勿輸入超過250個字")]
        public string Description { get; set; }

        [DisplayName("商品顏色")]
        [Required(ErrorMessage = "請選擇商品顏色")]
        public ConsoleColor Color { get; set; }

        [DisplayName("商品售價")]
        [Required(ErrorMessage = "請輸入商品售價")]
        [Range(99,10000,ErrorMessage="商品價格必取在99~10000之間")]
        public int price { get; set; }

        [DisplayName("上架時間")]
        [Description("若無上架時間，則此商品已下架")]
        public DateTime? publishOn { get; set; }
    }
}