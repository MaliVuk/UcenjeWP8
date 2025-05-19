--go
--drop database if exists najam_stanova;
--go
--create database najam_stanova collate Croatian_CI_AS;
--go
--use najam_stanova;
--go

--create table najmodavac (
--sifra int  not null primary key identity (1,1),
--ime varchar (50),
--prezime varchar (100)
--);

--create table stan (
--sifra int  not null primary key identity (1,1),
--adresa varchar (100) not null,
--najmodavac int not null references najmodavac
--);

--create table ugovor (
--sifra int not null primary key identity (1,1),
--datum_pocetka date not null,
--datum_zavrsetka date not null,
--stan int not null references stan,
--najmodavac int not null references najmodavac
--);

--create table najmoprimac (
--sifra int not null primary key identity (1,1),
--ime_ili_naziv varchar (50) not null,
--kontakt_broj varchar (50) not null
--);

--create table racun (
--sifra int not null primary key identity (1,1),
--tip_najamnina_ili_rezija varchar (50) not null,
--iznos decimal (6,2) not null,
--mjesec int not null,
--stan int not null references stan
--);

--create table stavka_racuna (
--sifra int not null primary key identity (1,1),
--vrsta_rezije varchar (50) not null,
--iznos decimal not null,
--datum_placanja date null,
--racun int not null references racun,
--stanje_placanja varchar (20) null,
--);

IF OBJECT_ID('trg_insert_stanje_placanja_stavka_racuna', 'TR') IS NOT NULL
    DROP TRIGGER trg_insert_stanje_placanja_stavka_racuna;
GO

-- INSTEAD OF INSERT trigger - ispravno
CREATE TRIGGER trg_insert_stanje_placanja_stavka_racuna
ON stavka_racuna
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO stavka_racuna (vrsta_rezije, iznos, datum_placanja, racun, stanje_placanja)
    SELECT 
        vrsta_rezije,
        iznos,
        datum_placanja,
        racun,
        CASE 
            WHEN stanje_placanja IS NOT NULL THEN stanje_placanja
            WHEN datum_placanja IS NOT NULL THEN 'PLAĆENO'
            ELSE 'NIJE PLAĆENO'
        END
    FROM inserted;
END;
GO

-- Brisanje starog trigggera ako postoji
IF OBJECT_ID('trg_azuriraj_stanje_placanja_stavka_racuna', 'TR') IS NOT NULL
    DROP TRIGGER trg_azuriraj_stanje_placanja_stavka_racuna;
GO

-- AFTER UPDATE trigger - ispravno
CREATE TRIGGER trg_azuriraj_stanje_placanja_stavka_racuna
ON stavka_racuna
AFTER UPDATE
AS
BEGIN
    UPDATE sr
    SET stanje_placanja = 
        CASE 
            WHEN i.datum_placanja IS NOT NULL THEN 'PLAĆENO'
            ELSE 'NIJE PLAĆENO'
        END
    FROM stavka_racuna sr
    INNER JOIN inserted i ON sr.sifra = i.sifra;
END;
GO
INSERT INTO racun (tip_najamnina_ili_rezija, iznos, mjesec, stan)
VALUES ('REŽIJE', 500.00, 5, 1);

--- 1 Unesi najmodavca
INSERT INTO najmodavac (ime, prezime)
VALUES ('ZLATA', 'VUČIĆ');

--2 Unesi stan
INSERT INTO stan (adresa, najmodavac)
VALUES ('UL.SV.L.B, MANDIĆA 10', 1),
        ('MEDULINSKA 4', 1   );
--3 Unesi račun
INSERT INTO racun (tip_najamnina_ili_rezija, iznos, mjesec, stan)
VALUES ('REŽIJE', 500.00, 5, 1);

--4 Unesi stavku računa
INSERT INTO stavka_racuna (vrsta_rezije, iznos, datum_placanja, racun)
VALUES ('Struja', 50.00, NULL, 1),
('voda',30.00, null, 1)
;


-- Provjeri rezultat
SELECT * FROM stavka_racuna;

select * from racun
najmodavac

DELETE FROM racun  WHERE sifra IN (7, 8, 9);
DBCC CHECKIDENT ('racun', RESEED, 0);


SELECT 
    sr.sifra AS sifra_stavke,
    sr.vrsta_rezije,
    sr.iznos AS iznos_stavke,
    sr.datum_placanja,
    sr.stanje_placanja,
    r.tip_najamnina_ili_rezija,
    r.mjesec,
    s.adresa AS adresa_stana
FROM stavka_racuna sr
JOIN racun r ON sr.racun = r.sifra
JOIN stan s ON r.stan = s.sifra;