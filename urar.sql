create database urar;
use urar;

create table korisnici (
sifra int,
ime varchar (20),
prezime varchar (50),
broj_telefona varchar (20)
);

create table satovi (
sifra int,
vrsta_sata varchar (50),
kvar varchar (100)
);