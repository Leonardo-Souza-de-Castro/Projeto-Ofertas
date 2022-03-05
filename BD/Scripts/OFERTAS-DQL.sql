USE OFERTA;
GO

SELECT * FROM TipoUsuario

SELECT * FROM Usuario

SELECT * FROM Endereco

SELECT * FROM Instituicao

SELECT * FROM Cliente

SELECT * FROM TipoProduto

SELECT * FROM Finalidade

SELECT * FROM Produto

SELECT * FROM SituacaoReserva

SELECT * FROM Reserva

-- Quantidade de Usuários
SELECT COUNT(IdUsuario) 'Quantidade Usuários' FROM Usuario;
GO

--Usuario e Tipo de Usuario
SELECT IdUsuario,Email,TipoUsuario
FROM Usuario
INNER JOIN TipoUsuario
ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario


SELECT NomeProduto, Descricao, Finalidade, TipoProduto
FROM Produto
INNER JOIN Finalidade
ON Produto.IdFinalidade = Finalidade.IdFinalidade
INNER JOIN TipoProduto
ON Produto.IdTipoProduto = TipoProduto.IdTipoProduto
GO

SELECT Email, SituacaoReserva, NomeProduto, QuantidadeReservada
FROM Reserva
INNER JOIN Usuario
ON Reserva.IdUsuario = Usuario.IdUsuario
INNER JOIN SituacaoReserva
ON Reserva.IdSituacaoReserva = SituacaoReserva.IdSituacaoReserva
INNER JOIN Produto
ON Reserva.IdProduto = Produto.IdProduto
GO

-- Converter Data da Consulta do Usuário para Formato (mm-dd-yyyy) 
SELECT FORMAT (DataValidade, 'dd/MM/yyyy')FROM Produto;
GO
