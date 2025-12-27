create database colacao_carros;

use colacao_carros;

create table carros
(
id int primary key,
nome varchar(30),
marca varchar(30),
ano int,
preco float
);

select * from carros;