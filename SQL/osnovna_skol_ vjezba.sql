go
drop database if exists osnovna_skola;
go
create database osnovna_skola collate Croatian_CI_AS;
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

insert into uciteljica (ime, prezime, predmet)
values 
('čedo', 'vujičić','plesanje'),
('Ranka', 'Rankić', 'tehnički'),
('ivo', 'ivić', 'kemija'),
('ana', 'anić', 'pijevanje');




--insert into radionica (naziv ,uciteljica)
--values 

--DELETE FROM uciteljica
--WHERE sifra in (1, 2 ,3 ,4);


--SELECT * FROM uciteljica
--drop table sudjelovanje;