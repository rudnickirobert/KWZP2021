//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2021
{
    using System;
    using System.Collections.Generic;
    
    public partial class DP_Produkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DP_Produkt()
        {
            this.DM_Szczegoly_wydania_produktu = new HashSet<DM_Szczegoly_wydania_produktu>();
            this.DM_Szczegoly_magazynu_gotowych_produktow = new HashSet<DM_Szczegoly_magazynu_gotowych_produktow>();
        }
    
        public int Id_produkt { get; set; }
        public string nazwa_produktu { get; set; }
        public string uwagi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Szczegoly_wydania_produktu> DM_Szczegoly_wydania_produktu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Szczegoly_magazynu_gotowych_produktow> DM_Szczegoly_magazynu_gotowych_produktow { get; set; }
    }
}