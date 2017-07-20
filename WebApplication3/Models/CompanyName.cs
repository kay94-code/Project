//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyName()
        {
            this.Associations = new HashSet<Association>();
            this.Investments = new HashSet<Investment>();
            this.Subsidiaries = new HashSet<Subsidiary>();
        }
    
        public string CompanyID { get; set; }
        public string ExchangeCode { get; set; }
        public string CompanyName1 { get; set; }
        public string ShortCode { get; set; }
        public string CountryID { get; set; }
        public string BusinessSectorID { get; set; }
        public string CompanyTypeID { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Association> Associations { get; set; }
        public virtual Exchange Exchange { get; set; }
        public virtual CompanyType CompanyType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Investment> Investments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subsidiary> Subsidiaries { get; set; }
    }
}
