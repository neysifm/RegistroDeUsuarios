CREATE DATABASE UsiariosDb
GO

USE UsiariosDb
GO

CREATE TABLE Usuarios
(
	ID_Usuario INT PRIMARY KEY, 
	Nombre VARCHAR(50), 
	Email VARCHAR(50), 
	NivelUsuario VARCHAR(50),
	Usuario VARCHAR(50), 
	Clave VARCHAR(50), 
	FechaIngreso DATE
);
GO


