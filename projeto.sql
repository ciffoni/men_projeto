create database projeto;
use projeto;
CREATE TABLE `usuario` (
  `cod_usu` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(70) DEFAULT NULL,
  `email` varchar(70) DEFAULT NULL,
  `senha` varchar(46) DEFAULT NULL,
  PRIMARY KEY (`cod_usu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

insert into usuario(nome,email,senha) values("jorge","ciffoni@gmail.com","aula123");

create table cargo(
cod_cargo int auto_increment primary key,
cargo varchar(50)
);
insert into cargo(cargo) values("administrador"),
("gerente"),
("técnico"),
("vendedor");
