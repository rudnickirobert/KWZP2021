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
    
    public partial class DZ_Zamowienie_klienta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DZ_Zamowienie_klienta()
        {
            this.DM_Magazyn_gotowych_produktow = new HashSet<DM_Magazyn_gotowych_produktow>();
            this.DM_Wydanie_materialu_dla_produkcji = new HashSet<DM_Wydanie_materialu_dla_produkcji>();
            this.DZ_Status_zamowienia = new HashSet<DZ_Status_zamowienia>();
            this.DZ_Szczegoly_zamowienia_klienta = new HashSet<DZ_Szczegoly_zamowienia_klienta>();
        }
    
        public int Id_zamowienia { get; set; }
        public Nullable<int> Id_klienta { get; set; }
        public Nullable<int> Id_pracownika { get; set; }
        public System.DateTime data_zamowienia { get; set; }
        public System.DateTime oczekiwany_termin_wykonania { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Magazyn_gotowych_produktow> DM_Magazyn_gotowych_produktow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_materialu_dla_produkcji> DM_Wydanie_materialu_dla_produkcji { get; set; }
        public virtual DZ_Klient DZ_Klient { get; set; }
        public virtual DZ_Pracownik DZ_Pracownik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Status_zamowienia> DZ_Status_zamowienia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Szczegoly_zamowienia_klienta> DZ_Szczegoly_zamowienia_klienta { get; set; }
    }
}
