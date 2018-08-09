CREATE TABLE alunos(
	id INT IDENTITY(1, 1),
	nome VARCHAR(100),
	matricula VARCHAR(20),
	nota1 FLOAT,
	nota2 FLOAT,
	nota3 FLOAT,
	frequencia TINYINT
);

INSERT INTO alunos (nome, matricula, nota1, nota2, nota3, frequencia) VALUES ('ALAN', '20-a', 10, 10, 10, 100)