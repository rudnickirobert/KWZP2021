USE Drukarnia
GO

CREATE VIEW vDM_Material
AS
SELECT Id_materialu AS [Numer materialu], DM_Rodzaj_materialu.Rodzaj_materialu AS [Rodzaj materialu], DM_Material.Nazwa AS [Nazwa materialu]
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
SELECT Id_narzedzia AS [Numer narzedzia], DM_Narzedzie.nazwa AS [Nazwa], DM_Rodzaj_narzedzia.Nazwa AS [Rodzaj narzedzia],Nr_seryjny AS [Numer seryjny], Data_zuzycia AS [Data zuzycia]
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
SELECT Id_maszyny AS [Numer maszyny], DP_Rodzaj_maszyny.Rodzaj_maszyny AS [Rodzaj maszyny], DP_Model_maszyny.Nazwa_modelu_maszyny AS [Nazwa modelu],nr_seryjny AS [Numer seryjny], data_wprowadzenia AS [Data wprowadzenia maszyny], koszt_1rh AS [Koszt 1 roboczo-godziny]
FROM     dbo.DP_Maszyna INNER JOIN
DP_Rodzaj_maszyny ON DP_Maszyna.Id_rodzaj_maszyny=DP_Rodzaj_maszyny.Id_rodzaj_maszyny INNER JOIN
DP_Model_maszyny ON DP_Maszyna.Id_model_maszyny=DP_Model_maszyny.Id_model_maszyny
GO
CREATE VIEW vDM_Czesc
AS
SELECT Id_czesci AS [Numer czesci], DM_Czesc.nazwa AS [Nazwa], DM_Czesc.ilosc_poczatkowa AS [Ilosc poczatkowa], DP_Model_maszyny.Nazwa_modelu_maszyny AS [Model maszyny]
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
SELECT Id_rachunki AS [Numer rachunku], DZ_Rodzaj_rachunku.Rodzaj_rachunku AS [Rodzaj rachunku], DZ_Rachunek.koszt AS [Koszt], data_zaplaty AS [Data zaplaty]
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
SELECT Id_nieobecnosci AS [Identyfikator nieobecnoœci], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika], DZ_Rodzaj_nieobecnosci.Rodzaj AS [Rodzaj nieobecnosci],DZ_Nieobecnosc.data_rozpoczecia AS [Data rozpoczecia], DZ_Nieobecnosc.data_zakonczenia AS [Data zakonczenia]
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
SELECT Id_zatrudnienia AS [Identyfikator zatrudnienia], DZ_Pracownik.Nazwisko AS [Nazwisko], DZ_Stanowisko.Stanowisko AS [Stanowisko],DZ_Dzial.Dzial AS [Dział], DZ_Etat.Etat AS [Etat], DZ_Rodzaj_umowy.Rodzaj_umowy AS[Rodzaj umowy],DZ_Zatrudnienie.Data_zatrudnienia AS[Data zatrudnienia], DZ_Zatrudnienie.Data_zwolnienia AS [Data zwolnienia],
(DATEDIFF(YEAR,Data_zatrudnienia,GETDATE())- CASE WHEN DATEPART(DAYOFYEAR, GETDATE())<DATEPART(DAYOFYEAR, Data_zatrudnienia) THEN 1 ELSE 0 END ) AS Staz,
Case when Data_zwolnienia>(TRY_CAST(('1900-01-01')as date)) then 'zwolniono'end  AS Zwolnienie
FROM     dbo.DZ_Zatrudnienie INNER JOIN
DZ_Pracownik ON DZ_Zatrudnienie.Id_pracownika=DZ_Pracownik.Id_pracownika INNER JOIN
DZ_Stanowisko ON DZ_Zatrudnienie.Id_stanowiska=DZ_Stanowisko.Id_stanowiska INNER JOIN
DZ_Dzial ON DZ_Zatrudnienie.Id_dzialu=DZ_Dzial.Id_dzialu INNER JOIN
DZ_Etat ON DZ_Zatrudnienie.Id_etatu=DZ_Etat.Id_etatu INNER JOIN
DZ_Rodzaj_umowy ON DZ_Zatrudnienie.Id_rodzaj_umowy=DZ_Rodzaj_umowy.Id_rodzaj_umowy
GO
CREATE VIEW vDZ_Szczegoly_zatrudnienia
AS
SELECT Id_szczegoly_zatrudnienia AS [Identyfikator szczegolow zatrudnienia], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika], data_zmiany_wynagrodzenia AS [Data zmiany wynagrodzenia], podstawa_wynagrodzenia AS [Podstawa wynagrodzenia]
FROM dbo.DZ_Szczegoly_zatrudnienia INNER JOIN 
DZ_Zatrudnienie ON DZ_Szczegoly_zatrudnienia.Id_zatrudnienia=DZ_Zatrudnienie.Id_zatrudnienia INNER JOIN
DZ_Pracownik ON DZ_Zatrudnienie.Id_zatrudnienia=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDZ_Zamowienie_klienta
AS
SELECT Id_zamowienia AS [Numer zamówienia], DZ_Klient.Nazwa_firmy AS [Nazwa firmy], DZ_Pracownik.Nazwisko AS [Pracownik przyjmujacy zamówienie], data_zamowienia AS [Data zamowienia], oczekiwany_termin_wykonania AS [Oczekiwany termin wykonania]
FROM dbo.DZ_Zamowienie_klienta INNER JOIN
DZ_Klient ON DZ_Zamowienie_klienta.Id_klienta=DZ_Klient.Id_klienta INNER JOIN
DZ_Pracownik ON DZ_Zamowienie_klienta.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDZ_Plik
AS
SELECT Id_pliku AS [Numer pliku], nazwa_pliku AS [Nazwa pliku], Rozszerzenie
FROM dbo.DZ_Plik
GO
CREATE VIEW vDZ_Szczegoly_zamowienia_klienta
AS
SELECT Id_szczegoly_zam_klienta AS [Identyfikator szczegolow zamowienia klienta], DZ_Zamowienie_klienta.Id_zamowienia AS [Numer zamowienia], DZ_Plik.Nazwa_pliku AS [Nazwa pliku], ilosc_sztuk AS [Ilosc sztuk], DM_Material.Nazwa AS [Nazwa materialu]
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
CREATE VIEW vDZ_Status_zamowienia
AS
SELECT Id_status_zam AS [Identyfikator statusu zamowienia],  DZ_Zamowienie_klienta.Id_zamowienia AS [Identyfikator zamowienia klienta], DZ_Rodzaj_statusu_zamowienia.Status_zam AS [Rodzaj statusu zamowienia]
FROM dbo.DZ_Status_zamowienia INNER JOIN
DZ_Zamowienie_klienta ON DZ_Status_zamowienia.Id_zamowienia=DZ_Zamowienie_klienta.Id_zamowienia INNER JOIN 
DZ_Rodzaj_statusu_zamowienia ON DZ_Status_zamowienia.Id_rodzaj_statusu_zam=DZ_Rodzaj_statusu_zamowienia.Id_rodzaj_statusu_zam
GO
CREATE VIEW vDZ_Zamowienie_zewn
AS
SELECT Id_zamowienia_zewn AS [Numer zamowienia], DZ_Pracownik.Nazwisko AS [Pracownik skladajacy zamówienie], data_zamowienia_zewn AS [Data zamowienia]
FROM DZ_Zamowienie_zewn INNER JOIN
DZ_Pracownik ON DZ_Zamowienie_zewn.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDZ_Szczegoly_zam_maszyn
AS
SELECT Id_szczegoly_zam_maszyn AS [Identyfikator szczegolow zamowienia maszyn], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamówienia], DP_Maszyna.Nr_seryjny AS [Numer seryjny], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], ilosc AS [Ilosc]
FROM dbo.DZ_Szczegoly_zam_maszyn INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_maszyn.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DP_Maszyna ON DZ_Szczegoly_zam_maszyn.Id_maszyny=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDZ_Szczegoly_zam_materialu
AS
SELECT Id_szczegoly_zam_materialu AS [Identyfikator szczegolow zamowienia materialu], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia], DM_Material.Nazwa AS [Nazwa materiału], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], DM_Wlasciwosc.Jednostka_pomiarowa AS [Jednostka pomiarowa], ilosc AS [Ilosc]
FROM dbo.DZ_Szczegoly_zam_materialu INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_materialu.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DM_Material ON DZ_Szczegoly_zam_materialu.Id_materialu=DM_Material.Id_materialu INNER JOIN
DM_Wlasciwosc ON DZ_Szczegoly_zam_materialu.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO
CREATE VIEW vDZ_Szczegoly_zam_czesci
AS
SELECT Id_szczegoly_zam_czesci AS [Identyfikator szczegolow zamowienia czesci], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia], DM_Czesc.Nazwa AS [Nazwa], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], DM_Wlasciwosc.Jednostka_pomiarowa AS [Jednostka pomiarowa], ilosc AS [Ilosc]
FROM dbo.DZ_Szczegoly_zam_czesci INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_czesci.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DM_Czesc ON DZ_Szczegoly_zam_czesci.Id_czesci=DM_Czesc.Id_czesci INNER JOIN
DM_Wlasciwosc ON DZ_Szczegoly_zam_czesci.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO
CREATE VIEW vDZ_Szczegoly_zam_narzedzi
AS
SELECT Id_szczegoly_zam_narzedzi AS [Identyfikator szczegolow zamowienia narzedzi], DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia], DM_Narzedzie.Nazwa AS [Nazwa narzedzia], koszt_jednostkowy_oferta AS [Koszt jednostkowy oferty], DM_Wlasciwosc.Jednostka_pomiarowa AS [Jednostka pomiarowa], ilosc AS [Ilosc]
FROM dbo.DZ_Szczegoly_zam_narzedzi INNER JOIN
DZ_Zamowienie_zewn ON DZ_Szczegoly_zam_narzedzi.Id_zamowienia_zewn=DZ_Zamowienie_zewn.Id_zamowienia_zewn INNER JOIN
DM_Narzedzie ON DZ_Szczegoly_zam_narzedzi.Id_narzedzia=DM_Narzedzie.Id_narzedzia INNER JOIN
DM_Wlasciwosc ON DZ_Szczegoly_zam_narzedzi.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO

CREATE VIEW vDZ_Po_szczegoly_zam_produkt
AS
SELECT DZ_Szczegoly_zamowienia_klienta.Id_szczegoly_zam_klienta AS [Identyfikator szczegolow produktu], DP_Produkt.Nazwa_produktu AS [Numer produktu]
FROM dbo.DZ_Po_szczegoly_zam_produkt INNER JOIN
DZ_Szczegoly_zamowienia_klienta ON DZ_Po_szczegoly_zam_produkt.Id_szczegoly_zam_klienta=DZ_Szczegoly_zamowienia_klienta.Id_szczegoly_zam_klienta INNER JOIN
DP_Produkt ON DZ_Po_szczegoly_zam_produkt.Id_produkt=DP_Produkt.Id_produkt
GO

CREATE VIEW vDM_Magazyn_gotowych_produktow
AS
SELECT Id_Magazynu_gotowych_produktow AS [Identyfikator magazynu], DZ_Zamowienie_klienta.Id_zamowienia AS [Numer zamowienia], Data_i_godzina_przyjecia AS [Data i godzina przyjecia], Uwagi
FROM dbo.DM_Magazyn_gotowych_produktow INNER JOIN
DZ_Zamowienie_klienta ON DM_Magazyn_gotowych_produktow.Id_zamowienie=DZ_Zamowienie_klienta.Id_Zamowienia
GO

CREATE VIEW vDM_Wydanie_produktu
AS
SELECT Id_wydania AS [Identyfikator wydania produktu], DM_Magazyn_gotowych_produktow.Id_Magazynu_gotowych_produktow AS [Numer zamowienia], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wydajacego], Data_i_godzina, DM_Wydanie_produktu.Uwagi AS [Uwagi]
FROM dbo.DM_Wydanie_produktu INNER JOIN
DM_Magazyn_gotowych_produktow ON DM_Wydanie_produktu.Id_magazyn_gotowych_produktow=DM_Magazyn_gotowych_produktow.Id_magazynu_gotowych_produktow INNER JOIN
DZ_Pracownik ON DM_Wydanie_produktu.Id_pracownika =DZ_Pracownik.Id_pracownika
GO

CREATE VIEW vDM_Szczegoly_wydania_produktu
AS
SELECT DM_Szczegoly_wydania_produktu.Id_szczegoly_wydania_produktu, DM_Wydanie_produktu.Id_wydania AS [Identyfikator wydania], DP_Produkt.Nazwa_produktu AS [Nazwa produktu], DM_Szczegoly_wydania_produktu.Ilosc AS [Ilosc]
FROM dbo.DM_Szczegoly_wydania_produktu INNER JOIN
DM_Wydanie_produktu ON DM_Szczegoly_wydania_produktu.Id_wydania=DM_Wydanie_produktu.Id_wydania INNER JOIN
DP_Produkt ON DM_Szczegoly_wydania_produktu.Id_produkt=DP_Produkt.Id_Produkt
GO

