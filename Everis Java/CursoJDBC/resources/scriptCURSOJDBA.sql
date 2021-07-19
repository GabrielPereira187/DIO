create database cursoJDBA;
 
use cursoJDBA;

create table aluno(
	id integer primary key auto_increment,
    nome varchar(60) not null,
    idade integer not null,
    estado character(2) not null
)

select * from aluno;

insert into aluno(nome,idade,estado) values('gabriel',12,'SP');