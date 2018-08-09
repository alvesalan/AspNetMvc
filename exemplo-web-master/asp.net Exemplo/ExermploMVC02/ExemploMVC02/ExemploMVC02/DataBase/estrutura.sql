CREATE TABLE recrutadoras(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(100) NOT NULL,
	cpf CHAR(11) NOT NULL,
	tempo_empresa SMALLINT,
	salario DECIMAL(12, 2)
);




SELECT * FROM recrutadoras