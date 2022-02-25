Create Database OFERTA;
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
   Logadouro VARCHAR(70) NOT NULL,
   Numero SMALLINT NOT NULL,
   Bairro VARCHAR(50) NOT NULL,
   Municipio VARCHAR(50) NOT NULL,
   Estado VARCHAR(2) NOT NULL,
   CEP VARCHAR(8) NOT NULL
);
GO

CREATE TABLE Empresa(
   IdEmpresa INT PRIMARY KEY IDENTITY(1,1),
   IdEndereco INT FOREIGN KEY REFERENCES Endereco(IdEndereco),
   IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
   CNPJ VARCHAR(14) NOT NULL,
   CNAE VARCHAR(7) NOT NULL,
   NomeFantasia VARCHAR(70) NOT NULL,
   RazaoSocial  VARCHAR(70) NOT NULL
);
GO

CREATE TABLE ONG(
	IdONG INT PRIMARY KEY IDENTITY(1,1),
	IdEndereco INT FOREIGN KEY REFERENCES Endereco(IdEndereco),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	NomeFantasia VARCHAR(70) NOT NULL,
	CNPJ VARCHAR(14) NOT NULL,
	Imagem VARCHAR NOT NULL
);
GO

CREATE TABLE Cliente(
    IdCliente INT PRIMARY KEY IDENTITY(1,1),
	IdEndereco INT FOREIGN KEY REFERENCES Endereco(IdEndereco),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	NomeCliente  VARCHAR(70) NOT NULL,
	CPF VARCHAR(11) NOT NULL, 
);
GO

CREATE TABLE ClienteBaixaRenda(
    IdClienteBaixaRenda INT PRIMARY KEY IDENTITY(1,1),
	IdEndereco INT FOREIGN KEY REFERENCES Endereco(IdEndereco),
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
	NomeClienteBaixaRenda VARCHAR(70) NOT NULL,
	CPF VARCHAR(11) NOT NULL, 
	NIS VARCHAR(11) NOT NULL,
);
GO

CREATE TABLE TipoProduto(
	IdTipoProduto INT PRIMARY KEY IDENTITY(1,1),
	TipoProduto VARCHAR(20) NOT NULL UNIQUE
);
GO

CREATE TABLE Produto(
	IdProduto INT PRIMARY KEY IDENTITY(1,1),
	IdTipoProduto INT FOREIGN KEY REFERENCES TipoProduto(IdTipoProduto),
	Quantidade INT NOT NULL,
	Descricao VARCHAR(200) NOT NULL UNIQUE,
	Preco FLOAT NOT NULL,
	DataValidade VARCHAR NOT NULL,
	Imagem VARCHAR NOT NULL
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
	DataReserva VARCHAR NOT NULL
);
GO

CREATE TABLE CarrinhoDeCompras(
	IdCarrinhoDeCompras INT PRIMARY KEY IDENTITY(1,1),
	IdProduto INT FOREIGN KEY REFERENCES Produto(IdProduto),
	Quantidade INT NOT NULL
);
GO