CREATE VIEW vDM_Wypozyczenie_narzedzia
AS
SELECT Id_wypozyczenia_narzedzia AS [Identyfikator wypozyczenia], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wypozyczajacego],Data_i_godzina_wypozyczenia AS [Data i godzina wypozyczenia], Data_i_godzina_zwrotu AS [Data i godzina zwrotu], DM_Wypozyczenie_narzedzia.Uwagi AS [Uwagi]
FROM dbo.DM_Wypozyczenie_narzedzia INNER JOIN
DZ_Pracownik  ON DM_Wypozyczenie_narzedzia.Id_pracownika_wypozyczajacego=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDM_Szczegoly_wypozyczenia_narzedzia
AS
SELECT DM_Szczegoly_wypozyczenia_narzedzia.Id_wypozyczenia_narzedzia, DM_Wypozyczenie_narzedzia.Id_wypozyczenia_narzedzia AS [Identyfikator wypozyczenia], DM_Narzedzie.Nazwa AS [Nazwa narzedzia], DM_Szczegoly_wypozyczenia_narzedzia.Ilosc AS [Ilosc]
FROM dbo.DM_Szczegoly_wypozyczenia_narzedzia INNER JOIN
DM_Wypozyczenie_narzedzia  ON DM_Szczegoly_wypozyczenia_narzedzia.Id_wypozyczenia_narzedzia=DM_Wypozyczenie_narzedzia.Id_wypozyczenia_narzedzia INNER JOiN
DM_Narzedzie ON DM_Szczegoly_wypozyczenia_narzedzia.Id_narzedzia=DM_Narzedzie.Id_narzedzia
GO
CREATE VIEW vDM_Parametr_narzedzia
AS
SELECT Id_parametru, DM_Narzedzie.Nazwa AS [Nazwa narzedzia], DM_Wlasciwosc.Nazwa_wlasciwosci AS [Wlasciwosc], DM_Parametr_narzedzia.Wartosc AS [Wartosc], DM_Wlasciwosc.Jednostka_pomiarowa AS [Jednostka pomiarowa]
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
SELECT DM_Dostawa_maszyn.Id_dostawy AS [Identyfikator dostawy], DM_Dostawca.Nazwa AS [Nazwa dostawcy],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny],DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia],DM_Sklad_dostawy_maszyn.Ilosc AS [Ilosc], DM_Sklad_dostawy_maszyn.Cena_jednostkowa_maszyny AS [Cena jednostkowa maszyny]
FROM dbo.DM_Sklad_dostawy_maszyn INNER JOIN
DM_Dostawa_maszyn  ON DM_Sklad_dostawy_maszyn.Id_dostawy=DM_Dostawa_maszyn.Id_dostawy INNER JOIN
DM_Dostawca ON DM_Sklad_dostawy_maszyn.Id_dostawcy=DM_Dostawca.Id_dostawcy INNER JOIN
DP_Maszyna  ON DM_Sklad_dostawy_maszyn.Id_maszyn=DP_Maszyna.Id_maszyny INNER JOIN
DZ_Zamowienie_zewn  ON DM_Sklad_dostawy_maszyn.Id_zamowienie_zewn=DZ_Zamowienie_zewn.Id_Zamowienia_zewn
GO
CREATE VIEW vDM_Sklad_dostawy_narzedzi
AS
SELECT DM_Sklad_dostawy_narzedzi.Id_dostawy AS [Identyfikator dostawy], DM_Dostawca.Nazwa AS [Nazwa dostawcy],DM_Narzedzie.Nazwa AS [Nazwa narzedzia],DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia],DM_Sklad_dostawy_narzedzi.Ilosc AS [Ilosc], DM_Sklad_dostawy_narzedzi.Cena_jednostkowa_narzedzi AS [Cena jednostkowa narzedzia]
FROM dbo.DM_Sklad_dostawy_narzedzi INNER JOIN
DM_Dostawa_maszyn  ON DM_Sklad_dostawy_narzedzi.Id_dostawy=DM_Dostawa_maszyn.Id_dostawy INNER JOIN
DM_Dostawca ON DM_Sklad_dostawy_narzedzi.Id_dostawcy=DM_Dostawca.Id_dostawcy INNER JOIN
DM_Narzedzie  ON DM_Sklad_dostawy_narzedzi.Id_narzedzia=DM_Narzedzie.Id_narzedzia INNER JOIN
DZ_Zamowienie_zewn  ON DM_Sklad_dostawy_narzedzi.Id_zamowienie_zewn=DZ_Zamowienie_zewn.Id_Zamowienia_zewn
GO
CREATE VIEW vDM_Sklad_dostawy_czesci
AS
SELECT DM_Sklad_dostawy_czesci.Id_dostawy_czesci, DM_Sklad_dostawy_czesci.Id_dostawy AS [Identyfikator dostawy], DM_Dostawca.Nazwa AS [Nazwa dostawcy],DM_Czesc.Nazwa AS [Nazwa czesci],DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia],DM_Sklad_dostawy_czesci.Ilosc AS [Ilosc], DM_Sklad_dostawy_czesci.Cena_jednostkowa_czesci AS [Cena jednostkowa czesci]
FROM dbo.DM_Sklad_dostawy_czesci INNER JOIN
DM_Dostawa_maszyn  ON DM_Sklad_dostawy_czesci.Id_dostawy=DM_Dostawa_maszyn.Id_dostawy INNER JOIN
DM_Dostawca ON DM_Sklad_dostawy_czesci.Id_dostawcy=DM_Dostawca.Id_dostawcy INNER JOIN
DM_Czesc  ON DM_Sklad_dostawy_czesci.Id_czesci =DM_Czesc.Id_czesci INNER JOIN
DZ_Zamowienie_zewn  ON DM_Sklad_dostawy_czesci.Id_zamowienie_zewn=DZ_Zamowienie_zewn.Id_Zamowienia_zewn
GO
CREATE VIEW vDM_Sklad_dostawy_materialu
AS
SELECT  DM_Sklad_dostawy_materialu.Id_dostawy_mate, DM_Sklad_dostawy_materialu.Id_dostawy AS [Identyfikator dostawy], DM_Dostawca.Nazwa AS [Nazwa dostawcy],DM_Material.Nazwa AS [Nazwa materialu],DZ_Zamowienie_zewn.Id_zamowienia_zewn AS [Numer zamowienia],DM_Sklad_dostawy_materialu.Ilosc AS [Ilosc], DM_Sklad_dostawy_materialu.Cena_jednostkowa_materialu AS [Cena jednostkowa materialu]
FROM dbo.DM_Sklad_dostawy_materialu INNER JOIN
DM_Dostawa_maszyn  ON DM_Sklad_dostawy_materialu.Id_dostawy=DM_Dostawa_maszyn.Id_dostawy INNER JOIN
DM_Dostawca ON DM_Sklad_dostawy_materialu.Id_dostawcy=DM_Dostawca.Id_dostawcy INNER JOIN
DM_Material  ON DM_Sklad_dostawy_materialu.Id_materialu =DM_Material.Id_materialu INNER JOIN
DZ_Zamowienie_zewn  ON DM_Sklad_dostawy_materialu.Id_zamowienie_zewn=DZ_Zamowienie_zewn.Id_Zamowienia_zewn
GO
CREATE VIEW vDM_Wydanie_czesci
AS
SELECT Id_wydania_czesci AS [Identyfikator wypozyczenia], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wypozyczajacego], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wydajacego],DM_Wydanie_czesci.Data_i_godzina AS [Data i godzina wydania], DM_Wydanie_czesci.Uwagi AS [ Uwagi]
FROM dbo.DM_Wydanie_czesci INNER JOIN
DZ_Pracownik  ON DM_Wydanie_czesci.Id_pracownik_pobierajacy&DM_Wydanie_czesci.Id_pracownik_wydajacy=DZ_Pracownik.Id_pracownika
GO

CREATE VIEW vDM_Szczegoly_wydania_czesci
AS
SELECT Id_szczegolow_wydania_czesci, DM_Wydanie_czesci.Id_wydania_czesci AS [Identyfikator wydania], DM_Czesc.Nazwa AS [Nazwa czesci], DM_Szczegoly_wydania_czesci.Ilosc AS [Ilosc]
FROM dbo.DM_Szczegoly_wydania_czesci INNER JOIN
DM_Wydanie_czesci  ON DM_Szczegoly_wydania_czesci.Id_wydania_czesci=DM_Wydanie_czesci.Id_wydania_czesci INNER JOIN
DM_Czesc ON DM_Szczegoly_wydania_czesci. Id_czesci=DM_Czesc.Id_czesci
GO

CREATE VIEW vDM_Parametr_czesci
AS
SELECT DM_Parametr_czesci.Id_parametr_czesci, DM_Czesc.Nazwa AS [Nazwa czesci], DM_wlasciwosc.Nazwa_wlasciwosci AS [Wlasciwosc], Wartosc
FROM dbo.DM_Parametr_czesci INNER JOIN
DM_czesc  ON DM_Parametr_czesci.Id_czesci=DM_czesc.Id_czesci INNER JOIN
DM_wlasciwosc ON DM_Parametr_czesci. Id_wlasciwosc=DM_wlasciwosc.Id_wlasciwosc
GO

