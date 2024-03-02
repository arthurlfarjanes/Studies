create database db_crudContatos;
use db_crudContatos;

create table if not exists tb_contato(
id_contato integer auto_increment primary key,
nm_nome varchar(50) not null,
cd_telefone varchar(15) not null,
cd_ativo char(1) not null default 'S'
);

/*INSERT INTO tb_contato(nm_nome, cd_telefone, cd_ativo)
VALUES ("Arthur Lanzilotti", 13991306180, 'S');*/

/*UPDATE tb_contato SET cd_ativo = 'N' WHERE id_contato = 3;*/

/*SELECT * from tb_contato;*/