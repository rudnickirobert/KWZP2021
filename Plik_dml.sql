USE Drukarnia

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
	 INSERT INTO DM_Narzedzie (nazwa, Id_rodzaj_narzedzia,ilosc_poczatkowa)
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
    ('Janex',5842751979,'Dostawy akcesoriów'),
	('Klejex',6842751989,'Dostawa kleju'),
	('Narzedzix',2862453979,'Dostawy narzêdzi'),
	('RTVAGD',3751454279,'Dostawy narzêdzi'),
	('Roznosci',9263233158,'Dostawy akcesoriów'),
	('Sensei',5748264839,'Dostawy pêdzli'),
	('Akcesorium',2265748395,'Dostawy kleju'),
	('Chwytareks',5628495717,'Dostawy uchwytow')
	;
	INSERT INTO DP_Produkt (nazwa_produktu,uwagi)
VALUES
    ('Obudowa elektroniki','Kolor czerwony'),
	('Zabawka','Kolor czarny'),
	('Obudowa wkrêtarki','Kolor niebieski'),
	('Stojak ','Kolor czerwony'),
	('Uchwyt','Kolor czarny'),
	('Obudowa elektroniki','Kolor zielony'),
	('Uchwyt na telefon','Rozne kolory'),
	('Deska do krojenia','Kolor czarny')
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
    (1,4,12567653211,'12-11-2020',20),
	(2,1,87857493697,'11-11-2020',10),
	(2,2,12746551735,'15-11-2020',12),
	(2,3,68548376567,'11-11-2020',9)
	;
			INSERT INTO DM_Czesci (nazwa,Id_model_maszyny,ilosc_poczatkowa)
VALUES
    ('Drukarka 3D Zortrax',1,3),
	('Drukarka 3D Makerbot',2,3),
	('Drukarka 3D Raise3D',3,3),
	('Szlifierka sto³owa',4,2)
	;
	INSERT INTO DZ_Rodzaj_rachunku(rodzaj_rachunku)
VALUES
    ('czynsz'),
	('woda'),
	('pr¹d'),
	('internet')
	;
		INSERT INTO DZ_Rachunki(Id_rodzaj_rachunku, koszt, data_zaplaty)
VALUES
    ('1',1500,'10-12-2020'),
	('2',300,'11-12-2020'),
	('3',15000,'11-12-2020'),
	('4',1000,'12-12-2020'),
	('1',1800,'10-01-2021'),
	('1',900,'11-01-2021'),
	('2',10000,'11-01-2021'),
	('4',1000,'12-01-2021')
	;
		INSERT INTO DZ_Pracownik(imie, nazwisko, email, adres, miasto, kod_pocztowy, data_urodzenia,telefon, numer_rachunku)
VALUES
    ('Stefan','Astrol','stefan123@prezes.com','Kochanowskiego 15/34','Warszawa', 00154,'19-12-1990',887554662,0000555543215432),
	('Krzysztof','Kononowicz','ksiomisio@bialystok.com','Misia Yogi 10/3','Warszawa', 00744,'11-11-1962',814742578,0000111112854712),
	('Major','Suchodolski','nitro20%@bialystok.com','Na swoim 1','Warszawa', 00118,'12-10-1973',187656285,1756385765827561),
	('Andrzej','Golota','golota@gmail.com','Zelwerowicza 5','Warszawa', 00112,'15-05-1991',887554662,8763068196037658),
	('Jerzy','Sarna','sarenka1@o2.com','Podkarpacka 2/5','Warszawa', 00997,'16-01-1996',887554662,1765305918295735),
	('Piotr','Golomp','piotr_g@wp.com','Golebia 13','Warszawa', 00514,'05-03-1989',887554662,0196837460195723),
	('Janina','Mlodosc','mloda_jasia@interia.com','Starosci 2','Warszawa', 00324,'10-08-1975',887554662,1958372560198273),
	('Jan','Drewniany','drewniak_jan@onet.com','Drewniakow 15','Warszawa', 00256,'01-06-1975',887554662,1728592049582712),
	('Janina','Drewniana','drewniak_janka@onet.com','Drewniakow 15','Warszawa', 00256,'12-09-1974',867124006,1857462019583716),
	('Artiom','Nowak','artiem_now@onet.com','Polska 25/3','Warszawa', 00316,'19-02-1988',887554662,1285726130591824)
	;

		INSERT INTO DZ_Klient(nazwa_firmy,NIP,imie, nazwisko, adres, miasto, kod_pocztowy, email,telefon, numer_rachunku)
VALUES
    ('Obudowix',1241295225,'Jozef','Miedziany','Wawrzyszewska 10','Warszawa', 00564,'obudowix@gmail.com',665665665,1234432156788765),
	 ('Skrzyniers',1873788435,'Andrzej','Trawczyk','Mi³osna 15','Warszawa', 00318,'skrzyniers@skrzyniers.com',948701956,8702978450697812),
	  ('Zelmix',0681956284,'Bartosz','Brokul','Ulubiona 10','Warszawa', 00426,'zelmix@zelmix.com',176924587,7439587618539476),
	   ('Antylos',1872058241,'Dariusz','Antylopa','Stara 11','Warszawa', 00995,'antylos@antylos.com',676502978,6473195279358642)
	;
	INSERT INTO DZ_Rodzaj_nieobecnosci(rodzaj, procent_pensji)
VALUES
    ('L4', 80),
	('Urlop p³atny', 100),
	('Urlop bezplatny', 0),
	('Szkolenie', 100),
	('Badania', 100)
	;
	INSERT INTO DZ_Nieobecnosc(Id_pracownika,Id_Rodzaj_nieobecnosci,data_rozpoczecia, data_zakonczenia)
VALUES
    (1,1,'10-11-2020','15-11-2020'),
	 (1,3,'01-01-2021','21-01-2021'),
	 (4,2,'15-01-2021','17-01-2021'),
	 (3,5,'17-01-2021','18-01-2021'),
	 (4,4,'21-01-2021','22-01-2021'),
	 (6,5,'01-03-2021','02-03-2021'),
	 (2,2,'15-03-2021','20-03-2021')
	;
	INSERT INTO DZ_Stanowisko(stanowisko)
VALUES
    ('prezes'),
	('ksiêgowy'),
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
    (1,1,1,3,1,'10-10-2020','10-10-2050'),
	(2,2,1,1,1,'10-10-2020','01-02-2021'),
	(3,3,2,1,1,'10-10-2020','10-10-2050'),
	(4,3,2,1,1,'10-10-2020','10-10-2050'),
	(5,4,3,1,1,'10-10-2020','10-10-2050'),
	(6,4,3,2,2,'10-10-2020','10-10-2050'),
	(7,4,3,1,1,'10-10-2020','10-10-2050'),
	(8,2,1,1,1,'10-10-2020','15-03-2021'),
	(9,5,3,1,3,'10-10-2020','10-10-2050'),
	(10,6,3,1,2,'10-10-2020','10-10-2050')
	;
	

