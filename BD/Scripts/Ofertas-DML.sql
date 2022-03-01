USE OFERTA;
GO

INSERT INTO TipoUsuario (TipoUsuario) 
VALUES ('Cliente comum'), ('Cliente baixa renda'), 
	   ('ONG'), ('Empresa');
GO


INSERT INTO Usuario (IdTipoUsuario, Email, Senha)
VALUES (1,'Clientecomum@Gmail.com', 'comum123' ), (2,'Clientebaixa@Gmail.com', 'baixarenda123'), 
	  (3,'ONG@Gmail.com', 'ONG123'), (4,'Empresa@Gmail.com', 'empresa123');
GO


INSERT INTO Endereco (IdUsuario, Logadouro, Numero, Bairro, Municipio, Estado, CEP)
VALUES (1,'Santa Catarina', '1463', 'São Cristóvão', 'Cuiabá', 'MT', '97504546'),
	   (2,'Um', '99', 'Santo Antônio', 'Manaus', 'AM', '89858366'),
	   (3,'Pará', '9844', 'Planalto', 'Porto Velho', 'RO', '79083236'),
	   (4,'Mato Grosso', '342', 'Industrial', 'Boa Vista', 'RR', '69323894');
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
VALUES ('Doação'), ('Compra'), ('Ofertado');
GO


INSERT INTO Produto (IdUsuario, IdTipoProduto, IdFinalidade, Descricao, Quantidade, Preco, DataValidade, Imagem)
VALUES (1, 2, 2, 'O Biscoito Recheado Trakinas possui uma deliciosa massa crocante e recheio saboroso. Sua embalagem é compacta, podendo ser levada para onde quiser. Ideal para qualquer ocasião', 
		3, 2.00, 2024-07-03, 0000 ),
		(2, 2, 1, 'TORCIDA® é a marca brasileira que conquistou todas as faixas etárias, inclusive os adultos, sendo o aperitivo perfeito para acompanhar os jogos de futebol e a roda de amigos.', 
		1, 1.00, 2022-03-24, 0000 ),
		(4, 2, 3, 'O prazer do sabor equilibrado, forte, com aroma intenso e que promove a cada amanhecer, experiências apaixonantes ao lado de quem mais amamos. Um clássico trazendo de suas raízes o gosto perfeito a cada xícara', 
		1, 6.00, 2023-07-14, 0000 );
GO


INSERT INTO SituacaoReserva (SituacaoReserva)
VALUES ('Reservado'), ('Ainda não reservado');
GO

INSERT INTO Reserva (IdUsuario, IdSituacaoReserva, IdProduto, QuantidadeReservada)
VALUES (2, 1, 3, '2'),
	   (1, 2, 1, '1');
GO







