USE OFERTA;
GO

SELECT * FROM TipoUsuario;
SELECT * FROM Usuario;
SELECT * FROM Endereco;
SELECT * FROM Instituicao;
SELECT * FROM Cliente;
SELECT * FROM TipoProduto;
SELECT * FROM Finalidade;
SELECT * FROM Produto;
SELECT * FROM SituacaoReserva;
SELECT * FROM Reserva;
GO

INSERT INTO TipoUsuario (TipoUsuario) 
VALUES ('Cliente Comum'), ('Cliente Baixa Renda'), 
	   ('ONG'), ('Empresa');
GO


INSERT INTO Usuario (IdTipoUsuario, Email, Senha)
VALUES (1,'ClienteComum@Gmail.com', 'omum123' ), (2,'ClienteBaixa@Gmail.com', 'baixarenda123'), 
	  (3,'ONG@Gmail.com', 'ONG123'), (4,'Empresa@Gmail.com', 'empresa123');
GO


INSERT INTO Endereco (IdUsuario, Logadouro, Numero, Bairro, Municipio, Estado, CEP)
VALUES (1,'Quadra Seis', '1463', 'Tabajara Brites', 'Uruguaiana', 'RS', '97504546'),
	   (2,'Rua Lopes de Oliveira', '99', 'Barra Funda', 'São Paulo', 'SP', '01152010'),
	   (3,'Rua Espírito Santo', '651', 'Cerâmica', 'São Caetano do Sul', 'SP', '09530701'),
	   (4,'Rua George Eastman', '671', 'Vila Tramontano', 'São Paulo', 'SP', '05690000');
GO


INSERT INTO Instituicao (IdUsuario, CNPJ, NomeFantasia, RazaoSocial)
VALUES (3,'46824082000190', 'Centro Cidadania', 'ONG Centro Cidadania de ajuda'),
	   (4,'70862984000103', 'Carrefour', 'Carrefour Comercio e Industria Ltda' );
GO


INSERT INTO Cliente (IdUsuario, NomeCliente, CPF, NIS)
VALUES (1,'Oswaldo', '51363555065', '09606874074'),
	   (2,'Cleber', '41552321037', '62993218288');
GO


INSERT INTO TipoProduto (TipoProduto)
VALUES ('Roupa'), ('Alimentos');
GO


INSERT INTO Finalidade (Finalidade)
VALUES ('Doação'), ('Compra'), ('Oferta');
GO


INSERT INTO Produto (IdUsuario, IdTipoProduto, IdFinalidade, Descricao, Quantidade, Preco, DataValidade, Imagem)
VALUES (1, 2, 2, 'O Biscoito Recheado Trakinas possui uma deliciosa massa crocante e recheio saboroso. Sua embalagem é compacta, podendo ser levada para onde quiser. Ideal para qualquer ocasião', 
		3, 2, '07/03/2024', '0450' ),
		(2, 2, 1, 'TORCIDA® é a marca brasileira que conquistou todas as faixas etárias, inclusive os adultos, sendo o aperitivo perfeito para acompanhar os jogos de futebol e a roda de amigos.', 
		1, 1, '03/02/2022', '5000' ),
		(4, 2, 3, 'O prazer do sabor equilibrado, forte, com aroma intenso e que promove a cada amanhecer, experiências apaixonantes ao lado de quem mais amamos. Um clássico trazendo de suas raízes o gosto perfeito a cada xícara', 
		1, 6.5, '14/07/2023', '0560' );
GO


INSERT INTO SituacaoReserva (SituacaoReserva)
VALUES ('Reservado'), ('Não Reservado');
GO

INSERT INTO Reserva (IdUsuario, IdSituacaoReserva, IdProduto, QuantidadeReservada)
VALUES (2, 1, 3, 2),
	   (1, 2, 1, 1);
GO







