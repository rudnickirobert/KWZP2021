USE Drukarnia_4
GO

CREATE VIEW vDM_Material
AS
SELECT Id_materialu AS [Numer materia³u], DM_Rodzaj_materialu.Id_rodzaj_materialu AS [Rodzaj materialu], DM_Material.nazwa
FROM     dbo.DM_Material INNER JOIN
DM_Rodzaj_materialu ON DM_Material.Id_rodzaj_materialu=DM_Rodzaj_materialu.Id_rodzaj_materialu
;
CREATE VIEW vDM_Narzedzie
AS
SELECT Id_narzedzia AS [Numer narzedzia], DM_Narzedzie.nazwa AS [Nazwa], DM_Rodzaj_narzedzia.Id_rodzaj_narzedzia AS [Rodzaj narzedzia],ilosc_poczatkowa AS [Ilosc poczatkowa]
FROM     dbo.DM_Narzedzie INNER JOIN
DM_Rodzaj_narzedzia ON DM_Narzedzie.Id_rodzaj_narzedzia=DM_Rodzaj_narzedzia.Id_rodzaj_narzedzia
;
CREATE VIEW vDM_Dostawcy
AS
SELECT Id_dostawcy AS [Numer dostawcy], DM_Dostawcy.nazwa AS [Nazwa], DM_Dostawcy.NIP AS [NIP],uwagi AS [Uwagi]
FROM     dbo.DM_Dostawcy
;
CREATE VIEW vDZ_Klient
AS
SELECT ID_Klienta AS [Numer klienta], nazwa_firmy AS [Nazwa firmy], NIP, imie, nazwisko, adres, miasto , kod_pocztowy AS [Kod pocztowy], email AS [e-mail], telefon, numer_rachunku AS [Numer rachunku]
FROM     dbo.DZ_Klient
;
CREATE VIEW vDP_Produkt
AS
SELECT ID_produkt AS [Numer produktu], DP_produkt.nazwa_produktu AS [Nazwa produktu], uwagi AS [Uwagi]
FROM     dbo.DP_Produkt
;
CREATE VIEW vDP_Model_maszyny
AS
SELECT Id_model_maszyny AS [Numer modelu], DP_Model_maszyny.nazwa_modelu_maszyny AS [Nazwa maszyny]
FROM     dbo.DP_Model_maszyny
;
CREATE VIEW vDP_Maszyny
AS
SELECT Id_maszyny AS [Numer maszyny], DP_Rodzaj_maszyny.Id_rodzaj_maszyny AS [Rodzaj maszyny], DP_Model_maszyny.Id_model_maszyny AS [Numer modelu],nr_seryjny AS [Numer seryjny], data_wprowadzenie AS [Data wprowadzenia maszyny], koszt_1rh AS [ Koszt 1 roboczo-godziny]
FROM     dbo.DP_Maszyny INNER JOIN
DP_Rodzaj_maszyny ON DP_Maszyny.Id_rodzaj_maszyny=DP_Rodzaj_maszyny.Id_rodzaj_maszyny INNER JOIN
DP_Model_maszyny ON DP_Maszyny.Id_model_maszyny=DP_Model_maszyny.Id_model_maszyny
;
CREATE VIEW vDM_Czesci
AS
SELECT Id_czesci AS [Numer czesci], DM_Czesci.nazwa AS [Nazwa], DM_Czesci.ilosc_poczatkowa AS [Ilosc pocz¹tkowa]
FROM     dbo.DM_Czesci INNER JOIN
DP_Model_maszyny ON DM_Czesci.Id_model_maszyny=DP_Model_maszyny.id_model_maszyny
;
CREATE VIEW vDZ_Rachunki
AS
SELECT Id_rachunki AS [Numer rachunku], DZ_Rodzaj_rachunku.Id_rodzaj_rachunku AS [Rodzaj rachunku], DZ_Rachunki.koszt AS [Koszt], data_zaplaty AS [Data zaplaty]
FROM     dbo.DZ_Rachunki INNER JOIN
DZ_Rodzaj_rachunku ON DZ_Rachunki.Id_rodzaj_rachunku=DZ_Rodzaj_rachunku.Id_rodzaj_rachunku
;
CREATE VIEW vDZ_Pracownik
AS
SELECT Id_pracownika AS [Numer pracownika],imie, nazwisko, email AS[e-mail],adres,miasto,kod_pocztowy AS[Kod pocztowy],data_urodzenia AS [Data urodzenia],telefon AS[Numer telefonu], numer_rachunku AS[Numer rachunku]
FROM     dbo.DZ_Pracownik
;


