USE Drukarnia
GO

INSERT INTO DM_Rodzaj_materialu (rodzaj_materialu)
VALUES
    ('srodki adhezyjne'),
	('filament'),
	('klej')
	;
 INSERT INTO DM_Wlasciwosc (nazwa_wlasciwosci, jednostka_pomiarowa)
VALUES
    ('gestosc', 'g/cm3'),
	('dlugosc', 'm'),
	('kolor','-'),
	('masa','kg')
	;
	INSERT INTO DM_Material (Id_rodzaj_materialu, nazwa)
VALUES
    (2, '3DACTIVE PLA'),
	(2, 'STWQ PLA'),
	(1,'DIMAFIX'),
	(3,'SPRAY-KON B700'),
	(2, 'ASQ PLA'),
	(2, 'ZDY PLA')
	;
	INSERT INTO DM_Wlasciwosci_materialu (Id_materialu, Id_wlasciwosc, wartosc)
VALUES
    (1, 2, '150'),
	(1, 3, 'zielony'),
	(1,4,'20'),
	(2,2, '200'),
	(2,3, 'czarny'),
	(2,4, '25'),
	(3,3, 'bezbarwny'),
	(3,4, '1'),
	(4,3,'bezbarwny'),
	(4,4,'20'),
	(5, 2, '100'),
	(5, 3, 'czerwony'),
	(5,4,'10'),
	(6, 2, '300'),
	(6, 3, 'niebieski'),
	(6,4,'40')
	;
	 INSERT INTO DM_Rodzaj_narzedzia (nazwa)
VALUES
    ('szlifierka'),
	('wiertarka'),
	('wkretarka'),
	('miotla'),
	('mlotek'),
	('lopata'),
	('pedzel'),
	('uchwyt')
	;
	 INSERT INTO DM_Narzedzie (nazwa,Id_rodzaj_narzedzia, ilosc_poczatkowa)
VALUES
    ('Makita HF25',1,3),
	('MAKITA HF20',1,1),
	('MAKITA WI1',2,2),
	('MAKITA WI2',2,1),
	('MAKITA WK456',3,3),
	('Super',4,2),
	('Twardy',5,3),
	('Ostra',6,1),
	('Maly',7,10),
	('Duzy',7,5),
	('Uchwyt',8,25)
	;
	INSERT INTO DM_Dostawcy (nazwa, NIP, uwagi)
VALUES
    ('Janex','5842751979','Dostawy akcesori�w'),
	('Klejex','6842751989','Dostawa kleju'),
	('Narzedzix','2862453979','Dostawy narz�dzi'),
	('RTVAGD','3751454279','Dostawy narz�dzi'),
	('Roznosci','9263233158','Dostawy akcesori�w'),
	('Sensei','5748264839','Dostawy p�dzli'),
	('Akcesorium','2265748395','Dostawy kleju'),
	('Chwytareks','5628495717','Dostawy uchwytow')
	;
	INSERT INTO DP_Produkt (Id_produkt,nazwa_produktu,uwagi)
VALUES
    (1,'Obudowa elektroniki','Kolor czerwony'),
	(2,'Zabawka','Kolor czarny'),
	(3,'Obudowa wkretarki','Kolor niebieski'),
	(4,'Stojak ','Kolor czerwony'),
	(5,'Uchwyt','Kolor czarny'),
	(6,'Obudowa elektroniki','Kolor zielony'),
	(7,'Uchwyt na telefon','Rozne kolory'),
	(8,'Kostka','Kolor czarny'),
	(9,'Obudowa kluczy','Kolor czarny'),
	(10,'Klamka','Kolor czarny'),
	(11,'Deska do krojenia','Kolor czarny'),
	(12,'Gwizdek','Kolor czarny')
	;
	INSERT INTO DP_Model_maszyny (nazwa_modelu_maszyny)
VALUES
    ('M300 Dual'),
	('Replicator+'),
	('Pro2Plus'),
	('ASFSAR444')
	;
	INSERT INTO DP_Rodzaj_maszyny (rodzaj_maszyny)
