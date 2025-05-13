use master;
go
drop database if exists azil_za_zivotinje;
go
create database azil_za_zivotinje;
go

use azil_za_zivotinje;

create table djelatnici(
sifra int not null primary key identity (1,1),
ime_i_prezime varchar (50)not null,
zanimanje varchar (50)
);

create table zivotinje (
Sifra int not null primary key identity (1,1),

ime varchar (20) not null,
dob int,
djelatnici int not null references djelatnici
);

create table prostorije (
sifra int not null primary key identity (1,1),
boja_prostorije varchar (20)
);

create table boravak (
sifra int not null primary key identity (1,1),
zivotinje int not null references zivotinje,
prostorije int not null references prostorije,
datum_boravka_od date,
datum_boravka_do date

);