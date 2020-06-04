CREATE DATABASE BIBLIOTECA;
USE BIBLIOTECA;


CREATE TABLE areas(
areCodigo VARCHAR(10) PRIMARY KEY NOT NULL,
areNombre VARCHAR(25) NOT NULL,
areTiempo INT not null,
areId int identity (1,1)
);


CREATE TABLE libros(
libCodigo VARCHAR(10) PRIMARY KEY,
libNombre VARCHAR(50) NOT NULL,
libNumPag INT NOT NULL,
libAutor VARCHAR(50),
libEditorial VARCHAR(50),
libArea VARCHAR(10),
libId int identity(1,1),
FOREIGN KEY (libArea) REFERENCES areas(areCodigo)
);

CREATE TABLE usuarios(
usuDocumento VARCHAR(15) PRIMARY KEY NOT NULL,
usuNombre VARCHAR(100) NOT NULL,
usuDireccion VARCHAR(100) NOT NULL,
usuTelefono VARCHAR(12) NOT NULL,
usuCorreo VARCHAR(50) NOT NULL,
usuEstado VARCHAR(20) NOT NULL,
usuId INT identity (1,1)
)

CREATE TABLE prestamos(
preCodigo INT PRIMARY KEY IDENTITY(1,1),
preFecha DATETIME NOT NULL,
preUsuario VARCHAR(15) NOT NULL,
FOREIGN KEY (preUsuario) REFERENCES usuarios(usuDocumento)
);

CREATE TABLE detallePrestamos(
detCodigo INT PRIMARY KEY IDENTITY (1,1),
detPrestamo INT NOT NULL,
detDiasSansion INT NOT NULL,
detFechaInicio DATETIME NOT NULL,
detFechaFin DATETIME NOT NULL,
detLibro VARCHAR(10) NOT NULL,
detCantidad INT NOT NULL,
detFechaDev DATETIME
FOREIGN KEY (detLibro) REFERENCES libros(libCodigo),
FOREIGN KEY (detPrestamo) REFERENCES prestamos(preCodigo)
)

