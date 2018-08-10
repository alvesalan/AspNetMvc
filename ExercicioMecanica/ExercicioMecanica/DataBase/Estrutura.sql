DROP TABLE servicos;




CREATE TABLE servicos(
 id INT IDENTITY(1, 1) PRIMARY KEY,
 nomeDono VARCHAR(100),
 modelo VARCHAR(40),
 cor VARCHAR(30),
 colaboradorResponsavel VARCHAR(100),
 status VARCHAR(70),
 dataOrcamento DATE,
 valorOrcamento FLOAT,
 valorServico FLOAT,
 valorDesconto FLOAT,
 valorTotal FLOAT,
 finalizacaoServico DATE
);


INSERT INTO servicos (nomeDono, modelo, cor, colaboradorResponsavel, status, dataOrcamento, valorOrcamento, valorServico, valorDesconto, valorTotal, finalizacaoServico)
VALUES ('Alan', 'Ford', 'Azul', 'Jose', 'Carro Perfeito', '2018-04-12', 200.00, 50.00, 20.00, 270.00, '2018-04-20');



 
 
 
        
        
        














INSERT INTO servicos VALUES ('Alan');
INSERT INTO servicos VALUES ('Jose');
INSERT INTO servicos VALUES ('Camila');

SELECT * FROM servicos