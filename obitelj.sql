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
--1.zadatak
--select*from sestra;
insert into sestra (introvertno,haljina,marka,hlače,narukvica)
values (1,'plava',150.25,'traper',2),
        (0,'crvena',90.50,'pamučne',1),
		(1,'bajkovita', 120.00, 'kožne', 3);
--select*from svekar;
insert into svekar(boja_ociju,prstena,dukserica,lipa,eura,majica)
values('smeđa', 2, 'Nike', 15.25000000, 12.3400000, 'Crna'),
      ('zelena', 1, 'Adidas', 9.12345678, 8.2500000, 'Bijela'),
      ('plava', 3, 'Puma', 10.00000000, 11.1100000, 'Siva');

--select* from zena;
insert into zena (treciputa, hlace, kratka_majica, jmbag, boja_ociju, haljina, sestra)
values('2025-01-01', 'plave hlace', 'kratka1', '12345678901', 'zelena', 'duga', 1),
('2025-01-02', 'ana hlace', 'kratka2', '22345678901', 'smeđa', 'srednja', 3),
('2025-01-03', 'crvene hlace', 'plisirana', '52565678901', 'plava', 'uska', 3),
('2025-01-03', 'crne hlace', 'oslikana', '32345678901', 'plava', 'kratka', 3);

--select *from muskarac;
insert into muskarac (boja_ociju, hlace, model_naocala, marka, zena)
values('zelena', 'Jeans', 'RayBan', 100.50, 1),
('plava', 'Chino', 'Oakley', 120.75, 2),
('smeđa', 'Skinny', 'Gucci', 95.20, 3);

--select*from sestra_svekar;
insert into sestra_svekar (sestra, svekar)
values (1, 1),
       (2, 2),
       (3, 3);

--2.zadatak
--select *from punac;
insert into punac (ogrlica, gustoca, hlace)
values(3, 10.55, 'traperice'),
(2, 12.75, 'crne'),
(5, 11.30, 'bijele');
--select *from cura;
insert into cura (novcica, gustoca, lipa, ogrlica, boja_kose, suknja, punac)
values (5.00, 12.50, 3.50, 1, 'smeđa', 'mini', 1),
(4.50, 10.25, 2.10, 2, 'plava', 'džins', 2),
(6.25, 8.80, 1.75, 3, 'crna', 'kožna', 3);

update cura
set gustoca = 15.77;

--3.zadatak u tablici mladic obrisat sve vrijednosti kuna veće od 15.78
--select*from mladic;
insert into mladic(suknja,kuna,drugiputa,asocijalno,ekstroventno,dukserica,muskarac)
values ('kratka',23.60000000,'2025-04-01',0,1,'xl',1),
('nema', 18.99, '2025-04-02', 1, 0, 'crna', 2),
('duga', 15.77, '2025-04-03', 0, 1, 'bijela', 3);
--delete from mladic
--where kuna > 15.78;

--4.zad. izlistajte kratkamajica iz tablice žena uz uvjet da vrijednost kolone hlače sadrže slova ana
--select *from zena;
select kratka_majica from zena
where hlace like'%ana%';

--5.zad.prikazat dukserica iz tabl. svekar,asocijalno iz tabl. mladic ta hlace iz tabl. muskarac uz uvjet da sve hlače iz tab, zena
--počinju slovom a te da vrijednosti kolone haljina iz tabl.sestra sadrže niz znakova ba. Hlače iz tabl, muškarac složiti silazno
select s.dukserica, mld.asocijalno, m.hlace                 
from svekar s
inner join sestra_svekar ss on ss.svekar = s.sifra
inner join sestra se on se.sifra = ss.sestra
inner join zena z on z.sestra = se.sifra
inner join muskarac m on m.zena = z.sifra
inner join mladic mld on mld.muskarac = m.sifra
where z.hlace like 'a%'
  and se.haljina like '%ba%'
order by m.hlace desc;
