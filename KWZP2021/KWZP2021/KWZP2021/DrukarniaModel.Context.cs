﻿//------------------------------------------------------------------------------
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
    
        public virtual DbSet<DM_Czesc> DM_Czesc { get; set; }
        public virtual DbSet<DM_Dostawa_czesci> DM_Dostawa_czesci { get; set; }
        public virtual DbSet<DM_Dostawa_maszyn> DM_Dostawa_maszyn { get; set; }
        public virtual DbSet<DM_Dostawa_materialu> DM_Dostawa_materialu { get; set; }
        public virtual DbSet<DM_Dostawa_narzedzi> DM_Dostawa_narzedzi { get; set; }
        public virtual DbSet<DM_Dostawca> DM_Dostawca { get; set; }
        public virtual DbSet<DM_Magazyn_gotowych_produktow> DM_Magazyn_gotowych_produktow { get; set; }
        public virtual DbSet<DM_Material> DM_Material { get; set; }
        public virtual DbSet<DM_Narzedzie> DM_Narzedzie { get; set; }
        public virtual DbSet<DM_Parametr_narzedzia> DM_Parametr_narzedzia { get; set; }
        public virtual DbSet<DM_Rodzaj_materialu> DM_Rodzaj_materialu { get; set; }
        public virtual DbSet<DM_Rodzaj_narzedzia> DM_Rodzaj_narzedzia { get; set; }
        public virtual DbSet<DM_Szczegoly_wydania_produktu> DM_Szczegoly_wydania_produktu { get; set; }
        public virtual DbSet<DM_Szczegoly_wypozyczenia_narzedzia> DM_Szczegoly_wypozyczenia_narzedzia { get; set; }
        public virtual DbSet<DM_Wlasciwosc> DM_Wlasciwosc { get; set; }
        public virtual DbSet<DM_Wlasciwosc_materialu> DM_Wlasciwosc_materialu { get; set; }
        public virtual DbSet<DM_Wydanie_czesci> DM_Wydanie_czesci { get; set; }
        public virtual DbSet<DM_Wydanie_czesci_dla_produkcji> DM_Wydanie_czesci_dla_produkcji { get; set; }
        public virtual DbSet<DM_Wydanie_materialu_dla_produkcji> DM_Wydanie_materialu_dla_produkcji { get; set; }
        public virtual DbSet<DM_Wydanie_produktu> DM_Wydanie_produktu { get; set; }
        public virtual DbSet<DM_Wypozyczenie_narzedzia> DM_Wypozyczenie_narzedzia { get; set; }
        public virtual DbSet<DM_Zuzyte_narzedzie> DM_Zuzyte_narzedzie { get; set; }
        public virtual DbSet<DP_Co_ile_obsluga> DP_Co_ile_obsluga { get; set; }
        public virtual DbSet<DP_Czynnosc> DP_Czynnosc { get; set; }
        public virtual DbSet<DP_Czynnosc_w_ramach_obslugi_serw_wew> DP_Czynnosc_w_ramach_obslugi_serw_wew { get; set; }
        public virtual DbSet<DP_Firma_serwisowa> DP_Firma_serwisowa { get; set; }
        public virtual DbSet<DP_Maszyna> DP_Maszyna { get; set; }
        public virtual DbSet<DP_Model_maszyny> DP_Model_maszyny { get; set; }
        public virtual DbSet<DP_Nazwa_obslugi> DP_Nazwa_obslugi { get; set; }
        public virtual DbSet<DP_Obsluga> DP_Obsluga { get; set; }
        public virtual DbSet<DP_Po_maszyna_wydruk> DP_Po_maszyna_wydruk { get; set; }
        public virtual DbSet<DP_Po_material_wydruk> DP_Po_material_wydruk { get; set; }
        public virtual DbSet<DP_Po_proc_czynnosc> DP_Po_proc_czynnosc { get; set; }
        public virtual DbSet<DP_Po_wydr_proc> DP_Po_wydr_proc { get; set; }
        public virtual DbSet<DP_Proces_produkcyjny> DP_Proces_produkcyjny { get; set; }
        public virtual DbSet<DP_Proces_technologiczny> DP_Proces_technologiczny { get; set; }
        public virtual DbSet<DP_prod_czynnosc_dodatkowa> DP_prod_czynnosc_dodatkowa { get; set; }
        public virtual DbSet<DP_prod_wydruk> DP_prod_wydruk { get; set; }
        public virtual DbSet<DP_Produkt> DP_Produkt { get; set; }
        public virtual DbSet<DP_Rodzaj_czynnosci> DP_Rodzaj_czynnosci { get; set; }
        public virtual DbSet<DP_Rodzaj_maszyny> DP_Rodzaj_maszyny { get; set; }
        public virtual DbSet<DP_Serwis_wewnetrzny_naprawa> DP_Serwis_wewnetrzny_naprawa { get; set; }
        public virtual DbSet<DP_Serwis_wewnetrzny_obsluga> DP_Serwis_wewnetrzny_obsluga { get; set; }
        public virtual DbSet<DP_Serwis_zewnetrzny> DP_Serwis_zewnetrzny { get; set; }
        public virtual DbSet<DP_Usluga_serwisu_zewnetrznego> DP_Usluga_serwisu_zewnetrznego { get; set; }
        public virtual DbSet<DP_Wydruk> DP_Wydruk { get; set; }
        public virtual DbSet<DP_Zuzyta_maszyna> DP_Zuzyta_maszyna { get; set; }
        public virtual DbSet<DZ_Dzial> DZ_Dzial { get; set; }
        public virtual DbSet<DZ_Etat> DZ_Etat { get; set; }
        public virtual DbSet<DZ_Klient> DZ_Klient { get; set; }
        public virtual DbSet<DZ_Nieobecnosc> DZ_Nieobecnosc { get; set; }
        public virtual DbSet<DZ_Plik> DZ_Plik { get; set; }
        public virtual DbSet<DZ_Pracownik> DZ_Pracownik { get; set; }
        public virtual DbSet<DZ_Rachunek> DZ_Rachunek { get; set; }
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
        public virtual DbSet<DM_Parametr_czesci> DM_Parametr_czesci { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_czesci> DM_Sklad_dostawy_czesci { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_maszyn> DM_Sklad_dostawy_maszyn { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_materialu> DM_Sklad_dostawy_materialu { get; set; }
        public virtual DbSet<DM_Sklad_dostawy_narzedzi> DM_Sklad_dostawy_narzedzi { get; set; }
        public virtual DbSet<DM_Szczegoly_magazynu_gotowych_produktow> DM_Szczegoly_magazynu_gotowych_produktow { get; set; }
        public virtual DbSet<DM_Szczegoly_wydania_czesci> DM_Szczegoly_wydania_czesci { get; set; }
        public virtual DbSet<DM_Szczegoly_wydania_materialu> DM_Szczegoly_wydania_materialu { get; set; }
        public virtual DbSet<DP_Po_material_czynnosc> DP_Po_material_czynnosc { get; set; }
        public virtual DbSet<DP_po_prod_czyn_dod_material> DP_po_prod_czyn_dod_material { get; set; }
        public virtual DbSet<DP_prod_material> DP_prod_material { get; set; }
        public virtual DbSet<vDM_Czesc> vDM_Czesc { get; set; }
        public virtual DbSet<vDM_Dostawa_czesci> vDM_Dostawa_czesci { get; set; }
        public virtual DbSet<vDM_Dostawa_maszyn> vDM_Dostawa_maszyn { get; set; }
        public virtual DbSet<vDM_Dostawa_materialu> vDM_Dostawa_materialu { get; set; }
        public virtual DbSet<vDM_Dostawa_narzedzi> vDM_Dostawa_narzedzi { get; set; }
        public virtual DbSet<vDM_Dostawca> vDM_Dostawca { get; set; }
        public virtual DbSet<vDM_Magazyn_gotowych_produktow> vDM_Magazyn_gotowych_produktow { get; set; }
        public virtual DbSet<vDM_Material> vDM_Material { get; set; }
        public virtual DbSet<vDM_Narzedzie> vDM_Narzedzie { get; set; }
        public virtual DbSet<vDM_Parametr_czesci> vDM_Parametr_czesci { get; set; }
        public virtual DbSet<vDM_Parametr_narzedzia> vDM_Parametr_narzedzia { get; set; }
        public virtual DbSet<vDM_Rodzaj_narzedzia> vDM_Rodzaj_narzedzia { get; set; }
        public virtual DbSet<vDM_Sklad_dostawy_czesci> vDM_Sklad_dostawy_czesci { get; set; }
        public virtual DbSet<vDM_Sklad_dostawy_maszyn> vDM_Sklad_dostawy_maszyn { get; set; }
        public virtual DbSet<vDM_Sklad_dostawy_materialu> vDM_Sklad_dostawy_materialu { get; set; }
        public virtual DbSet<vDM_Sklad_dostawy_narzedzi> vDM_Sklad_dostawy_narzedzi { get; set; }
        public virtual DbSet<vDM_Szczegoly_magazynu_gotowych_produktow> vDM_Szczegoly_magazynu_gotowych_produktow { get; set; }
        public virtual DbSet<vDM_Szczegoly_wydania_czesci> vDM_Szczegoly_wydania_czesci { get; set; }
        public virtual DbSet<vDM_Szczegoly_wydania_materialu> vDM_Szczegoly_wydania_materialu { get; set; }
        public virtual DbSet<vDM_Szczegoly_wydania_produktu> vDM_Szczegoly_wydania_produktu { get; set; }
        public virtual DbSet<vDM_Szczegoly_wypozyczenia_narzedzia> vDM_Szczegoly_wypozyczenia_narzedzia { get; set; }
        public virtual DbSet<vDM_Wlasciwosc> vDM_Wlasciwosc { get; set; }
        public virtual DbSet<vDM_Wlasciwosc_materialu> vDM_Wlasciwosc_materialu { get; set; }
        public virtual DbSet<vDM_Wybor_maszyny> vDM_Wybor_maszyny { get; set; }
        public virtual DbSet<vDM_Wydanie_czesci> vDM_Wydanie_czesci { get; set; }
        public virtual DbSet<vDM_Wydanie_czesci_dla_produkcji> vDM_Wydanie_czesci_dla_produkcji { get; set; }
        public virtual DbSet<vDM_Wydanie_materialu_dla_produkcji> vDM_Wydanie_materialu_dla_produkcji { get; set; }
        public virtual DbSet<vDM_Wydanie_produktu> vDM_Wydanie_produktu { get; set; }
        public virtual DbSet<vDM_Wypozyczenie_narzedzia> vDM_Wypozyczenie_narzedzia { get; set; }
        public virtual DbSet<vDM_Zapotrzebowanie> vDM_Zapotrzebowanie { get; set; }
        public virtual DbSet<vDM_Zliczanieilosciwdostawie> vDM_Zliczanieilosciwdostawie { get; set; }
        public virtual DbSet<vDM_Zliczanieilosciwydanej> vDM_Zliczanieilosciwydanej { get; set; }
        public virtual DbSet<vDM_Zliczaniematerialudoczynnosci> vDM_Zliczaniematerialudoczynnosci { get; set; }
        public virtual DbSet<vDM_Zliczaniematerialudowydruku> vDM_Zliczaniematerialudowydruku { get; set; }
        public virtual DbSet<vDP_Co_ile_obsluga> vDP_Co_ile_obsluga { get; set; }
        public virtual DbSet<vDP_Czesc_wykorzystana> vDP_Czesc_wykorzystana { get; set; }
        public virtual DbSet<vDP_Czynnosc> vDP_Czynnosc { get; set; }
        public virtual DbSet<vDP_Czynnosc_w_ramach_obslugi_serw_wew> vDP_Czynnosc_w_ramach_obslugi_serw_wew { get; set; }
        public virtual DbSet<vDP_CzynnoscProces> vDP_CzynnoscProces { get; set; }
        public virtual DbSet<vDP_Firma_serwisowa> vDP_Firma_serwisowa { get; set; }
        public virtual DbSet<vDP_Koszt_jednostkowy_material> vDP_Koszt_jednostkowy_material { get; set; }
        public virtual DbSet<vDP_Koszt_maszyn_dodatkowe_ofertowy> vDP_Koszt_maszyn_dodatkowe_ofertowy { get; set; }
        public virtual DbSet<vDP_Koszt_maszyn_dodatkowe_powykonawczy> vDP_Koszt_maszyn_dodatkowe_powykonawczy { get; set; }
        public virtual DbSet<vDP_Koszt_maszyn_wydruk_ofertowy> vDP_Koszt_maszyn_wydruk_ofertowy { get; set; }
        public virtual DbSet<vDP_Koszt_maszyn_wydruk_powykonawczy> vDP_Koszt_maszyn_wydruk_powykonawczy { get; set; }
        public virtual DbSet<vDP_Koszt_materialu_dodatkowe_ofertowy> vDP_Koszt_materialu_dodatkowe_ofertowy { get; set; }
        public virtual DbSet<vDP_Koszt_materialu_dodatkowe_powykonawczy> vDP_Koszt_materialu_dodatkowe_powykonawczy { get; set; }
        public virtual DbSet<vDP_Koszt_materialu_ofertowy> vDP_Koszt_materialu_ofertowy { get; set; }
        public virtual DbSet<vDP_Koszt_materialu_wydruk_ofertowy> vDP_Koszt_materialu_wydruk_ofertowy { get; set; }
        public virtual DbSet<vDP_Koszt_materialu_wydruk_powykonawczy> vDP_Koszt_materialu_wydruk_powykonawczy { get; set; }
        public virtual DbSet<vDP_Koszt_pracownika_ofertowy> vDP_Koszt_pracownika_ofertowy { get; set; }
        public virtual DbSet<vDP_Koszt_pracownika_powykonawczy> vDP_Koszt_pracownika_powykonawczy { get; set; }
        public virtual DbSet<vDP_Koszt_RH_pracownika> vDP_Koszt_RH_pracownika { get; set; }
        public virtual DbSet<vDP_Maszyna> vDP_Maszyna { get; set; }
        public virtual DbSet<vDP_Maszyna_drukarki> vDP_Maszyna_drukarki { get; set; }
        public virtual DbSet<vDP_Maszyna_Proces> vDP_Maszyna_Proces { get; set; }
        public virtual DbSet<vDP_MaszynaWydruk_Proces> vDP_MaszynaWydruk_Proces { get; set; }
        public virtual DbSet<vDP_Material_Proces> vDP_Material_Proces { get; set; }
        public virtual DbSet<vDP_MaterialWydruk_Proces> vDP_MaterialWydruk_Proces { get; set; }
        public virtual DbSet<vDP_Model_maszyny> vDP_Model_maszyny { get; set; }
        public virtual DbSet<vDP_Narzedzia_Proces> vDP_Narzedzia_Proces { get; set; }
        public virtual DbSet<vDP_Narzedzie_uzyte_naprawa> vDP_Narzedzie_uzyte_naprawa { get; set; }
        public virtual DbSet<vDP_Narzedzie_uzyte_obsluga> vDP_Narzedzie_uzyte_obsluga { get; set; }
        public virtual DbSet<vDP_Nazwa_obslugi> vDP_Nazwa_obslugi { get; set; }
        public virtual DbSet<vDP_Obsluga> vDP_Obsluga { get; set; }
        public virtual DbSet<vDP_Po_maszyna_czynnosc> vDP_Po_maszyna_czynnosc { get; set; }
        public virtual DbSet<vDP_Po_maszyna_wydruk> vDP_Po_maszyna_wydruk { get; set; }
        public virtual DbSet<vDP_Po_material_czynnosc> vDP_Po_material_czynnosc { get; set; }
        public virtual DbSet<vDP_Po_material_wydruk> vDP_Po_material_wydruk { get; set; }
        public virtual DbSet<vDP_Po_narzedzia_czynnosc> vDP_Po_narzedzia_czynnosc { get; set; }
        public virtual DbSet<vDP_Po_prac_czynnosc> vDP_Po_prac_czynnosc { get; set; }
        public virtual DbSet<vDP_Po_proc_czynnosc> vDP_Po_proc_czynnosc { get; set; }
        public virtual DbSet<vDP_po_prod_czyn_dod_maszyna> vDP_po_prod_czyn_dod_maszyna { get; set; }
        public virtual DbSet<vDP_po_prod_czyn_dod_pracownik> vDP_po_prod_czyn_dod_pracownik { get; set; }
        public virtual DbSet<vDP_Po_wydr_proc> vDP_Po_wydr_proc { get; set; }
        public virtual DbSet<vDP_Pracownik_Proces> vDP_Pracownik_Proces { get; set; }
        public virtual DbSet<vDP_Proces_produkcyjny> vDP_Proces_produkcyjny { get; set; }
        public virtual DbSet<vDP_Proces_produkt> vDP_Proces_produkt { get; set; }
        public virtual DbSet<vDP_Proces_Techno1> vDP_Proces_Techno1 { get; set; }
        public virtual DbSet<vDP_Proces_technologiczny> vDP_Proces_technologiczny { get; set; }
        public virtual DbSet<vDP_prod_czynnosc_dodatkowa> vDP_prod_czynnosc_dodatkowa { get; set; }
        public virtual DbSet<vDP_prod_material> vDP_prod_material { get; set; }
        public virtual DbSet<vDP_prod_wydruk> vDP_prod_wydruk { get; set; }
        public virtual DbSet<vDP_Produkt> vDP_Produkt { get; set; }
        public virtual DbSet<vDP_Rodzaj_czynnosci> vDP_Rodzaj_czynnosci { get; set; }
        public virtual DbSet<vDP_Rodzaj_maszyny> vDP_Rodzaj_maszyny { get; set; }
        public virtual DbSet<vDP_Serwis_wewnetrzny_naprawa> vDP_Serwis_wewnetrzny_naprawa { get; set; }
        public virtual DbSet<vDP_Serwis_wewnetrzny_obsluga> vDP_Serwis_wewnetrzny_obsluga { get; set; }
        public virtual DbSet<vDP_Serwis_zewnetrzny> vDP_Serwis_zewnetrzny { get; set; }
        public virtual DbSet<vDP_Usluga_serwisu_zewnetrznego> vDP_Usluga_serwisu_zewnetrznego { get; set; }
        public virtual DbSet<vDP_Wydruk> vDP_Wydruk { get; set; }
        public virtual DbSet<vDP_Wydruk_Proces1> vDP_Wydruk_Proces1 { get; set; }
        public virtual DbSet<vDP_WydrukProces> vDP_WydrukProces { get; set; }
        public virtual DbSet<vDP_Zuzyta_maszyna> vDP_Zuzyta_maszyna { get; set; }
        public virtual DbSet<vDZ_Archiwum_Koszty_zewnetrzne> vDZ_Archiwum_Koszty_zewnetrzne { get; set; }
        public virtual DbSet<vDZ_Dzial> vDZ_Dzial { get; set; }
        public virtual DbSet<vDZ_Etat> vDZ_Etat { get; set; }
        public virtual DbSet<vDZ_Klient> vDZ_Klient { get; set; }
        public virtual DbSet<vDZ_Koszty_zewnetrzne> vDZ_Koszty_zewnetrzne { get; set; }
        public virtual DbSet<vDZ_Nieobecnosc> vDZ_Nieobecnosc { get; set; }
        public virtual DbSet<vDZ_Nieobecnosc_pensja> vDZ_Nieobecnosc_pensja { get; set; }
        public virtual DbSet<vDZ_Obecnosc_pensja> vDZ_Obecnosc_pensja { get; set; }
        public virtual DbSet<vDZ_Oferta_dla_klienta> vDZ_Oferta_dla_klienta { get; set; }
        public virtual DbSet<vDZ_Oplaty_stale> vDZ_Oplaty_stale { get; set; }
        public virtual DbSet<vDZ_Plik> vDZ_Plik { get; set; }
        public virtual DbSet<vDZ_Po_szczegoly_zam_produkt> vDZ_Po_szczegoly_zam_produkt { get; set; }
        public virtual DbSet<vDZ_Pracownik> vDZ_Pracownik { get; set; }
        public virtual DbSet<vDZ_Premia> vDZ_Premia { get; set; }
        public virtual DbSet<vDZ_Rachunek> vDZ_Rachunek { get; set; }
        public virtual DbSet<vDZ_Rodzaj_nieobecnosci> vDZ_Rodzaj_nieobecnosci { get; set; }
        public virtual DbSet<vDZ_Rodzaj_rachunku> vDZ_Rodzaj_rachunku { get; set; }
        public virtual DbSet<vDZ_Rodzaj_statusu_zamowienia> vDZ_Rodzaj_statusu_zamowienia { get; set; }
        public virtual DbSet<vDZ_Rodzaj_umowy> vDZ_Rodzaj_umowy { get; set; }
        public virtual DbSet<vDZ_Stanowisko> vDZ_Stanowisko { get; set; }
        public virtual DbSet<vDZ_Status_zamowienia> vDZ_Status_zamowienia { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_czesci> vDZ_Szczegoly_zam_czesci { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_maszyn> vDZ_Szczegoly_zam_maszyn { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_materialu> vDZ_Szczegoly_zam_materialu { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zam_narzedzi> vDZ_Szczegoly_zam_narzedzi { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zamowienia_klienta> vDZ_Szczegoly_zamowienia_klienta { get; set; }
        public virtual DbSet<vDZ_Szczegoly_zatrudnienia> vDZ_Szczegoly_zatrudnienia { get; set; }
        public virtual DbSet<vDZ_Wplyw> vDZ_Wplyw { get; set; }
        public virtual DbSet<vDZ_Wycena_sz_zamowienia> vDZ_Wycena_sz_zamowienia { get; set; }
        public virtual DbSet<vDZ_Wydanie_faktury> vDZ_Wydanie_faktury { get; set; }
        public virtual DbSet<vDZ_Wyplata> vDZ_Wyplata { get; set; }
        public virtual DbSet<vDZ_Zamowienie_klienta> vDZ_Zamowienie_klienta { get; set; }
        public virtual DbSet<vDZ_Zamowienie_zewn> vDZ_Zamowienie_zewn { get; set; }
        public virtual DbSet<vDZ_Zatrudnienie> vDZ_Zatrudnienie { get; set; }
    }
}
