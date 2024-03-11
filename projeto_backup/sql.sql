create database projeto;
use projeto;
create table usuario(
id_usuario int primary key auto_increment,
nome varchar(70),
email varchar(70),
senha varchar(40)
);