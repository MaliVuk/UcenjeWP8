--create database azil_za_zivotinje;
--use azil_za_zivotinje;

--create table djelatnici(
--sifra int
--ime_i_prezime varchar (50),
--zanimanje varchar (50)
--);
--create table zivotinje (
--Sifra int,
--ime varchar (20),
--dob int
--);

--create table prostorije (
--sifra int,
--boja_prostorije varchar (20)
--);

create table boravak (
zivotinje int,
prostorije int,
datum_boravka_od date,
datum_boravka_do date

);