VALUES
    ('Szlifierka'),
	('Drukarka')
	;
		INSERT INTO DP_Maszyny (Id_rodzaj_maszyny,Id_model_maszyny,nr_seryjny,data_wprowadzenia,koszt_1rh)
VALUES
    (1,4,'12567653211','2020-11-12',20),
	(2,1,'87857493697','2020-11-11',10),
	(2,2,'12746551735','2020-11-15',12),
	(2,3,'68548376567','2020-11-11',9)
	;
			INSERT INTO DM_Czesci (nazwa,Id_model_maszyny,ilosc_poczatkowa)
VALUES
    ('Sterownik drukarki',2,1),
	('Ekstruder',2,3),
	('Ekstruder',3,3),
	('Ekstruder',4,3),
	('Silnik',1,1),
	('Zasilacz',3,2);
	INSERT INTO DZ_Rodzaj_rachunku(rodzaj_rachunku)
VALUES
    ('czynsz'),
	('woda'),
	('pr�d'),
	('internet')
	;
		INSERT INTO DZ_Rachunki(Id_rodzaj_rachunku, koszt, data_zaplaty)
VALUES
    ('1',1500,'2020-12-10'),
	('2',300,'2020-12-11'),
	('3',15000,'2020-12-1'),
	('4',1000,'2020-12-12'),
	('1',1800,'2021-01-10'),
	('1',900,'2021-01-11'),
	('2',10000,'2021-01-11'),
	('4',1000,'2021-01-12')
	;
		INSERT INTO DZ_Pracownik(imie, nazwisko, email, adres, miasto, kod_pocztowy, data_urodzenia,telefon, numer_rachunku)
VALUES
    ('Stefan','Astrol','stefan123@prezes.com','Kochanowskiego 15/34','Warszawa', '00-154','1990-12-19','887554662','0000555543215432'),
	('Krzysztof','Kononowicz','ksiomisio@bialystok.com','Misia Yogi 10/3','Warszawa', '00-744','1962-11-11','814742578','0000111112854712'),
	('Major','Suchodolski','nitro20%@bialystok.com','Na swoim 1','Warszawa', '00-118','1973-10-12','187656285','1756385765827561'),
	('Andrzej','Golota','golota@gmail.com','Zelwerowicza 5','Warszawa', '00-112','1991-05-15','887554662','8763068196037658'),
	('Jerzy','Sarna','sarenka1@o2.com','Podkarpacka 2/5','Warszawa', '00-997','1996-01-16','887554662','1765305918295735'),
	('Piotr','Golomp','piotr_g@wp.com','Golebia 13','Warszawa', '00-514','1989-03-15','887554662','0196837460195723'),
	('Janina','Mlodosc','mloda_jasia@interia.com','Starosci 2','Warszawa', '00-324','1975-08-10','887554662','1958372560198273'),
	('Jan','Drewniany','drewniak_jan@onet.com','Drewniakow 15','Warszawa', '00-256','1975-06-01','887554662','1728592049582712'),
	('Janina','Drewniana','drewniak_janka@onet.com','Drewniakow 15','Warszawa', '00-256','1974-09-10','867124006','1857462019583716'),
	('Artiom','Nowak','artiem_now@onet.com','Polska 25/3','Warszawa', '00-316','1988-02-19','887554662','1285726130591824')
	;

		INSERT INTO DZ_Klient(nazwa_firmy,NIP,imie, nazwisko, adres, miasto, kod_pocztowy, email,telefon, numer_rachunku)
VALUES
    ('Obudowix','1241295225','Jozef','Miedziany','Wawrzyszewska 10','Warszawa', '00-564','obudowix@gmail.com','665665665','1234432156788765'),
	 ('Skrzyniers','1873788435','Andrzej','Trawczyk','Mi�osna 15','Warszawa', '00-318','skrzyniers@skrzyniers.com','948701956','8702978450697812'),
	  ('Zelmix','0681956284','Bartosz','Brokul','Ulubiona 10','Warszawa', '00-426','zelmix@zelmix.com','176924587','7439587618539476'),
	   ('Antylos','1872058241','Dariusz','Antylopa','Stara 11','Warszawa', '00-995','antylos@antylos.com','676502978','6473195279358642')
	;
	INSERT INTO DZ_Rodzaj_nieobecnosci(rodzaj, procent_pensji)
