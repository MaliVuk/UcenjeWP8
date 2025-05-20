go
drop database if exists iznajmljivanje;
go
create database iznajmljivanje collate Croatian_CI_AS;
go
use iznajmljivanje;
go

create table najmodavac (
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (100)
);

create table stan (
sifra int not null primary key identity (1,1),
adresa varchar(100) not null,
datum_uplate_stanarine date null,
najmodavac int not null references najmodavac
);

create table rezije (
sifra int not null primary key identity (1,1),
mjesec int not null,
tip varchar (50),
iznos decimal ,
datum_placanja_rezije date null,
stan int not null references stan
);
create table ugovor (
sifra int not null primary key identity (1,1),
datum_pocetka date null,
datum_zavrsetka date null,
stan  int not null references stan
);
create table najmoprimac (
sifra int not null primary key identity (1,1),
ime_ili_naziv varchar (50) null,
kontakt varchar(50)null,
ugovor int not null references ugovor
);

