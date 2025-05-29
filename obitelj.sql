use master;
go
drop database if exists obitelj;
go
create database obitelj collate Croatian_CI_AS;
go
use obitelj;
go

create table sestra (
sifra int not null primary key identity(1,1),
introvertno bit ,
haljina varchar (31),
marka decimal (16,6),
hlače varchar (46),
narukvica int
);
create table svekar (
sifra int not null primary key identity(1,1),
boja_ociju varchar(40) not null,
prstena int,
dukserica varchar (41),
lipa decimal (13,8),
eura decimal (12,7),
majica varchar(35)
);
create table sestra_svekar (
sifra int not null primary key identity(1,1),
sestra  int not null references sestra (sifra),
svekar int not null references svekar (sifra)
);
create table zena (
sifra  int not null primary key identity(1,1),
treciputa datetime,
hlace varchar (46),
kratka_majica varchar (31) not null,
jmbag char (11) not null,
boja_ociju varchar  (39)not null,
haljina varchar (44),
sestra int not null references sestra (sifra)
);
create table muskarac (
sifra  int not null primary key identity(1,1),
boja_ociju varchar(50),
hlace varchar(30),
model_naocala varchar(43),
marka decimal (14,5),
zena int not null references zena (sifra)
);
create table mladic(
sifra  int not null primary key identity(1,1),
suknja varchar(50) not null,
kuna decimal (16,8)not null,
drugiputa datetime,
asocijalno bit not null,
ekstroventno bit not null,
dukserica varchar (48),
muskarac int not null references muskarac (sifra)
);
create table punac (
sifra  int not null primary key identity(1,1),
ogrlica int,
gustoca decimal (14,9),
hlace varchar (41)not null
);
create table cura (
sifra  int not null primary key identity(1,1),
novcica decimal (16,5) not null,
gustoca decimal (18,6)not null,
lipa decimal (13,10),
ogrlica int not null,
boja_kose varchar (38),
suknja varchar (36),
punac int not null references punac (sifra)
);