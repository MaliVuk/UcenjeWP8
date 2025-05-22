go
drop database if exists iznajmljivanje;
go
create database iznajmljivanje collate Croatian_CI_AS;
go
use iznajmljivanje;
go

create table najmodavac (
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (100)
);

create table stan (
sifra int not null primary key identity (1,1),
adresa varchar(100) not null unique,
datum_uplate_stanarine date null,
najmodavac int not null references najmodavac
);

create table rezije (
sifra int not null primary key identity (1,1),
mjesec int not null,
godina int null,
tip varchar (50),
iznos decimal (10,2) ,
datum_placanja date null,
stan int not null references stan
);
go
drop database if exists iznajmljivanje;
go
create database iznajmljivanje collate Croatian_CI_AS;
go
use iznajmljivanje;
go

create table najmodavac (
sifra int not null primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (100)
);

create table stan (
sifra int not null primary key identity (1,1),
adresa varchar(100) not null unique,
datum_uplate_stanarine date null,
najmodavac int not null references najmodavac
);

create table rezije (
sifra int not null primary key identity (1,1),
mjesec int not null,
godina int null,
tip varchar (50),
iznos decimal (10,2) ,
datum_placanja date null,
stan int not null references stan
);

create table najmoprimac (
sifra int not null primary key identity (1,1),
ime_ili_naziv varchar (50) null,
kontakt varchar(50)null
);

create table ugovor (
sifra int not null primary key identity (1,1),
datum_pocetka date null,
datum_zavrsetka date null,
stan  int not null references stan,
najmoprimac int not null references najmoprimac
);


select * from najmodavac
insert into najmodavac(ime,prezime)
values ('Zlata','Vučić');
--delete from najmodavac
--where sifra in (2,3);

select * from stan
insert into stan (adresa,datum_uplate_stanarine,najmodavac)
values ('SLB_Mandića_10',NULL,1),
('Medulinska_4',NULL,1);



declare @mjesec int = 1;
while @mjesec <= 12
begin
insert into rezije (mjesec,godina,tip,iznos,datum_placanja,stan)
values(@mjesec, 2025, 'struja',null,null, 1),
        (@mjesec, 2025, 'voda',null,null, 1),
        (@mjesec, 2025, 'plin',null,null, 1),
        (@mjesec, 2025, 'unikom',null,null, 1),
        (@mjesec, 2025, 'porez',null,null, 1),
        (@mjesec, 2025, 'internet',null,null, 1),
        (@mjesec, 2025, 'stambeno',null,null, 1),
		(@mjesec, 2025, 'komunalno',null,null, 1);
        
    set @mjesec += 1;
end;
set @mjesec = 1;
while @mjesec <= 12
begin
insert into rezije (mjesec,godina,tip,iznos,datum_placanja,stan)
values(@mjesec, 2025, 'struja',null,null, 2),
        (@mjesec, 2025, 'voda',null, null,2),
        (@mjesec, 2025, 'plin',null,null,2),
        (@mjesec, 2025, 'unikom', null,null, 2),
        (@mjesec, 2025, 'porez', null,null, 2),
        (@mjesec, 2025, 'internet',null,null, 2),
        (@mjesec, 2025, 'stambeno',null,null, 2),
		(@mjesec, 2025, 'komunalno',null,null, 2);
        
    set @mjesec += 1;
end;

create table ugovor (
sifra int not null primary key identity (1,1),
datum_pocetka date null,
datum_zavrsetka date null,
stan  int not null references stan,
najmoprimac int not null references najmoprimac
);


select * from najmodavac
insert into najmodavac(ime,prezime)
values ('Zlata','Vučić');
--delete from najmodavac
--where sifra in (2,3);

select * from stan

insert into stan (adresa,datum_uplate_stanarine,najmodavac)
values ('SLB_Mandića_10',NULL,1),
('Medulinska_4',NULL,1);

select* from rezije

declare @mjesec int = 1;
while @mjesec <= 12
begin
insert into rezije (mjesec,godina,tip,iznos,datum_placanja,stan)
values(@mjesec, 2025, 'struja',null,null, 1),
        (@mjesec, 2025, 'voda',null,null, 1),
        (@mjesec, 2025, 'plin',null,null, 1),
        (@mjesec, 2025, 'unikom',null,null, 1),
        (@mjesec, 2025, 'porez',null,null, 1),
        (@mjesec, 2025, 'internet',null,null, 1),
        (@mjesec, 2025, 'stambeno',null,null, 1),
		(@mjesec, 2025, 'komunalno',null,null, 1);
        
    set @mjesec += 1;
end;
set @mjesec = 1;
while @mjesec <= 12
begin
insert into rezije (mjesec,godina,tip,iznos,datum_placanja,stan)
values(@mjesec, 2025, 'struja',null,null, 2),
        (@mjesec, 2025, 'voda',null, null,2),
        (@mjesec, 2025, 'plin',null,null,2),
        (@mjesec, 2025, 'unikom', null,null, 2),
        (@mjesec, 2025, 'porez', null,null, 2),
        (@mjesec, 2025, 'internet',null,null, 2),
        (@mjesec, 2025, 'stambeno',null,null, 2),
		(@mjesec, 2025, 'komunalno',null,null, 2);
        
    set @mjesec += 1;
end;

select *from najmoprimac;
insert into najmoprimac (ime_ili_naziv,kontakt)
values ('Erna','0953669852'),
       ('Mlinar','0914232276');

delete from najmoprimac
where sifra in (3,4,5,6);

select *from ugovor;
insert into ugovor (datum_pocetka,datum_zavrsetka,stan,najmoprimac)
values ('2025-02-01',null,1,1),
        ('2023-01-01',null,2,2);

