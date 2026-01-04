create database COLECAO_CARROS;
use COLECAO_CARROS;

create table CARROS(
id int AUTO_INCREMENT PRIMARY KEY,
Nome varchar(70),
Marca varchar (70),
Ano int,
Preco float
);

select * from CARROS;