CREATE VIEW vDM_Wybor_maszyny
AS
SELECT DP_Model_maszyny.Nazwa_modelu_maszyny AS [Nazwa modelu], DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny]
FROM dbo.DM_Wybor_maszyny INNER JOIN
DP_Model_maszyny  ON DM_Wybor_maszyny.Id_model_maszyny=DP_Model_maszyny.Id_model_maszyny INNER JOIN
DP_Maszyna ON DM_Wybor_maszyny. Id_maszyny=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDM_Wydanie_materialu_dla_produkcji
AS
SELECT Id_wydanie_materialu_dla_produkcji AS [Identyfikator wydania materialu], DZ_Zamowienie_klienta.Id_zamowienia AS [Numer zamówienia], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika pobierajacego],DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wydajacego],DM_Wydanie_materialu_dla_produkcji.Data_i_godzina AS [Data i godzina]
FROM dbo.DM_Wydanie_materialu_dla_produkcji INNER JOIN
DZ_Zamowienie_klienta  ON DM_Wydanie_materialu_dla_produkcji.Id_zamowienia=DZ_Zamowienie_klienta.Id_Zamowienia INNER JOIN
DZ_Pracownik ON DM_Wydanie_materialu_dla_produkcji.Id_pracownik_pobierajacy&DM_Wydanie_materialu_dla_produkcji.Id_pracownik_wydajacy=DZ_Pracownik.Id_pracownika 
GO
CREATE VIEW vDM_Szczegoly_wydania_materialu
AS
SELECT DM_Wydanie_materialu_dla_produkcji.Id_wydanie_materialu_dla_produkcji AS [Identyfikator wydania], DM_Material.Nazwa [Nazwa materialu]
FROM dbo.DM_Szczegoly_wydania_materialu INNER JOIN
DM_Wydanie_materialu_dla_produkcji ON DM_Szczegoly_wydania_materialu.Id_wydanie_materialu_dla_produkcji =DM_Wydanie_materialu_dla_produkcji.Id_wydanie_materialu_dla_produkcji INNER JOIN
DM_Material ON DM_Szczegoly_wydania_materialu. Id_materialu=DM_Material.Id_materialu
GO
CREATE VIEW vDM_Szczegoly_magazynu_gotowych_produktow
AS
SELECT DM_Magazyn_gotowych_produktow.Id_magazynu_gotowych_produktow AS [Identyfikator magazynu], DP_Produkt.Nazwa_produktu [Nazwa produktu],DM_Szczegoly_magazynu_gotowych_produktow.Ilosc AS [Ilosc]
FROM dbo.DM_Szczegoly_magazynu_gotowych_produktow INNER JOIN
DM_Magazyn_gotowych_produktow ON DM_Szczegoly_magazynu_gotowych_produktow.Id_magazynu_gotowych_produktow =DM_Magazyn_gotowych_produktow.Id_magazynu_gotowych_produktow INNER JOIN
DP_Produkt ON DM_Szczegoly_magazynu_gotowych_produktow. Id_produktu=DP_Produkt.Id_produkt
GO
CREATE VIEW vDM_Wydanie_czesci_dla_produkcji
AS
SELECT Id_wydania_czesci AS [Identyfikator wydania materialu], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika pobierajacego],DZ_Pracownik.Nazwisko AS [Nazwisko pracownika wydajacego],DM_Wydanie_czesci_dla_produkcji.Data_i_godzina_wydania AS [Data i godzina wydania], DM_Wydanie_czesci_dla_produkcji.Uwagi AS [Uwagi]
FROM dbo.DM_Wydanie_czesci_dla_produkcji INNER JOIN
DZ_Pracownik ON DM_Wydanie_czesci_dla_produkcji.Id_pracownik_pobierajacy&DM_Wydanie_czesci_dla_produkcji.Id_pracownik_wydajacy=DZ_Pracownik.Id_pracownika 
GO
CREATE VIEW vDP_Wydruk
AS
SELECT Id_wydruk AS [Identyfikator wydruku], Wypelnienie AS [Wypelnienie],Estymowany_czas AS [Estymowany czas wydruku],Estymowana_masa AS [Estymowana masa wydruku], DZ_Plik.Nazwa_pliku AS [Nazwa pliku]
FROM dbo.DP_Wydruk INNER JOIN
DZ_Plik ON DP_Wydruk.Id_pliku=DZ_Plik.Id_pliku
GO
CREATE VIEW vDP_Proces_technologiczny
AS
SELECT Id_proces_technologiczny AS [Identyfikator procesu technologicznego], DP_Proces_technologiczny.Nazwa AS [Nazwa]
FROM dbo.DP_Proces_technologiczny
GO
CREATE VIEW vDP_Po_wydr_proc
AS
SELECT Id_po_wydr_proces AS [Identyfikator], DP_Wydruk.Id_wydruk AS [Identyfikator wydruku], DP_Proces_technologiczny.Nazwa AS [Nazwa procesu technologicznego], DP_Po_wydr_proc.Czas_zamierzony
FROM dbo.DP_Po_wydr_proc INNER JOIN
DP_Wydruk ON DP_Po_wydr_proc.Id_wydruk=DP_Wydruk.Id_wydruk INNER JOIN
DP_Proces_technologiczny ON DP_Po_wydr_proc.Id_proces_technologiczny=DP_Proces_technologiczny.Id_proces_technologiczny
GO
CREATE VIEW vDP_Po_material_wydruk
AS
SELECT DM_Material.Nazwa AS [Nazwa materialu], DP_po_wydr_proc.Id_wydruk [Identyfikator wydruku],DP_Po_material_wydruk.Ilosc AS [Ilosc materialu]
FROM dbo.DP_Po_material_wydruk INNER JOIN
DM_Material ON DP_Po_material_wydruk.Id_materialu=DM_Material.Id_materialu INNER JOIN
DP_po_wydr_proc ON DP_Po_material_wydruk.Id_po_wydr_proc=DP_po_wydr_proc.Id_po_wydr_proces
GO
CREATE VIEW vDP_Rodzaj_czynnosci
AS
SELECT Id_rodzaj_czynnosci AS [Identyfikator czynnosci], DP_Rodzaj_czynnosci.Nazwa AS [Nazwa czynnosci]
FROM dbo.DP_Rodzaj_czynnosci
GO
CREATE VIEW vDP_Po_proc_czynnosc
AS
SELECT Id_po_proc_czynnosci AS [Identyfikator], DP_Rodzaj_czynnosci.Nazwa AS [Nazwa czynnosci],DP_Proces_technologiczny.Nazwa AS [Nazwa procesu technologicznego],DP_Po_proc_czynnosc.Czas_zamierzony AS [Czas zamierzony]
FROM dbo.DP_Po_proc_czynnosc INNER JOIN
DP_Rodzaj_czynnosci ON DP_Po_proc_czynnosc.Id_rodzaj_czynnosci=DP_Rodzaj_czynnosci.Id_rodzaj_czynnosci INNER JOIN
DP_Proces_technologiczny ON DP_Po_proc_czynnosc.Id_proces_technologiczny=DP_Proces_technologiczny.Id_proces_technologiczny
GO
CREATE VIEW vDP_Po_narzedzia_czynnosc
AS
SELECT DP_Po_proc_czynnosc.Id_po_proc_czynnosci AS [Identyfikator], DM_Narzedzie.Nazwa AS [Nazwa narzedzia]
FROM dbo.DP_Po_narzedzia_czynnosc INNER JOIN
DP_Po_proc_czynnosc ON DP_Po_narzedzia_czynnosc.Id_po_proc_czynnosci=DP_Po_proc_czynnosc.Id_po_proc_czynnosci INNER JOIN
DM_Narzedzie ON DP_Po_narzedzia_czynnosc.Id_narzedzia=DM_Narzedzie.Id_narzedzia
GO
CREATE VIEW vDP_Po_maszyna_czynnosc
AS
SELECT DP_Po_proc_czynnosc.Id_po_proc_czynnosci AS [Identyfikator], DP_Maszyna.Nr_seryjny [Numer seryjny maszyny]
FROM dbo.DP_Po_maszyna_czynnosc INNER JOIN
DP_Po_proc_czynnosc ON DP_Po_maszyna_czynnosc.Id_po_proc_czynnosci=DP_Po_proc_czynnosc.Id_po_proc_czynnosci INNER JOIN
DP_Maszyna ON DP_Po_maszyna_czynnosc.Id_maszyny=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDP_Po_prac_czynnosc
AS
SELECT DP_Po_proc_czynnosc.Id_po_proc_czynnosci AS [Identyfikator], DZ_Pracownik.Nazwisko AS [Nazwisko pracownika]
FROM dbo.DP_Po_prac_czynnosc INNER JOIN
DP_Po_proc_czynnosc ON DP_Po_prac_czynnosc.Id_po_proc_czynnosci=DP_Po_proc_czynnosc.Id_po_proc_czynnosci INNER JOIN
DZ_pracownik ON DP_Po_prac_czynnosc.Id_pracownika=DZ_pracownik.Id_pracownika
GO
CREATE VIEW vDP_Po_material_czynnosc
AS
SELECT DP_Po_proc_czynnosc.Id_po_proc_czynnosci AS [Identyfikator], DM_Material.Nazwa AS [Nazwa materialu], DP_Po_material_czynnosc.Ilosc AS [Ilosc materialu]
FROM dbo.DP_Po_material_czynnosc INNER JOIN
DP_Po_proc_czynnosc ON DP_Po_material_czynnosc.Id_po_proc_czynnosci=DP_Po_proc_czynnosc.Id_po_proc_czynnosci INNER JOIN
DM_Material ON DP_Po_material_czynnosc.Id_materialu=DM_Material.Id_materialu
GO
CREATE VIEW vDP_Po_maszyna_wydruk
AS
SELECT DP_Po_wydr_proc.Id_po_wydr_proces [Identyfikator], DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny]
FROM dbo.DP_Po_maszyna_wydruk INNER JOIN
DP_Po_wydr_proc ON DP_Po_maszyna_wydruk.Id_po_wydr_proces=DP_Po_wydr_proc.Id_po_wydr_proces INNER JOIN
DP_Maszyna ON DP_Po_maszyna_wydruk.Id_maszyny=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDP_Proces_produkt
AS
SELECT DP_Proces_technologiczny.Nazwa [Nazwa procesu technologicznego], DP_Produkt.Nazwa_produktu AS [Nazwa produktu]
FROM dbo.DP_Proces_produkt INNER JOIN
DP_Proces_technologiczny ON DP_Proces_produkt.Id_proces_technologiczny=DP_Proces_technologiczny.Id_proces_technologiczny INNER JOIN
DP_Produkt ON DP_Proces_produkt.Id_produkt=DP_Produkt.Id_produkt
GO
CREATE VIEW vDP_Proces_produkcyjny
AS
SELECT Id_proces_produkcyjny AS [Identyfikator procesu produkcyjnego],DP_Proces_technologiczny.Nazwa [Nazwa procesu technologicznego], Data_realizacji AS [Data realizacji]
FROM dbo.DP_Proces_produkcyjny INNER JOIN
DP_Proces_technologiczny ON DP_Proces_produkcyjny.Id_proces_technologiczny=DP_Proces_technologiczny.Id_proces_technologiczny
GO
CREATE VIEW vDP_prod_material
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny AS [Identyfikator procesu produkcyjnego],DM_Material.Nazwa AS [Nazwa materialu]
FROM dbo.DP_prod_material INNER JOIN
DP_Proces_produkcyjny ON DP_prod_material.Id_proces_produkcyjny=DP_Proces_produkcyjny.Id_proces_produkcyjny INNER JOIN
DM_Material ON DP_prod_material.Id_materialu=DM_Material.Id_materialu
GO
CREATE VIEW vDP_prod_wydruk
AS
SELECT Id_prod_wydruk AS [Identyfikator procesu wydruku],DP_Proces_produkcyjny.Id_proces_produkcyjny AS [Identyfikator procesu produkcyjnego],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny],DP_prod_wydruk.Czas_wydruku AS [Czas wydruku]
FROM dbo.DP_prod_wydruk INNER JOIN
DP_Proces_produkcyjny ON DP_prod_wydruk.Id_proces_produkcyjny=DP_Proces_produkcyjny.Id_proces_produkcyjny INNER JOIN
DP_Maszyna ON DP_prod_wydruk.Id_maszyny=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDP_prod_czynnosc_dodatkowa
AS
SELECT Id_prod_czynnosci_dodatkowe AS [Identyfikator czynnosci dodatkowej],DP_Proces_produkcyjny.Id_proces_produkcyjny AS [Identyfikator procesu produkcyjnego],DP_Rodzaj_czynnosci.Nazwa AS [Nazwa czynnosci],DP_prod_czynnosc_dodatkowa.Czas_pracy AS [Czas pracy]
FROM dbo.DP_prod_czynnosc_dodatkowa INNER JOIN
DP_Proces_produkcyjny ON DP_prod_czynnosc_dodatkowa.Id_proces_produkcyjny=DP_Proces_produkcyjny.Id_proces_produkcyjny INNER JOIN
DP_Rodzaj_czynnosci ON DP_prod_czynnosc_dodatkowa.Id_rodzaj_czynnosci=DP_Rodzaj_czynnosci.Id_rodzaj_czynnosci
GO
CREATE VIEW vDP_po_prod_czyn_dod_maszyna
AS
SELECT DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe AS [Identyfikator czynnosci dodatkowej],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny]
FROM dbo.DP_po_prod_czyn_dod_maszyna INNER JOIN
DP_prod_czynnosc_dodatkowa ON DP_po_prod_czyn_dod_maszyna.Id_prod_czynnosci_dodatkowe=DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe INNER JOIN
DP_Maszyna ON DP_po_prod_czyn_dod_maszyna.Id_maszyna=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDP_po_prod_czyn_dod_pracownik
AS
SELECT DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe AS [Identyfikator czynnosci dodatkowej],DZ_Pracownik.Nazwisko AS [Nazwisko pracownika]
FROM dbo.DP_po_prod_czyn_dod_pracownik INNER JOIN
DP_prod_czynnosc_dodatkowa ON DP_po_prod_czyn_dod_pracownik.Id_prod_czynnosci_dodatkowe=DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe INNER JOIN
DZ_Pracownik ON DP_po_prod_czyn_dod_pracownik.Id_pracownika=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDP_Zuzyta_maszyna
AS
SELECT Id_zuzyte_maszyny AS [Identyfikator zuzycia maszyny],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny], Data_zuzycia_maszyny AS [Data zuzycia],DP_Zuzyta_maszyna.Uwagi AS [Uwagi]
FROM dbo.DP_Zuzyta_maszyna INNER JOIN
DP_Maszyna ON DP_Zuzyta_maszyna.Id_maszyny=DP_Maszyna.Id_maszyny
GO
CREATE VIEW vDP_Nazwa_obslugi
AS
SELECT Id_nazwa_obslugi AS [Identyfikator nazwy obslugi],Nazwa_obslugi AS [Nazwa obslugi]
FROM dbo.DP_Nazwa_obslugi
GO
CREATE VIEW vDP_Czynnosc
AS
SELECT Id_czynnosc AS [Identyfikator nazwy czynnosci],Nazwa_czynnosci AS [Nazwa czynnosci]
FROM dbo.DP_Czynnosc
GO
CREATE VIEW vDP_Czynnosc_w_ramach_obslugi_serw_wew
AS
SELECT Id_czynnosc_w_ramach_obslugi_serw_wew AS [Identyfikator],DP_Nazwa_obslugi.Nazwa_obslugi AS [Nazwa obslugi], DP_Czynnosc.Nazwa_czynnosci AS [Nazwa czynnosci]
FROM dbo.DP_Czynnosc_w_ramach_obslugi_serw_wew INNER JOIN
DP_Nazwa_obslugi ON DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_nazwa_obslugi=DP_Nazwa_obslugi.Id_nazwa_obslugi INNER JOIN
DP_Czynnosc ON DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_czynnosc=DP_Czynnosc.Id_czynnosc
GO
CREATE VIEW vDP_Co_ile_obsluga
AS
SELECT Id_co_ile_obsluga AS [Identyfikator],Co_ile_obsluga AS [Czas miedzy obslugami]
FROM dbo.DP_Co_ile_obsluga
GO
CREATE VIEW vDP_Obsluga
AS
SELECT Id_obslugi AS [Identyfikator obslugi],DP_Nazwa_obslugi.Nazwa_obslugi AS [Nazwa obslugi], DP_Rodzaj_maszyny.Rodzaj_maszyny AS [Rodzaj maszyny],DP_Co_ile_obsluga.Co_ile_obsluga[Czas miedzy obslugami]
FROM dbo.DP_Obsluga INNER JOIN
DP_Nazwa_obslugi ON DP_Obsluga.Id_nazwa_obslugi=DP_Nazwa_obslugi.Id_nazwa_obslugi INNER JOIN
DP_Rodzaj_maszyny ON DP_Obsluga.Id_rodzaj_maszyny=DP_Rodzaj_maszyny.Id_rodzaj_maszyny INNER JOIN
DP_Co_ile_obsluga ON DP_Obsluga.Id_co_ile_obsluga=DP_Co_ile_obsluga.Id_co_ile_obsluga
GO
CREATE VIEW vDP_Usluga_serwisu_zewnetrznego
AS
SELECT Id_usluga_serwisu_zewnetrznego AS [Identyfikator],Nazwa_uslugi_serwisu_zewnetrznego AS [Nazwa obslugi]
FROM dbo.DP_Usluga_serwisu_zewnetrznego
GO
CREATE VIEW vDP_Firma_serwisowa
AS
SELECT Id_firma_serwisowa AS [Identyfikator firmy],Nazwa_firmy AS [Nazwa firmy],Adres,Miasto,Kod_pocztowy AS [Kod pocztowy],Nr_tel AS [Numer telefonu], DP_Firma_serwisowa.E_mail AS[E-mail]
FROM dbo.DP_Firma_serwisowa
GO
CREATE VIEW vDP_Serwis_zewnetrzny
AS
SELECT Id_serwis_zewnetrzny AS [Id serwisu zewnetrznego], DP_Firma_serwisowa.Nazwa_firmy AS [Nazwa firmy serwisowej],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny],DP_Usluga_serwisu_zewnetrznego.Nazwa_uslugi_serwisu_zewnetrznego AS [Nazwa usługi],DP_Serwis_zewnetrzny.Koszt AS [Koszt], DP_Serwis_zewnetrzny.Data_rozpoczecia AS [Data rozpoczecia serwisu], DP_Serwis_zewnetrzny.Data_zakonczenia AS [Data zakonczenia serwisu],DP_Serwis_zewnetrzny.Uwagi AS [Uwagi]
FROM dbo.DP_Serwis_zewnetrzny INNER JOIN
DP_Firma_serwisowa ON DP_Serwis_zewnetrzny.Id_firma_serwisowa=DP_Firma_serwisowa.Id_firma_serwisowa INNER JOIN
DP_Maszyna ON DP_Serwis_zewnetrzny.Id_maszyny=DP_Maszyna.Id_maszyny INNER JOIN
DP_Usluga_serwisu_zewnetrznego ON DP_Serwis_zewnetrzny.Id_usluga_serwisu_zewnetrznego=DP_Usluga_serwisu_zewnetrznego.Id_usluga_serwisu_zewnetrznego
GO
CREATE VIEW vDP_Serwis_wewnetrzny_naprawa
AS
SELECT Id_serwis_wewnetrzny_naprawa AS [Id serwisu wewnetrznego naprawy],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny],DZ_Pracownik.Nazwisko AS [Nazwisko pracownika serwisujacego ], DP_Serwis_wewnetrzny_naprawa.Data_rozpoczecia AS [Data rozpoczecia serwisu], DP_Serwis_wewnetrzny_naprawa.Data_zakonczenia AS [Data zakonczenia serwisu],DP_Serwis_wewnetrzny_naprawa.Uwagi AS [Uwagi]
FROM dbo.DP_Serwis_wewnetrzny_naprawa INNER JOIN
DP_Maszyna ON DP_Serwis_wewnetrzny_naprawa.Id_maszyny=DP_Maszyna.Id_maszyny INNER JOIN
DZ_Pracownik ON DP_Serwis_wewnetrzny_naprawa.Id_pracownik=DZ_Pracownik.Id_pracownika
GO
CREATE VIEW vDP_Serwis_wewnetrzny_obsluga
AS
SELECT Id_serwis_wewnetrzny_obsluga AS [Id serwisu wewnetrznego obslugi],DP_Maszyna.Nr_seryjny AS [Numer seryjny maszyny],DZ_Pracownik.Nazwisko AS [Nazwisko pracownika serwisujacego ],DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_czynnosc_w_ramach_obslugi_serw_wew AS [Identyfikator czynnosci],DP_Serwis_wewnetrzny_obsluga.Data_rozpoczecia AS [Data rozpoczecia serwisu], DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia AS [Data zakonczenia serwisu]
FROM dbo.DP_Serwis_wewnetrzny_obsluga INNER JOIN
DP_Maszyna ON DP_Serwis_wewnetrzny_obsluga.Id_maszyny=DP_Maszyna.Id_maszyny INNER JOIN
DZ_Pracownik ON DP_Serwis_wewnetrzny_obsluga.Id_pracownik=DZ_Pracownik.Id_pracownika INNER JOIN
DP_Czynnosc_w_ramach_obslugi_serw_wew ON DP_Serwis_wewnetrzny_obsluga.Id_czynnosc_w_ramach_obslugi_serw_wew=DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_czynnosc_w_ramach_obslugi_serw_wew
GO
CREATE VIEW vDP_Narzedzie_uzyte_obsluga
AS
SELECT DM_Narzedzie.Nazwa AS [Nazwa narzedzia], DP_Serwis_wewnetrzny_obsluga.Id_serwis_wewnetrzny_obsluga AS [Identyfikator serwisu]
FROM dbo.DP_Narzedzie_uzyte_obsluga INNER JOIN
DM_Narzedzie ON DP_Narzedzie_uzyte_obsluga.Id_narzedzia=DM_Narzedzie.Id_narzedzia INNER JOIN
DP_Serwis_wewnetrzny_obsluga ON DP_Narzedzie_uzyte_obsluga.Id_serwis_wewnetrzny_obsluga=DP_Serwis_wewnetrzny_obsluga.Id_serwis_wewnetrzny_obsluga
GO
CREATE VIEW vDP_Narzedzie_uzyte_naprawa
AS
SELECT DM_Narzedzie.Nazwa AS [Nazwa narzedzia], DP_Serwis_wewnetrzny_naprawa.Id_serwis_wewnetrzny_naprawa AS [Identyfikator serwisu]
FROM dbo.DP_Narzedzie_uzyte_naprawa INNER JOIN
DM_Narzedzie ON DP_Narzedzie_uzyte_naprawa.Id_narzedzia=DM_Narzedzie.Id_narzedzia INNER JOIN
DP_Serwis_wewnetrzny_naprawa ON DP_Narzedzie_uzyte_naprawa.Id_serwis_wewnetrzny_naprawa=DP_Serwis_wewnetrzny_naprawa.Id_serwis_wewnetrzny_naprawa
GO
CREATE VIEW vDP_Czesc_wykorzystana
AS
SELECT DM_Czesc.Nazwa AS [Nazwa narzedzia], DP_Serwis_wewnetrzny_naprawa.Id_serwis_wewnetrzny_naprawa AS [Identyfikator serwisu]
FROM dbo.DP_Czesc_wykorzystana INNER JOIN
DM_Czesc ON DP_Czesc_wykorzystana.Id_czesci=DM_Czesc.Id_czesci INNER JOIN
DP_Serwis_wewnetrzny_naprawa ON DP_Czesc_wykorzystana.Id_serwis_wewnetrzny_naprawa=DP_Serwis_wewnetrzny_naprawa.Id_serwis_wewnetrzny_naprawa
GO
CREATE VIEW vDZ_Oplaty_stale
AS
SELECT DZ_Rachunek.Id_rachunki AS [Numer rachunku], DZ_Rodzaj_rachunku.Rodzaj_rachunku AS [Rodzaj rachunku], DZ_Rachunek.Koszt, DZ_Rachunek.Data_zaplaty AS [Data zapłaty]
FROM DZ_Rachunek INNER JOIN
DZ_Rodzaj_rachunku ON DZ_Rachunek.Id_rodzaj_rachunku=DZ_Rodzaj_rachunku.Id_rodzaj_rachunku
WHERE (MONTH(Data_zaplaty)=MONTH(GETDATE())) 
AND (YEAR(Data_zaplaty)=YEAR(GETDATE()))
GROUP BY DZ_Rachunek.Id_rachunki, DZ_Rodzaj_rachunku.Rodzaj_rachunku, DZ_Rachunek.Koszt, DZ_Rachunek.Data_zaplaty
GO
CREATE VIEW vDZ_Koszty_zewnetrzne
AS
SELECT DISTINCT DM_Dostawa_czesci.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_czesci.Cena_jednostkowa_czesci),2) AS [Cena jednostkowa], DM_Sklad_dostawy_czesci.Ilosc, vDM_Czesc.Nazwa AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_czesci * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_czesci INNER JOIN
DM_Sklad_dostawy_czesci ON DM_Dostawa_czesci.Id_dostawy=DM_Sklad_dostawy_czesci.Id_dostawy INNER JOIN
vDM_Czesc ON DM_Sklad_dostawy_czesci.Id_czesci=vDM_Czesc.[Numer czesci]
WHERE (MONTH(Data_dostawy)=MONTH(GETDATE())) 
AND (YEAR(Data_dostawy)=YEAR(GETDATE()))
GROUP BY DM_Dostawa_czesci.Data_dostawy,DM_Sklad_dostawy_czesci.Cena_jednostkowa_czesci, DM_Sklad_dostawy_czesci.Ilosc, vDM_Czesc.Nazwa 
UNION ALL
SELECT DISTINCT DM_Dostawa_maszyn.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_maszyn.Cena_jednostkowa_maszyny),2) AS [Cena jednostkowa], DM_Sklad_dostawy_maszyn.Ilosc, vDP_Maszyna.[Nazwa modelu] AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_maszyny * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_maszyn INNER JOIN
DM_Sklad_dostawy_maszyn ON DM_Dostawa_maszyn.Id_dostawy=DM_Sklad_dostawy_maszyn.Id_dostawy INNER JOIN
vDP_Maszyna ON DM_Sklad_dostawy_maszyn.Id_maszyn=vDP_Maszyna.[Numer maszyny]
WHERE (MONTH(Data_dostawy)=MONTH(GETDATE())) 
AND (YEAR(Data_dostawy)=YEAR(GETDATE()))
GROUP BY DM_Dostawa_maszyn.Data_dostawy,DM_Sklad_dostawy_maszyn.Cena_jednostkowa_maszyny,DM_Sklad_dostawy_maszyn.Ilosc, vDP_Maszyna.[Nazwa modelu]
UNION ALL
SELECT DISTINCT DM_Dostawa_materialu.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_materialu.Cena_jednostkowa_materialu),2) AS [Cena jednostkowa], DM_Sklad_dostawy_materialu.Ilosc, vDM_Material.[Nazwa materialu] AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_materialu * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_materialu INNER JOIN
DM_Sklad_dostawy_materialu ON DM_Dostawa_materialu.Id_dostawy=DM_Sklad_dostawy_materialu.Id_dostawy INNER JOIN
vDM_Material ON DM_Sklad_dostawy_materialu.Id_materialu=vDM_Material.[Numer materialu]
WHERE (MONTH(Data_dostawy)=MONTH(GETDATE())) 
AND (YEAR(Data_dostawy)=YEAR(GETDATE()))
GROUP BY DM_Dostawa_materialu.Data_dostawy,DM_Sklad_dostawy_materialu.Cena_jednostkowa_materialu, DM_Sklad_dostawy_materialu.Ilosc, vDM_Material.[Nazwa materialu]
UNION ALL
SELECT DISTINCT DM_Dostawa_narzedzi.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_narzedzi.Cena_jednostkowa_narzedzi),2) AS [Cena jednostkowa], DM_Sklad_dostawy_narzedzi.Ilosc, vDM_Narzedzie.Nazwa AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_narzedzi * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_narzedzi INNER JOIN
DM_Sklad_dostawy_narzedzi ON DM_Dostawa_narzedzi.Id_dostawy=DM_Sklad_dostawy_narzedzi.Id_dostawy INNER JOIN
vDM_Narzedzie ON DM_Sklad_dostawy_narzedzi.Id_narzedzia=vDM_Narzedzie.[Numer narzedzia]
WHERE (MONTH(Data_dostawy)=MONTH(GETDATE())) 
AND (YEAR(Data_dostawy)=YEAR(GETDATE()))
GROUP BY DM_Dostawa_narzedzi.Data_dostawy, DM_Sklad_dostawy_narzedzi.Cena_jednostkowa_narzedzi,DM_Sklad_dostawy_narzedzi.Ilosc, vDM_Narzedzie.Nazwa
UNION ALL
SELECT DISTINCT DP_Serwis_zewnetrzny.Data_zakonczenia AS [Data], ROUND((DP_Serwis_zewnetrzny.Koszt),2) AS [Cena jednostkowa], DP_Serwis_zewnetrzny.Ilosc, vDP_Maszyna.[Nazwa modelu] AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 THEN TRY_CAST((Koszt * Ilosc) AS DECIMAL) END) AS Koszt
FROM DP_Serwis_zewnetrzny INNER JOIN
vDP_Maszyna ON DP_Serwis_zewnetrzny.Id_maszyny=vDP_Maszyna.[Numer maszyny]
WHERE (MONTH(Data_zakonczenia)=MONTH(GETDATE())) 
AND (YEAR(Data_zakonczenia)=YEAR(GETDATE()))
GROUP BY DP_Serwis_zewnetrzny.Data_zakonczenia, DP_Serwis_zewnetrzny.Koszt, DP_Serwis_zewnetrzny.Ilosc, vDP_Maszyna.[Nazwa modelu] 
GO
CREATE VIEW vDZ_Premia
AS
SELECT DZ_Pracownik.Id_pracownika AS [Identyfikator pracownika], DZ_Pracownik.Imie, DZ_Pracownik.Nazwisko, DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia AS [Podstawa wynagrodzenia], DZ_Zatrudnienie.Data_zatrudnienia AS [Data zatrudnienia], vDZ_Zatrudnienie.Staz, 
CASE WHEN Staz>=0 AND Staz<1 THEN (Podstawa_wynagrodzenia*0)
	 WHEN Staz>=1 AND Staz<2 THEN ((Podstawa_wynagrodzenia*0.01))
	 WHEN Staz>=2 AND Staz<3 THEN ((Podstawa_wynagrodzenia*0.02))
	 WHEN Staz>=3 AND Staz<4 THEN ((Podstawa_wynagrodzenia*0.03))
	 WHEN Staz>=4 AND Staz<5 THEN ((Podstawa_wynagrodzenia*0.04))
	 WHEN Staz>=5 AND Staz<6 THEN ((Podstawa_wynagrodzenia*0.05))
	 WHEN Staz>=6 AND Staz<7 THEN ((Podstawa_wynagrodzenia*0.06))
	 WHEN Staz>=7 AND Staz<8 THEN ((Podstawa_wynagrodzenia*0.07))
	 WHEN Staz>=8 AND Staz<9 THEN ((Podstawa_wynagrodzenia*0.08))
	 WHEN Staz>=9 AND Staz<10 THEN ((Podstawa_wynagrodzenia*0.09))
	 WHEN Staz>=10 AND Staz<11 THEN ((Podstawa_wynagrodzenia*0.1))
	 WHEN Staz>=11 AND Staz<12 THEN ((Podstawa_wynagrodzenia*0.11))
	 WHEN Staz>=12 AND Staz<13 THEN ((Podstawa_wynagrodzenia*0.12))
	 WHEN Staz>=13 AND Staz<14 THEN ((Podstawa_wynagrodzenia*0.13))
	 WHEN Staz>=14 AND Staz<15 THEN ((Podstawa_wynagrodzenia*0.14))
	 WHEN Staz>=15 AND Staz<16 THEN ((Podstawa_wynagrodzenia*0.15))
	 WHEN Staz>=16 AND Staz<17 THEN ((Podstawa_wynagrodzenia*0.16))
	 WHEN Staz>=17 AND Staz<18 THEN ((Podstawa_wynagrodzenia*0.17))
	 WHEN Staz>=18 AND Staz<19 THEN ((Podstawa_wynagrodzenia*0.18))
	 WHEN Staz>=19 AND Staz<20 THEN ((Podstawa_wynagrodzenia*0.19))
	 WHEN Staz>=20 THEN ((Podstawa_wynagrodzenia*0.2)) END AS Premia
