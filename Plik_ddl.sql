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
	rodzaj_materialu nvarchar(30) not null
);
CREATE TABLE DM_Wlasciwosc(
	Id_wlasciwosc int identity(1,1) not null PRIMARY KEY,
	nazwa_wlasciwosci nvarchar(30) not null,
	jednostka_pomiarowa nvarchar(15) not null
);
CREATE TABLE DM_Material (
	Id_materialu int identity(1,1) not null PRIMARY KEY,
	Id_rodzaj_materialu int not null FOREIGN KEY REFERENCES DM_Rodzaj_materialu (Id_rodzaj_materialu),
	nazwa nvarchar(30) not null,
);
CREATE TABLE DM_Wlasciwosci_materialu (
	Id_materialu int not null FOREIGN KEY REFERENCES DM_Material (Id_materialu),
	Id_wlasciwosc int not null FOREIGN KEY REFERENCES DM_Wlasciwosc (Id_wlasciwosc),
	wartosc nvarchar(20) not null
);
CREATE TABLE DM_Rodzaj_narzedzia (
	Id_rodzaj_narzedzia int identity(1,1) not null PRIMARY KEY,
	nazwa nvarchar(30)
);
CREATE TABLE DM_Narzedzie (
	Id_narzedzia int identity(1,1) not null PRIMARY KEY,
	nazwa nvarchar(30) not null,
	Id_rodzaj_narzedzia int not null FOREIGN KEY REFERENCES DM_Rodzaj_narzedzia (Id_rodzaj_narzedzia),
	ilosc_poczatkowa int not null
);
CREATE TABLE DM_Dostawcy(
	Id_dostawcy int identity(1,1) NOT NULL PRIMARY KEY, 
        nazwa nvarchar(40) NOT NULL,
	NIP nvarchar(15) NOT NULL, 
	uwagi nvarchar(200) NOT NULL
);
CREATE TABLE DP_Produkt(
	Id_produkt int IDENTITY(1,1) PRIMARY KEY NOT NULL,  
	nazwa_produktu nvarchar(50),
	uwagi nvarchar(55),
);
CREATE TABLE DP_Model_maszyny(
	Id_model_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	nazwa_modelu_maszyny nvarchar(30) NOT NULL
	);
CREATE TABLE DP_Rodzaj_maszyny(
	Id_rodzaj_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	rodzaj_maszyny nvarchar(30) NOT NULL
	);
CREATE TABLE DP_Maszyny(
	Id_maszyny int IDENTITY(1,1) NOT NULL  PRIMARY KEY,
	Id_rodzaj_maszyny int FOREIGN KEY REFERENCES DP_Rodzaj_maszyny(Id_rodzaj_maszyny),
	Id_model_maszyny int FOREIGN KEY REFERENCES DP_Model_maszyny(Id_model_maszyny),
	nr_seryjny nvarchar(30) NOT NULL,
	data_wprowadzenia date NOT NULL,
	koszt_1rh money NOT NULL
);

CREATE TABLE DM_Czesci(
    Id_czesci int identity(1,1) PRIMARY KEY,
	nazwa nvarchar(40) NOT NULL,
	Id_model_maszyny int NOT NULL FOREIGN KEY REFERENCES DP_Model_maszyny(id_model_maszyny),
    ilosc_poczatkowa int NOT NULL, 
);
CREATE TABLE DZ_Rodzaj_rachunku(
	Id_rodzaj_rachunku int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	rodzaj_rachunku nvarchar(30) NOT NULL, 
	);

CREATE TABLE DZ_Rachunki(
	Id_rachunki int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_rodzaj_rachunku int FOREIGN KEY REFERENCES DZ_Rodzaj_rachunku(Id_rodzaj_rachunku), 
	koszt float NOT NULL,
	data_zaplaty date NOT NULL
	);

