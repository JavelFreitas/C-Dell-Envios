CREATE DATABASE Oficina;
GO
USE Oficina;
GO
CREATE TABLE Aluno (
matricula int not null primary key,
nome varchar(30) not null,
curso varchar(50) not null,
data_nascimento date not null,
);
GO
CREATE TABLE Turma (
nr_turma int not null primary key,
nometurma varchar(30) not null,
sala varchar(20) not null,
horario varchar(13) not null,
);
GO
INSERT INTO Aluno (matricula,nome,curso,data_nascimento)
VALUES (1,'Mateus Lima Custodio','Odontologia','2000-01-01');
GO
INSERT INTO Aluno (matricula,nome,curso,data_nascimento)
VALUES (2,'Julia Almeida Soares','Engenharia de Controle e Automação','2000-04-01');
GO
INSERT INTO Aluno (matricula,nome,curso,data_nascimento)
VALUES (3,'Matheus Cardoso Valverde','Sistemas de Midias Digitais','2000-12-31');
GO
INSERT INTO Turma (nr_turma,nometurma,sala,horario)
VALUES (1,'ODNT-01','B4S3','13:30 - 15:30');
GO
INSERT INTO Turma (nr_turma,nometurma,sala,horario)
VALUES (2,'ECA-01','B3S1','10:00 - 12:00');
GO
INSERT INTO Turma (nr_turma,nometurma,sala,horario)
VALUES (3,'SMD-01','B2S5','15:30 - 17:30');
GO