VALUES
    ('L4', 80),
	('Urlop p�atny', 100),
	('Urlop bezplatny', 0),
	('Szkolenie', 100),
	('Badania', 100)
	;
	INSERT INTO DZ_Nieobecnosc(Id_pracownika,Id_Rodzaj_nieobecnosci,data_rozpoczecia, data_zakonczenia)
VALUES
    (1,1,'2020-11-10','2020-11-15'),
	 (1,3,'2020-01-01','2020-01-21'),
	 (4,2,'2020-01-15','2020-01-17'),
	 (3,5,'2021-01-17','2021-01-18'),
	 (4,4,'2021-01-21','2021-01-22'),
	 (6,5,'2021-03-01','2021-03-02'),
	 (2,2,'2021-03-15','2021-03-20')
	;
	INSERT INTO DZ_Stanowisko(stanowisko)
VALUES
    ('prezes'),
	('ksi�gowy'),
	('magazynier'),
	('pracownik produkcji'),
	('pracownik utrzymania ruchu'),
	('technolog')
	;
	INSERT INTO DZ_Etat(etat)
VALUES
    (1),
	(0.5),
	(0.25)
	;
	INSERT INTO DZ_Rodzaj_umowy(rodzaj_umowy)
VALUES
    ('o prace'),
	('zlecenie'),
	('dzielo')
	;
	INSERT INTO DZ_Dzial(dzial)
VALUES
    ('zarzadzanie'),
	('magazyn'),
	('produkcja')
	;
	INSERT INTO DZ_Zatrudnienie(Id_pracownika, Id_stanowiska, Id_dzialu, Id_etatu, Id_rodzaj_umowy, data_zatrudnienia,data_zwolnienia)
VALUES
      (1,1,1,3,1,'2020-10-10','2099-03-15'),
	(2,2,1,1,1,'2020-10-10','2021-02-01'),
	(3,3,2,1,1,'2020-10-10','2099-03-15'),
	(4,3,2,1,1,'2020-10-10','2099-03-15'),
	(5,4,3,1,1,'2020-10-10','2021-03-15'),
	(6,4,3,2,2,'2020-10-10','2099-03-15'),
	(7,4,3,1,1,'2020-10-11','2099-03-15'),
	(8,2,1,1,1,'2020-10-11','2021-03-15'),
	(9,5,3,1,3,'2020-10-12','2099-03-15'),
	(10,6,3,1,2,'2020-10-13','2099-03-15')
	;
		INSERT INTO DZ_Szczegoly_Zatrudnienia(Id_zatrudnienia, data_zmiany_wynagrodzenia, podstawa_wynagrodzenia)
VALUES
    (1,'2020-10-10',14000),
	(2,'2020-10-10',7000),
	(3,'2020-10-10',6000),
	(4,'2020-10-10',6500),
	(5,'2020-10-10',6000),
	(6,'2020-10-10',4500),
	(7,'2020-10-11',4600),
	(8,'2020-10-11',4500),
	(9,'2020-10-12',4900),
	(10,'2020-10-13',5000)
	;
	INSERT INTO DZ_Plik(nazwa_pliku, zalacznik)
VALUES
	('zabawka','pdf'),
	('obudowa elektroniki','stl'),
	('obudowa wkretarki','pdf'),
	('gwizdek','step'),
	('stojak','obj'),
	('obudowa elektroniki','pdf'),
	('opakowanie na soczewki','stl'),
	('uchwyt','obj'),
	('deska do krojenia','pdf'),
	('uchwyt na telefon','obj'),
	('kostka','stl'),
	('obudowa kluczy','step'),
	('klamka','pdf')
	;
	INSERT INTO DZ_Rodzaj_statusu_zamowienia(status_zam)