FROM DZ_Szczegoly_zatrudnienia INNER JOIN
DZ_Zatrudnienie ON DZ_Szczegoly_zatrudnienia.Id_zatrudnienia=DZ_Zatrudnienie.Id_zatrudnienia INNER JOIN
DZ_Pracownik ON DZ_Zatrudnienie.Id_pracownika=DZ_Pracownik.Id_pracownika INNER JOIN
vDZ_Zatrudnienie ON DZ_Zatrudnienie.Id_zatrudnienia=vDZ_Zatrudnienie.[Identyfikator zatrudnienia] 
GROUP BY DZ_Pracownik.Id_pracownika, DZ_Pracownik.Imie, DZ_Pracownik.Nazwisko, DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia, DZ_Zatrudnienie.Data_zatrudnienia, vDZ_Zatrudnienie.Staz
GO
CREATE VIEW vDZ_Nieobecnosc_pensja
AS
SELECT DZ_Szczegoly_zatrudnienia.Id_szczegoly_zatrudnienia, DZ_Pracownik.Id_pracownika,DZ_Pracownik.Imie, DZ_Pracownik.Nazwisko, DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia, DZ_Nieobecnosc.Data_rozpoczecia, DZ_Nieobecnosc.Data_zakonczenia, DZ_Rodzaj_nieobecnosci.Rodzaj,vDZ_Premia.Premia,vDZ_Zatrudnienie.Zwolnienie,
CASE WHEN Rodzaj='L4' AND (vDZ_Zatrudnienie.Zwolnienie is null) THEN ((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.8)-((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.5)*0.34)) 
	 WHEN vDZ_Zatrudnienie.Zwolnienie='zwolniono' THEN (((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.8)-((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.5)*0.34))*0)
	 WHEN  Rodzaj not in ('L4') AND (vDZ_Zatrudnienie.Zwolnienie is null) THEN ((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia)-((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.5)*0.34)) END AS 'Pensja'
FROM DZ_Szczegoly_zatrudnienia INNER JOIN
DZ_Zatrudnienie ON DZ_Szczegoly_zatrudnienia.Id_zatrudnienia=DZ_Zatrudnienie.Id_zatrudnienia INNER JOIN
DZ_Pracownik ON DZ_Zatrudnienie.Id_pracownika=DZ_Pracownik.Id_pracownika INNER JOIN
DZ_Nieobecnosc ON DZ_Pracownik.Id_pracownika=DZ_Nieobecnosc.Id_pracownika INNER JOIN
DZ_Rodzaj_nieobecnosci ON DZ_Nieobecnosc.Id_rodzaj_nieobecnosci=DZ_Rodzaj_nieobecnosci.Id_rodzaj_nieobecnosci INNER JOIN
vDZ_Premia ON DZ_Szczegoly_zatrudnienia.Id_szczegoly_zatrudnienia=vDZ_Premia.[Identyfikator pracownika] INNER JOIN
vDZ_Zatrudnienie ON DZ_Zatrudnienie.Id_zatrudnienia=vDZ_Zatrudnienie.[Identyfikator zatrudnienia]
WHERE (MONTH(Data_rozpoczecia)=MONTH(GETDATE())) 
AND (YEAR(Data_rozpoczecia)=YEAR(GETDATE())) 
OR (MONTH(Data_zakonczenia)=MONTH(GETDATE())) 
AND (YEAR(Data_zakonczenia)=YEAR(GETDATE()))
GO
CREATE VIEW vDZ_Obecnosc_pensja
AS
SELECT DZ_Szczegoly_zatrudnienia.Id_szczegoly_zatrudnienia, DZ_Pracownik.Id_pracownika, DZ_Pracownik.Imie, DZ_Pracownik.Nazwisko, DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia,DZ_Zatrudnienie.Data_zatrudnienia, DZ_Zatrudnienie.Data_zwolnienia,vDZ_Premia.Premia, vDZ_Zatrudnienie.Zwolnienie,
CASE WHEN vDZ_Zatrudnienie.Zwolnienie is null THEN ((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia)-((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.5)*0.34)) 
	 WHEN vDZ_Zatrudnienie.Zwolnienie='zwolniono' THEN (((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.8)-((DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia*0.5)*0.34))*0) END AS 'Pensja'
FROM DZ_Szczegoly_zatrudnienia INNER JOIN
DZ_Zatrudnienie ON DZ_Szczegoly_zatrudnienia.Id_zatrudnienia=DZ_Zatrudnienie.Id_zatrudnienia INNER JOIN
DZ_Pracownik ON DZ_Zatrudnienie.Id_pracownika=DZ_Pracownik.Id_pracownika INNER JOIN
vDZ_Premia ON DZ_Szczegoly_zatrudnienia.Id_szczegoly_zatrudnienia=vDZ_Premia.[Identyfikator pracownika] INNER JOIN
vDZ_Zatrudnienie ON DZ_Zatrudnienie.Id_zatrudnienia=vDZ_Zatrudnienie.[Identyfikator zatrudnienia]
WHERE DZ_Pracownik.Id_pracownika not in (SELECT Id_pracownika FROM DZ_Nieobecnosc 
WHERE (MONTH(Data_rozpoczecia)=MONTH(GETDATE())) 
AND (YEAR(Data_rozpoczecia)=YEAR(GETDATE())) 
OR (MONTH(Data_zakonczenia)=MONTH(GETDATE())) 
AND (YEAR(Data_zakonczenia)=YEAR(GETDATE()))) 
GO
CREATE VIEW vDZ_Wyplata
AS 
SELECT vDZ_Nieobecnosc_pensja.Id_pracownika AS [Identyfikator pracownika], vDZ_Nieobecnosc_pensja.Imie, vDZ_Nieobecnosc_pensja.Nazwisko, vDZ_Nieobecnosc_pensja.Podstawa_wynagrodzenia AS [Podstawa wynagrodzenia], vDZ_Nieobecnosc_pensja.Premia, vDZ_Nieobecnosc_pensja.Pensja,
CASE WHEN Premia IS NULL THEN Pensja
	 ELSE (Premia+Pensja) END AS 'Wypłata'
