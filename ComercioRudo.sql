create database comercio_rudo
go
use comercio_rudo

--TABLAS

create table Usuarios(
Id int primary key identity (1,1),
Usuario varchar(20) not null,
Contraseña varchar(20) not null,
TipoUsuario int not null
)

create table Administrador(
IdAdministrador int primary key identity (1,1),
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
IdUsuario int foreign key  references Usuarios(Id),
)

Create table Vendedor(
IdVendedor int Primary key identity(1,1),
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
IdUsuario int foreign key references Usuarios(Id)
)

Create table Clientes(
IdCliente int Primary key identity(1,1),
Nombre varchar(50) not null, 
Apellido varchar(50) not null,
DNI varchar(8) not null unique
)



Create table Marcas(
IdMarca int primary key identity (1,1),
Nombre varchar(50) not null,
Activa int not null
)

Create table Categorias(
IdCategoria int primary key identity (1,1),
Nombre varchar(50) not null,
Activa int not null
)

Create table Productos(
IdProducto int primary key identity (1,1),
Nombre varchar(50) not null,
IdMarca int foreign key references Marcas(IdMarca),
IdCategoria int foreign key references Categorias(IdCategoria),
Activa int not null
)
