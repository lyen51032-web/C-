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
    
    public partial class z_bas_goods_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public z_bas_goods_type()
        {
            this.z_bas_goods = new HashSet<z_bas_goods>();
        }
    
        public int rowid { get; set; }
        public string mno { get; set; }
        public string mname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<z_bas_goods> z_bas_goods { get; set; }
    }
}