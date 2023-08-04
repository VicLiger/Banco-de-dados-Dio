SELECT Nome, Ano FROM Filmes

SELECT * FROM Filmes
ORDER BY Ano

SELECT * FROM Filmes WHERE Nome = 'De Volta para o Futuro'

SELECT * FROM Filmes WHERE Ano = 1997

SELECT * FROM Filmes WHERE Ano > 2000

SELECT * FROM Filmes WHERE Duracao > 100 AND Duracao < 150 ORDER BY Duracao

SELECT Ano, COUNT(*) AS quantidade
FROM Filmes
GROUP BY Ano
ORDER BY quantidade DESC;

SELECT * FROM Atores WHERE Genero = 'M'

SELECT * FROM Atores WHERE Genero = 'F' ORDER BY PrimeiroNome


SELECT * FROM FilmesGenero
SELECT * FROM Generos
SELECT * FROM Filmes

SELECT f.Nome AS NomeFilmes, g.Genero
FROM FilmesGenero
JOIN Filmes f ON IdFilme = f.Id
JOIN Generos g ON IdGenero = g.Id

SELECT f.Nome AS Nome, g.Genero
FROM FilmesGenero
JOIN Filmes f ON IdFilme = f.Id
JOIN Generos g ON IdGenero = g.Id
WHERE Genero = 'Mistério'

SELECT f.Nome AS NomeFilme, a.PrimeiroNome, a.UltimoNome, e.PAPEL
FROM ElencoFilme e
JOIN Filmes f ON e.IdFilme = f.Id
JOIN Atores a ON e.IdAtor = a.Id;
