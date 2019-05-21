CREATE DATABASE UsuariosDb
GO

USE UsuariosDb

CREATE TABLE Usuarios
(
	UsuarioId INT PRIMARY KEY, 
	Nombres VARCHAR(50), 
	Email VARCHAR(50), 
	NivelUsuario VARCHAR(50),
	Usuario VARCHAR(50), 
	Clave VARCHAR(50), 
	FechaIngreso DATE
);
GO

CREATE TABLE Cargos
(
	CargosId INT PRIMARY KEY,
	Descripcion VARCHAR(MAX)
);
GO



