USE master
GO
DROP DATABASE Drukarnia
GO
CREATE DATABASE Drukarnia
GO
USE Drukarnia
GO
CREATE TABLE DM_Rodzaj_materialu (
	Id_rodzaj_materialu int identity(1,1) not null PRIMARY KEY,
	Rodzaj_materialu nvarchar(30) not null
);
CREATE TABLE DM_Wlasciwosc(
	Id_wlasciwosc int identity(1,1) not null PRIMARY KEY,
	Nazwa_wlasciwosci nvarchar(30) not null,
	Jednostka_pomiarowa nvarchar(15) not null
);
CREATE TABLE DM_Material(
	Id_materialu int identity(1,1) not null PRIMARY KEY,
	Id_rodzaj_materialu int not null FOREIGN KEY REFERENCES DM_Rodzaj_materialu (Id_rodzaj_materialu),
	Nazwa nvarchar(30) not null,
);
CREATE TABLE DM_Wlasciwosc_materialu (
	Id_materialu int not null FOREIGN KEY REFERENCES DM_Material (Id_materialu),
	Id_wlasciwosc int not null FOREIGN KEY REFERENCES DM_Wlasciwosc (Id_wlasciwosc),
	Wartosc nvarchar(20) not null
);
CREATE TABLE DM_Rodzaj_narzedzia (
	Id_rodzaj_narzedzia int identity(1,1) not null PRIMARY KEY,
	Nazwa nvarchar(30)
);
CREATE TABLE DM_Narzedzie (
	Id_narzedzia int identity(1,1) not null PRIMARY KEY,
	Nazwa nvarchar(30) not null,
	Id_rodzaj_narzedzia int not null FOREIGN KEY REFERENCES DM_Rodzaj_narzedzia (Id_rodzaj_narzedzia),
	Ilosc_poczatkowa int not null
);
CREATE TABLE DM_Dostawca(
	Id_dostawcy int identity(1,1) NOT NULL PRIMARY KEY, 
        Nazwa nvarchar(40) NOT NULL,
	NIP nvarchar(15) NOT NULL, 
	Uwagi nvarchar(200) NOT NULL
);
CREATE TABLE DP_Produkt(
	Id_produkt int IDENTITY(1,1) PRIMARY KEY NOT NULL,  
	Nazwa_produktu nvarchar(50),
	Uwagi nvarchar(55),
);
CREATE TABLE DP_Model_maszyny(
	Id_model_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Nazwa_modelu_maszyny nvarchar(30) NOT NULL
	);
CREATE TABLE DP_Rodzaj_maszyny(
	Id_rodzaj_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Rodzaj_maszyny nvarchar(30) NOT NULL
	);
CREATE TABLE DP_Maszyna(
	Id_maszyny int IDENTITY(1,1) NOT NULL  PRIMARY KEY,
	Id_rodzaj_maszyny int FOREIGN KEY REFERENCES DP_Rodzaj_maszyny(Id_rodzaj_maszyny),
	Id_model_maszyny int FOREIGN KEY REFERENCES DP_Model_maszyny(Id_model_maszyny),
	Nr_seryjny nvarchar(30) NOT NULL,
	Data_wprowadzenia date NOT NULL,
	Koszt_1rh money NOT NULL
);

CREATE TABLE DM_Czesc(
    Id_czesci int identity(1,1) PRIMARY KEY,
	Nazwa nvarchar(40) NOT NULL,
	Id_model_maszyny int NOT NULL FOREIGN KEY REFERENCES DP_Model_maszyny(id_model_maszyny),
    Ilosc_poczatkowa int NOT NULL, 
);
CREATE TABLE DZ_Rodzaj_rachunku(
	Id_rodzaj_rachunku int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Rodzaj_rachunku nvarchar(30) NOT NULL, 
	);

CREATE TABLE DZ_Rachunek(
	Id_rachunki int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_rodzaj_rachunku int FOREIGN KEY REFERENCES DZ_Rodzaj_rachunku(Id_rodzaj_rachunku), 
	Koszt float NOT NULL,
	Data_zaplaty date NOT NULL
	);

