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
    
    public partial class DM_Magazyn_gotowych_produktow
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DM_Magazyn_gotowych_produktow()
        {
            this.DM_Szczegoly_magazynu_gotowych_produktow = new HashSet<DM_Szczegoly_magazynu_gotowych_produktow>();
            this.DM_Wydanie_produktow = new HashSet<DM_Wydanie_produktow>();
        }
    
        public int Id_magazynu_gotowych_produktow { get; set; }
        public int Id_zamowienie { get; set; }
        public System.DateTime data_i_godzina_przyjecia { get; set; }
        public string uwagi { get; set; }
    
        public virtual DZ_Zamowienie_klienta DZ_Zamowienie_klienta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Szczegoly_magazynu_gotowych_produktow> DM_Szczegoly_magazynu_gotowych_produktow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_produktow> DM_Wydanie_produktow { get; set; }
    }
}
