use master;
go
drop database if exists knjiznica;
create database knjiznica;
go
use knjiznica;

create table clan (
sifra int not null primary key identity (1,1),
clanski_broj int  not null
);

create table osobe (
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
adresa varchar (50),
email varchar (50)
);

create table vlasnik (
sifra int not null primary key identity (1,1),
knjige int not null
);

create table knjige (
sifra int  not null primary key identity (1,1),
naslov varchar (50) not null,
pisac varchar (50) not null,
vlasnik int not null ,
clan int null references clan,
datum_posudbe datetime not null,
datum_vracanja datetime
);
--alter table vlasnik 
--add constraint fk_vlasnik_knjige
--foreign key (knjige) references knjige (sifra)

--alter table knjige
--add constraint fk_knjige_vlasnik 
--foreign key (vlasnik) references vlasnik (sifra)
