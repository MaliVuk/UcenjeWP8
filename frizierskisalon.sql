use master;
go
drop database if exists frizerski_salon;
go
create database frizerski_salon;
go
use frizerski_salon;

create table djelatnica (
sifra int not null primary key identity(1,1),
ime varchar (100)not null,
prezime varchar (100)not null
);

create table korisnik (
sifra int not null primary key identity(1,1),
spol varchar  (10) ,
br_telefona varchar (20) not null
);

create table usluga (
sifra int not null primary key identity (1,1),
naziv varchar(50)  not null ,
cijena decimal(18,2) not null
);

create table posjeta (
sifra int not null primary key identity(1,1),
djelatnica  int not null references djelatnica,
korisnik  int not null references korisnik,
usluga  int not null references usluga
   
);