FROM vDZ_Nieobecnosc_pensja
WHERE Premia>0
GROUP BY vDZ_Nieobecnosc_pensja.Id_pracownika, vDZ_Nieobecnosc_pensja.Imie, vDZ_Nieobecnosc_pensja.Nazwisko, vDZ_Nieobecnosc_pensja.Podstawa_wynagrodzenia, vDZ_Nieobecnosc_pensja.Premia, vDZ_Nieobecnosc_pensja.Pensja
UNION
SELECT vDZ_Obecnosc_pensja.Id_pracownika, vDZ_Obecnosc_pensja.Imie, vDZ_Obecnosc_pensja.Nazwisko, vDZ_Obecnosc_pensja.Podstawa_wynagrodzenia, vDZ_Obecnosc_pensja.Premia, vDZ_Obecnosc_pensja.Pensja,
CASE WHEN Premia IS NULL THEN Pensja
	 ELSE (Premia+Pensja) END AS 'Wypłata'
FROM vDZ_Obecnosc_pensja
GROUP BY vDZ_Obecnosc_pensja.Id_pracownika, vDZ_Obecnosc_pensja.Imie, vDZ_Obecnosc_pensja.Nazwisko, vDZ_Obecnosc_pensja.Podstawa_wynagrodzenia, vDZ_Obecnosc_pensja.Premia, vDZ_Obecnosc_pensja.Pensja
GO
CREATE VIEW vDZ_Archiwum_Koszty_zewnetrzne
AS
SELECT DISTINCT DM_Dostawa_czesci.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_czesci.Cena_jednostkowa_czesci),2) AS [Cena jednostkowa], DM_Sklad_dostawy_czesci.Ilosc, vDM_Czesc.Nazwa AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_czesci * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_czesci INNER JOIN
DM_Sklad_dostawy_czesci ON DM_Dostawa_czesci.Id_dostawy=DM_Sklad_dostawy_czesci.Id_dostawy INNER JOIN
vDM_Czesc ON DM_Sklad_dostawy_czesci.Id_czesci=vDM_Czesc.[Numer czesci]
GROUP BY DM_Dostawa_czesci.Data_dostawy,DM_Sklad_dostawy_czesci.Cena_jednostkowa_czesci, DM_Sklad_dostawy_czesci.Ilosc, vDM_Czesc.Nazwa 
UNION ALL
SELECT DISTINCT DM_Dostawa_maszyn.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_maszyn.Cena_jednostkowa_maszyny),2) AS [Cena jednostkowa], DM_Sklad_dostawy_maszyn.Ilosc, vDP_Maszyna.[Nazwa modelu] AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_maszyny * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_maszyn INNER JOIN
DM_Sklad_dostawy_maszyn ON DM_Dostawa_maszyn.Id_dostawy=DM_Sklad_dostawy_maszyn.Id_dostawy INNER JOIN
vDP_Maszyna ON DM_Sklad_dostawy_maszyn.Id_maszyn=vDP_Maszyna.[Numer maszyny]
GROUP BY DM_Dostawa_maszyn.Data_dostawy,DM_Sklad_dostawy_maszyn.Cena_jednostkowa_maszyny,DM_Sklad_dostawy_maszyn.Ilosc, vDP_Maszyna.[Nazwa modelu]
UNION ALL
SELECT DISTINCT DM_Dostawa_materialu.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_materialu.Cena_jednostkowa_materialu),2) AS [Cena jednostkowa], DM_Sklad_dostawy_materialu.Ilosc, vDM_Material.[Nazwa materialu] AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_materialu * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_materialu INNER JOIN
DM_Sklad_dostawy_materialu ON DM_Dostawa_materialu.Id_dostawy=DM_Sklad_dostawy_materialu.Id_dostawy INNER JOIN
vDM_Material ON DM_Sklad_dostawy_materialu.Id_materialu=vDM_Material.[Numer materialu]
GROUP BY DM_Dostawa_materialu.Data_dostawy,DM_Sklad_dostawy_materialu.Cena_jednostkowa_materialu, DM_Sklad_dostawy_materialu.Ilosc, vDM_Material.[Nazwa materialu]
UNION ALL
SELECT DISTINCT DM_Dostawa_narzedzi.Data_dostawy AS [Data], ROUND((DM_Sklad_dostawy_narzedzi.Cena_jednostkowa_narzedzi),2) AS [Cena jednostkowa], DM_Sklad_dostawy_narzedzi.Ilosc, vDM_Narzedzie.Nazwa AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 then TRY_CAST((Cena_jednostkowa_narzedzi * Ilosc) AS DECIMAL) END) AS Koszt
FROM DM_Dostawa_narzedzi INNER JOIN
DM_Sklad_dostawy_narzedzi ON DM_Dostawa_narzedzi.Id_dostawy=DM_Sklad_dostawy_narzedzi.Id_dostawy INNER JOIN
vDM_Narzedzie ON DM_Sklad_dostawy_narzedzi.Id_narzedzia=vDM_Narzedzie.[Numer narzedzia]
GROUP BY DM_Dostawa_narzedzi.Data_dostawy, DM_Sklad_dostawy_narzedzi.Cena_jednostkowa_narzedzi,DM_Sklad_dostawy_narzedzi.Ilosc, vDM_Narzedzie.Nazwa
UNION ALL
SELECT DISTINCT DP_Serwis_zewnetrzny.Data_zakonczenia AS [Data], ROUND((DP_Serwis_zewnetrzny.Koszt),2) AS [Cena jednostkowa], DP_Serwis_zewnetrzny.Ilosc, vDP_Maszyna.[Nazwa modelu] AS [Nazwa],
SUM(CASE WHEN Ilosc>=1 THEN TRY_CAST((Koszt * Ilosc) AS DECIMAL) END) AS Koszt
FROM DP_Serwis_zewnetrzny INNER JOIN
vDP_Maszyna ON DP_Serwis_zewnetrzny.Id_maszyny=vDP_Maszyna.[Numer maszyny]
GROUP BY DP_Serwis_zewnetrzny.Data_zakonczenia, DP_Serwis_zewnetrzny.Koszt, DP_Serwis_zewnetrzny.Ilosc, vDP_Maszyna.[Nazwa modelu] 
GO


CREATE VIEW vDM_Wlasciwosc_materialu
AS
SELECT id_wlasciwosc_materialu ,DM_Material.Nazwa AS [Nazwa materialu], DM_Wlasciwosc.Nazwa_wlasciwosci AS [Nazwa wlasciwosci],Wartosc AS [Wartosc], DM_Wlasciwosc.Jednostka_pomiarowa AS [Jednostka pomiarowa]
FROM dbo.DM_Wlasciwosc_materialu INNER JOIN
DM_Material ON DM_Wlasciwosc_materialu.Id_materialu=DM_Material .Id_materialu INNER JOIN
DM_Wlasciwosc ON DM_Wlasciwosc_materialu.Id_wlasciwosc=DM_Wlasciwosc.Id_wlasciwosc
GO

/*NARZEDZIE WYKORZYSTANE W PROCESIE_CZYNNOSC Z NAZWA I RODZAJEM */
CREATE VIEW vDP_Narzedzia_Proces
AS
SELECT PN.Id_po_proc_czynnosci, PN.Nazwa, PN.Rodzaj_narzedzia FROM (
SELECT DP_Po_narzedzia_czynnosc.Id_po_proc_czynnosci, DM_Narzedzie.Nazwa, DM_Rodzaj_narzedzia.Nazwa AS Rodzaj_narzedzia  
FROM DP_Po_narzedzia_czynnosc
INNER JOIN DM_Narzedzie ON DM_Narzedzie.Id_narzedzia = DP_Po_narzedzia_czynnosc.Id_narzedzia
INNER JOIN DM_Rodzaj_narzedzia ON DM_Narzedzie.Id_rodzaj_narzedzia = DM_Rodzaj_narzedzia.Id_rodzaj_narzedzia) AS PN
INNER JOIN DP_Po_proc_czynnosc ON PN.Id_po_proc_czynnosci = DP_Po_proc_czynnosc.Id_po_proc_czynnosci;
GO

/*MASYZNA WYKORZYSTANE W PROCESIE_CZYNNOSC Z NR SERYJNY NAZWA */
CREATE VIEW vDP_Maszyna_Proces
AS
SELECT PM.Id_po_proc_czynnosci, PM.Id_maszyny, PM.Nr_seryjny, PM.Rodzaj_maszyny FROM(
SELECT DP_Po_maszyna_czynnosc.Id_po_proc_czynnosci, DP_Po_maszyna_czynnosc.Id_maszyny,
DP_Maszyna.Nr_seryjny, DP_Rodzaj_maszyny.Rodzaj_maszyny FROM DP_Po_maszyna_czynnosc
INNER JOIN DP_Maszyna ON DP_Po_maszyna_czynnosc.Id_maszyny = DP_Maszyna.Id_maszyny
INNER JOIN DP_Rodzaj_maszyny ON DP_Maszyna.Id_rodzaj_maszyny = DP_Rodzaj_maszyny.Id_rodzaj_maszyny) AS PM
INNER JOIN DP_Po_proc_czynnosc ON PM.Id_po_proc_czynnosci = DP_Po_proc_czynnosc.Id_po_proc_czynnosci;
GO

/*PRACOWNIK WYKORZYSTANE W PROCESIE_CZYNNOSC Z NAZWA */
CREATE VIEW vDP_Pracownik_Proces
AS
SELECT PP.Id_po_proc_czynnosci, PP.Id_pracownika, PP.Pracownik FROM(
SELECT DP_Po_prac_czynnosc.Id_po_proc_czynnosci, DP_Po_prac_czynnosc.Id_pracownika, 
(DZ_Pracownik.Imie +' '+ DZ_Pracownik.Nazwisko) AS Pracownik FROM DP_Po_prac_czynnosc
INNER JOIN DZ_Pracownik ON DP_Po_prac_czynnosc.Id_pracownika = DZ_Pracownik.Id_pracownika) AS PP
INNER JOIN DP_Po_proc_czynnosc ON PP.Id_po_proc_czynnosci = DP_Po_proc_czynnosc.Id_po_proc_czynnosci;
GO

/*MATERIAL WYKORZYSTANE W PROCESIE_CZYNNOSC Z NAZWA */
CREATE VIEW vDP_Material_Proces
AS
SELECT PMA.Id_po_proc_czynnosci, PMA.Id_materialu, PMA.Ilosc, PMA.Nazwa, PMA.Rodzaj_materialu FROM(
SELECT DP_Po_material_czynnosc.Id_po_proc_czynnosci, DP_Po_material_czynnosc.Id_materialu, 
DP_Po_material_czynnosc.Ilosc, DM_Material.Nazwa, DM_Rodzaj_materialu.Rodzaj_materialu FROM DP_Po_material_czynnosc
INNER JOIN DM_Material ON DP_Po_material_czynnosc.Id_materialu = DM_Material.Id_materialu
INNER JOIN DM_Rodzaj_materialu ON DM_Material.Id_materialu = DM_Rodzaj_materialu.Id_rodzaj_materialu) AS PMA
INNER JOIN DP_Po_proc_czynnosc ON PMA.Id_po_proc_czynnosci = DP_Po_proc_czynnosc.Id_po_proc_czynnosci;
GO

/*WYDRUK*/

/*WYDRUK W PROCESIE z nazwa elementu*/
CREATE VIEW vDP_Wydruk_Proces1
AS
SELECT WP.Id_po_wydr_proces, WP.Id_wydruk, WP.Wypelnienie, WP.Estymowana_masa, WP.Nazwa_elementu,DP_Po_wydr_proc.Czas_zamierzony FROM(
SELECT DP_Po_wydr_proc.Id_po_wydr_proces, DP_Po_wydr_proc.Id_wydruk, DP_Wydruk.Wypelnienie, DP_Wydruk.Estymowana_masa,
DZ_Plik.Nazwa_pliku AS Nazwa_elementu FROM DP_Po_wydr_proc
INNER JOIN DP_Wydruk ON DP_Po_wydr_proc.Id_wydruk = DP_Wydruk.Id_wydruk
INNER JOIN DZ_Plik ON DP_Wydruk.Id_pliku = DZ_Plik.Id_pliku) AS WP
INNER JOIN DP_Po_wydr_proc ON WP.Id_po_wydr_proces = DP_Po_wydr_proc.Id_po_wydr_proces
GO

/*MASZYNA Z WYDRUKIEM nazwa maszyny*/
CREATE VIEW vDP_MaszynaWydruk_Proces
AS
SELECT MW.Id_po_wydr_proces, MW.Id_maszyny, MW.Nr_seryjny, MW.RODZAJ FROM(
SELECT DP_Po_maszyna_wydruk.Id_po_wydr_proces, DP_Po_maszyna_wydruk.Id_maszyny,
DP_Maszyna.Nr_seryjny, DP_Rodzaj_maszyny.Rodzaj_maszyny AS RODZAJ FROM DP_Po_maszyna_wydruk
INNER JOIN DP_Maszyna ON DP_Po_maszyna_wydruk.Id_maszyny = DP_Maszyna.Id_maszyny
INNER JOIN DP_Rodzaj_maszyny ON DP_Maszyna.Id_rodzaj_maszyny = DP_Rodzaj_maszyny.Id_rodzaj_maszyny) AS MW
INNER JOIN DP_Po_wydr_proc ON MW.Id_po_wydr_proces = DP_Po_wydr_proc.Id_po_wydr_proces;
GO

/*MATERIAL DO WYDRUKU Z NAZWA*/
CREATE VIEW vDP_MaterialWydruk_Proces
AS
SELECT MAW.Id_po_wydr_proc, MAW.Id_materialu, MAW.Ilosc, MAW.Nazwa, MAW.Rodzaj_materialu FROM(
SELECT DP_Po_material_wydruk.Id_po_wydr_proc, DP_Po_material_wydruk.Id_materialu, 
DP_Po_material_wydruk.Ilosc, DM_Material.Nazwa, DM_Rodzaj_materialu.Rodzaj_materialu FROM DP_Po_material_wydruk
INNER JOIN DM_Material ON DP_Po_material_wydruk.Id_materialu = DM_Material.Id_materialu
INNER JOIN DM_Rodzaj_materialu ON DM_Material.Id_materialu = DM_Rodzaj_materialu.Id_rodzaj_materialu) AS MAW
INNER JOIN DP_Po_proc_czynnosc ON MAW.Id_po_wydr_proc = DP_Po_proc_czynnosc.Id_po_proc_czynnosci;
GO

/*POŁĄCZENIE WYDRUKU Z PROCESEM*/
CREATE VIEW vDP_WydrukProces
AS
SELECT VW.ID_WYDRUKU [Numer wydruku], 
VW.NAZWA_ELEMENTU [Nazwa elementu], 
VW.WYPEŁNIENIE [Wypełnienie], 
VW.ESTYMOWANA_MASA [masa w g], 
VW.NR_SERYJNY_MASZYNY[nr seryjny drukarki], 
VW.RODZAJ_MASZYNY [rodzaj maszyny], 
VW.MATERIAL [rodzaj materialu],
VW.ILOSC_MATERIALU_W_G [Material dodatkowy w g],  
DP_Proces_technologiczny.Nazwa [nazwa procesu] FROM

