CREATE DATABASE frizerski_salon;   
use master;
go
drop database if exits frizerski_salon;
go
create database frizerski_salon
use frizerski_salon;

create table djelatnica (
sifra int not null identity(1,1) primary key,
ime varchar (100)not null,
prezime varchar (100)not null
);
create table korisnik (
sifra int not null primary key identity(1,1),
spol varchar  (10) not null,
br_telefona varchar (20) not null
);

create table usluga (
sifra int not null primary key,
naziv  not null varchar(50),
cijena decimal(18,2) not nul
);

create table posjeta (
sifra int not null identity(1,1)primary key,
djelatnica not null int,
korisnik not null int,
usluga  not nul int,
    FOREIGN KEY (djelatnica) not nul REFERENCES Djelatnica(sifra),
    FOREIGN KEY (korisnik) REFERENCES Korisnik(sifra),
    FOREIGN KEY (usluga) REFERENCES Usluga(sifra)

);

