---DML---

INSERT INTO TipoUsuario(Nome) VALUES ('Administrador'),('Medico'),('Paciente');
SELECT * FROM TipoUsuario;

INSERT INTO Usuario(Nome,Email,Senha) VALUES('Guilherme','gui@email.com','12345678'),('Francisca','fran@email.com','87654321'),('Valdeci','valdeci@email.com','batata123');
SELECT * FROM Usuario;

UPDATE Usuario SET IdTipoUsuario = 1 WHERE IdUsuario = 1
UPDATE Usuario SET IdTipoUsuario = 2 WHERE IdUsuario = 2
UPDATE Usuario SET IdTipoUsuario = 3 WHERE IdUsuario = 3

INSERT INTO Paciente(IdUsuario,Nome,DataNascimento,Telefone,CPF) VALUES(3,'Valdeci','1962-05-11','11923548798','12345678909');
SELECT * FROM Paciente;

INSERT INTO Clinica(Endereco,NomeFantasia,RazaoSocial) VALUES('Rua das Ruas, 123, Sao Paulo','HC','HealthClinic');
SELECT * FROM Clinica;

INSERT INTO Especialidade(Nome) VALUES('Dermatologia'),('Oftalmologia'),('Endocrinologia');
SELECT * FROM Especialidade

--ALTER TABLE Paciente
--DROP COLUMN Nome

INSERT INTO Comentario(Descricao) VALUES('Medico atencioso e preparado, me senti confortavel e amparado');
SELECT * FROM Comentario;

INSERT INTO Medico(IdUsuario,IdClinica,IdEspecialidade,CRM) VALUES(2,1,1,'SP213243');
SELECT * FROM Medico;

INSERT INTO Consulta(IdMedico,IdPaciente,IdComentario,[Data],Horario,Prontuario)
VALUES(1,2,1,'2023-08-15','15:30:00','Paciente reclamava de dores na costas, foi receitado antibiotico Bioanti e 3 dias de repouso');
SELECT * FROM Consulta;