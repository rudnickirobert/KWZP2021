USE Drukarnia
GO

CREATE VIEW vDM_Material
AS
SELECT Id_materialu AS [Numer materia³u], DM_Rodzaj_materialu.Rodzaj_materialu AS [Rodzaj materia³u], DM_Material.Nazwa AS [Nazwa materia³u]
FROM     dbo.DM_Material INNER JOIN
DM_Rodzaj_materialu ON DM_Material.Id_rodzaj_materialu=DM_Rodzaj_materialu.Id_rodzaj_materialu
GO
CREATE VIEW vDM_Wlasciwosc
AS
SELECT Id_wlasciwosc AS [Numer wlasciwosci], nazwa_wlasciwosci AS [Nazwa], jednostka_pomiarowa AS[Jednostka pomiarowa]
FROM     dbo.DM_Wlasciwosc 
GO
CREATE VIEW vDM_Rodzaj_narzedzia
AS
SELECT Id_rodzaj_narzedzia AS [Rodzaj narzedzia], DM_Rodzaj_narzedzia.nazwa AS [Nazwa]
FROM     dbo.DM_Rodzaj_narzedzia 
GO
CREATE VIEW vDM_Narzedzie
AS
SELECT Id_narzedzia AS [Numer narzedzia], DM_Narzedzie.nazwa AS [Nazwa], DM_Rodzaj_narzedzia.Nazwa AS [Rodzaj narzedzia],ilosc_poczatkowa AS [Ilosc poczatkowa]
FROM     dbo.DM_Narzedzie INNER JOIN
DM_Rodzaj_narzedzia ON DM_Narzedzie.Id_rodzaj_narzedzia=DM_Rodzaj_narzedzia.Id_rodzaj_narzedzia
GO
CREATE VIEW vDM_Dostawca
AS
SELECT Id_dostawcy AS [Numer dostawcy], DM_Dostawca.nazwa AS [Nazwa], DM_Dostawca.NIP AS [NIP],uwagi AS [Uwagi]
FROM     dbo.DM_Dostawca
GO
CREATE VIEW vDZ_Klient
AS
SELECT ID_Klienta AS [Numer klienta], nazwa_firmy AS [Nazwa firmy], NIP, imie AS [Imiê], nazwisko AS [Nazwisko], adres AS [Adres], miasto AS [Miasto] , kod_pocztowy AS [Kod pocztowy], email AS [E-mail], telefon, numer_rachunku AS [Numer rachunku]
FROM     dbo.DZ_Klient
GO
CREATE VIEW vDP_Produkt
AS
SELECT ID_produkt AS [Numer produktu], DP_produkt.nazwa_produktu AS [Nazwa produktu], uwagi AS [Uwagi]
FROM     dbo.DP_Produkt
GO
CREATE VIEW vDP_Model_maszyny
AS
SELECT Id_model_maszyny AS [Numer modelu], DP_Model_maszyny.nazwa_modelu_maszyny AS [Nazwa maszyny]
FROM     dbo.DP_Model_maszyny
GO
CREATE VIEW vDP_Rodzaj_maszyny
AS
SELECT Id_rodzaj_maszyny AS [Numer rodzaju], rodzaj_maszyny AS [Rodzaj]
FROM     dbo.DP_Rodzaj_maszyny
GO
CREATE VIEW vDP_Maszyna
AS
SELECT Id_maszyny AS [Numer maszyny], DP_Rodzaj_maszyny.Rodzaj_maszyny AS [Rodzaj maszyny], DP_Model_maszyny.Nazwa_modelu_maszyny AS [Nazwa modelu],nr_seryjny AS [Numer seryjny], data_wprowadzenia AS [Data wprowadzenia maszyny], koszt_1rh AS [ Koszt 1 roboczo-godziny]
FROM     dbo.DP_Maszyna INNER JOIN
DP_Rodzaj_maszyny ON DP_Maszyna.Id_rodzaj_maszyny=DP_Rodzaj_maszyny.Id_rodzaj_maszyny INNER JOIN
DP_Model_maszyny ON DP_Maszyna.Id_model_maszyny=DP_Model_maszyny.Id_model_maszyny
GO
CREATE VIEW vDM_Czesc
AS
SELECT Id_czesci AS [Numer czesci], DM_Czesc.nazwa AS [Nazwa], DM_Czesc.ilosc_poczatkowa AS [Ilosc pocz¹tkowa]
FROM     dbo.DM_Czesc INNER JOIN
DP_Model_maszyny ON DM_Czesc.Id_model_maszyny=DP_Model_maszyny.id_model_maszyny
GO
CREATE VIEW vDZ_Rodzaj_rachunku
AS
SELECT Id_rodzaj_rachunku AS [Numer rodzaju], rodzaj_rachunku AS [Rodzaj]
FROM     dbo.DZ_Rodzaj_rachunku
GO
CREATE VIEW vDZ_Rachunek
AS
SELECT Id_rachunki AS [Numer rachunku], DZ_Rodzaj_rachunku.Id_rodzaj_rachunku AS [Rodzaj rachunku], DZ_Rachunek.koszt AS [Koszt], data_zaplaty AS [Data zaplaty]
FROM     dbo.DZ_Rachunek INNER JOIN
DZ_Rodzaj_rachunku ON DZ_Rachunek.Id_rodzaj_rachunku=DZ_Rodzaj_rachunku.Id_rodzaj_rachunku
GO
CREATE VIEW vDZ_Pracownik
AS
SELECT Id_pracownika AS [Numer pracownika],imie AS [Imiê], nazwisko AS [Nazwisko], email AS[E-mail],adres AS [Adres],miasto AS [Miasto],kod_pocztowy AS [Kod pocztowy],data_urodzenia AS [Data urodzenia],telefon AS[Numer telefonu], numer_rachunku AS[Numer rachunku]
FROM     dbo.DZ_Pracownik
GO
CREATE VIEW vDZ_Rodzaj_nieobecnosci
AS
SELECT Id_rodzaj_nieobecnosci AS [Numer rodzaju],rodzaj, procent_pensji AS [Procent pensji]
FROM     dbo.DZ_Rodzaj_nieobecnosci
GO
CREATE VIEW vDZ_Nieobecnosc
AS
SELECT Id_nieobecnosci AS [Identyfikator nieobecnoœci], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika], DZ_Rodzaj_nieobecnosci.Rodzaj AS [Rodzaj nieobecnoœci],DZ_Nieobecnosc.data_rozpoczecia AS [Data rozpoczêcia], DZ_Nieobecnosc.data_zakonczenia AS [Data zakoñczenia]
FROM     dbo.DZ_Nieobecnosc INNER JOIN
DZ_Pracownik ON DZ_Nieobecnosc.Id_pracownika=DZ_Pracownik.Id_pracownika INNER JOIN
DZ_Rodzaj_nieobecnosci ON DZ_Nieobecnosc.Id_rodzaj_nieobecnosci=DZ_Rodzaj_nieobecnosci.Id_rodzaj_nieobecnosci
GO
CREATE VIEW vDZ_Stanowisko
AS
SELECT Id_stanowiska AS [Identyfikator stanowiska],stanowisko AS [Nazwa stanowiska]
FROM     dbo.DZ_Stanowisko
GO
CREATE VIEW vDZ_Etat
AS
SELECT Id_etatu AS [Identyfikator etatu],etat AS [Rodzaj etatu]
FROM     dbo.DZ_Etat
GO
CREATE VIEW vDZ_Rodzaj_umowy
AS
SELECT Id_rodzaj_umowy AS [Identyfikator umowy],rodzaj_umowy AS [Rodzaj umowy]
FROM     dbo.DZ_Rodzaj_umowy
GO
CREATE VIEW vDZ_Dzial
AS
SELECT Id_dzialu AS [Identyfikator dzialu],dzial AS [Nazwa dzialu]
FROM     dbo.DZ_Dzial
GO
CREATE VIEW vDZ_Zatrudnienie
AS
SELECT Id_zatrudnienia AS [Identyfikator zatrudnienia], DZ_Pracownik.Nazwisko AS [Nazwisko], DZ_Stanowisko.Stanowisko AS [Stanowisko],DZ_Dzial.Dzial AS [Dzia³], DZ_Etat.Etat AS [Etat], DZ_Rodzaj_umowy.Rodzaj_umowy AS[Rodzaj umowy],DZ_Zatrudnienie.Data_zatrudnienia AS[Data zatrudnienia], DZ_Zatrudnienie.Data_zwolnienia AS [Data zwolnienia]
FROM     dbo.DZ_Zatrudnienie INNER JOIN
DZ_Pracownik ON DZ_Zatrudnienie.Id_pracownika=DZ_Pracownik.Id_pracownika INNER JOIN
DZ_Stanowisko ON DZ_Zatrudnienie.Id_stanowiska=DZ_Stanowisko.Id_stanowiska INNER JOIN
DZ_Dzial ON DZ_Zatrudnienie.Id_dzialu=DZ_Dzial.Id_dzialu INNER JOIN
DZ_Etat ON DZ_Zatrudnienie.Id_etatu=DZ_Etat.Id_etatu INNER JOIN
DZ_Rodzaj_umowy ON DZ_Zatrudnienie.Id_rodzaj_umowy=DZ_Rodzaj_umowy.Id_rodzaj_umowy
GO
CREATE VIEW vDZ_Szczegoly_zatrudnienia
AS
SELECT Id_szczegoly_zatrudnienia AS [Identyfikator szczegolow zatrudnienia], DZ_Zatrudnienie.Id_pracownika AS [Nazwisko pracownika], data_zmiany_wynagrodzenia AS [Data zmiany wynagrodzenia], podstawa_wynagrodzenia AS [Podstawa wynagrodzenia]
FROM dbo.DZ_Szczegoly_zatrudnienia INNER JOIN 
DZ_Zatrudnienie ON DZ_Szczegoly_zatrudnienia.Id_zatrudnienia=DZ_Zatrudnienie.Id_zatrudnienia
GO
CREATE VIEW vDZ_Zamowienie_klienta
AS
SELECT Id_zamowienia AS [Numer zamówienia], DZ_Klient.Nazwa_firmy AS [Nazwa firmy], DZ_Pracownik.Nazwisko AS [Pracownik przyjmuj¹cy zamówienie], data_zamowienia AS [Data zamowienia], oczekiwany_termin_wykonania AS [Oczekiwany termin wykonania]
FROM dbo.DZ_Zamowienie_klienta INNER JOIN
DZ_Klient ON DZ_Zamowienie_klienta.Id_klienta=DZ_Klient.Id_klienta INNER JOIN
DZ_Pracownik ON DZ_Zamowienie_klienta.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDZ_Plik
AS
SELECT Id_pliku AS [Numer pliku], nazwa_pliku AS [Nazwa pliku], zalacznik
FROM dbo.DZ_Plik
GO
CREATE VIEW vDZ_Szczegoly_zamowienia_klienta
AS
SELECT Id_szczegoly_zam_klienta AS [Identyfikator szczegolow zamowienia klienta], DZ_Zamowienie_klienta.Id_zamowienia AS [Numer zamowienia], DZ_Plik.Nazwa_pliku AS [Nazwa pliku], ilosc_sztuk AS [Iloœæ sztuk], DM_Material.Nazwa AS [Nazwa materia³u]
FROM dbo.DZ_Szczegoly_zamowienia_klienta INNER JOIN
DZ_Zamowienie_klienta ON DZ_Szczegoly_zamowienia_klienta.Id_zamowienia=DZ_Zamowienie_klienta.Id_zamowienia INNER JOIN
DZ_Plik ON DZ_Szczegoly_zamowienia_klienta.Id_pliku=DZ_Plik.Id_pliku INNER JOIN
DM_Material ON DZ_Szczegoly_zamowienia_klienta.Id_materialu=DM_Material.Id_materialu
GO
CREATE VIEW vDZ_Wycena_sz_zamowienia
AS
SELECT Id_wycena_sz_zamowienia AS [Identyfikator wyceny zamowienia], DZ_Szczegoly_zamowienia_klienta.Id_szczegoly_zam_klienta AS [Identyfikator szczegolow zamowienia klienta], DZ_Plik.Nazwa_pliku AS [Nazwa pliku], koszt AS [Koszt], czas_wykonania AS [Czas wykonania]
FROM dbo.DZ_Wycena_sz_zamowienia INNER JOIN
DZ_Szczegoly_zamowienia_klienta ON DZ_Wycena_sz_zamowienia.Id_szczegoly_zam_klienta=DZ_Szczegoly_zamowienia_klienta.Id_szczegoly_zam_klienta INNER JOIN
DZ_Plik ON DZ_Wycena_sz_zamowienia.Id_pliku=DZ_Plik.Id_pliku
GO
CREATE VIEW vDZ_Rodzaj_statusu_zamowienia
AS
SELECT Id_rodzaj_statusu_zam AS [Identyfikator rodzaju statusu zamowienia], status_zam AS [Status zamowienia]
FROM dbo.DZ_Rodzaj_statusu_zamowienia
GO
CREATE VIEW vDZ_Zamowienie_zewn
AS
SELECT Id_zamowienia_zewn AS [Numer zamowienia], DZ_Pracownik.Nazwisko AS [Pracownik sk³adaj¹cy zamówienie], data_zamowienia_zewn AS [Data zamowienia]
FROM DZ_Zamowienie_zewn INNER JOIN
DZ_Pracownik ON DZ_Zamowienie_zewn.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDZ_Szczegoly_zam_maszyn
AS
SELECT Id_szczegoly_zam_maszyn AS [Identyfikator szczegolow zamowienia maszyn], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamówienia], DP_Maszyna.Nr_seryjny AS [Numer seryjny], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], ilosc AS [Ilość]
FROM dbo.DZ_Szczegoly_zam_maszyn INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_maszyn.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DP_Maszyna ON DZ_Szczegoly_zam_maszyn.Id_maszyny=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDZ_Szczegoly_zam_materialu
AS
SELECT Id_szczegoly_zam_materialu AS [Identyfikator szczegolow zamowienia materialu], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia], DM_Material.Nazwa AS [Nazwa materiału], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], DM_Wlasciwosc.Nazwa_wlasciwosci AS [Nazwa właściwości], ilosc AS [Ilość]
FROM dbo.DZ_Szczegoly_zam_materialu INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_materialu.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DM_Material ON DZ_Szczegoly_zam_materialu.Id_materialu=DM_Material.Id_materialu INNER JOIN
DM_Wlasciwosc ON DZ_Szczegoly_zam_materialu.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO
CREATE VIEW vDZ_Szczegoly_zam_czesci
AS
SELECT Id_szczegoly_zam_czesci AS [Identyfikator szczegolow zamowienia czesci], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia], DM_Czesc.Nazwa AS [Nazwa], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], DM_Wlasciwosc.Nazwa_wlasciwosci AS [Nazwa w³aœciwoœci], ilosc AS [Iloœæ]
FROM dbo.DZ_Szczegoly_zam_czesci INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_czesci.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DM_Czesc ON DZ_Szczegoly_zam_czesci.Id_czesci=DM_Czesc.Id_czesci INNER JOIN
DM_Wlasciwosc ON DZ_Szczegoly_zam_czesci.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO
CREATE VIEW vDZ_Szczegoly_zam_narzedzi
AS
SELECT Id_szczegoly_zam_narzedzi AS [Identyfikator szczegolow zamowienia narzedzi], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia], DM_Narzedzie.Nazwa AS [Nazwa narzêdzia], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], DM_Wlasciwosc.Nazwa_wlasciwosci AS [Nazwa  w³aœciwoœci], ilosc AS [Iloœæ]
FROM dbo.DZ_Szczegoly_zam_narzedzi INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_narzedzi.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DM_Narzedzie ON DZ_Szczegoly_zam_narzedzi.Id_narzedzia=DM_Narzedzie.Id_narzedzia INNER JOIN
DM_Wlasciwosc ON DZ_Szczegoly_zam_narzedzi.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO

