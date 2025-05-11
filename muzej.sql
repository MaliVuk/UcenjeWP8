--create database muzej;
--use muzej;
--create table kustosi (
--sifra int primary key,
--ime_i_prezime varchar(100),
--mail varchar (100)
--);

create table sponzori (
﻿create database muzej;
go
use muzej;
go
create table kustosi (
sifra int primary key,
ime_i_prezime varchar(100),
mail varchar (100)
);
go
create table sponzori (
sifra int primary key,
naziv varchar(50),
iznos_uplate decimal (10,2)
);
go
create table izlozbe (
sifra int primary key,
naziv_izlozbe varchar (50),
vrsta_izlozbe varchar (50),
sifra_kustosa int unique,
sifra_sponzora int unique, 
foreign key (sifra_kustosa) references kustosi(sifra),
foreign key (sifra_sponzora) references sponzori(sifra)
);
go
CREATE TABLE Djela (
    sifra INT PRIMARY KEY,
    naziv_djela VARCHAR(100),
    vrsta_djela VARCHAR(100),
    cijena DECIMAL(10,2),
    sifra_izlozbe INT,
    FOREIGN KEY (sifra_izlozbe) REFERENCES izlozbe(sifra)
);



