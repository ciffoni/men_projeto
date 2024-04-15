create database projeto;
use projeto;

create table cargo(
cod_cargo int auto_increment primary key,
cargo varchar(50)
);
insert into cargo(cargo) values("administrador"),
("gerente"),
("técnico"),
("vendedor");
CREATE TABLE `usuario` (
  `cod_usu` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(70) DEFAULT NULL,
  `email` varchar(70) DEFAULT NULL,
  `senha` varchar(46) DEFAULT NULL,
  cod_cargo int,
  PRIMARY KEY (`cod_usu`),
  foto varchar(120),
  constraint fk_cargo foreign key (cod_cargo) references cargo(cod_cargo)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

insert into usuario(nome,email,senha) values("jorge","ciffoni@gmail.com","aula123",1);

create table fornecedor(
cod_forn int primary key auto_increment,
nome varchar(70)
);
create table produto(
cod_prod int primary key auto_increment,
nome varchar(70),
quantidade int,
preco decimal(5,2),
foto varchar(120),
cod_fornecedor int,
constraint fk_forn foreign key(cod_fornecedor) references fornecedor(cod_forn)
);