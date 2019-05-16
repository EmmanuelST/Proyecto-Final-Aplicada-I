
create database ProyectoFinal_db
go
use ProyectoFinal_db
go
create table Usuarios
(
	UsuarioID int primary key,
	Nombre varchar(50) not null,
	Email varchar(80),
	NivelUsuario int not null,
	Usuario varchar(50),
	Clave varchar(50),
	FechaIngreso DateTIme
)

