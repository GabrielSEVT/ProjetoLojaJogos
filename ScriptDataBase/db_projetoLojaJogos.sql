DROP DATABASE IF EXISTS db_projetoLojaJogos;

CREATE DATABASE db_projetoLojaJogos;
USE db_projetoLojaJogos;

CREATE TABLE tbCliente(
	Cpf VARCHAR(15) PRIMARY KEY,
	Nome VARCHAR(150) NOT NULL,
    DataNascimento DATETIME NOT NULL,
    Email VARCHAR(150) NOT NULL UNIQUE,
    Celular VARCHAR(15) NOT NULL UNIQUE,
    Endereco VARCHAR(150) NOT NULL     
)
default charset utf8;

CREATE TABLE tbFuncionario(
	Codigo INT PRIMARY KEY,
	Cpf VARCHAR(15) NOT NULL,
    Rg VARCHAR(12) NOT NULL,
	Nome VARCHAR(150) NOT NULL,
    DataNascimento DATETIME NOT NULL,
    Email VARCHAR(150) NOT NULL UNIQUE,
    Celular VARCHAR(15) NOT NULL UNIQUE,
    Endereco VARCHAR(150) NOT NULL,
    Cargo VARCHAR(70) NOT NULL
)
default charset utf8;

CREATE TABLE tbJogo(
	Codigo INT PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL UNIQUE,
    Versao VARCHAR(30),
    Desenvolvedor VARCHAR(150) NOT NULL,
    Genero VARCHAR(150) NOT NULL,
    FaixaEtaria VARCHAR(2) NOT NULL,
    Plataforma VARCHAR(50) NOT NULL,
    AnoLancamento VARCHAR(4) NOT NULL,
    Sinopse VARCHAR(300) NOT NULL UNIQUE
) 
default charset utf8;

select * from tbCliente;
select * from tbFuncionario;
select * from tbJogo;