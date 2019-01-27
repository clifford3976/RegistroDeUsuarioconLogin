create database Registros
go
use Registros
go
create table Usuarios
(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(30),
	NombreUsuario varchar (max),
	Clave varchar (15),
	fecha datetime,
	Email varchar (30),
	Telefono varchar (30),
	Celular varchar (30)
	

);
go

SELECT * FROM Usuarios
set dateformat dmy;

insert into Usuarios values('Clifford Jeffrey Millien','JAY','123456')
