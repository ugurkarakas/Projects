//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MarketSafe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MarketSafe()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int MarketSafeID { get; set; }
        public Nullable<int> TotalMoney { get; set; }
        public Nullable<int> GovernanceID { get; set; }
        public Nullable<int> StaffID { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual Product Product { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Governance Governance { get; set; }
    }
}
