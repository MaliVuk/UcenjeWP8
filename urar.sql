
--create database urar;
--use urar;

--create table korisnici (
--sifra int,
--ime varchar (20),
--prezime varchar (50),
--broj_telefona varchar (20)
--);

--create table satovi (
--sifra int,
--vrsta_sata varchar (50),
--kvar varchar (100)
--);

create table urar (
sifra int,
ime varchar (20),
prezime varchar (50)
);

create table popravak (
sifra int,
datum_zaprimanja date,
kvar varchar (100),
cijena_popravka decimal (10,2),
sifra_sata int
);

create table segrt (
sifra int,
ime varchar (20),
prezime varchar (50)
);

create table sudionici_popravka (
sifra_popravka int,
sifra_segrta int
);