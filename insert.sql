use edunovawp8;

select * from smjerovi;

--1 ->
insert into smjerovi (naziv ,cijena,datumpokretanja,aktivan)
values ('Web programiranje',1200.54, '2025-05-16 17:00:01',1);

insert into smjerovi (naziv) values
--2
('Serviser'),
--3
('Web dizajn'),
--4
('Marketing');


insert into grupe (naziv,smjer)
values ('WP8',1),
--1
('wp7',1),
--2
('s1',2)
--3