VALUES
	('zrealizowane'),
	('przyjete do realizacji'),
	('oczekuje na zatwierdzenie'),
	('w trakcie'),
	('nie przyjete do realizacji')
	;
	INSERT INTO DZ_Zamowienie_klienta(Id_klienta, Id_pracownika, data_zamowienia, oczekiwany_termin_wykonania)
VALUES
	(3,2,'2021-01-09','2021-10-26'),
	(1,2,'2021-01-11','2021-05-01'),
	(3,8,'2021-02-15','2021-04-16'),
	(1,2,'2021-03-03','2021-09-30'),
	(4,8,'2021-03-16','2021-08-22'),
	(3,2,'2021-04-04','2021-10-30'),
	(2,8,'2021-04-13','2021-04-30'),
	(1,8,'2021-04-13','2021-05-05'),
	(4,2,'2021-04-22','2021-05-10'),
	(3,8,'2021-04-22','2021-07-16'),
	(2,2,'2021-04-24','2021-07-18'),
	(2,2,'2021-04-25','2021-07-19'),
	(4,8,'2021-04-25','2021-06-30')
	;
	INSERT INTO DZ_Zamowienie_zewn(Id_pracownika, data_zamowienia_zewn)
VALUES
	(8,'2021-01-01'),
	(8,'2021-02-02'),
	(2,'2021-03-15'),
	(8,'2021-03-30'),
	(2,'2021-04-03'),
	(8,'2021-03-27'),
	(8,'2021-03-31'),
	(2,'2021-03-15'),
	(8,'2021-04-05'),
	(2,'2021-02-03'),
	(2,'2020-12-12'),
	(2,'2020-11-08')
	;
	INSERT INTO DZ_Status_zamowienia(Id_zamowienia, Id_rodzaj_statusu_zam)
VALUES
	(1,4),
	(2,4),
	(3,1),
	(4,3),
	(5,5),
	(6,2),
	(7,4),
	(8,5),
	(9,3),
	(10,2),
	(11,3),
	(12,5),
	(13,5)
	;
	INSERT INTO DZ_Szczegoly_zamowienia_klienta(Id_szczegoly_zam_klienta, Id_zamowienia, Id_pliku, ilosc_sztuk, Id_materialu)
VALUES
	(1,1,4,8,1),
	(2,2,6,30,5),
	(3,3,1,15,2),
	(4,4,10,120,6),
	(5,5,8,88,4),
	(6,6,7,150,3),
	(7,7,2,25,1),
	(8,8,5,30,6),
	(9,9,3,11,5),
	(10,10,9,66,1),
	(11,11,12,10,2),
	(12,12,11,8,3),
	(13,13,13,3,4)
	;
	INSERT INTO DZ_Po_szczegoly_zam_produkt(Id_szczegoly_zam_klienta,Id_produktu)
VALUES
	(7,1),
	(3,2),
	(9,3),
	(8,4),
	(5,5),
	(2,6),
	(4,7),
	(10,8),
	(1,12),
	(11,9),
	(12,8),
	(13,10)
	;
	INSERT INTO DZ_Szczegoly_zam_maszyn(Id_zamowienia_zewn, Id_maszyny, koszt_jednostkowy_oferta, ilosc)
VALUES	
	(1,1,21093.27,10),
	(2,2,13284.00,10),
	(3,3,24259.99,10),
	(4,4,12000,10),
	(1,2,13284.00,5);
	INSERT INTO DZ_Szczegoly_zam_materialu(Id_zamowienia_zewn, Id_materialu, koszt_jednostkowy_oferta, Id_wlasciwosc, ilosc)
VALUES
	(5,2,45.00,3,15),
	(8,6,36.50,3,40),
	(9,4,27.80,3,26),
	(1,6,36.50,3,10),
	(3,2,45.00,3,5)
	;
	INSERT INTO DZ_Szczegoly_zam_czesci(Id_zamowienia_zewn, Id_czesci, koszt_jednostkowy_oferta, Id_wlasciwosc, ilosc)
