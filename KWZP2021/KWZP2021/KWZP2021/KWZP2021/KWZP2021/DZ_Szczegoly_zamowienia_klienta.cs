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
    
    public partial class DZ_Szczegoly_zamowienia_klienta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DZ_Szczegoly_zamowienia_klienta()
        {
            this.DZ_Wycena_sz_zamowienia = new HashSet<DZ_Wycena_sz_zamowienia>();
        }
    
        public int Id_szczegoly_zam_klienta { get; set; }
        public Nullable<int> Id_zamowienia { get; set; }
        public Nullable<int> Id_pliku { get; set; }
        public int ilosc_sztuk { get; set; }
        public Nullable<int> Id_materialu { get; set; }
    
        public virtual DM_Material DM_Material { get; set; }
        public virtual DZ_Plik DZ_Plik { get; set; }
        public virtual DZ_Zamowienie_klienta DZ_Zamowienie_klienta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Wycena_sz_zamowienia> DZ_Wycena_sz_zamowienia { get; set; }
    }
}