CREATE VIEW vDZ_Po_szczegoly_zam_produkt
AS
SELECT DZ_Szczegoly_zamowienia_klienta.Id_szczegoly_zam_klienta AS [Identyfikator szczeg?w produktu], DP_Produkt.Nazwa_produktu AS [Numer produktu]
FROM dbo.DZ_Po_szczegoly_zam_produkt INNER JOIN
DZ_Szczegoly_zamowienia_klienta ON DZ_Po_szczegoly_zam_produkt.Id_szczegoly_zam_klienta=DZ_Szczegoly_zamowienia_klienta.Id_szczegoly_zam_klienta INNER JOIN
DP_Produkt ON DZ_Po_szczegoly_zam_produkt.Id_produkt=DP_Produkt.Id_produkt
GO

CREATE VIEW vDM_Magazyn_gotowych_produktow
AS
SELECT Id_Magazynu_gotowych_produktow AS [Identyfikator magazynu], DZ_Zamowienie_klienta.Id_zamowienia AS [Numer zam?ienia], Data_i_godzina_przyjecia AS [ Data i godzina przyjecia], Uwagi
FROM dbo.DM_Magazyn_gotowych_produktow INNER JOIN
DZ_Zamowienie_klienta ON DM_Magazyn_gotowych_produktow.Id_zamowienie=DZ_Zamowienie_klienta.Id_Zamowienia
GO

