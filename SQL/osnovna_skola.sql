
create database osnovna_skola;
go
use osnovna_skola;
go

create table uciteljica (
sifra int  not null primary key identity (1,1),
ime varchar (50),
prezime varchar (100),
predmet varchar (100)
);

create table radionica (
sifra int not null primary key identity (1,1),
naziv varchar (100),
uciteljica int not null references uciteljica
);

create table dijete (
sifra  int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (100)not null,
razred varchar (10)
);

create table sudjelovanje (
sifra int not null primary key identity (1,1),
dijete int not null references dijete,
radionica int not null references radionica
);