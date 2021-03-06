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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DrukarniaEntities : DbContext
    {
        public DrukarniaEntities()
            : base("name=DrukarniaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DM_Czesci> DM_Czesci { get; set; }
        public virtual DbSet<DM_Dostawa_czesci> DM_Dostawa_czesci { get; set; }
        public virtual DbSet<DM_Dostawa_maszyn> DM_Dostawa_maszyn { get; set; }
        public virtual DbSet<DM_Dostawa_materialu> DM_Dostawa_materialu { get; set; }
        public virtual DbSet<DM_Dostawa_narzedzi> DM_Dostawa_narzedzi { get; set; }
        public virtual DbSet<DM_Dostawcy> DM_Dostawcy { get; set; }
        public virtual DbSet<DM_Magazyn_gotowych_produktow> DM_Magazyn_gotowych_produktow { get; set; }
        public virtual DbSet<DM_Material> DM_Material { get; set; }
        public virtual DbSet<DM_Narzedzie> DM_Narzedzie { get; set; }
        public virtual DbSet<DM_Rodzaj_materialu> DM_Rodzaj_materialu { get; set; }
        public virtual DbSet<DM_Rodzaj_narzedzia> DM_Rodzaj_narzedzia { get; set; }
        public virtual DbSet<DM_Wlasciwosc> DM_Wlasciwosc { get; set; }
        public virtual DbSet<DM_Wydanie_czesci> DM_Wydanie_czesci { get; set; }
        public virtual DbSet<DM_Wydanie_czesci_dla_produkcji> DM_Wydanie_czesci_dla_produkcji { get; set; }
        public virtual DbSet<DM_Wydanie_materialu_dla_produkcji> DM_Wydanie_materialu_dla_produkcji { get; set; }
        public virtual DbSet<DM_Wydanie_produktow> DM_Wydanie_produktow { get; set; }
        public virtual DbSet<DM_Wypozyczenie_narzedzia> DM_Wypozyczenie_narzedzia { get; set; }
        public virtual DbSet<DM_Zuzyte_narzedzia> DM_Zuzyte_narzedzia { get; set; }
        public virtual DbSet<DP_Co_ile_obsluga> DP_Co_ile_obsluga { get; set; }
        public virtual DbSet<DP_Czynnosci> DP_Czynnosci { get; set; }
        public virtual DbSet<DP_Czynnosci_w_ramach_obslugi_serw_wew> DP_Czynnosci_w_ramach_obslugi_serw_wew { get; set; }
        public virtual DbSet<DP_Firma_serwisowa> DP_Firma_serwisowa { get; set; }
        public virtual DbSet<DP_Maszyny> DP_Maszyny { get; set; }
        public virtual DbSet<DP_Model_maszyny> DP_Model_maszyny { get; set; }
        public virtual DbSet<DP_Nazwa_obslugi> DP_Nazwa_obslugi { get; set; }
        public virtual DbSet<DP_Obsluga> DP_Obsluga { get; set; }
        public virtual DbSet<DP_Po_proc_czynnosci> DP_Po_proc_czynnosci { get; set; }
        public virtual DbSet<DP_Po_wydr_proc> DP_Po_wydr_proc { get; set; }
        public virtual DbSet<DP_Proces_produkcyjny> DP_Proces_produkcyjny { get; set; }
        public virtual DbSet<DP_Proces_technologiczny> DP_Proces_technologiczny { get; set; }
        public virtual DbSet<DP_prod_czynnosci_dodatkowe> DP_prod_czynnosci_dodatkowe { get; set; }
        public virtual DbSet<DP_prod_wydruk> DP_prod_wydruk { get; set; }
        public virtual DbSet<DP_Produkt> DP_Produkt { get; set; }
        public virtual DbSet<DP_Rodzaj_czynnosci> DP_Rodzaj_czynnosci { get; set; }
        public virtual DbSet<DP_Rodzaj_maszyny> DP_Rodzaj_maszyny { get; set; }
        public virtual DbSet<DP_Serwis_wewnetrzny_naprawa> DP_Serwis_wewnetrzny_naprawa { get; set; }
        public virtual DbSet<DP_Serwis_wewnetrzny_obsluga> DP_Serwis_wewnetrzny_obsluga { get; set; }
        public virtual DbSet<DP_Serwis_zewnetrzny> DP_Serwis_zewnetrzny { get; set; }
        public virtual DbSet<DP_Usluga_serwisu_zewnetrznego> DP_Usluga_serwisu_zewnetrznego { get; set; }
        public virtual DbSet<DP_Wydruk> DP_Wydruk { get; set; }
        public virtual DbSet<DP_Zuzute_maszyny> DP_Zuzute_maszyny { get; set; }
        public virtual DbSet<DZ_Dzial> DZ_Dzial { get; set; }
        public virtual DbSet<DZ_Etat> DZ_Etat { get; set; }
        public virtual DbSet<DZ_Klient> DZ_Klient { get; set; }
        public virtual DbSet<DZ_Nieobecnosc> DZ_Nieobecnosc { get; set; }
        public virtual DbSet<DZ_Plik> DZ_Plik { get; set; }
        public virtual DbSet<DZ_Pracownik> DZ_Pracownik { get; set; }
        public virtual DbSet<DZ_Rachunki> DZ_Rachunki { get; set; }
        public virtual DbSet<DZ_Rodzaj_nieobecnosci> DZ_Rodzaj_nieobecnosci { get; set; }
        public virtual DbSet<DZ_Rodzaj_rachunku> DZ_Rodzaj_rachunku { get; set; }
        public virtual DbSet<DZ_Rodzaj_statusu_zamowienia> DZ_Rodzaj_statusu_zamowienia { get; set; }
        public virtual DbSet<DZ_Rodzaj_umowy> DZ_Rodzaj_umowy { get; set; }
        public virtual DbSet<DZ_Stanowisko> DZ_Stanowisko { get; set; }
        public virtual DbSet<DZ_Status_zamowienia> DZ_Status_zamowienia { get; set; }
        public virtual DbSet<DZ_Szczegoly_zam_czesci> DZ_Szczegoly_zam_czesci { get; set; }
        public virtual DbSet<DZ_Szczegoly_zam_maszyn> DZ_Szczegoly_zam_maszyn { get; set; }
        public virtual DbSet<DZ_Szczegoly_zam_materialu> DZ_Szczegoly_zam_materialu { get; set; }
        public virtual DbSet<DZ_Szczegoly_zam_narzedzi> DZ_Szczegoly_zam_narzedzi { get; set; }
        public virtual DbSet<DZ_Szczegoly_zamowienia_klienta> DZ_Szczegoly_zamowienia_klienta { get; set; }
        public virtual DbSet<DZ_Szczegoly_zatrudnienia> DZ_Szczegoly_zatrudnienia { get; set; }
        public virtual DbSet<DZ_Wycena_sz_zamowienia> DZ_Wycena_sz_zamowienia { get; set; }
        public virtual DbSet<DZ_Zamowienie_klienta> DZ_Zamowienie_klienta { get; set; }
        public virtual DbSet<DZ_Zamowienie_zewn> DZ_Zamowienie_zewn { get; set; }
        public virtual DbSet<DZ_Zatrudnienie> DZ_Zatrudnienie { get; set; }
        public virtual DbSet<DM_Parametry_czesci> DM_Parametry_czesci { get; set; }
        public virtual DbSet<DM_Parametry_narzedzia> DM_Parametry_narzedzia { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_czesci> DM_Sklad_dostawy_czesci { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_maszyn> DM_Sklad_dostawy_maszyn { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_materialu> DM_Sklad_dostawy_materialu { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_narzedzi> DM_Sklad_dostawy_narzedzi { get; set; }
        public virtual DbSet<DM_Szczegoly_magazynu_gotowych_produktow> DM_Szczegoly_magazynu_gotowych_produktow { get; set; }
        public virtual DbSet<DM_Szczegoly_wydania_czesci> DM_Szczegoly_wydania_czesci { get; set; }
        public virtual DbSet<DM_Szczegoly_wydania_materialu> DM_Szczegoly_wydania_materialu { get; set; }
        public virtual DbSet<DM_Szczegoly_wydania_produktu> DM_Szczegoly_wydania_produktu { get; set; }
        public virtual DbSet<DM_Szczegoly_wypozyczenia_narzedzia> DM_Szczegoly_wypozyczenia_narzedzia { get; set; }
        public virtual DbSet<DM_Wlasciwosci_materialu> DM_Wlasciwosci_materialu { get; set; }
        public virtual DbSet<DP_Po_material_wydruk> DP_Po_material_wydruk { get; set; }
        public virtual DbSet<vDM_Czesci> vDM_Czesci { get; set; }
        public virtual DbSet<vDM_Dostawcy> vDM_Dostawcy { get; set; }
        public virtual DbSet<vDM_Material> vDM_Material { get; set; }
        public virtual DbSet<vDM_Narzedzie> vDM_Narzedzie { get; set; }
        public virtual DbSet<vDM_Rodzaj_narzedzia> vDM_Rodzaj_narzedzia { get; set; }
        public virtual DbSet<vDM_Wlasciwosc> vDM_Wlasciwosc { get; set; }
        public virtual DbSet<vDP_Maszyny> vDP_Maszyny { get; set; }
        public virtual DbSet<vDP_Model_maszyny> vDP_Model_maszyny { get; set; }
        public virtual DbSet<vDP_Produkt> vDP_Produkt { get; set; }
        public virtual DbSet<vDP_Rodzaj_maszyny> vDP_Rodzaj_maszyny { get; set; }
        public virtual DbSet<vDZ_Dzial> vDZ_Dzial { get; set; }
        public virtual DbSet<vDZ_Etat> vDZ_Etat { get; set; }
        public virtual DbSet<vDZ_Klient> vDZ_Klient { get; set; }
        public virtual DbSet<vDZ_Nieobecnosc> vDZ_Nieobecnosc { get; set; }
        public virtual DbSet<vDZ_Plik> vDZ_Plik { get; set; }
        public virtual DbSet<vDZ_Pracownik> vDZ_Pracownik { get; set; }
        public virtual DbSet<vDZ_Rachunki> vDZ_Rachunki { get; set; }
        public virtual DbSet<vDZ_Rodzaj_nieobecnosci> vDZ_Rodzaj_nieobecnosci { get; set; }
        public virtual DbSet<vDZ_Rodzaj_rachunku> vDZ_Rodzaj_rachunku { get; set; }
        public virtual DbSet<vDZ_Rodzaj_statusu_zamowienia> vDZ_Rodzaj_statusu_zamowienia { get; set; }
        public virtual DbSet<vDZ_Rodzaj_umowy> vDZ_Rodzaj_umowy { get; set; }
        public virtual DbSet<vDZ_Stanowisko> vDZ_Stanowisko { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_czesci> vDZ_Szczegoly_zam_czesci { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_maszyn> vDZ_Szczegoly_zam_maszyn { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_materialu> vDZ_Szczegoly_zam_materialu { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_narzedzi> vDZ_Szczegoly_zam_narzedzi { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zamowienia_klienta> vDZ_Szczegoly_zamowienia_klienta { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zatrudnienia> vDZ_Szczegoly_zatrudnienia { get; set; }
        public virtual DbSet<vDZ_Wycena_sz_zamowienia> vDZ_Wycena_sz_zamowienia { get; set; }
        public virtual DbSet<vDZ_Zamowienie_klienta> vDZ_Zamowienie_klienta { get; set; }
        public virtual DbSet<vDZ_Zamowienie_zewn> vDZ_Zamowienie_zewn { get; set; }
        public virtual DbSet<vDZ_Zatrudnienie> vDZ_Zatrudnienie { get; set; }
    }
}
