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
    
    public partial class DZ_Plik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DZ_Plik()
        {
            this.DP_Wydruk = new HashSet<DP_Wydruk>();
            this.DZ_Szczegoly_zamowienia_klienta = new HashSet<DZ_Szczegoly_zamowienia_klienta>();
            this.DZ_Wycena_sz_zamowienia = new HashSet<DZ_Wycena_sz_zamowienia>();
        }
    
        public int Id_pliku { get; set; }
        public string Nazwa_pliku { get; set; }
        public string Zalacznik { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Wydruk> DP_Wydruk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Szczegoly_zamowienia_klienta> DZ_Szczegoly_zamowienia_klienta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Wycena_sz_zamowienia> DZ_Wycena_sz_zamowienia { get; set; }
    }
}
