//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EC_Back.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    //<--商品內容-->
    public partial class Commodity
    {
        [Display(Name = "商品ID")]
        [Required]
        public int Id { get; set; }

        [Display(Name = "商品名稱")]
        [Required(ErrorMessage = "請輸入正確商品名稱")]
        public string Name { get; set; }

        [Display(Name = "商品說明")]
        [Required(ErrorMessage = "請輸入正確商品說明")]
        public string Help { get; set; }

        [Display(Name = "商品價格")]
        [Required(ErrorMessage = "請輸入正確價格")]
        public int Price { get; set; }

        [Display(Name = "商品庫存")]
        [Required(ErrorMessage = "請輸入正確庫存")]
        public int Inventory { get; set; }

        [Display(Name = "賣家")]
        [Required]
        public string Owner { get; set; }
    }
}
