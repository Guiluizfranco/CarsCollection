create database colacao_carros;

use colacao_carros;

create table carros
(
id int auto_increment,
nome varchar(30),
marca varchar(30),
ano int,
preco float,
primary key(id)
);

select * from carros where nome = 'corsa';

drop database colacao_carros;