VALUES
	(6,3,299.99,4,5),
	(7,1,150.00,4,2),
	(1,2,300.00,4,4),
	(2,1,150.00,4,15)
	;
	INSERT INTO DZ_Szczegoly_zam_narzedzi(Id_zamowienia_zewn, Id_narzedzia, koszt_jednostkowy_oferta, Id_wlasciwosc, ilosc)
VALUES
	(10,3,1530.80,4,3),
	(11,6,30.50,4,6)
	;

	INSERT INTO DM_Magazyn_gotowych_produktow(Id_magazynu_gotowych_produktow, Id_zamowienia, data_i_godzina_przyjecia, uwagi)
VALUES	
	(1,1,'2021-04-01 10:30:00','brak'),
	(2,1,'2021-04-02 11:00:00','brak'),
	(3,3,'2021-04-05 11:30:00','brak'),
	(4,4,'2021-04-06 12:10:00','brak'),
	(5,5,'2021-04-07 12:15:00','brak'),
	(6,6,'2021-04-08 12:20:00','brak'),
	(7,7,'2021-04-09 12:25:00','brak'),
	(8,8,'2021-04-12 12:30:00','brak'),
	(9,9,'2021-04-13 12:35:00','brak'),
	(10,10,'2021-04-14 12:40:00','brak'),
	(11,11,'2021-04-15 13:00:00','brak'),
	(12,12,'2021-04-16 14:00:00','brak'),
	(13,13,'2021-04-19 14:30:00','brak')
;
INSERT INTO DM_Szczegoly_magazynu_gotowych_produktow(Id_magazynu_gotowych_produktow, Id_produktu, ilosc)
VALUES	
	(1,1,20),
	(2,1,30),
	(3,3,10),
	(4,5,45),
	(5,5,50),
	(6,6,100),
	(7,7,1100),
	(8,8,200),
	(9,9,25),
	(10,10,500),
	(11,11,60),
	(12,12,80),
	(13,13,5)
;
INSERT INTO DM_Wydanie_produktow (Id_wydania, Id_magazynu_gotowych_produktow, Id_pracownika, data_i_godzina, uwagi)
VALUES	
	(1,1,6,'2021-04-01 15:30:00','brak'),
	(2,1,6,'2021-04-02 15:00:00','brak'),
	(3,3,6,'2021-04-05 15:30:00','brak'),
	(4,4,6,'2021-04-06 15:00:00','brak'),
	(5,5,7,'2021-04-07 15:30:00','brak'),
	(6,6,7,'2021-04-08 15:45:00','brak'),
	(7,7,7,'2021-04-09 15:00:00','brak'),
	(8,8,7,'2021-04-12 15:30:00','brak'),
	(9,8,7,'2021-04-13 15:30:00','brak'),
	(10,8,7,'2021-04-14 15:30:00','brak'),
	(11,8,7,'2021-04-15 15:30:00','brak'),
	(12,8,7,'2021-04-16 15:30:00','brak'),
	(13,8,7,'2021-04-19 15:30:00','brak')
;
	INSERT INTO DM_Szczegoly_wydania_produktu(Id_wydania,Id_produktu, ilosc)
VALUES	
	(1,1,15),
	(2,2,20),
	(3,3,50),
	(4,4,35),
	(5,5,100),
	(6,6,80),
	(7,7,75),
	(8,8,65)
;

INSERT INTO DP_Wydruk(wypelnienie,estymowany_czas,estymowana_masa,Id_pliku)
VALUES
	('0,5',5,1000,1),
	('0,25',3,600,2),
	('0,45',7,2000,3),
	('0,35',5,1000,4),
	('0,15',1,500,5),
	('0,50',8,2500,6)
;

INSERT INTO DP_Po_material_wydruk(Id_materialu, Id_po_wydr_proc, ilosc)
VALUES
(1,1,1000),
(2,2,2000),
(3,3,1800),
(4,4,2200),
(5,5,3000),
(6,6,1200);

INSERT INTO DP_Po_maszyna_wydruk(Id_po_wydr_proces, Id_maszyny)
VALUES
(1,1),
(1,2),
(1,3);