CREATE TABLE DZ_Pracownik(
	Id_pracownika int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	imie nvarchar(20) NOT NULL, 
	nazwisko nvarchar(20) NOT NULL,
	email nvarchar(40) NOT NULL,
	adres nvarchar(30) NOT NULL,
	miasto nvarchar(40) NOT NULL,
	kod_pocztowy nvarchar(10) NOT NULL,
	data_urodzenia date NOT NULL,
	telefon nvarchar(12) NOT NULL,
	numer_rachunku nvarchar(25) NOT NULL);

CREATE TABLE DZ_Klient(
	Id_klienta int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	nazwa_firmy nvarchar(30) NOT NULL, 
	nip nvarchar(15) NOT NULL,
	imie nvarchar(20) NOT NULL,
	nazwisko nvarchar(40) NOT NULL,
	adres nvarchar(30) NOT NULL,
	miasto nvarchar(40) NOT NULL,
	kod_pocztowy nvarchar(10) NOT NULL,
	email nvarchar(40) NOT NULL,
	telefon nvarchar(12) NOT NULL,
	numer_rachunku nvarchar(25) NOT NULL);

CREATE TABLE DZ_Rodzaj_nieobecnosci(
	Id_rodzaj_nieobecnosci int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	rodzaj nvarchar(30) NOT NULL, 
	procent_pensji float NOT NULL,
	);

CREATE TABLE DZ_Nieobecnosc(
	Id_nieobecnosci int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
	Id_rodzaj_nieobecnosci int FOREIGN KEY REFERENCES DZ_Rodzaj_nieobecnosci(Id_rodzaj_nieobecnosci), 
	data_rozpoczecia date NOT NULL,
	data_zakonczenia date NOT NULL
	);

CREATE TABLE DZ_Stanowisko(
	Id_stanowiska int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	stanowisko nvarchar(30) NOT NULL, 
	);

CREATE TABLE DZ_Etat(
	Id_etatu int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	etat float NOT NULL
	);

CREATE TABLE DZ_Rodzaj_umowy(
	Id_rodzaj_umowy int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	rodzaj_umowy nvarchar(30) NOT NULL
	);

CREATE TABLE DZ_Dzial(
	Id_dzialu int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	dzial nvarchar(30) NOT NULL
	);

CREATE TABLE DZ_Zatrudnienie(
	Id_zatrudnienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
	Id_stanowiska int FOREIGN KEY REFERENCES DZ_Stanowisko(Id_stanowiska), 
	Id_dzialu int FOREIGN KEY REFERENCES DZ_Dzial(Id_dzialu),
	Id_etatu int FOREIGN KEY REFERENCES DZ_Etat(Id_etatu),
	Id_rodzaj_umowy int FOREIGN KEY REFERENCES DZ_Rodzaj_umowy(Id_rodzaj_umowy),
	data_zatrudnienia date NOT NULL,
	data_zwolnienia date NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zatrudnienia(
	Id_szczegoly_zatrudnienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zatrudnienia int FOREIGN KEY REFERENCES DZ_Zatrudnienie(Id_zatrudnienia), 
	data_zmiany_wynagrodzenia date NOT NULL,
	podstawa_wynagrodzenia float NOT NULL
	);

CREATE TABLE DZ_Zamowienie_klienta(
	Id_zamowienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_klienta int FOREIGN KEY REFERENCES DZ_Klient(Id_klienta), 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
	data_zamowienia date NOT NULL,
	oczekiwany_termin_wykonania date NOT NULL
	);
CREATE TABLE DZ_Plik(
	Id_pliku int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	nazwa_pliku nvarchar(50) NOT NULL,
	zalacznik nvarchar(30) NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zamowienia_klienta(
	Id_szczegoly_zam_klienta int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia int FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_zamowienia), 
	Id_pliku int FOREIGN KEY REFERENCES DZ_Plik(Id_pliku), 
	ilosc_sztuk int NOT NULL,
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
	);

CREATE TABLE DZ_Wycena_sz_zamowienia(
	Id_wycena_sz_zamowienia int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_szczegoly_zam_klienta int FOREIGN KEY REFERENCES DZ_Szczegoly_zamowienia_klienta(Id_szczegoly_zam_klienta), 
	Id_pliku int FOREIGN KEY REFERENCES DZ_Plik(Id_pliku), 
	koszt float NOT NULL,
	czas_wykonania int NOT NULL
	);

CREATE TABLE DZ_Rodzaj_statusu_zamowienia(
	Id_rodzaj_statusu_zam int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	status_zam nvarchar(50) NOT NULL
	);

CREATE TABLE DZ_Status_zamowienia(
	Id_status_zam int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia int FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_zamowienia), 
	Id_rodzaj_statusu_zam int FOREIGN KEY REFERENCES DZ_Rodzaj_statusu_zamowienia(Id_rodzaj_statusu_zam), 
	);

