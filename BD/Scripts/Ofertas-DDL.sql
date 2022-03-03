Create Database OFERTA;
GO

USE OFERTA;
GO


CREATE TABLE TipoUsuario(
	IdTipoUsuario INT PRIMARY KEY IDENTITY(1,1),
	TipoUsuario VARCHAR(20) NOT NULL UNIQUE
);
GO

CREATE TABLE Usuario(
	IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario),
    Email VARCHAR(30) NOT NULL UNIQUE,
    Senha VARCHAR(20) NOT NULL 
);
GO

CREATE TABLE Endereco(
   IdEndereco INT PRIMARY KEY IDENTITY(1,1),
   IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
   Logadouro VARCHAR(70) NOT NULL,
   Numero SMALLINT NOT NULL,
   Bairro VARCHAR(50) NOT NULL,
   Municipio VARCHAR(50) NOT NULL,
   Estado VARCHAR(2) NOT NULL,
   CEP VARCHAR(8) NOT NULL
);
GO

CREATE TABLE Instituicao(
   IdInstituicao INT PRIMARY KEY IDENTITY(1,1),
   IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
   CNPJ VARCHAR(14) NOT NULL,
   NomeFantasia VARCHAR(50) NOT NULL,
   RazaoSocial  VARCHAR(70) NOT NULL
);
GO

CREATE TABLE Cliente(
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	NomeCliente  VARCHAR(70) NOT NULL,
	CPF VARCHAR(11) NOT NULL UNIQUE, 
	NIS VARCHAR(11) UNIQUE
);
GO

CREATE TABLE TipoProduto(
	IdTipoProduto INT PRIMARY KEY IDENTITY(1,1),
	TipoProduto VARCHAR(20) NOT NULL UNIQUE
);
GO

CREATE TABLE Finalidade(
	IdFinalidade INT PRIMARY KEY IDENTITY(1,1),
	Finalidade VARCHAR(20) NOT NULL UNIQUE
);
GO

CREATE TABLE Produto(
	IdProduto INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	IdTipoProduto INT FOREIGN KEY REFERENCES TipoProduto(IdTipoProduto),
	IdFinalidade INT FOREIGN KEY REFERENCES Finalidade(IdFinalidade),
	NomeProduto VARCHAR(60) NOT NULL,
	Descricao VARCHAR(300) NOT NULL,
	Quantidade SMALLINT NOT NULL,
	Preco FLOAT NOT NULL,
	DataValidade DATE NOT NULL,
	Imagem VArCHAR(70) NOT NULL
);
GO

CREATE TABLE SituacaoReserva(
	IdSituacaoReserva INT PRIMARY KEY IDENTITY(1,1),
	SituacaoReserva VARCHAR(20) NOT NULL UNIQUE
);
GO

CREATE TABLE Reserva(
	IdReserva INT PRIMARY KEY IDENTITY(1,1),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	IdSituacaoReserva INT FOREIGN KEY REFERENCES SituacaoReserva(IdSituacaoReserva),
	IdProduto INT FOREIGN KEY REFERENCES Produto(IdProduto),
	QuantidadeReservada SMALLINT NOT NULL
);
GO