INSERT INTO DP_Proces_technologiczny(nazwa) /***zrobione***/
VALUES
('proces technologiczny nr1'),
('proces technologiczny nr2'),
('proces technologiczny nr3'),
('proces technologiczny nr4'),
('proces technologiczny nr5'),
('proces technologiczny nr6');

INSERT INTO DP_Po_wydr_proc(Id_wydruk,Id_proces_technologiczny,czas_zamierzony)
VALUES
(1,1,5),
(2,2,3),
(3,3,7),
(4,4,5),
(5,5,1),
(6,6,8);

/***czynnosci***/

INSERT INTO DP_Rodzaj_czynnosci(nazwa)
VALUES
('przygotowanie pliku'),
('szlifowanie'),
('klejenie'),
('obr�bka wyka�czaj�ca'),
('obr�bka kszta�tuj�ca');

INSERT INTO DP_Po_proc_czynnosci(Id_rodzaj_czynnosci, Id_proces_technologiczny, czas_zamierzony)
VALUES
(1,1,'2021-09-20 8:30:00'), 
(2,1,'2021-09-20 12:30:00'), 
(5,1,'2021-09-20 15:30:00'), 
(2,1,'2021-09-21 8:15:00'), 
(3,1,'2021-09-21 8:15:00'), 
(4,1,'2021-09-21 9:15:00'), 
(1,2,'2021-04-05 8:30:00'), 
(2,2,'2021-04-05 12:30:00'), 
(5,2,'2021-04-05 15:30:00'), 
(2,2,'2021-04-06 8:15:00'), 
(3,2,'2021-04-06 8:15:00'), 
(4,2,'2021-04-06 9:15:00'), 
(1,3,'2021-07-05 8:30:00'), 
(2,3,'2021-07-05 12:30:00'), 
(5,3,'2021-07-05 15:30:00'), 
(2,3,'2021-07-06 8:15:00'), 
(3,3,'2021-07-06 8:15:00'), 
(4,3,'2021-07-06 9:15:00'); 

INSERT INTO DP_Po_narzedzia_czynnosci(Id_po_proc_czynnosci, Id_narzedzia)
VALUES
(2,2),
(5,6),
(5,7),
(6,7),
(2,7),
(6,4);

INSERT INTO DP_Po_maszyna_czynnosci(Id_po_proc_czynnosci, Id_maszyny)
VALUES
(2,1),
(5,1);

INSERT INTO DP_Po_prac_czynnosci(Id_pracownika, Id_po_proc_czynnosci)
VALUES
(5,1),
(6,2),
(7,3),
(7,4),
(6,5),
(5,6),
(5,7),
(6,8),
(7,9),
(7,10),
(6,11),
(5,12),
(5,13),
(6,14),
(5,15),
(5,16),
(7,17),
(7,18);

INSERT INTO DP_Po_material_czynnosci(Id_po_proc_czynnosci, Id_materialu, ilosc)
VALUES
(3,3,200),
(4,3,300),
(5,4,200),
(3,4,220),
(4,3,300),
(5,4,240);

INSERT INTO DP_Proces_produkt(Id_proces_technologiczny,Id_produkt)
VALUES 
(1,1),
(2,2),
(3,3),
(4,4),
(5,5),
(6,6);

INSERT INTO DP_Proces_produkcyjny(Id_proces_technologiczny, data_realizacji, czas_realizacji)
VALUES 
(1,'2021-06-12',10),
(2,'2021-07-09',15),
(3,'2021-06-05',12),
(4,'2021-08-23',18),
(5,'2021-07-15',11),
(6,'2021-05-30',12);


INSERT INTO DP_Proces_produkcyjny_wykorzystany_material(Id_proces_produkcyjny, Id_materialu, ilosc)
VALUES 
(1,2,10),
(2,3,9),
(3,1,12),
(4,1,7),
(5,6,5),
(6,5,3);

INSERT INTO DP_Proces_produkcyjny_czas_czynnosci_dodatkowych(Id_proces_produkcyjny, Id_rodzaj_czynnosci, wykorzystany_czas)
VALUES 
(1,2,2),
(2,3,3),
(3,3,1),
(4,5,3),
(5,4,1),
(6,2,2);

