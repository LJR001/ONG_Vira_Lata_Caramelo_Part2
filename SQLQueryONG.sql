USE ONG


CREATE TABLE Pessoa(
	CPF varchar(15) PRIMARY KEY Not null,
	Nome varchar(50) Not null,
	Sexo char(1),
	Data_Nascimento DATE Not null,
	Telefone varchar(11) Not Null,

	Logradouro varchar(50),
	Numero varchar(5) Not null,
	Bairro varchar(50) not null, 
	Cidade varchar(20) Not null,
	Estado varchar(20) Not null,
	CEP varchar(10) 
	
);

CREATE TABLE Animal(
	Numero_Chip int PRIMARY KEY,
	Familia varchar(15) Not null,
	Raca varchar(15),
	Sexo char(1),
	Nome varchar(50)
);

CREATE TABLE Adocao(
	Numero_Chip int Not null, 
	CPF varchar(15) Not null,
	Data_adocao DATETIME,

	FOREIGN KEY(CPF) REFERENCES Pessoa(CPF),
	FOREIGN KEY(Numero_Chip) REFERENCES Animal(Numero_Chip)

);


SELECT * FROM Adocao
SELECT * FROM Animal
SELECT * FROM Pessoa

DELETE  FROM Pessoa
DELETE  FROM Animal
DELETE FROM Adocao
