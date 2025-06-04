create database ordinacija;
go
use ordinacija;

create table doktor (
sifra int not null primary key identity (1,1),
ime varchar (20),
prezime varchar (50) not null
);

create table pacijent (
sifra int not null primary key identity (1,1), 
ime varchar (50) not null,
prezime varchar (50) not null,
broj_telefona varchar (20),
mail varchar (50)
);

create table lijecenje (
sifra int not null primary key identity (1,1), 
doktor int not null references doktor,
pacijent int not null references pacijent,
vrsta_lijecenja varchar (100),
datum_posjeta date not null
);

create table medicinske_sestre (
sifra int not null primary key identity (1,1),
ime varchar (50) not null, 
prezime varchar (100) not null
);

create table asistiranja (
sifra int not null primary key identity (1,1),
lijecenje int not null references lijecenje,
medicinske_sestre int not null references medicinske_sestre
);