CREATE TABLE DZ_Zamowienie_zewn(
	Id_zamowienia_zewn int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	data_zamowienia_zewn date NOT NULL 
	);

CREATE TABLE DZ_Szczegoly_zam_maszyn(
	Id_szczegoly_zam_maszyn int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny), 
	koszt_jednostkowy_oferta float NOT NULL,
	ilosc int NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zam_materialu(
	Id_szczegoly_zam_materialu int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
	koszt_jednostkowy_oferta float NOT NULL,
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_Wlasciwosc(Id_wlasciwosc),
	ilosc int NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zam_czesci(
	Id_szczegoly_zam_czesci int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_czesci int FOREIGN KEY REFERENCES DM_Czesci(Id_czesci), 
	koszt_jednostkowy_oferta float NOT NULL,
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_Wlasciwosc(Id_wlasciwosc),
	ilosc int NOT NULL
	);

CREATE TABLE DZ_Szczegoly_zam_narzedzi(
	Id_szczegoly_zam_narzedzi int IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	Id_zamowienia_zewn int FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_zamowienia_zewn), 
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia), 
	koszt_jednostkowy_oferta float NOT NULL,
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_Wlasciwosc(Id_wlasciwosc),
	ilosc int NOT NULL
	);

CREATE TABLE DZ_Po_szczegoly_zam_produkt(
	Id_szczegoly_zam_klienta int FOREIGN KEY REFERENCES DZ_Szczegoly_zamowienia_klienta(Id_szczegoly_zam_klienta),
	Id_produkt int FOREIGN KEY REFERENCES DP_Produkt(Id_produkt)
);

