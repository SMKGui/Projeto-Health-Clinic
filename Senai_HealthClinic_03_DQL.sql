SELECT
	Consulta.IdConsulta,
	Consulta.[Data],
	Consulta.Horario,
	Clinica.NomeFantasia AS Clinica,
	Usuario.Nome AS Nome,
	Especialidade.Nome AS Especialidade,
	Medico.CRM,
	Consulta.Prontuario,
	Comentario.Descricao
FROM Clinica
	INNER JOIN Medico ON Clinica.IdClinica = Medico.IdClinica
	INNER JOIN Consulta ON Medico.IdMedico = Consulta.IdMedico
	INNER JOIN Usuario ON Medico.IdUsuario = Usuario.IdUsuario
	INNER JOIN Especialidade ON Medico.IdEspecialidade = Especialidade.IdEspecialidade
	INNER JOIN Comentario ON Consulta.IdComentario = Comentario.IdComentario