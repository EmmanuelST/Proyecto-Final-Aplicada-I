
create database ProyectoFinal_db
go
use ProyectoFinal_db
go
create table Usuarios
(
	UsuarioID int primary key identity,
	Nombre varchar(80) not null,
	Email varchar(80),
	NivelUsuario int not null,
	Usuario varchar(50),
	Clave varchar(50),
	FechaIngreso DateTIme
)