CREATE VIEW vDM_Wydanie_produktu
AS
SELECT Id_wydania AS [Identyfikator wydania produktu], DM_Magazyn_gotowych_produktow.Id_Magazynu_gotowych_produktow AS [Numer zamowienia], DZ_Pracownik.Nazwisko AS [ Nazwisko pracownika wydajacego], Data_i_godzina, DM_Wydanie_produktu.Uwagi AS [Uwagi]
FROM dbo.DM_Wydanie_produktu INNER JOIN
DM_Magazyn_gotowych_produktow ON DM_Wydanie_produktu.Id_magazyn_gotowych_produktow=DM_Magazyn_gotowych_produktow.Id_magazynu_gotowych_produktow INNER JOIN
DZ_Pracownik ON DM_Wydanie_produktu.Id_pracownika =DZ_Pracownik.Id_pracownika
GO

CREATE VIEW vDM_Szczegoly_wydania_produktu
AS
SELECT DM_Wydanie_produktu.Id_wydania AS [Identyfikator wydania], DP_Produkt.Nazwa_produktu AS [Nazwa produktu], DM_Szczegoly_wydania_produktu.Ilosc AS [Ilość]
FROM dbo.DM_Szczegoly_wydania_produktu INNER JOIN
DM_Wydanie_produktu ON DM_Szczegoly_wydania_produktu.Id_wydania=DM_Wydanie_produktu.Id_wydania INNER JOIN
DP_Produkt ON DM_Szczegoly_wydania_produktu.Id_produkt=DP_Produkt.Id_Produkt
GO