INSERT INTO DP_Zuzute_maszyny(Id_maszyny, data_zuzycia_maszyny, uwagi)
VALUES 
(1,'2021-01-06','niezdolna do pracy'),
(2,'2021-02-12','niezdolna do pracy'),
(3,'2021-03-16','wylaczona z uzytku'),
(4,'2021-02-19','wylaczona z uzytku');

INSERT INTO DP_Nazwa_obslugi(nazwa_obslugi)
VALUES
('biezaca'),
('okresowa'),
('profilaktyczny');

INSERT INTO DP_Czynnosci(nazwa_czynnosci)
VALUES
('sprawdzenie'),
('konserwacja'),
('wyczyszczenie'),
('przeglad');

INSERT INTO DP_Czynnosci_w_ramach_obslugi_serw_wew(Id_nazwa_obslugi, Id_czynnosc)
VALUES
(1,1),
(1,3),
(2,2);

INSERT INTO DP_Co_ile_obsluga(co_ile_obsluga)
VALUES
(7),
(91),
(365);

INSERT INTO DP_Obsluga(Id_nazwa_obslugi, Id_rodzaj_maszyny, Id_co_ile_obsluga)
VALUES
(1,1,1),
(2,1,2),
(3,1,3),
(1,2,1),
(2,2,2),
(3,2,3);

INSERT INTO DP_Usluga_serwisu_zewnetrznego(nazwa_uslugi_serwisu_zewnetrznego)
VALUES
('naprawa'),
('przeglad profilaktyczny');

INSERT INTO DP_Firma_serwisowa(nazwa_firmy, adres, miasto, kod_pocztowy, nr_tel, e_mail)
VALUES

('Serwis3D','Klonowa 21','Warszawa','00-256','555874548','druk3d@o2.pl'),
('2B3D','Nowa 21/3','Warszawa','01-316','678872148','2b3d@o2.pl'),
('serwis 3D','Klonowa 21','Warszawa','00-256','555874548','druk3d@o2.pl'),
('Omni3D','Wolska 4/2','Warszawa','01-100','736524199','omni3d@wp.pl'),
('Cadxpert','Kolorowa 92','Warszawa','02-258','635986147','cadxpert@gmail.com'),
('Centrum serwisowe','Spokojna 90','Warszawa','10-458','515456985','centrumserwisowe@o2.pl'),
('Dobry serwis','Sportowa 34/2','Warszawa','14-654','754156874','dobryserwis@o2.pl'),
('Serwisownia','Kolejowa 3/1','Warszawa','23-978','698745852','serwisownia@gmail.com'),
('CADevent','Harcerska 86/2','Warszawa','10-122','835412588','cadevent@gmail.com'),
('Drukarki 3D','Szkolna 43/2','Warszawa','11-200','659021458','drukarki3d@o2.pl');

INSERT INTO DP_Serwis_zewnetrzny(Id_firma_serwisowa, Id_maszyny, Id_usluga_serwisu_zewnetrznego, koszt, data_rozpoczecia, data_zakonczenia, uwagi)
VALUES

(7,1,2,200,'2021-11-12','2021-11-13','zaplanowany'),
(1,2,2,200,'2021-11-11','2021-11-13','zaplanowany'),
(2,3,2,200,'2021-11-15','2021-11-13','zaplanowany'),
(3,4,2,200,'2021-11-11','2021-11-13','zaplanowany'),
(4,4,1,300,'2021-02-01','2021-02-01','uszkodzenie mechaniczne'),
(6,1,1,100,'2021-01-20','2021-01-20','uszkodzenie mechaniczne'),
(5,2,1,350,'2021-01-30','2021-01-30','uszkodzenie mechaniczne'),
(8,3,1,400,'2021-02-12','2021-02-12','uszkodzenie mechaniczne');

