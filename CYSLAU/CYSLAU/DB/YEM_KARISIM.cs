//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYSLAU.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class YEM_KARISIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YEM_KARISIM()
        {
            this.HAYVAN_YEM_KARISIM_YEM_TURU = new HashSet<HAYVAN_YEM_KARISIM_YEM_TURU>();
            this.YEM_KARISIM_YEM_TURU = new HashSet<YEM_KARISIM_YEM_TURU>();
        }

        public override string ToString()
        {
            return ACIKLAMA;
        }
        public int KARISIM_SIRANO { get; set; }
        public string ACIKLAMA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HAYVAN_YEM_KARISIM_YEM_TURU> HAYVAN_YEM_KARISIM_YEM_TURU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YEM_KARISIM_YEM_TURU> YEM_KARISIM_YEM_TURU { get; set; }
    }
}
