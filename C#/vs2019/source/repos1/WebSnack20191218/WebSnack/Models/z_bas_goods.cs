//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSnack.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class z_bas_goods
    {
        public int rowid { get; set; }
        public string mno { get; set; }
        public string mname { get; set; }
        public Nullable<int> mtype { get; set; }
        public Nullable<int> mspec { get; set; }
        public Nullable<System.DateTime> mdate { get; set; }
        public string mimg { get; set; }
        public Nullable<decimal> qty_stock { get; set; }
        public Nullable<decimal> price_sale { get; set; }
        public Nullable<decimal> price_discount { get; set; }
        public Nullable<decimal> price_cost { get; set; }
        public string description { get; set; }
        public string remark { get; set; }
    
        public virtual z_bas_goods_type z_bas_goods_type { get; set; }
    }
}