INSERT INTO DM_Wypozyczenie_narzedzia(Id_pracownika_wypozyczajacego, Id_pracownika_wydajacego, data_i_godzina_wypozyczenia, data_i_godzina_zwrotu, uwagi)
VALUES
(1, 2, '2021-02-12','2021-02-12', 'brak'),
(7, 2, '2021-04-11','2021-04-11', 'uszkodzenie mechaniczne'),
(8, 2, '2021-01-31','2021-01-31', 'brak'),
(7, 3, '2021-03-03','2021-03-03', 'brak'),
(7, 3, '2021-04-16','2021-04-17', 'brak'),
(9, 3, '2021-03-01','2021-03-01', 'uszkodzona izolacja'),
(5, 3, '2021-02-15','2021-02-15', 'porysowana obudowa');

INSERT INTO DM_Dostawa_narzedzi(Id_pracownika, data_dostawy, uwagi)
VALUES
(6, '2021-03-23','brak'),
(4, '2021-01-16','brak'),
(5, '2021-03-07','brak'),
(6, '2021-04-12','brak'),
(8, '2021-04-22','brak'),
(1, '2021-03-04','brak'),
(9, '2021-04-03','brak');

 INSERT INTO DM_Dostawa_maszyn (Id_pracownika, data_dostawy, uwagi)
VALUES
   (4, '2021-01-02','brak'),
(6, '2021-01-03','brak'),
(3, '2021-01-18','brak'),
(2, '2021-01-18','brak'),
(7, '2021-01-15','brak'),
(3, '2021-03-16','brak'),
(5, '2021-04-12','brak');

INSERT INTO DM_Sklad_dostawy_narzedzi(Id_dostawy, Id_dostawcy, Id_narzedzia, Id_zamowienie_zewn, ilosc, cena_jednostkowa_narzedzi)
VALUES
(2, 4, 7, 3, 3, 20),
(5, 4, 4, 1, 1, 1700),
(7, 3, 6, 2, 1, 15),
(6, 4, 3, 6, 1, 900),
(4, 3, 1, 4, 1, 1200),
(5, 3, 2, 2, 1, 1900),
(3, 4, 5, 9, 1, 1500);

INSERT INTO DM_Sklad_dostawy_czesci(Id_dostawy, Id_dostawcy, Id_czesci, Id_zamowienie_zewn, ilosc, cena_jednostkowa_czesci)
VALUES
(1, 5, 1, 2, 1, 500),
(2, 4, 2, 1, 3, 200),
(2, 4, 3, 1, 3, 200),
(2, 4, 4, 1, 3, 200),
(3, 3, 5, 4, 2, 100);

INSERT INTO DM_Sklad_dostawy_materialu(Id_dostawy, Id_dostawcy, Id_materialu, Id_zamowienie_zewn, ilosc, cena_jednostkowa_materialu)
VALUES
(1, 3, 1, 3, 1, 256),
(2, 7, 2, 3, 3, 459),
(2, 7, 3, 2, 3, 380),
(3, 6, 4, 1, 3, 499),
(4, 2, 6, 4, 2, 500);

INSERT INTO DM_Wydanie_czesci(Id_pracownik_pobierajacy, Id_pracownik_wydajacy, data_i_godzina, uwagi)
VALUES
(3, 6, '2021-01-20 8:30:00','wada powierzchniowa'),
(3, 5, '2021-02-15 9:15:00','brak'),
(4, 9, '2021-02-16 8:00:00','brak'),
(4, 10, '2021-03-21 14:00:00','brak'),
(4, 5, '2021-04-31 15:00:00','brak');
	
	INSERT INTO DM_Szczegoly_wydania_czesci(Id_wydania_czesci, Id_czesci, ilosc)
VALUES
(1, 3, 1),
(1, 2, 1),
(2, 1, 1),
(3, 4, 2),
(5, 4, 2),
(6, 5, 2);

INSERT INTO DM_Parametry_czesci(Id_czesci, Id_wlasciwosc, wartosc)
VALUES
(1, 3, 'czarny'),
(1, 4, '10'),
(2, 3, 'czarny'),
(2, 4, '11'),
(3, 3, 'czarny'),
(3, 4, '9'),
(4, 3, 'czarny'),
(4, 4, '8'),
(5, 3, 'czarny'),
(5, 4, '6'),
