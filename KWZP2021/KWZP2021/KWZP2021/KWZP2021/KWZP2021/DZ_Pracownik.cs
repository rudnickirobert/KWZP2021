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
    
    public partial class DZ_Pracownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DZ_Pracownik()
        {
            this.DM_Dostawa_czesci = new HashSet<DM_Dostawa_czesci>();
            this.DM_Dostawa_maszyn = new HashSet<DM_Dostawa_maszyn>();
            this.DM_Dostawa_materialu = new HashSet<DM_Dostawa_materialu>();
            this.DM_Dostawa_narzedzi = new HashSet<DM_Dostawa_narzedzi>();
            this.DM_Wydanie_czesci = new HashSet<DM_Wydanie_czesci>();
            this.DM_Wydanie_czesci1 = new HashSet<DM_Wydanie_czesci>();
            this.DM_Wydanie_czesci_dla_produkcji = new HashSet<DM_Wydanie_czesci_dla_produkcji>();
            this.DM_Wydanie_czesci_dla_produkcji1 = new HashSet<DM_Wydanie_czesci_dla_produkcji>();
            this.DM_Wydanie_materialu_dla_produkcji = new HashSet<DM_Wydanie_materialu_dla_produkcji>();
            this.DM_Wydanie_materialu_dla_produkcji1 = new HashSet<DM_Wydanie_materialu_dla_produkcji>();
            this.DM_Wydanie_produktow = new HashSet<DM_Wydanie_produktow>();
            this.DM_Wypozyczenie_narzedzia = new HashSet<DM_Wypozyczenie_narzedzia>();
            this.DM_Wypozyczenie_narzedzia1 = new HashSet<DM_Wypozyczenie_narzedzia>();
            this.DP_Serwis_wewnetrzny_naprawa = new HashSet<DP_Serwis_wewnetrzny_naprawa>();
            this.DP_Serwis_wewnetrzny_obsluga = new HashSet<DP_Serwis_wewnetrzny_obsluga>();
            this.DZ_Nieobecnosc = new HashSet<DZ_Nieobecnosc>();
            this.DZ_Zamowienie_klienta = new HashSet<DZ_Zamowienie_klienta>();
            this.DZ_Zamowienie_zewn = new HashSet<DZ_Zamowienie_zewn>();
            this.DZ_Zatrudnienie = new HashSet<DZ_Zatrudnienie>();
        }
    
        public int Id_pracownika { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string email { get; set; }
        public string adres { get; set; }
        public string miasto { get; set; }
        public string kod_pocztowy { get; set; }
        public System.DateTime data_urodzenia { get; set; }
        public string telefon { get; set; }
        public string numer_rachunku { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Dostawa_czesci> DM_Dostawa_czesci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Dostawa_maszyn> DM_Dostawa_maszyn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Dostawa_materialu> DM_Dostawa_materialu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Dostawa_narzedzi> DM_Dostawa_narzedzi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_czesci> DM_Wydanie_czesci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_czesci> DM_Wydanie_czesci1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_czesci_dla_produkcji> DM_Wydanie_czesci_dla_produkcji { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_czesci_dla_produkcji> DM_Wydanie_czesci_dla_produkcji1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_materialu_dla_produkcji> DM_Wydanie_materialu_dla_produkcji { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_materialu_dla_produkcji> DM_Wydanie_materialu_dla_produkcji1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wydanie_produktow> DM_Wydanie_produktow { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wypozyczenie_narzedzia> DM_Wypozyczenie_narzedzia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DM_Wypozyczenie_narzedzia> DM_Wypozyczenie_narzedzia1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Serwis_wewnetrzny_naprawa> DP_Serwis_wewnetrzny_naprawa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DP_Serwis_wewnetrzny_obsluga> DP_Serwis_wewnetrzny_obsluga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Nieobecnosc> DZ_Nieobecnosc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Zamowienie_klienta> DZ_Zamowienie_klienta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Zamowienie_zewn> DZ_Zamowienie_zewn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DZ_Zatrudnienie> DZ_Zatrudnienie { get; set; }
    }
}