(SELECT vDP_Wydruk_Proces1.Id_po_wydr_proces AS ID_WYDRUKU,
vDP_Wydruk_Proces1.Nazwa_elementu AS NAZWA_ELEMENTU, 
vDP_Wydruk_Proces1.Wypelnienie AS WYPEŁNIENIE,
vDP_Wydruk_Proces1.Estymowana_masa AS ESTYMOWANA_MASA, 
vDP_MaszynaWydruk_Proces.Nr_seryjny AS NR_SERYJNY_MASZYNY, 
vDP_MaszynaWydruk_Proces.RODZAJ AS RODZAJ_MASZYNY,
vDP_MaterialWydruk_Proces.Nazwa AS MATERIAL, 
vDP_MaterialWydruk_Proces.Ilosc AS ILOSC_MATERIALU_W_G,
vDP_Wydruk_Proces1.Id_po_wydr_proces AS ID_PO_PROCES
FROM vDP_Wydruk_Proces1
INNER JOIN vDP_MaszynaWydruk_Proces ON vDP_Wydruk_Proces1.Id_po_wydr_proces = vDP_MaszynaWydruk_Proces.Id_po_wydr_proces
INNER JOIN vDP_MaterialWydruk_Proces ON vDP_MaszynaWydruk_Proces.Id_po_wydr_proces = vDP_MaterialWydruk_Proces.Id_po_wydr_proc) AS VW
INNER JOIN DP_Po_wydr_proc ON VW.ID_PO_PROCES = DP_Po_wydr_proc.Id_po_wydr_proces
INNER JOIN DP_Proces_technologiczny ON DP_Po_wydr_proc.Id_proces_technologiczny = DP_Proces_technologiczny.Id_proces_technologiczny
WHERE RODZAJ_MASZYNY LIKE ('D%');
GO
/*POŁĄCZENIE CZYNNOŚCI Z PROCESEM*/
CREATE VIEW vDP_CzynnoscProces
AS
SELECT VC.ID_CZYNNOSCI, VC.NAZWA_CZYNNOSCI, VC.NARZEDZIE, VC.MASZYNA, VC.MATERIAL, VC.ILOSC_MATERIALU, VC.PRACOWNIK, DP_Proces_technologiczny.Nazwa FROM

(SELECT DP_Po_proc_czynnosc.Id_rodzaj_czynnosci AS ID_CZYNNOSCI, 
DP_Rodzaj_czynnosci.Nazwa AS NAZWA_CZYNNOSCI,
vDP_Narzedzia_Proces.Rodzaj_narzedzia AS NARZEDZIE,
vDP_Maszyna_Proces.Rodzaj_maszyny AS MASZYNA,
vDP_Material_Proces.Nazwa AS MATERIAL,
vDP_Material_Proces.Ilosc AS ILOSC_MATERIALU,
vDP_Pracownik_Proces.Pracownik AS PRACOWNIK FROM DP_Rodzaj_czynnosci
INNER JOIN DP_Po_proc_czynnosc ON DP_Rodzaj_czynnosci.Id_rodzaj_czynnosci = DP_Po_proc_czynnosc.Id_rodzaj_czynnosci
INNER JOIN vDP_Narzedzia_Proces ON DP_Po_proc_czynnosc.Id_po_proc_czynnosci = vDP_Narzedzia_Proces.Id_po_proc_czynnosci
INNER JOIN vDP_Maszyna_Proces ON vDP_Narzedzia_Proces.Id_po_proc_czynnosci = vDP_Maszyna_Proces.Id_po_proc_czynnosci
INNER JOIN vDP_Material_Proces ON vDP_Maszyna_Proces.Id_po_proc_czynnosci = vDP_Material_Proces.Id_po_proc_czynnosci
INNER JOIN vDP_Pracownik_Proces ON vDP_Material_Proces.Id_po_proc_czynnosci = vDP_Pracownik_Proces.Id_po_proc_czynnosci) AS VC
INNER JOIN DP_Proces_technologiczny ON VC.ID_CZYNNOSCI = DP_Proces_technologiczny.Id_proces_technologiczny;
GO

CREATE VIEW vDP_Maszyna_drukarki
AS
SELECT DP_Maszyna.Id_maszyny, DP_Maszyna.Nr_seryjny, DP_Model_maszyny.Nazwa_modelu_maszyny FROM DP_Maszyna
INNER JOIN DP_Rodzaj_maszyny ON DP_Maszyna.Id_rodzaj_maszyny = DP_Rodzaj_maszyny.Id_rodzaj_maszyny
INNER JOIN DP_Model_maszyny ON DP_Maszyna.Id_model_maszyny = DP_Model_maszyny.Id_model_maszyny
where DP_Rodzaj_maszyny.Rodzaj_maszyny like ('D%');
GO

CREATE VIEW vDP_Proces_Techno1
AS
SELECT A.Id_proces_technologiczny AS [Identyfikator procesu technologicznego], 
A.Nazwa, 
COUNT(A.Id_po_proc_czynnosci) AS [Liczba czynnosci dodatkowych], 
COUNT(DP_Po_wydr_proc.Id_po_wydr_proces) AS [Liczba wydrukow],
SUM(DP_Po_wydr_proc.Czas_zamierzony) AS [Sumaryczny czas wydruku]
FROM (SELECT DP_Proces_technologiczny.Id_proces_technologiczny, DP_Proces_technologiczny.Nazwa,DP_Po_proc_czynnosc.Id_po_proc_czynnosci
FROM DP_Proces_technologiczny
LEFT OUTER JOIN DP_Po_proc_czynnosc ON DP_Proces_technologiczny.Id_proces_technologiczny = DP_Po_proc_czynnosc.Id_proces_technologiczny) AS A
LEFT OUTER JOIN DP_Po_wydr_proc ON A.Id_proces_technologiczny = DP_Po_wydr_proc.Id_proces_technologiczny
GROUP BY A.Id_proces_technologiczny, A.Nazwa;
GO

CREATE VIEW vDM_Zliczanieilosciwydanej
AS
SELECT DM_Material.Nazwa AS 'Nazwa materialu', SUM(DM_Szczegoly_wydania_materialu.Ilosc) AS [Ilosc1],SUM(DM_Sklad_dostawy_materialu.Ilosc) AS [Ilosc2],SUM(DP_Po_material_wydruk.Ilosc) AS [Ilosc3],SUM(DP_Po_material_czynnosc.Ilosc) AS [Ilosc4]
FROM dbo.DM_Material INNER JOIN
DM_Szczegoly_wydania_materialu ON DM_Material.Id_materialu=DM_Szczegoly_wydania_materialu.Id_materialu INNER JOIN
DM_Sklad_dostawy_materialu ON DM_Material.Id_materialu=DM_Sklad_dostawy_materialu.Id_materialu INNER JOIN
DP_Po_material_wydruk ON DM_Material.Id_materialu=DP_Po_material_wydruk.Id_materialu INNER JOIN
DP_Po_material_czynnosc ON DM_Material.Id_materialu=DP_Po_material_czynnosc.Id_materialu
GROUP BY  DM_Material.Nazwa,DM_Szczegoly_wydania_materialu.Ilosc,DM_Sklad_dostawy_materialu.Ilosc,DP_Po_material_wydruk.Ilosc,DP_Po_material_czynnosc.Id_materialu
GO
CREATE VIEW vDM_Zapotrzebowanie1
AS
SELECT DM_Material.Nazwa AS 'Nazwa materialu', vDM_Zliczanieilosciwydanej.Ilosc1 AS [Ilosc1], dbo.vDM_Zliczanieilosciwydanej.Ilosc2, dbo.vDM_Zliczanieilosciwydanej.Ilosc3 AS [Ilosc3], dbo.vDM_Zliczanieilosciwydanej.Ilosc4 AS [Ilosc4],
CASE WHEN (vDM_Zliczanieilosciwydanej.Ilosc1 - dbo.vDM_Zliczanieilosciwydanej.Ilosc2-vDM_Zliczanieilosciwydanej.Ilosc3-dbo.vDM_Zliczanieilosciwydanej.Ilosc4) <= 100 THEN 'Brak materialu'
ELSE 'Wystarczająca' END AS 'Stan materiału',
CASE WHEN ((vDM_Zliczanieilosciwydanej.Ilosc1 - vDM_Zliczanieilosciwydanej.Ilosc2-vDM_Zliczanieilosciwydanej.Ilosc3-dbo.vDM_Zliczanieilosciwydanej.Ilosc4) !=0) THEN ((vDM_Zliczanieilosciwydanej.Ilosc1 - dbo.vDM_Zliczanieilosciwydanej.Ilosc2-vDM_Zliczanieilosciwydanej.Ilosc3-dbo.vDM_Zliczanieilosciwydanej.Ilosc4)* -1) END AS 'Brakujaca ilosc'
FROM dbo.DM_Material INNER JOIN
vDM_Zliczanieilosciwydanej ON DM_Material.Nazwa=vDM_Zliczanieilosciwydanej.[Nazwa materialu]
GO


CREATE VIEW vDP_Koszt_jednostkowy_material
AS
SELECT DM_Sklad_dostawy_materialu.Id_materialu, DM_Material.Nazwa, DM_Rodzaj_materialu.Rodzaj_materialu,
	(DM_Sklad_dostawy_materialu.Cena_jednostkowa_materialu/DM_Sklad_dostawy_materialu.Ilosc) AS [Koszt jednostkowy za material]
FROM DM_Material INNER JOIN
	DM_Sklad_dostawy_materialu ON DM_Material.Id_materialu=DM_Sklad_dostawy_materialu.Id_materialu
	INNER JOIN DM_Rodzaj_materialu ON DM_Material.Id_rodzaj_materialu=DM_Rodzaj_materialu.Id_rodzaj_materialu
GO

CREATE VIEW vDP_Koszt_RH_pracownika
AS
SELECT DZ_Pracownik.Id_pracownika, DZ_Pracownik.Imie, DZ_Pracownik.Nazwisko,
	(DZ_Szczegoly_zatrudnienia.Podstawa_wynagrodzenia/176) AS [Koszt RH pracownika],
	DZ_Stanowisko.Stanowisko
FROM DZ_Pracownik INNER JOIN
	DZ_Zatrudnienie ON DZ_Pracownik.Id_pracownika=DZ_Zatrudnienie.Id_pracownika
INNER JOIN DZ_Szczegoly_zatrudnienia ON DZ_Zatrudnienie.Id_zatrudnienia=DZ_Szczegoly_zatrudnienia.Id_zatrudnienia
INNER JOIN DZ_Stanowisko ON DZ_Zatrudnienie.Id_stanowiska=DZ_Stanowisko.Id_stanowiska
GO

CREATE VIEW vDP_Koszt_pracownika_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny, DP_Po_proc_czynnosc.Id_po_proc_czynnosci,
	 DZ_Pracownik.Imie, DZ_Pracownik.Nazwisko, DP_Po_prac_czynnosc.Id_pracownika, 
	 DP_Po_proc_czynnosc.Czas_zamierzony,
	 ROUND((DP_Po_proc_czynnosc.Czas_zamierzony * vDP_Koszt_RH_pracownika.[Koszt RH pracownika]),2) AS [Koszt pracownika przed]
FROM DP_Po_proc_czynnosc INNER JOIN
	DP_Proces_technologiczny ON DP_Po_proc_czynnosc.Id_proces_technologiczny=DP_Proces_technologiczny.Id_proces_technologiczny
INNER JOIN DP_Po_prac_czynnosc ON DP_Po_proc_czynnosc.Id_po_proc_czynnosci=DP_Po_prac_czynnosc.Id_po_proc_czynnosci
INNER JOIN DZ_Pracownik ON DP_Po_prac_czynnosc.Id_pracownika=DZ_Pracownik.Id_pracownika	
INNER JOIN vDP_Koszt_RH_pracownika ON DZ_Pracownik.Id_pracownika=vDP_Koszt_RH_pracownika.Id_pracownika
GO

CREATE VIEW vDP_Koszt_pracownika_powykonawczy
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny, DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe,
	DZ_Pracownik.Imie, DZ_Pracownik.Nazwisko, DP_po_prod_czyn_dod_pracownik.Id_pracownika,
	DP_prod_czynnosc_dodatkowa.Czas_pracy, 
	ROUND((DP_prod_czynnosc_dodatkowa.Czas_pracy * vDP_Koszt_RH_pracownika.[Koszt RH pracownika]),2) AS [Koszt pracownika]
FROM DP_prod_czynnosc_dodatkowa INNER JOIN
	DP_Proces_produkcyjny ON DP_prod_czynnosc_dodatkowa.Id_proces_produkcyjny=DP_Proces_produkcyjny.Id_proces_produkcyjny
INNER JOIN DP_po_prod_czyn_dod_pracownik ON DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe=DP_po_prod_czyn_dod_pracownik.Id_prod_czynnosci_dodatkowe
INNER JOIN DZ_Pracownik ON DP_po_prod_czyn_dod_pracownik.Id_pracownika=DZ_Pracownik.Id_pracownika
INNER JOIN vDP_Koszt_RH_pracownika ON DZ_Pracownik.Id_pracownika=vDP_Koszt_RH_pracownika.Id_pracownika
GO

CREATE VIEW vDP_Koszt_materialu_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny,DP_Po_wydr_proc.Id_po_wydr_proces,
	DP_Po_proc_czynnosc.Id_po_proc_czynnosci,
	DM_Material.Nazwa, DM_Rodzaj_materialu.Rodzaj_materialu,
	DP_Po_material_wydruk.Id_materialu AS [Material wydruk],
	DP_Po_material_czynnosc.Id_materialu AS [Material dodatkowe],
	DP_Po_material_wydruk.Ilosc AS [Ilosc wydruk], DP_Po_material_czynnosc.Ilosc AS [Ilosc dodatkowe],
	(DP_Po_material_wydruk.Ilosc * vDP_Koszt_jednostkowy_material.[Koszt jednostkowy za material]) AS [Koszt m_wydruk],
	(DP_Po_material_czynnosc.Ilosc * vDP_Koszt_jednostkowy_material.[Koszt jednostkowy za material]) AS [Koszt m_dodatkowe]
FROM DP_Po_wydr_proc INNER JOIN
	DP_Proces_technologiczny ON DP_Po_wydr_proc.Id_proces_technologiczny=DP_Proces_technologiczny.Id_proces_technologiczny
INNER JOIN DP_Po_proc_czynnosc ON DP_Po_wydr_proc.Id_proces_technologiczny=DP_Po_proc_czynnosc.Id_proces_technologiczny
INNER JOIN DP_Po_material_wydruk ON DP_Po_wydr_proc.Id_po_wydr_proces=DP_Po_material_wydruk.Id_po_wydr_proc
INNER JOIN DP_Po_material_czynnosc ON DP_Po_proc_czynnosc.Id_po_proc_czynnosci=DP_Po_material_czynnosc.Id_po_proc_czynnosci
INNER JOIN DM_Material ON DP_Po_material_czynnosc.Id_materialu=DM_Material.Id_materialu
INNER JOIN DM_Rodzaj_materialu ON DM_Material.Id_rodzaj_materialu=DM_Rodzaj_materialu.Id_rodzaj_materialu
INNER JOIN vDP_Koszt_jednostkowy_material ON DM_Material.Id_materialu=vDP_Koszt_jednostkowy_material.Id_materialu
GO

