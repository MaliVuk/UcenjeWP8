create database fakultet;
go
use fakultet;

create table student (
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (100)not null,
broj_indeksa varchar (20) unique not null
);

create table kolegij (
sifra  int not null primary key identity (1,1),
naziv varchar (100) not null,
ects int not null
);

create table rok (
sifra int not null primary key identity (1,1),
naziv_roka varchar (100) not null,
datum date not null,
kolegij int not null references kolegij
);

create table prijava (
sifra int not null primary key identity (1,1),
student int not null references student,
rok int not null references rok,
datum_prijave date not null,
ocjena int check (ocjena >= 1 and ocjena<= 5 )
);