CREATE TABLE DM_Magazyn_gotowych_produktow(
	Id_magazynu_gotowych_produktow int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_zamowienie int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_Zamowienia),
	data_i_godzina_przyjecia datetime NOT NULL,
	uwagi nvarchar(200) NOT NULL
);
CREATE TABLE DM_Wydanie_produktow (
	Id_wydania int identity(1,1) not null PRIMARY KEY,
	Id_magazyn_gotowych_produktow int not null FOREIGN KEY REFERENCES DM_Magazyn_gotowych_produktow (Id_magazynu_gotowych_produktow),
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik (Id_pracownika),
	data_i_godzina DATETIME,
	uwagi nvarchar (100)
);
CREATE TABLE DM_Szczegoly_wydania_produktu (
	Id_wydania int not null FOREIGN KEY REFERENCES DM_Wydanie_produktow (Id_wydania),
	Id_produkt int not null FOREIGN KEY REFERENCES DP_Produkt (Id_Produkt),
	ilosc int not null
);
CREATE TABLE DM_Wypozyczenie_narzedzia (
	Id_wypozyczenia_narzedzia int identity(1,1) not null PRIMARY KEY,
	Id_pracownika_wypozyczajacego int not null FOREIGN KEY REFERENCES DZ_Pracownik (Id_pracownika),
	Id_pracownika_wydajacego int not null FOREIGN KEY REFERENCES DZ_Pracownik (Id_pracownika),
	data_i_godzina_wypozyczenia DATE,
	data_i_godzina_zwrotu DATE,
	uwagi nvarchar (100)
);
CREATE TABLE DM_Zuzyte_narzedzia (
	Id_zuzycia int identity(1,1) not null PRIMARY KEY,
	Id_wypozyczenia_narzedzia int not null FOREIGN KEY REFERENCES DM_Wypozyczenie_narzedzia (Id_wypozyczenia_narzedzia),
	Id_narzedzia int not null FOREIGN KEY REFERENCES DM_Narzedzie (Id_narzedzia),
	data_zuzycia DATETIME,
	ilosc int not null,
	uwagi nvarchar (100)
);
CREATE TABLE DM_Szczegoly_wypozyczenia_narzedzia (
	Id_wypozyczenia_narzedzia int not null FOREIGN KEY REFERENCES DM_Wypozyczenie_narzedzia (Id_wypozyczenia_narzedzia),
	Id_narzedzia int not null FOREIGN KEY REFERENCES DM_Narzedzie (Id_narzedzia),
	ilosc int not null
);
CREATE TABLE DM_Parametry_narzedzia (
	Id_narzedzia int not null FOREIGN KEY REFERENCES DM_Narzedzie (Id_narzedzia),
	Id_wlasciwosc int not null FOREIGN KEY REFERENCES DM_Wlasciwosc (Id_wlasciwosc),
	wartosc nvarchar(10) not null
);
CREATE TABLE DM_Dostawa_materialu(
	Id_dostawy int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	data_dostawy datetime NOT NULL,
	uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Dostawa_czesci(
	Id_dostawy int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	data_dostawy datetime NOT NULL,
	uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Dostawa_narzedzi(
	Id_dostawy int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	data_dostawy DATE NOT NULL, 
	uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Dostawa_maszyn(
	Id_dostawy int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	data_dostawy DATE NOT NULL, 
	uwagi nvarchar(200) NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_maszyn(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_maszyn( Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawcy(Id_dostawcy),
	Id_maszyn int NOT NULL FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    ilosc int NOT NULL, 
	cena_jednostkowa_maszyny int NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_narzedzi(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_narzedzi(Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawcy(Id_dostawcy),
	Id_narzedzia int NOT NULL FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    ilosc int NOT NULL, 
	cena_jednostkowa_narzedzi int NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_czesci(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_czesci( Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawcy(Id_dostawcy),
	Id_czesci int NOT NULL FOREIGN KEY REFERENCES DM_Czesci(Id_czesci), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    ilosc int NOT NULL, 
	cena_jednostkowa_czesci int NOT NULL
);
CREATE TABLE DM_Sklad_dostawy_materialu(
	Id_dostawy int NOT NULL FOREIGN KEY REFERENCES DM_Dostawa_materialu( Id_dostawy) , 
    Id_dostawcy int FOREIGN KEY REFERENCES DM_Dostawcy(Id_dostawcy),
	Id_materialu int NOT NULL FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
    Id_zamowienie_zewn int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_zewn(Id_Zamowienia_zewn),
    ilosc int NOT NULL, 
	cena_jednostkowa_materialu int NOT NULL
);
CREATE TABLE DM_Wydanie_czesci(
	Id_wydania_czesci int identity(1,1) NOT NULL PRIMARY KEY, 
	Id_pracownik_pobierajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
    Id_pracownik_wydajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
    data_i_godzina DATETIME NOT NULL,
	uwagi nvarchar(200) NOT NULL
);

CREATE TABLE DM_Szczegoly_wydania_czesci(
	Id_wydania_czesci int NOT NULL FOREIGN KEY REFERENCES DM_Wydanie_czesci(Id_wydania_czesci), 
    Id_czesci int NOT NULL FOREIGN KEY REFERENCES DM_Czesci(Id_czesci),
    Ilosc int NOT NULL, 
);
CREATE TABLE DM_Parametry_czesci(
    Id_czesci int FOREIGN KEY REFERENCES DM_czesci(id_czesci),
	Id_wlasciwosc int FOREIGN KEY REFERENCES DM_wlasciwosc(id_wlasciwosc),
	wartosc varchar(60) NOT NULL
);
CREATE TABLE DM_Wybor_maszyny(
    Id_model_maszyny int FOREIGN KEY REFERENCES DP_Model_maszyny(Id_model_maszyny),
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
);

CREATE TABLE DM_Wydanie_materialu_dla_produkcji(
	Id_wydanie_materialu_dla_produkcji int identity(1,1) NOT NULL PRIMARY KEY, 
    Id_zamowienia int NOT NULL FOREIGN KEY REFERENCES DZ_Zamowienie_klienta(Id_Zamowienia),
	Id_pracownik_pobierajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
    Id_pracownik_wydajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
    data_i_godzina datetime NOT NULL      
);

CREATE TABLE DM_Szczegoly_wydania_materialu(
	Id_wydanie_materialu_dla_produkcji int FOREIGN KEY REFERENCES DM_Wydanie_materialu_dla_produkcji(Id_wydanie_materialu_dla_produkcji), 
    Id_materialu int NOT NULL FOREIGN KEY REFERENCES DM_Material(Id_materialu),
	ilosc int NOT NULL
);
CREATE TABLE DM_Szczegoly_magazynu_gotowych_produktow(
	Id_magazynu_gotowych_produktow int FOREIGN KEY REFERENCES DM_Magazyn_gotowych_produktow(Id_magazynu_gotowych_produktow), 
    Id_produktu int NOT NULL FOREIGN KEY REFERENCES DP_Produkt(Id_produkt),
    ilosc int NOT NULL
);
CREATE TABLE DM_Wydanie_czesci_dla_produkcji(
	Id_wydania_czesci int identity(1,1) NOT NULL PRIMARY KEY, 
	Id_pracownik_pobierajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika), 
    Id_pracownik_wydajacy int NOT NULL FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
    data_i_godzina_wydania datetime NOT NULL,
	uwagi nvarchar(200) NOT NULL      
);
/****Dzia³ Produkcji***/
CREATE TABLE DP_Wydruk(
	Id_wydruk int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	wypelnienie nvarchar(20) NOT NULL, 
	estymowany_czas int,
	estymowana_masa nvarchar(10),
	Id_pliku int FOREIGN KEY REFERENCES DZ_Plik(Id_pliku)
);

CREATE TABLE DP_Proces_technologiczny(
	Id_proces_technologiczny int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	nazwa nvarchar(150) NOT NULL
);

CREATE TABLE DP_Po_wydr_proc(
	Id_po_wydr_proces int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Id_wydruk int FOREIGN KEY REFERENCES DP_Wydruk(Id_wydruk), 
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny),
	czas_zamierzony int NOT NULL
);

CREATE TABLE DP_Po_material_wydruk(
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu), 
	Id_po_wydr_proc int FOREIGN KEY REFERENCES DP_po_wydr_proc(Id_po_wydr_proces), 
	ilosc float NOT NULL,
);

CREATE TABLE DP_Rodzaj_czynnosci(
	Id_rodzaj_czynnosci int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	nazwa nvarchar(150) NOT NULL
);

CREATE TABLE DP_Po_proc_czynnosci(
	Id_po_proc_czynnosci int IDENTITY(1,1) PRIMARY KEY NOT NULL, 
	Id_rodzaj_czynnosci int FOREIGN KEY REFERENCES DP_rodzaj_czynnosci(Id_rodzaj_czynnosci),
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny),
	czas_zamierzony datetime NOT NULL
);

CREATE TABLE DP_Po_narzedzia_czynnosci(
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosci(Id_po_proc_czynnosci), 
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia)
);

CREATE TABLE DP_Po_maszyna_czynnosci(
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosci(Id_po_proc_czynnosci),
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
);

CREATE TABLE DP_Po_prac_czynnosci(
	Id_pracownika int FOREIGN KEY REFERENCES DZ_pracownik(Id_pracownika), 
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosci(Id_po_proc_czynnosci),
);

CREATE TABLE DP_Po_material_czynnosci(
	Id_po_proc_czynnosci int FOREIGN KEY REFERENCES DP_Po_proc_czynnosci(Id_po_proc_czynnosci),
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu),
	ilosc int
);

CREATE TABLE DP_Po_maszyna_wydruk(
	Id_po_wydr_proces int FOREIGN KEY REFERENCES DP_Po_wydr_proc(Id_po_wydr_proces), 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
);


CREATE TABLE DP_Proces_produkt(
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny), 
	Id_produkt int FOREIGN KEY REFERENCES DP_Produkt(Id_produkt),
);
CREATE TABLE DP_Proces_produkcyjny(
	Id_proces_produkcyjny int IDENTITY(1,1) PRIMARY KEY NOT NULL,  
	Id_proces_technologiczny int FOREIGN KEY REFERENCES DP_Proces_technologiczny(Id_proces_technologiczny),
	data_realizacji datetime,
);

CREATE TABLE DP_prod_material(
	Id_proces_produkcyjny int FOREIGN KEY REFERENCES DP_Proces_produkcyjny(Id_proces_produkcyjny),  
	Id_materialu int FOREIGN KEY REFERENCES DM_Material(Id_materialu),
	ilosc_zuzytego_materialu float
);

CREATE TABLE DP_prod_wydruk(
	Id_prod_wydruk int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Id_proces_produkcyjny int FOREIGN KEY REFERENCES DP_Proces_produkcyjny(Id_proces_produkcyjny),  
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
	czas_wydruku int
);

CREATE TABLE DP_prod_czynnosci_dodatkowe(
	Id_prod_czynnosci_dodatkowe int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Id_proces_produkcyjny int FOREIGN KEY REFERENCES DP_Proces_produkcyjny(Id_proces_produkcyjny),  
	Id_rodzaj_czynnosci int FOREIGN KEY REFERENCES DP_Rodzaj_czynnosci(Id_rodzaj_czynnosci),
	czas_pracy int
);

CREATE TABLE DP_po_prod_czyn_dod_maszyna(
	Id_prod_czynnosci_dodatkowe int FOREIGN KEY REFERENCES DP_prod_czynnosci_dodatkowe(Id_prod_czynnosci_dodatkowe),
	Id_maszyna int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
);

CREATE TABLE DP_po_prod_czyn_dod_pracownik(
	Id_prod_czynnosci_dodatkowe int FOREIGN KEY REFERENCES DP_prod_czynnosci_dodatkowe(Id_prod_czynnosci_dodatkowe),
	Id_pracownika int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
);

CREATE TABLE DP_Zuzute_maszyny(
	Id_zuzyte_maszyny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_maszyny  int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny), 
	data_zuzycia_maszyny date,
	uwagi nvarchar(30)
);

CREATE TABLE DP_Nazwa_obslugi(
	Id_nazwa_obslugi int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	nazwa_obslugi nvarchar(30) NOT NULL
);
CREATE TABLE DP_Czynnosci(
	Id_czynnosc int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	nazwa_czynnosci nvarchar(30) NOT NULL
);
CREATE TABLE DP_Czynnosci_w_ramach_obslugi_serw_wew(
	Id_czynnosc_w_ramach_obslugi_serw_wew int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_nazwa_obslugi int FOREIGN KEY REFERENCES DP_Nazwa_obslugi(Id_nazwa_obslugi),
	Id_czynnosc int FOREIGN KEY REFERENCES DP_Czynnosci(Id_Czynnosc)
);
CREATE TABLE DP_Co_ile_obsluga(
	Id_co_ile_obsluga int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	co_ile_obsluga int
);
CREATE TABLE DP_Obsluga(
	Id_obslugi int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_nazwa_obslugi int FOREIGN KEY REFERENCES DP_Nazwa_obslugi(Id_nazwa_obslugi),
	Id_rodzaj_maszyny int FOREIGN KEY REFERENCES DP_Rodzaj_maszyny(Id_rodzaj_maszyny),
	Id_co_ile_obsluga int FOREIGN KEY REFERENCES DP_Co_ile_obsluga(Id_co_ile_obsluga)
);
CREATE TABLE DP_Usluga_serwisu_zewnetrznego(
	Id_usluga_serwisu_zewnetrznego int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	nazwa_uslugi_serwisu_zewnetrznego nvarchar(30) NOT NULL
);
CREATE TABLE DP_Firma_serwisowa(
	Id_firma_serwisowa int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	nazwa_firmy nvarchar(30) NOT NULL,
	adres nvarchar(30) NOT NULL,
	miasto nvarchar(40) NOT NULL,
	kod_pocztowy nvarchar(10) NOT NULL,
	nr_tel nvarchar(30) NOT NULL,
	e_mail nvarchar(30) NOT NULL
	);

CREATE TABLE DP_Serwis_zewnetrzny(
	Id_serwis_zewnetrzny int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_firma_serwisowa int FOREIGN KEY REFERENCES DP_Firma_serwisowa(Id_firma_serwisowa),
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
	Id_usluga_serwisu_zewnetrznego int FOREIGN KEY REFERENCES DP_Usluga_serwisu_zewnetrznego(Id_usluga_serwisu_zewnetrznego), 
	koszt money NOT NULL,
	data_rozpoczecia date NOT NULL,
	data_zakonczenia date,
	uwagi nvarchar(300)
);
CREATE TABLE DP_Serwis_wewnetrzny_naprawa(
	Id_serwis_wewnetrzny_naprawa int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
	Id_pracownik int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	data_rozpoczecia date NOT NULL,
	data_zakonczenia date,
	uwagi nvarchar(300) NOT NULL
	);


CREATE TABLE DP_Serwis_wewnetrzny_obsluga(
	Id_serwis_wewnetrzny_obsluga int IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	Id_maszyny int FOREIGN KEY REFERENCES DP_Maszyny(Id_maszyny),
	Id_pracownik int FOREIGN KEY REFERENCES DZ_Pracownik(Id_pracownika),
	Id_czynnosc_w_ramach_obslugi_serw_wew int FOREIGN KEY REFERENCES DP_Czynnosci_w_ramach_obslugi_serw_wew(Id_czynnosc_w_ramach_obslugi_serw_wew),
	data_rozpoczecia date NOT NULL,
	data_zakonczenia date
	
	);

CREATE TABLE DP_Narzedzia_uzyte_obsluga(
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia),
    Id_serwis_wewnetrzny_obsluga int FOREIGN KEY REFERENCES DP_Serwis_wewnetrzny_obsluga(Id_serwis_wewnetrzny_obsluga)
	);


CREATE TABLE DP_Narzedzia_uzyte_naprawa(
	Id_narzedzia int FOREIGN KEY REFERENCES DM_Narzedzie(Id_narzedzia),
    Id_serwis_wewnetrzny_naprawa int FOREIGN KEY REFERENCES DP_Serwis_wewnetrzny_obsluga(Id_serwis_wewnetrzny_obsluga)
	);

CREATE TABLE DP_Czesci_wykorzystane(
	Id_czesci int FOREIGN KEY REFERENCES DM_Czesci(Id_czesci),
    Id_serwis_wewnetrzny_naprawa int FOREIGN KEY REFERENCES DP_Serwis_wewnetrzny_obsluga(Id_serwis_wewnetrzny_obsluga)
	);
	