CREATE VIEW vDP_Koszt_materialu_wydruk_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny, DP_Po_material_wydruk.Id_materialu AS [Material wydruk],
	DM_Material.Nazwa, DM_Rodzaj_materialu.Rodzaj_materialu,
	DP_Po_material_wydruk.Ilosc, DP_Po_wydr_proc.Id_po_wydr_proces, 
	(DP_Po_material_wydruk.Ilosc * vDP_Koszt_jednostkowy_material.[Koszt jednostkowy za material]) AS [Koszt materialu wydruk]
FROM DP_Proces_technologiczny INNER JOIN
	DP_Po_wydr_proc ON DP_Proces_technologiczny.Id_proces_technologiczny=DP_Po_wydr_proc.Id_proces_technologiczny
INNER JOIN DP_Po_material_wydruk ON DP_Po_wydr_proc.Id_po_wydr_proces=DP_Po_material_wydruk.Id_po_wydr_proc
INNER JOIN DM_Material ON DP_Po_material_wydruk.Id_materialu=DM_Material.Id_materialu
INNER JOIN DM_Rodzaj_materialu ON DM_Material.Id_materialu=DM_Rodzaj_materialu.Id_rodzaj_materialu
INNER JOIN vDP_Koszt_jednostkowy_material ON DM_Material.Id_materialu=vDP_Koszt_jednostkowy_material.Id_materialu
GO

CREATE VIEW vDP_Koszt_materialu_dodatkowe_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny, DP_Po_proc_czynnosc.Id_po_proc_czynnosci,
	DP_Po_material_czynnosc.Id_materialu, DP_Po_material_czynnosc.Ilosc, 
	DM_Material.Nazwa, DM_Rodzaj_materialu.Rodzaj_materialu, 
	(DP_Po_material_czynnosc.Ilosc * vDP_Koszt_jednostkowy_material.[Koszt jednostkowy za material]) AS [Koszt material dodatkowe]
FROM DP_Proces_technologiczny INNER JOIN 
	DP_Po_proc_czynnosc ON DP_Proces_technologiczny.Id_proces_technologiczny=DP_Po_proc_czynnosc.Id_proces_technologiczny
INNER JOIN DP_Po_material_czynnosc ON DP_Po_proc_czynnosc.Id_po_proc_czynnosci=DP_Po_material_czynnosc.Id_po_proc_czynnosci
INNER JOIN DM_Material ON DP_Po_material_czynnosc.Id_materialu=DM_Material.Id_materialu
INNER JOIN DM_Rodzaj_materialu ON DM_Material.Id_rodzaj_materialu=DM_Rodzaj_materialu.Id_rodzaj_materialu
INNER JOIN vDP_Koszt_jednostkowy_material ON DM_Material.Id_materialu=vDP_Koszt_jednostkowy_material.Id_materialu
GO

CREATE VIEW vDP_Koszt_maszyn_wydruk_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny, DP_Po_maszyna_wydruk.Id_maszyny,
	DP_Po_wydr_proc.Czas_zamierzony, DP_Maszyna.Koszt_1rh,
	(DP_Po_wydr_proc.Czas_zamierzony * DP_Maszyna.Koszt_1rh) AS [Koszt maszyn wydruk przed]
FROM DP_Proces_technologiczny INNER JOIN 
	DP_Po_wydr_proc ON DP_Proces_technologiczny.Id_proces_technologiczny=DP_Po_wydr_proc.Id_proces_technologiczny
INNER JOIN DP_Po_maszyna_wydruk ON DP_Po_wydr_proc.Id_po_wydr_proces=DP_Po_maszyna_wydruk.Id_po_wydr_proces
INNER JOIN DP_Maszyna ON DP_Po_maszyna_wydruk.Id_maszyny=DP_Maszyna.Id_maszyny
GO

CREATE VIEW vDP_Koszt_maszyn_dodatkowe_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny, DP_Po_maszyna_czynnosc.Id_maszyny,
	DP_Po_proc_czynnosc.Czas_zamierzony, DP_Maszyna.Koszt_1rh,
	(DP_Po_proc_czynnosc.Czas_zamierzony * DP_Maszyna.Koszt_1rh) AS [Koszt maszyn dodatkowe ofertowy]
FROM DP_Proces_technologiczny INNER JOIN
	DP_Po_proc_czynnosc ON DP_Proces_technologiczny.Id_proces_technologiczny=DP_Po_proc_czynnosc.Id_proces_technologiczny
INNER JOIN DP_Po_maszyna_czynnosc ON DP_Po_proc_czynnosc.Id_po_proc_czynnosci=DP_Po_maszyna_czynnosc.Id_po_proc_czynnosci
INNER JOIN DP_Maszyna ON DP_Po_maszyna_czynnosc.Id_maszyny=DP_Maszyna.Id_maszyny
GO

CREATE VIEW vDP_Koszt_maszyn_wydruk_powykonawczy
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny, DP_prod_wydruk.Czas_wydruku,
	DP_Maszyna.Koszt_1rh, DP_prod_wydruk.Id_maszyny,
	(DP_prod_wydruk.Czas_wydruku * DP_Maszyna.Koszt_1rh) AS [Koszt maszyn wydruk powykonawczy]
FROM DP_Proces_produkcyjny INNER JOIN
	DP_prod_wydruk ON DP_Proces_produkcyjny.Id_proces_produkcyjny=DP_prod_wydruk.Id_proces_produkcyjny
INNER JOIN DP_Maszyna ON DP_prod_wydruk.Id_maszyny=DP_Maszyna.Id_maszyny
GO

CREATE VIEW vDP_Koszt_maszyn_dodatkowe_powykonawczy
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny, DP_po_prod_czyn_dod_maszyna.Id_maszyna,
	DP_prod_czynnosc_dodatkowa.Czas_pracy, DP_Maszyna.Koszt_1rh,
	(DP_prod_czynnosc_dodatkowa.Czas_pracy * DP_Maszyna.Koszt_1rh) AS [Koszt maszyn czyn_dodatkowe powykonawczy]
FROM DP_Proces_produkcyjny INNER JOIN 
	DP_prod_czynnosc_dodatkowa ON DP_Proces_produkcyjny.Id_proces_produkcyjny=DP_prod_czynnosc_dodatkowa.Id_proces_produkcyjny
INNER JOIN DP_po_prod_czyn_dod_maszyna ON DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe=DP_po_prod_czyn_dod_maszyna.Id_prod_czynnosci_dodatkowe
INNER JOIN DP_Maszyna ON DP_po_prod_czyn_dod_maszyna.Id_maszyna=DP_Maszyna.Id_maszyny
GO

CREATE VIEW vDP_Koszt_materialu_dodatkowe_powykonawczy
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny, DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe,
DP_po_prod_czyn_dod_material.Id_materialu,
	DP_po_prod_czyn_dod_material.Ilosc, DM_Material.Nazwa,
	(DP_po_prod_czyn_dod_material.Ilosc * vDP_Koszt_jednostkowy_material.[Koszt jednostkowy za material]) AS [Koszt material cz_dodatkowe powykonawczy]
FROM DP_Proces_produkcyjny INNER JOIN
	DP_prod_czynnosc_dodatkowa ON DP_Proces_produkcyjny.Id_proces_produkcyjny=DP_prod_czynnosc_dodatkowa.Id_proces_produkcyjny
INNER JOIN DP_po_prod_czyn_dod_material ON DP_prod_czynnosc_dodatkowa.Id_prod_czynnosci_dodatkowe=DP_po_prod_czyn_dod_material.Id_prod_czynnosci_dodatkowe
INNER JOIN DM_Material ON DP_po_prod_czyn_dod_material.Id_materialu=DM_Material.Id_materialu
INNER JOIN vDP_Koszt_jednostkowy_material ON DM_Material.Id_materialu=vDP_Koszt_jednostkowy_material.Id_materialu
GO

CREATE VIEW vDP_Koszt_materialu_wydruk_powykonawczy
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny, DP_prod_material.Id_materialu,
	DP_prod_material.Ilosc_zuzytego_materialu, DM_Material.Nazwa,
	(DP_prod_material.Ilosc_zuzytego_materialu * vDP_Koszt_jednostkowy_material.[Koszt jednostkowy za material]) AS [Koszt materialu powykonawczy]
FROM DP_Proces_produkcyjny INNER JOIN
	DP_prod_material ON DP_Proces_produkcyjny.Id_proces_produkcyjny=DP_prod_material.Id_proces_produkcyjny
INNER JOIN DM_Material ON DP_prod_material.Id_materialu=DM_Material.Id_materialu
INNER JOIN vDP_Koszt_jednostkowy_material ON DM_Material.Id_materialu=vDP_Koszt_jednostkowy_material.Id_materialu
GO

CREATE VIEW vDP_K_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny,
	sum(vDP_Koszt_maszyn_dodatkowe_ofertowy.[Koszt maszyn dodatkowe ofertowy]) AS [Koszt maszyn1 ofertowy],
	sum(vDP_Koszt_maszyn_wydruk_ofertowy.[Koszt maszyn wydruk przed]) AS [Koszt maszyn2 ofertowy],
	sum(vDP_Koszt_materialu_dodatkowe_ofertowy.[Koszt material dodatkowe]) AS [Koszt materialu1 ofertowy],
	sum(vDP_Koszt_materialu_wydruk_ofertowy.[Koszt materialu wydruk])AS [Koszt materialu2 ofertowy],
	sum(vDP_Koszt_pracownika_ofertowy.[Koszt pracownika przed]) AS [Koszt pracownik ofertowy] 
	/*(vDP_Koszt_maszyn_dodatkowe_ofertowy.[Koszt maszyn dodatkowe ofertowy] +
	vDP_Koszt_maszyn_wydruk_ofertowy.[Koszt maszyn wydruk przed] +
	vDP_Koszt_materialu_dodatkowe_ofertowy.[Koszt material dodatkowe]+
	vDP_Koszt_materialu_wydruk_ofertowy.[Koszt materialu wydruk] +
	vDP_Koszt_pracownika_ofertowy.[Koszt pracownika przed]) AS [Koszt ofertowy]*/
FROM DP_Proces_technologiczny INNER JOIN
	vDP_Koszt_maszyn_dodatkowe_ofertowy ON DP_Proces_technologiczny.Id_proces_technologiczny=vDP_Koszt_maszyn_dodatkowe_ofertowy.Id_proces_technologiczny
INNER JOIN vDP_Koszt_maszyn_wydruk_ofertowy ON DP_Proces_technologiczny.Id_proces_technologiczny=vDP_Koszt_maszyn_wydruk_ofertowy.Id_proces_technologiczny
INNER JOIN vDP_Koszt_materialu_dodatkowe_ofertowy ON DP_Proces_technologiczny.Id_proces_technologiczny=vDP_Koszt_maszyn_dodatkowe_ofertowy.Id_proces_technologiczny
INNER JOIN vDP_Koszt_materialu_wydruk_ofertowy ON DP_Proces_technologiczny.Id_proces_technologiczny=vDP_Koszt_materialu_wydruk_ofertowy.Id_proces_technologiczny
INNER JOIN vDP_Koszt_pracownika_ofertowy ON DP_Proces_technologiczny.Id_proces_technologiczny=vDP_Koszt_pracownika_ofertowy.Id_proces_technologiczny
GROUP BY DP_Proces_technologiczny.Id_proces_technologiczny
GO

CREATE VIEW vDP_Kosztorys_ofertowy
AS
SELECT DP_Proces_technologiczny.Id_proces_technologiczny,
	ROUND((vDP_K_ofertowy.[Koszt maszyn1 ofertowy] + vDP_K_ofertowy.[Koszt maszyn2 ofertowy] + 
	vDP_K_ofertowy.[Koszt materialu1 ofertowy] + vDP_K_ofertowy.[Koszt materialu2 ofertowy] +
	vDP_K_ofertowy.[Koszt pracownik ofertowy]),2) AS [Koszt ofertowy]
FROM DP_Proces_technologiczny INNER JOIN 
	vDP_K_ofertowy ON DP_Proces_technologiczny.Id_proces_technologiczny=vDP_K_ofertowy.Id_proces_technologiczny
GO


CREATE VIEW vDP_K_powykonawczy
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny,
	sum(vDP_Koszt_maszyn_dodatkowe_powykonawczy.[Koszt maszyn czyn_dodatkowe powykonawczy]) AS [Koszt maszyn1 powykonawczy],
	sum(vDP_Koszt_maszyn_wydruk_powykonawczy.[Koszt maszyn wydruk powykonawczy])AS [Koszt maszyn2 powykonawczy],
	sum(vDP_Koszt_materialu_dodatkowe_powykonawczy.[Koszt material cz_dodatkowe powykonawczy]) AS [Koszt materialu1 powykonawczy], 
	sum(vDP_Koszt_materialu_wydruk_powykonawczy.[Koszt materialu powykonawczy]) AS [Koszt materialu2 powykonawczy],
	sum(vDP_Koszt_pracownika_powykonawczy.[Koszt pracownika]) AS [Koszt pracownik powykonawczy]
	/*(vDP_Koszt_maszyn_dodatkowe_powykonawczy.[Koszt maszyn czyn_dodatkowe powykonawczy]+
	vDP_Koszt_maszyn_wydruk_powykonawczy.[Koszt maszyn wydruk powykonawczy]+
	vDP_Koszt_materialu_dodatkowe_powykonawczy.[Koszt material cz_dodatkowe powykonawczy]+ 
	vDP_Koszt_materialu_wydruk_powykonawczy.[Koszt materialu powykonawczy]+
	vDP_Koszt_pracownika_powykonawczy.[Koszt pracownika]) AS [Koszt powykonawczy]*/
FROM DP_Proces_produkcyjny INNER JOIN
	vDP_Koszt_maszyn_dodatkowe_powykonawczy ON DP_Proces_produkcyjny.Id_proces_produkcyjny=vDP_Koszt_maszyn_dodatkowe_powykonawczy.Id_proces_produkcyjny
INNER JOIN vDP_Koszt_maszyn_wydruk_powykonawczy ON DP_Proces_produkcyjny.Id_proces_produkcyjny=vDP_Koszt_maszyn_wydruk_powykonawczy.Id_proces_produkcyjny
INNER JOIN vDP_Koszt_materialu_dodatkowe_powykonawczy ON DP_Proces_produkcyjny.Id_proces_produkcyjny=vDP_Koszt_materialu_dodatkowe_powykonawczy.Id_proces_produkcyjny
INNER JOIN vDP_Koszt_materialu_wydruk_powykonawczy ON DP_Proces_produkcyjny.Id_proces_produkcyjny=vDP_Koszt_materialu_wydruk_powykonawczy.Id_proces_produkcyjny
INNER JOIN vDP_Koszt_pracownika_powykonawczy ON DP_Proces_produkcyjny.Id_proces_produkcyjny=vDP_Koszt_pracownika_powykonawczy.Id_proces_produkcyjny
GROUP BY DP_Proces_produkcyjny.Id_proces_produkcyjny 
GO

