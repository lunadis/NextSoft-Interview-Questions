use master
go
drop database filmes
go
create database filmes
go 
use filmes
go

create table tb_genero(
	id int not null identity (0,1),
	nmGenero varchar(180),

	PRIMARY KEY(id)
),
create table tb_filme(
	id int not null identity (0,1),
	nmFilme varchar(180),
	idGenero int not null,

	Primary key(id),
	foreign Key(idGenero) references tb_genero(id)
)


insert into tb_genero (nmGenero) values('acao');
insert into tb_filme (idGenero, nmFilme) values(1, 'Cemiterio maldito')

select * from tb_filme
select * from tb_genero