CREATE TABLE DZ_Pracownik(
	Id_pracownika int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Imie nvarchar(20) NOT NULL, 
	Nazwisko nvarchar(20) NOT NULL,
	Email nvarchar(40) NOT NULL,
	Adres nvarchar(30) NOT NULL,
	Miasto nvarchar(40) NOT NULL,
	Kod_pocztowy nvarchar(10) NOT NULL,
	Data_urodzenia date NOT NULL,
	Telefon nvarchar(12) NOT NULL,
	Numer_rachunku nvarchar(25) NOT NULL);

CREATE TABLE DZ_Klient(
	Id_klienta int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Nazwa_firmy nvarchar(30) NOT NULL, 
	Nip nvarchar(15) NOT NULL,
	Imie nvarchar(20) NOT NULL,
	Nazwisko nvarchar(40) NOT NULL,
	Adres nvarchar(30) NOT NULL,
	Miasto nvarchar(40) NOT NULL,
	Kod_pocztowy nvarchar(10) NOT NULL,
	Email nvarchar(40) NOT NULL,
	Telefon nvarchar(12) NOT NULL,
	Numer_rachunku nvarchar(25) NOT NULL);

CREATE TABLE DZ_Rodzaj_nieobecnosci(
	Id_rodzaj_nieobecnosci int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Rodzaj nvarchar(30) NOT NULL, 
	Procent_pensji float NOT NULL,
	);

CREATE TABLE DZ_Nieobecnosc(
	Id_nieobecnosci int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
	Id_rodzaj_nieobecnosci int FOREIGN KEY REFERENCES DZ_Rodzaj_nieobecnosci(Id_rodzaj_nieobecnosci), 
	Data_rozpoczecia date NOT NULL,
	Data_zakonczenia date NOT NULL
	);

CREATE TABLE DZ_Stanowisko(
	Id_stanowiska int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Stanowisko nvarchar(30) NOT NULL, 
	);

CREATE TABLE DZ_Etat(
	Id_etatu int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Etat float NOT NULL
	);

CREATE TABLE DZ_Rodzaj_umowy(
	Id_rodzaj_umowy int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Rodzaj_umowy nvarchar(30) NOT NULL
	);

CREATE TABLE DZ_Dzial(
	Id_dzialu int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Dzial nvarchar(30) NOT NULL
	);

CREATE TABLE DZ_Zatrudnienie(
	Id_zatrudnienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
	Id_stanowiska int FOREIGN KEY REFERENCES DZ_Stanowisko(Id_stanowiska), 
	Id_dzialu int FOREIGN KEY REFERENCES DZ_Dzial(Id_dzialu),
	Id_etatu int FOREIGN KEY REFERENCES DZ_Etat(Id_etatu),
	Id_rodzaj_umowy int FOREIGN KEY REFERENCES DZ_Rodzaj_umowy(Id_rodzaj_umowy),
	Data_zatrudnienia date NOT NULL,
	Data_zwolnienia date NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zatrudnienia(
	Id_szczegoly_zatrudnienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zatrudnienia int FOREIGN KEY REFERENCES DZ_Zatrudnienie(Id_zatrudnienia), 
	Data_zmiany_wynagrodzenia date NOT NULL,
	Podstawa_wynagrodzenia float NOT NULL
	);

CREATE TABLE DZ_Zamowienie_klienta(
	Id_zamowienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_klienta int FOREIGN KEY REFERENCES DZ_Klient(Id_klienta), 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
	Data_zamowienia date NOT NULL,
	Oczekiwany_termin_wykonania date NOT NULL
	);
CREATE TABLE DZ_Plik(
	Id_pliku int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Nazwa_pliku nvarchar(50) NOT NULL,
	Zalacznik nvarchar(30) NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zamowienia_klienta(
	Id_szczegoly_zam_klienta int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia int FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_zamowienia), 
	Id_pliku int FOREIGN KEY REFERENCES DZ_Plik(Id_pliku), 
	Ilosc_sztuk int NOT NULL,
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
	);

CREATE TABLE DZ_Wycena_sz_zamowienia(
	Id_wycena_sz_zamowienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_szczegoly_zam_klienta int FOREIGN KEY REFERENCES DZ_Szczegoly_zamowienia_klienta(Id_szczegoly_zam_klienta), 
	Id_pliku int FOREIGN KEY REFERENCES DZ_Plik(Id_pliku), 
	Koszt float NOT NULL,
	Czas_wykonania int NOT NULL
	);

CREATE TABLE DZ_Rodzaj_statusu_zamowienia(
	Id_rodzaj_statusu_zam int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Status_zam nvarchar(50) NOT NULL
	);

CREATE TABLE DZ_Status_zamowienia(
	Id_status_zam int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia int FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_zamowienia), 
	Id_rodzaj_statusu_zam int FOREIGN KEY REFERENCES DZ_Rodzaj_statusu_zamowienia(Id_rodzaj_statusu_zam), 
	);

