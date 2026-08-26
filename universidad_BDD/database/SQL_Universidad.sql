USE master;
GO

CREATE DATABASE universidad;
GO

ALTER DATABASE universidad
COLLATE SQL_Latin1_General_CP1_CI_AI;
GO

USE universidad;
GO

CREATE TABLE Carreras(
Id VARCHAR(4) PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
FechaCreacion DATE NOT NULL CHECK(FechaCreacion <= GETDATE()),
Mail VARCHAR(50) NOT NULL,
Nivel VARCHAR(20) NOT NULL CHECK (Nivel IN('Grado', 'Pregrado', 'Diplomatura', 'Posgrado'))
);
GO

CREATE TABLE Alumnos(
Legajo BIGINT IDENTITY(1000,1) PRIMARY KEY,
IdCarrera VARCHAR(4) NOT NULL,
CONSTRAINT FK_Alumnos_Carreras FOREIGN KEY (IdCarrera) REFERENCES Carreras(Id),
Apellido VARCHAR(50) NOT NULL,
Nombre VARCHAR(50) NOT NULL,
FechaNacimiento DATE NOT NULL CHECK(FechaNacimiento <= GETDATE()),
Mail VARCHAR(50) NOT NULL UNIQUE,
Telefono BIGINT NULL CHECK(Telefono > 0)
);
GO

CREATE TABLE Materias(
Id BIGINT NOT NULL PRIMARY KEY IDENTITY(1,1),
IdCarrera VARCHAR(4) NOT NULL,
CONSTRAINT FK_Materias_Carreras FOREIGN KEY (IdCarrera) REFERENCES Carreras (Id),
Nombre VARCHAR(50) NOT NULL,
CargaHoraria BIGINT NOT NULL CHECK (CargaHoraria > 0)
);
GO