CREATE VIEW vDP_Kosztorys_powykonawczy
AS
SELECT DP_Proces_produkcyjny.Id_proces_produkcyjny,
	(vDP_K_powykonawczy.[Koszt maszyn1 powykonawczy] + vDP_K_powykonawczy.[Koszt maszyn2 powykonawczy] +
	vDP_K_powykonawczy.[Koszt materialu1 powykonawczy] + vDP_K_powykonawczy.[Koszt materialu2 powykonawczy] +
	vDP_K_powykonawczy.[Koszt pracownik powykonawczy]) AS [Koszt powykonawczy]
FROM DP_Proces_produkcyjny INNER JOIN
	vDP_K_powykonawczy ON DP_Proces_produkcyjny.Id_proces_produkcyjny=vDP_K_powykonawczy.Id_proces_produkcyjny
GO

CREATE VIEW vDZ_Wydanie_faktury
AS
SELECT DZ_Status_zamowienia.Id_zamowienia AS [Numer faktury], DZ_Szczegoly_zamowienia_klienta.Ilosc_sztuk AS [Ilość sztuk], DZ_Plik.Nazwa_pliku AS [Nazwa pliku], DZ_Rodzaj_statusu_zamowienia.Status_zam AS [Status zamówienia], DZ_Klient.Nip AS [NIP],DZ_Klient.Nazwa_firmy AS [Nazwa firmy], DZ_Klient.Imie AS [Imię], DZ_Klient.Nazwisko, DZ_Klient.Adres, DZ_Klient.Kod_pocztowy AS [Kod pocztowy], DZ_Klient.Miasto, DZ_Klient.Numer_rachunku AS [Numer rachunku],vDP_Kosztorys_powykonawczy.[Koszt powykonawczy],
CASE WHEN (DZ_Rodzaj_statusu_zamowienia.Status_zam='zrealizowane') THEN 'Wystawiono fakture' 
	 ELSE 'Nie wystawiono faktury' END AS 'Wydanie faktury',
CASE WHEN (DZ_Rodzaj_statusu_zamowienia.Status_zam='zrealizowane') THEN [Koszt powykonawczy]
	 ELSE 0 END AS [Kwota na fakturze]
FROM DZ_Status_zamowienia INNER JOIN
DZ_Rodzaj_statusu_zamowienia ON DZ_Status_zamowienia.Id_rodzaj_statusu_zam=DZ_Rodzaj_statusu_zamowienia.Id_rodzaj_statusu_zam INNER JOIN
DZ_Szczegoly_zamowienia_klienta ON DZ_Status_zamowienia.Id_zamowienia=DZ_Szczegoly_zamowienia_klienta.Id_zamowienia INNER JOIN
DZ_Zamowienie_klienta ON DZ_Status_zamowienia.Id_zamowienia=DZ_Zamowienie_klienta.Id_zamowienia INNER JOIN
DZ_Plik ON DZ_Szczegoly_zamowienia_klienta.Id_pliku=DZ_Plik.Id_pliku INNER JOIN
DZ_Klient ON DZ_Zamowienie_klienta.Id_klienta=DZ_Klient.Id_klienta INNER JOIN
vDP_Kosztorys_powykonawczy ON DZ_Zamowienie_klienta.Id_zamowienia=vDP_Kosztorys_powykonawczy.Id_proces_produkcyjny
GO
CREATE VIEW vDZ_Oferta_dla_klienta
AS
SELECT DZ_Zamowienie_klienta.Id_zamowienia AS [Numer zamowienia], DZ_Rodzaj_statusu_zamowienia.Status_zam AS [Status zamowienia], DZ_Klient.Nip, DZ_Klient.Nazwa_firmy AS [Nazwa firmy], DZ_Szczegoly_zamowienia_klienta.Ilosc_sztuk AS [Ilosc sztuk], (vDP_Kosztorys_ofertowy.[Koszt ofertowy]), ([Koszt ofertowy]*0.25) AS 'Współczynnik bezpieczeństwa', (([Koszt ofertowy]*0.25)+vDP_Kosztorys_ofertowy.[Koszt ofertowy]) AS 'Kwota oferty'
FROM DZ_Zamowienie_klienta INNER JOIN
DZ_Status_zamowienia ON DZ_Zamowienie_klienta.Id_zamowienia=DZ_Status_zamowienia.Id_zamowienia INNER JOIN
DZ_Rodzaj_statusu_zamowienia ON DZ_Status_zamowienia.Id_rodzaj_statusu_zam=DZ_Rodzaj_statusu_zamowienia.Id_rodzaj_statusu_zam INNER JOIN
DZ_Klient ON DZ_Zamowienie_klienta.Id_klienta=DZ_Klient.Id_klienta INNER JOIN
DZ_Szczegoly_zamowienia_klienta ON DZ_Zamowienie_klienta.Id_zamowienia=DZ_Szczegoly_zamowienia_klienta.Id_zamowienia INNER JOIN
vDP_Kosztorys_ofertowy ON DZ_Zamowienie_klienta.Id_zamowienia=vDP_Kosztorys_ofertowy.Id_proces_technologiczny
GROUP BY DZ_Zamowienie_klienta.Id_zamowienia,DZ_Rodzaj_statusu_zamowienia.Status_zam,DZ_Klient.Nip,DZ_Klient.Nazwa_firmy,DZ_Szczegoly_zamowienia_klienta.Ilosc_sztuk, vDP_Kosztorys_ofertowy.[Koszt ofertowy]
GO
CREATE VIEW vDZ_Wplyw
AS
SELECT vDZ_Wydanie_faktury.[Numer faktury], vDZ_Wydanie_faktury.[Status zamówienia], vDZ_Wydanie_faktury.NIP, vDZ_Wydanie_faktury.Imię, vDZ_Wydanie_faktury.Nazwisko, vDP_Kosztorys_powykonawczy.[Koszt powykonawczy],
CASE WHEN vDZ_Wydanie_faktury.[Status zamówienia]='zrealizowane' THEN 'OPŁACONE'
	 ELSE 'NIE OPŁACONO' END AS 'Status wpływu',
CASE WHEN (vDZ_Wydanie_faktury.[Status zamówienia]='zrealizowane') THEN vDP_Kosztorys_powykonawczy.[Koszt powykonawczy]
	 ELSE 0 END AS [Kwota wpływu]
FROM vDZ_Wydanie_faktury CROSS JOIN DZ_Szczegoly_zatrudnienia  INNER JOIN
DZ_Zatrudnienie ON DZ_Szczegoly_zatrudnienia.Id_zatrudnienia=DZ_Zatrudnienie.Id_zatrudnienia INNER JOIN
DZ_Pracownik ON DZ_Zatrudnienie.Id_pracownika=DZ_Pracownik.Id_pracownika INNER JOIN
DZ_Nieobecnosc ON DZ_Pracownik.Id_pracownika=DZ_Nieobecnosc.Id_pracownika INNER JOIN
DZ_Rodzaj_nieobecnosci ON DZ_Nieobecnosc.Id_rodzaj_nieobecnosci=DZ_Rodzaj_nieobecnosci.Id_rodzaj_nieobecnosci INNER JOIN
vDP_Kosztorys_powykonawczy ON vDZ_Wydanie_faktury.[Numer faktury]=vDP_Kosztorys_powykonawczy.Id_proces_produkcyjny
GROUP BY vDZ_Wydanie_faktury.[Numer faktury], vDZ_Wydanie_faktury.[Status zamówienia], vDZ_Wydanie_faktury.NIP, vDZ_Wydanie_faktury.Imię, vDZ_Wydanie_faktury.Nazwisko, vDP_Kosztorys_powykonawczy.[Koszt powykonawczy]
GO
CREATE VIEW vDZ_Przychod
AS
SELECT SUM(vDZ_Wplyw.[Kwota wpływu]) AS 'Przychód'
FROM vDZ_Wplyw
GO
CREATE VIEW vDZ_Suma_wyplat
AS 
SELECT SUM(vDZ_Wyplata.Wypłata) AS 'Suma Wypłat'
FROM vDZ_Wyplata
GO
CREATE VIEW vDZ_Suma_oplat
AS 
SELECT SUM(vDZ_Oplaty_stale.Koszt) AS 'Suma Opłat'
FROM vDZ_Oplaty_stale
GO
CREATE VIEW vDZ_Suma_kosztow
AS 
SELECT SUM(vDZ_Koszty_zewnetrzne.Koszt) AS 'Suma Kosztów'
FROM vDZ_Koszty_zewnetrzne
GO
CREATE VIEW vDZ_Rozchod
AS
SELECT (vDZ_Suma_kosztow.[Suma Kosztów]+vDZ_Suma_oplat.[Suma Opłat]+vDZ_Suma_wyplat.[Suma Wypłat]) AS 'Rozchód'
FROM vDZ_Suma_kosztow, vDZ_Suma_oplat, vDZ_Suma_wyplat
GO
CREATE VIEW vDZ_Bilans
AS
SELECT vDZ_Przychod.Przychód, vDZ_Rozchod.Rozchód, ROUND((vDZ_Przychod.Przychód-vDZ_Rozchod.Rozchód),2) AS 'Zysk/Strata',
CASE WHEN (vDZ_Przychod.Przychód-vDZ_Rozchod.Rozchód) <0 THEN 'STRATA'
	 ELSE 'ZYSK' END AS 'Wynik bilansu'
FROM vDZ_Przychod, vDZ_Rozchod
GO

CREATE VIEW vDP_Ostatnia_obsluga_biezaca
AS
SELECT DP_Maszyna.Id_maszyny, DP_Maszyna.Nr_seryjny, DP_Maszyna.Data_wprowadzenia, CONVERT (date, CURRENT_TIMESTAMP) AS [Dzisiejsza data], DP_Co_ile_obsluga.Co_ile_obsluga, 
DP_Nazwa_obslugi.Nazwa_obslugi AS [Nazwa obsługi], 
DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia, 
abs(DATEDIFF(day,CONVERT (date, CURRENT_TIMESTAMP) , DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia)) AS DateDiff 
FROM DP_Obsluga
FULL OUTER JOIN DP_Rodzaj_maszyny ON DP_Obsluga.Id_rodzaj_maszyny = DP_Obsluga.Id_rodzaj_maszyny
INNER JOIN DP_Maszyna ON DP_Rodzaj_maszyny.Id_rodzaj_maszyny= DP_Maszyna.Id_rodzaj_maszyny
INNER JOIN DP_Co_ile_obsluga ON DP_Obsluga.Id_co_ile_obsluga = DP_Co_ile_obsluga.Id_co_ile_obsluga
FULL OUTER JOIN DP_Nazwa_obslugi ON DP_Obsluga.Id_nazwa_obslugi = DP_Nazwa_obslugi.Id_nazwa_obslugi
FULL OUTER JOIN DP_Czynnosc_w_ramach_obslugi_serw_wew ON DP_Nazwa_obslugi.Id_nazwa_obslugi = DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_nazwa_obslugi
FULL OUTER JOIN DP_Serwis_wewnetrzny_obsluga ON DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_czynnosc_w_ramach_obslugi_serw_wew = DP_Serwis_wewnetrzny_obsluga.Id_czynnosc_w_ramach_obslugi_serw_wew
WHERE DP_Nazwa_obslugi.Nazwa_obslugi like('biezaca') and DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia is not null;
GO

CREATE VIEW vDP_Ostatnia_obsluga_okresowa
AS
SELECT DP_Maszyna.Id_maszyny, DP_Maszyna.Nr_seryjny, DP_Maszyna.Data_wprowadzenia, CONVERT (date, CURRENT_TIMESTAMP) AS [Dzisiejsza data], DP_Co_ile_obsluga.Co_ile_obsluga, 
DP_Nazwa_obslugi.Nazwa_obslugi AS [Nazwa obsługi], 
DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia, 
abs(DATEDIFF(day,CONVERT (date, CURRENT_TIMESTAMP) , DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia)) AS DateDiff 
FROM DP_Obsluga
FULL OUTER JOIN DP_Rodzaj_maszyny ON DP_Obsluga.Id_rodzaj_maszyny = DP_Obsluga.Id_rodzaj_maszyny
INNER JOIN DP_Maszyna ON DP_Rodzaj_maszyny.Id_rodzaj_maszyny= DP_Maszyna.Id_rodzaj_maszyny
INNER JOIN DP_Co_ile_obsluga ON DP_Obsluga.Id_co_ile_obsluga = DP_Co_ile_obsluga.Id_co_ile_obsluga
FULL OUTER JOIN DP_Nazwa_obslugi ON DP_Obsluga.Id_nazwa_obslugi = DP_Nazwa_obslugi.Id_nazwa_obslugi
FULL OUTER JOIN DP_Czynnosc_w_ramach_obslugi_serw_wew ON DP_Nazwa_obslugi.Id_nazwa_obslugi = DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_nazwa_obslugi
FULL OUTER JOIN DP_Serwis_wewnetrzny_obsluga ON DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_czynnosc_w_ramach_obslugi_serw_wew = DP_Serwis_wewnetrzny_obsluga.Id_czynnosc_w_ramach_obslugi_serw_wew
WHERE DP_Nazwa_obslugi.Nazwa_obslugi like('okresowa');
go

CREATE VIEW vDP_Ostatnia_obsluga_profilaktyczny
AS
SELECT DP_Maszyna.Id_maszyny, DP_Maszyna.Nr_seryjny, DP_Maszyna.Data_wprowadzenia, CONVERT (date, CURRENT_TIMESTAMP) AS [Dzisiejsza data], DP_Co_ile_obsluga.Co_ile_obsluga, 
DP_Nazwa_obslugi.Nazwa_obslugi AS [Nazwa obsługi], 
DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia, 
abs(DATEDIFF(day,CONVERT (date, CURRENT_TIMESTAMP) , DP_Serwis_wewnetrzny_obsluga.Data_zakonczenia)) AS DateDiff 
FROM DP_Obsluga
FULL OUTER JOIN DP_Rodzaj_maszyny ON DP_Obsluga.Id_rodzaj_maszyny = DP_Obsluga.Id_rodzaj_maszyny
INNER JOIN DP_Maszyna ON DP_Rodzaj_maszyny.Id_rodzaj_maszyny= DP_Maszyna.Id_rodzaj_maszyny
INNER JOIN DP_Co_ile_obsluga ON DP_Obsluga.Id_co_ile_obsluga = DP_Co_ile_obsluga.Id_co_ile_obsluga
FULL OUTER JOIN DP_Nazwa_obslugi ON DP_Obsluga.Id_nazwa_obslugi = DP_Nazwa_obslugi.Id_nazwa_obslugi
FULL OUTER JOIN DP_Czynnosc_w_ramach_obslugi_serw_wew ON DP_Nazwa_obslugi.Id_nazwa_obslugi = DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_nazwa_obslugi
FULL OUTER JOIN DP_Serwis_wewnetrzny_obsluga ON DP_Czynnosc_w_ramach_obslugi_serw_wew.Id_czynnosc_w_ramach_obslugi_serw_wew = DP_Serwis_wewnetrzny_obsluga.Id_czynnosc_w_ramach_obslugi_serw_wew
WHERE DP_Nazwa_obslugi.Nazwa_obslugi like('profilaktyczny');
go