CREATE TABLE DZ_Zamowienie_zewn(
	Id_zamowienia_zewn int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Data_zamowienia_zewn date NOT NULL 
	);

CREATE TABLE DZ_Szczegoly_zam_maszyn(
	Id_szczegoly_zam_maszyn int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny), 
	Koszt_jednostkowy_oferta float NOT NULL,
	Ilosc int NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zam_materialu(
	Id_szczegoly_zam_materialu int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
	Koszt_jednostkowy_oferta float NOT NULL,
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_Wlasciwosc(Id_wlasciwosc),
	Ilosc int NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zam_czesci(
	Id_szczegoly_zam_czesci int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_czesci int FOREIGN KEY REFERENCES DM_Czesc(Id_czesci), 
	Koszt_jednostkowy_oferta float NOT NULL,
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_Wlasciwosc(Id_wlasciwosc),
	Ilosc int NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zam_narzedzi(
	Id_szczegoly_zam_narzedzi int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia), 
	Koszt_jednostkowy_oferta float NOT NULL,
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_Wlasciwosc(Id_wlasciwosc),
	Ilosc int NOT NULL
	);

CREATE TABLE DZ_Po_szczegoly_zam_produkt(
	Id_szczegoly_zam_klienta int FOREIGN KEY REFERENCES DZ_Szczegoly_zamowienia_klienta(Id_szczegoly_zam_klienta),
	Id_produkt int FOREIGN KEY REFERENCES DP_Produkt(Id_produkt)
);

CREATE TABLE DM_Magazyn_gotowych_produktow(
	Id_magazynu_gotowych_produktow int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_zamowienie int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_Zamowienia),
	Data_i_godzina_przyjecia datetime NOT NULL,
	Uwagi nvarchar(200) NOT NULL
);
CREATE TABLE DM_Wydanie_produktu (
	Id_wydania int identity(1,1) not null PRIMARY KEY,
	Id_magazyn_gotowych_produktow int not null FOREIGN KEY REFERENCES DM_Magazyn_gotowych_produktow (Id_magazynu_gotowych_produktow),
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik (Id_pracownika),
	Data_i_godzina DATETIME,
	Uwagi nvarchar (100)
);
CREATE TABLE DM_Szczegoly_wydania_produktu (
	Id_wydania int not null FOREIGN KEY REFERENCES DM_Wydanie_produktu (Id_wydania),
	Id_produkt int not null FOREIGN KEY REFERENCES DP_Produkt (Id_Produkt),
	Ilosc int not null
);
CREATE TABLE DM_Wypozyczenie_narzedzia (
	Id_wypozyczenia_narzedzia int identity(1,1) not null PRIMARY KEY,
	Id_pracownika_wypozyczajacego int not null FOREIGN KEY REFERENCES DZ_Pracownik (Id_pracownika),
	Id_pracownika_wydajacego int not null FOREIGN KEY REFERENCES DZ_Pracownik (Id_pracownika),
	Data_i_godzina_wypozyczenia DATE,
	Data_i_godzina_zwrotu DATE,
	Uwagi nvarchar (100)
);
CREATE TABLE DM_Zuzyte_narzedzie (
	Id_zuzycia int identity(1,1) not null PRIMARY KEY,
	Id_wypozyczenia_narzedzia int not null FOREIGN KEY REFERENCES DM_Wypozyczenie_narzedzia (Id_wypozyczenia_narzedzia),
	Id_narzedzia int not null FOREIGN KEY REFERENCES DM_Narzedzie (Id_narzedzia),
	Data_zuzycia DATETIME,
	Ilosc int not null,
	Uwagi nvarchar (100)
);
CREATE TABLE DM_Szczegoly_wypozyczenia_narzedzia (
	Id_wypozyczenia_narzedzia int not null FOREIGN KEY REFERENCES DM_Wypozyczenie_narzedzia (Id_wypozyczenia_narzedzia),
	Id_narzedzia int not null FOREIGN KEY REFERENCES DM_Narzedzie (Id_narzedzia),
	Ilosc int not null
);
CREATE TABLE DM_Parametr_narzedzia (
	Id_narzedzia int not null FOREIGN KEY REFERENCES DM_Narzedzie (Id_narzedzia),
	Id_wlasciwosc int not null FOREIGN KEY REFERENCES DM_Wlasciwosc (Id_wlasciwosc),
	Wartosc nvarchar(10) not null
);
CREATE TABLE DM_Dostawa_materialu(
	Id_dostawy int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Data_dostawy datetime NOT NULL,
	Uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Dostawa_czesci(
	Id_dostawy int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Data_dostawy datetime NOT NULL,
	Uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Dostawa_narzedzi(
	Id_dostawy int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Data_dostawy DATE NOT NULL, 
	Uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Dostawa_maszyn(
	Id_dostawy int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Data_dostawy DATE NOT NULL, 
	Uwagi nvarchar(200) NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_maszyn(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_maszyn( Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawca(Id_dostawcy),
	Id_maszyn int NOT NULL FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    Ilosc int NOT NULL, 
	Cena_jednostkowa_maszyny int NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_narzedzi(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_narzedzi(Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawca(Id_dostawcy),
	Id_narzedzia int NOT NULL FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    Ilosc int NOT NULL, 
	Cena_jednostkowa_narzedzi int NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_czesci(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_czesci( Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawca(Id_dostawcy),
	Id_czesci int NOT NULL FOREIGN KEY REFERENCES DM_Czesc(Id_czesci), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    Ilosc int NOT NULL, 
	Cena_jednostkowa_czesci int NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_materialu(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_materialu( Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawca(Id_dostawcy),
	Id_materialu int NOT NULL FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    Ilosc int NOT NULL, 
	Cena_jednostkowa_materialu int NOT NULL
);
CREATE TABLE DM_Wydanie_czesci(
	Id_wydania_czesci int identity(1,1) NOT NULL PRIMARY KEY, 
	Id_pracownik_pobierajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
    Id_pracownik_wydajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
    Data_i_godzina DATETIME NOT NULL,
	Uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Szczegoly_wydania_czesci(
	Id_wydania_czesci int NOT NULL FOREIGN KEY REFERENCES DM_Wydanie_czesci(Id_wydania_czesci), 
    Id_czesci int NOT NULL FOREIGN KEY REFERENCES DM_Czesc(Id_czesci),
    Ilosc int NOT NULL, 
);
CREATE TABLE DM_Parametr_czesci(
    Id_czesci int FOREIGN KEY REFERENCES DM_czesc(id_czesci),
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_wlasciwosc(id_wlasciwosc),
	Wartosc varchar(60) NOT NULL
);
CREATE TABLE DM_Wybor_maszyny(
    Id_model_maszyny int FOREIGN KEY REFERENCES DP_Model_maszyny(Id_model_maszyny),
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
);

CREATE TABLE DM_Wydanie_materialu_dla_produkcji(
	Id_wydanie_materialu_dla_produkcji int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_zamowienia int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_Zamowienia),
	Id_pracownik_pobierajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
    Id_pracownik_wydajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
    Data_i_godzina datetime NOT NULL      
);

CREATE TABLE DM_Szczegoly_wydania_materialu(
	Id_wydanie_materialu_dla_produkcji int FOREIGN KEY REFERENCES DM_Wydanie_materialu_dla_produkcji(Id_wydanie_materialu_dla_produkcji), 
    Id_materialu int NOT NULL FOREIGN KEY REFERENCES DM_Material(Id_materialu),
	Ilosc int NOT NULL
);
CREATE TABLE DM_Szczegoly_magazynu_gotowych_produktow(
	Id_magazynu_gotowych_produktow int FOREIGN KEY REFERENCES DM_Magazyn_gotowych_produktow(Id_magazynu_gotowych_produktow), 
    Id_produktu int NOT NULL FOREIGN KEY REFERENCES DP_Produkt(Id_produkt),
    Ilosc int NOT NULL
);
CREATE TABLE DM_Wydanie_czesci_dla_produkcji(
	Id_wydania_czesci int identity(1,1) NOT NULL PRIMARY KEY, 
	Id_pracownik_pobierajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
    Id_pracownik_wydajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
    Data_i_godzina_wydania datetime NOT NULL,
	Uwagi nvarchar(200) NOT NULL      
);
/****Dzia³ Produkcji***/
CREATE TABLE DP_Wydruk(
	Id_wydruk int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Wypelnienie nvarchar(20) NOT NULL, 
	Estymowany_czas int,
	Estymowana_masa nvarchar(10),
	Id_pliku int FOREIGN KEY REFERENCES DZ_Plik(Id_pliku)
);

CREATE TABLE DP_Proces_technologiczny(
	Id_proces_technologiczny int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Nazwa nvarchar(150) NOT NULL
);

CREATE TABLE DP_Po_wydr_proc(
	Id_po_wydr_proces int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Id_wydruk int FOREIGN KEY REFERENCES DP_Wydruk(Id_wydruk), 
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny),
	Czas_zamierzony int NOT NULL
);

CREATE TABLE DP_Po_material_wydruk(
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
	Id_po_wydr_proc int FOREIGN KEY REFERENCES DP_po_wydr_proc(Id_po_wydr_proces), 
	Ilosc float NOT NULL,
);

CREATE TABLE DP_Rodzaj_czynnosci(
	Id_rodzaj_czynnosci int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Nazwa nvarchar(150) NOT NULL
);

CREATE TABLE DP_Po_proc_czynnosc(
	Id_po_proc_czynnosci int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Id_rodzaj_czynnosci int FOREIGN KEY REFERENCES DP_Rodzaj_czynnosci(Id_rodzaj_czynnosci),
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny),
	Czas_zamierzony datetime NOT NULL
);

CREATE TABLE DP_Po_narzedzia_czynnosc(
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosc(Id_po_proc_czynnosci), 
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia)
);

CREATE TABLE DP_Po_maszyna_czynnosc(
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosc(Id_po_proc_czynnosci),
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
);

CREATE TABLE DP_Po_prac_czynnosc(
	Id_pracownika int FOREIGN KEY REFERENCES DZ_pracownik(Id_pracownika), 
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosc(Id_po_proc_czynnosci),
);

CREATE TABLE DP_Po_material_czynnosc(
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosc(Id_po_proc_czynnosci),
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu),
	Ilosc int
);

CREATE TABLE DP_Po_maszyna_wydruk(
	Id_po_wydr_proces int FOREIGN KEY REFERENCES DP_Po_wydr_proc(Id_po_wydr_proces), 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
);


CREATE TABLE DP_Proces_produkt(
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny), 
	Id_produkt int FOREIGN KEY REFERENCES DP_Produkt(Id_produkt),
);
CREATE TABLE DP_Proces_produkcyjny(
	Id_proces_produkcyjny int IDENTITY(1,1) PRIMARY KEY NOT NULL,  
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny),
	Data_realizacji datetime,
);

CREATE TABLE DP_prod_material(
	Id_proces_produkcyjny int FOREIGN KEY REFERENCES DP_Proces_produkcyjny(Id_proces_produkcyjny),  
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu),
	Ilosc_zuzytego_materialu float
);

CREATE TABLE DP_prod_wydruk(
	Id_prod_wydruk int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Id_proces_produkcyjny int FOREIGN KEY REFERENCES DP_Proces_produkcyjny(Id_proces_produkcyjny),  
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
	Czas_wydruku int
);

CREATE TABLE DP_prod_czynnosc_dodatkowa(
	Id_prod_czynnosci_dodatkowe int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Id_proces_produkcyjny int FOREIGN KEY REFERENCES DP_Proces_produkcyjny(Id_proces_produkcyjny),  
	Id_rodzaj_czynnosci int FOREIGN KEY REFERENCES DP_Rodzaj_czynnosci(Id_rodzaj_czynnosci),
	Czas_pracy int
);

CREATE TABLE DP_po_prod_czyn_dod_maszyna(
	Id_prod_czynnosci_dodatkowe int FOREIGN KEY REFERENCES DP_prod_czynnosc_dodatkowa(Id_prod_czynnosci_dodatkowe),
	Id_maszyna int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
);

CREATE TABLE DP_po_prod_czyn_dod_pracownik(
	Id_prod_czynnosci_dodatkowe int FOREIGN KEY REFERENCES DP_prod_czynnosc_dodatkowa(Id_prod_czynnosci_dodatkowe),
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
);

CREATE TABLE DP_Zuzyta_maszyna(
	Id_zuzyte_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_maszyny  int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny), 
	Data_zuzycia_maszyny date,
	Uwagi nvarchar(30)
);

CREATE TABLE DP_Nazwa_obslugi(
	Id_nazwa_obslugi int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Nazwa_obslugi nvarchar(30) NOT NULL
);
CREATE TABLE DP_Czynnosc(
	Id_czynnosc int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Nazwa_czynnosci nvarchar(30) NOT NULL
);
CREATE TABLE DP_Czynnosc_w_ramach_obslugi_serw_wew(
	Id_czynnosc_w_ramach_obslugi_serw_wew int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_nazwa_obslugi int FOREIGN KEY REFERENCES DP_Nazwa_obslugi(Id_nazwa_obslugi),
	Id_czynnosc int FOREIGN KEY REFERENCES DP_Czynnosc(Id_Czynnosc)
);
CREATE TABLE DP_Co_ile_obsluga(
	Id_co_ile_obsluga int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Co_ile_obsluga int
);
CREATE TABLE DP_Obsluga(
	Id_obslugi int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_nazwa_obslugi int FOREIGN KEY REFERENCES DP_Nazwa_obslugi(Id_nazwa_obslugi),
	Id_rodzaj_maszyny int FOREIGN KEY REFERENCES DP_Rodzaj_maszyny(Id_rodzaj_maszyny),
	Id_co_ile_obsluga int FOREIGN KEY REFERENCES DP_Co_ile_obsluga(Id_co_ile_obsluga)
);
CREATE TABLE DP_Usluga_serwisu_zewnetrznego(
	Id_usluga_serwisu_zewnetrznego int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Nazwa_uslugi_serwisu_zewnetrznego nvarchar(30) NOT NULL
);
CREATE TABLE DP_Firma_serwisowa(
	Id_firma_serwisowa int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Nazwa_firmy nvarchar(30) NOT NULL,
	Adres nvarchar(30) NOT NULL,
	Miasto nvarchar(40) NOT NULL,
	Kod_pocztowy nvarchar(10) NOT NULL,
	Nr_tel nvarchar(30) NOT NULL,
	E_mail nvarchar(30) NOT NULL
	);

CREATE TABLE DP_Serwis_zewnetrzny(
	Id_serwis_zewnetrzny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_firma_serwisowa int FOREIGN KEY REFERENCES DP_Firma_serwisowa(Id_firma_serwisowa),
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
	Id_usluga_serwisu_zewnetrznego int FOREIGN KEY REFERENCES DP_Usluga_serwisu_zewnetrznego(Id_usluga_serwisu_zewnetrznego), 
	Koszt money NOT NULL,
	Data_rozpoczecia date NOT NULL,
	Data_zakonczenia date,
	Uwagi nvarchar(300)
);
CREATE TABLE DP_Serwis_wewnetrzny_naprawa(
	Id_serwis_wewnetrzny_naprawa int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
	Id_pracownik int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Data_rozpoczecia date NOT NULL,
	Data_zakonczenia date,
	Uwagi nvarchar(300) NOT NULL
	);


CREATE TABLE DP_Serwis_wewnetrzny_obsluga(
	Id_serwis_wewnetrzny_obsluga int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyna(Id_maszyny),
	Id_pracownik int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Id_czynnosc_w_ramach_obslugi_serw_wew int FOREIGN KEY REFERENCES DP_Czynnosc_w_ramach_obslugi_serw_wew(Id_czynnosc_w_ramach_obslugi_serw_wew),
	Data_rozpoczecia date NOT NULL,
	Data_zakonczenia date
	
	);

CREATE TABLE DP_Narzedzie_uzyte_obsluga(
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia),
    Id_serwis_wewnetrzny_obsluga int FOREIGN KEY REFERENCES DP_Serwis_wewnetrzny_obsluga(Id_serwis_wewnetrzny_obsluga)
	);


CREATE TABLE DP_Narzedzie_uzyte_naprawa(
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia),
    Id_serwis_wewnetrzny_naprawa int FOREIGN KEY REFERENCES DP_Serwis_wewnetrzny_naprawa(Id_serwis_wewnetrzny_naprawa)
	);

CREATE TABLE DP_Czesc_wykorzystana(
	Id_czesci int FOREIGN KEY REFERENCES DM_Czesc(Id_czesci),
    Id_serwis_wewnetrzny_naprawa int FOREIGN KEY REFERENCES DP_Serwis_wewnetrzny_naprawa(Id_serwis_wewnetrzny_naprawa)
	);
	