CREATE DATABASE frizerski_salon;        
use frizerski_salon;

create table djelatnica (
sifra int identity(1,1) primary key,
ime varchar(100),
prezime varchar(100)
);
create table korisnik (
sifra int primary key,
spol varchar (10),
br_telefona varchar (20)
);

create table usluga (
sifra int primary key,
naziv varchar(50),
cijena decimal(18,2)
);

create table posjeta (
sifra int identity(1,1)primary key,
djelatnica int,
korisnik int,
usluga int,
    FOREIGN KEY (djelatnica) REFERENCES Djelatnica(sifra),
    FOREIGN KEY (korisnik) REFERENCES Korisnik(sifra),
    FOREIGN KEY (usluga) REFERENCES Usluga(sifra)

);

