//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Damacanawithdb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class purchase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public purchase()
        {
            this.product = new HashSet<product>();
        }
    
        public int id { get; set; }
        public int userId { get; set; }
        public System.DateTime createdon { get; set; }
        public decimal totalprice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> product { get; set; }
        public virtual user user { get; set; }
    }
}