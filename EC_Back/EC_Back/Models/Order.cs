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

    //<--訂單內容-->
    public partial class Order
    {
        [Display(Name = "訂單ID")]
        public int Id { get; set; }

        [Display(Name = "買家")]
        public string Buyer { get; set; }

        [Display(Name = "訂單總價格")]
        public int Price { get; set; }

        [Display(Name = "訂單內容")]
        public string Content { get; set; }

        [Display(Name = "收件人地址")]
        public string ReceiverAddress { get; set; }

        [Display(Name = "是否出貨")]
        public string State { get; set; }
    }
}