CREATE VIEW vDM_Wypozyczenie_narzedzia
AS
SELECT Id_wypozyczenia_narzedzia AS [Identyfikator wypo?yczenia], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wypo?yczj?cego], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wydaj?cego],Data_i_godzina_wypozyczenia AS [Data i godzina wypo?yczenia], Data_i_godzina_zwrotu AS [ Data i godzina zwrotu], DM_Wypozyczenie_narzedzia.Uwagi AS [ Uwagi]
FROM dbo.DM_Wypozyczenie_narzedzia INNER JOIN
DZ_Pracownik  ON DM_Wypozyczenie_narzedzia.Id_pracownika_wypozyczajacego&DM_Wypozyczenie_narzedzia.Id_pracownika_wydajacego=DZ_Pracownik.Id_pracownika
GO

CREATE VIEW vDM_Zuzyte_narzedzie
AS
SELECT Id_zuzycia AS [Identyfikator zu?ycia narz?zia], DM_Wypozyczenie_narzedzia.Id_wypozyczenia_narzedzia  AS [Identyfikator wypo?yczenia], DM_Narzedzie.Nazwa AS [Nazwa narz?zia],Data_zuzycia AS [Data zu?ycia], DM_Zuzyte_narzedzie.Ilosc AS [Ilo??, DM_Zuzyte_narzedzie.Uwagi AS [ Uwagi]
FROM dbo.DM_Zuzyte_narzedzie INNER JOIN
DM_Wypozyczenie_narzedzia  ON DM_Zuzyte_narzedzie.Id_wypozyczenia_narzedzia=DM_Wypozyczenie_narzedzia.Id_wypozyczenia_narzedzia INNER JOIN
DM_Narzedzie ON DM_Zuzyte_narzedzie.Id_narzedzia=DM_Narzedzie.Id_narzedzia
GO
CREATE VIEW vDM_Szczegoly_wypozyczenia_narzedzia
AS
SELECT DM_Wypozyczenie_narzedzia.Id_wypozyczenia_narzedzia AS [Identyfikator wypożyczenia], DM_Narzedzie.Nazwa AS [Nazwa narzedzia], DM_Szczegoly_wypozyczenia_narzedzia.Ilosc AS [Ilo??
FROM dbo.DM_Szczegoly_wypozyczenia_narzedzia INNER JOIN
DM_Wypozyczenie_narzedzia  ON DM_Szczegoly_wypozyczenia_narzedzia.Id_wypozyczenia_narzedzia=DM_Wypozyczenie_narzedzia.Id_wypozyczenia_narzedzia INNER JOiN
DM_Narzedzie ON DM_Szczegoly_wypozyczenia_narzedzia.Id_narzedzia=DM_Narzedzie.Id_narzedzia
GO
CREATE VIEW vDM_Parametr_narzedzia
AS
SELECT DM_Narzedzie.Nazwa AS [Nazwa narz?zia], DM_Wlasciwosc.Nazwa_wlasciwosci AS [W?a?ciwo??, DM_Parametr_narzedzia.Wartosc AS [Warto??
FROM dbo.DM_Parametr_narzedzia INNER JOIN
DM_Narzedzie  ON DM_Parametr_narzedzia.Id_narzedzia=DM_Narzedzie.Id_narzedzia INNER JOiN
DM_Wlasciwosc ON DM_Parametr_narzedzia.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO
CREATE VIEW vDM_Dostawa_materialu
AS
SELECT Id_dostawy AS [Identyfikator dostawy], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika],DM_Dostawa_materialu.Data_dostawy AS [Data dostawy],DM_Dostawa_materialu.Uwagi AS [Uwagi]
FROM dbo.DM_Dostawa_materialu INNER JOIN
DZ_Pracownik  ON DM_Dostawa_materialu.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDM_Dostawa_czesci
AS
SELECT Id_dostawy AS [Identyfikator dostawy], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika],DM_Dostawa_czesci.Data_dostawy AS [Data dostawy],DM_Dostawa_czesci.Uwagi AS [Uwagi]
FROM dbo.DM_Dostawa_czesci INNER JOIN
DZ_Pracownik  ON DM_Dostawa_czesci.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDM_Dostawa_narzedzi
AS
SELECT Id_dostawy AS [Identyfikator dostawy], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika],DM_Dostawa_narzedzi.Data_dostawy AS [Data dostawy],DM_Dostawa_narzedzi.Uwagi AS [Uwagi]
FROM dbo.DM_Dostawa_narzedzi INNER JOIN
DZ_Pracownik  ON DM_Dostawa_narzedzi.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDM_Dostawa_maszyn
AS
SELECT Id_dostawy AS [Identyfikator dostawy], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika],DM_Dostawa_maszyn.Data_dostawy AS [Data dostawy],DM_Dostawa_maszyn.Uwagi AS [Uwagi]
FROM dbo.DM_Dostawa_maszyn INNER JOIN
DZ_Pracownik  ON DM_Dostawa_maszyn.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDM_Sklad_dostawy_maszyn
AS
SELECT DM_Dostawa_maszyn.Id_dostawy AS [Identyfikator dostawy], DM_Dostawca.Nazwa AS [Nazwa dostawcy],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny],DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zam?ienia],DM_Sklad_dostawy_maszyn.Ilosc AS [Ilo??, DM_Sklad_dostawy_maszyn.Cena_jednostkowa_maszyny AS [ Cena jednostkowa maszyny]
FROM dbo.DM_Sklad_dostawy_maszyn INNER JOIN
DM_Dostawa_maszyn  ON DM_Sklad_dostawy_maszyn.Id_dostawy=DM_Dostawa_maszyn.Id_dostawy INNER JOIN
DM_Dostawca ON DM_Sklad_dostawy_maszyn.Id_dostawcy=DM_Dostawca.Id_dostawcy INNER JOIN
DP_Maszyna  ON DM_Sklad_dostawy_maszyn.Id_maszyn=DP_Maszyna.Id_maszyny INNER JOIN
DZ_Zamowienie_zewn  ON DM_Sklad_dostawy_maszyn.Id_zamowienie_zewn=DZ_Zamowienie_zewn.Id_Zamowienia_zewn
GO
CREATE VIEW vDM_Sklad_dostawy_narzedzi
AS
SELECT DM_Sklad_dostawy_narzedzi.Id_dostawy AS [Identyfikator dostawy], DM_Dostawca.Nazwa AS [Nazwa dostawcy],DM_Narzedzie.Nazwa AS [Nazwa narz?zia],DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zam?ienia],DM_Sklad_dostawy_narzedzi.Ilosc AS [Ilo??, DM_Sklad_dostawy_narzedzi.Cena_jednostkowa_narzedzi AS [ Cena jednostkowa narz?zia]
FROM dbo.DM_Sklad_dostawy_narzedzi INNER JOIN
DM_Dostawa_maszyn  ON DM_Sklad_dostawy_narzedzi.Id_dostawy=DM_Dostawa_maszyn.Id_dostawy INNER JOIN
DM_Dostawca ON DM_Sklad_dostawy_narzedzi.Id_dostawcy=DM_Dostawca.Id_dostawcy INNER JOIN
DM_Narzedzie  ON DM_Sklad_dostawy_narzedzi.Id_narzedzia=DM_Narzedzie.Id_narzedzia INNER JOIN
DZ_Zamowienie_zewn  ON DM_Sklad_dostawy_narzedzi.Id_zamowienie_zewn=DZ_Zamowienie_zewn.Id_Zamowienia_zewn
GO

