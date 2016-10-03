

Create database DnPol
go

use DnPol
go

--------- Tablas modulo administrador-agente.
create table Roles(IdRol int identity primary key, Nombre Varchar(50))

create table Usuarios(IdUsuario int identity primary key, Usuario Varchar(50) unique not null, Password varchar(50), 
                      IdRol int references Roles(IdRol))

create table Agentes(IdAgente int identity primary key, Nombres Varchar(150), Apellidos Varchar(150), Placa Varchar(15),
                     Direecion Varchar(100), Telefono Varchar(30))

