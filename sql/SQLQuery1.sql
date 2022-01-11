CREATE DATABASE Refugiados;
GO
USE Refugiados;
GO
CREATE TABLE Refugiado
(
Refugiado_Id int NOT NULL PRIMARY KEY,
Nome varchar(50),
Idade int,
Genero varchar(11),
Estado_Civil varchar(10),
Telefone bigint,
Email varchar(50),
Nacionalidade varchar(50),
Etnia varchar(25),
Especialidade varchar(25)
);
GO
CREATE TABLE Vaga
(
Vaga_Id int NOT NULL PRIMARY KEY,
Nome_Empresa varchar(50),
CNPJ bigint,
Fk_Refugiado int NOT NULL,
Cargo varchar(50)
FOREIGN KEY(Fk_Refugiado) REFERENCES Refugiado(Refugiado_Id),
);

GO
INSERT INTO Refugiado
(Refugiado_Id,
Nome,
Idade,
Genero,
Estado_civil,
Telefone,
Email,
Nacionalidade,
Etnia,
Especialidade
)
VALUES
(1, 'Ava', 20, 'Feminino', 'Solteira', 618411088821, 'avabusiness@gmail.com', 'Venezuela', 'Indígena', 'Cozinheira'),
(2, 'Noah', 25, 'Masculino', 'Casado', 075658678467, 'noahbusiness@yahoo.com', 'Africa do Sul', 'Afrodescendente', 'Programador Java'),
(3, 'Grace', 30, 'Feminino', 'Casada', 7973164876747, 'gracebusiness@outlook.com', 'Sudão do Sul', 'Afrodescendente', 'Engenheira'),
(4, 'Elijah', 35, 'Masculino', 'Solteiro', 26481950858525, 'elijahbusiness@bol.com', 'Afeganistão', 'Hazara', 'Fisioterapeuta'),
(5, 'Lea', 40, 'Feminino', 'Viúva', 12607932918, 'leabusiness@fastmail.com', 'Síria', 'Muçulmana', 'Serviço geral');
GO
INSERT INTO Vaga
(
Vaga_Id,
Nome_Empresa,
CNPJ,
Fk_Refugiado,
Cargo
)
VALUES
(1, 'Wallmart', 83147851000199, 5, 'Serviço Geral'),
(2, 'Hospital Albert Einstein', 72132713000110, 4, 'Fisioterapeuta'),
(3, 'Toyota', 89041400000159, 3, 'Engenheira'),
(4, 'Microsoft', 89041400000159, 2, 'Programador Java'),
(5, 'Hospital São Lucas', 99749996000108, 1, 'Cozinheira');
GO
SELECT Nome, Idade, Genero, Estado_Civil, Telefone, Email, Nacionalidade, Etnia, Especialidade, Nome_Empresa, CNPJ, Cargo
FROM Refugiado
INNER JOIN Vaga
ON Refugiado.Refugiado_Id = Vaga.Vaga_Id;


