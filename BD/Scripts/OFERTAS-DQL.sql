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


--Mostrar Médicos, Epecialidade e Nome da Clinica
SELECT NomeProduto, Descricao, Finalidade, TipoProduto
FROM Produto
INNER JOIN Finalidade
ON Produto.IdFinalidade = Finalidade.IdFinalidade
INNER JOIN TipoProduto
ON Produto.IdTipoProduto = TipoProduto.IdTipoProduto
GO
-- Converter Data da Consulta do Usuário para Formato (mm-dd-yyyy) 
SELECT FORMAT (DataValidade, 'dd/MM/yyyy')[Data Consulta]  FROM Produto;
GO
