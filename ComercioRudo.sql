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



-----------------------------------------------------------
insert into Marcas (Nombre, Activa)
values ('Armani', 1)
-----------------------------------------------------------
insert into Categorias(Nombre, Activa)
values ('Armani', 1)
-----------------------------------------------------------



create procedure  spListarMarcas as
 
 select IdMarca, Nombre, Activa from Marcas

 exec spListarMarcas

 -------------------------------------------


 create procedure spListarCategoria as

 select IdCategoria, Nombre, Activa from Categorias 
 
 exec spListarCategoria

 --------------------------------------------------


 create procedure spListarProductos as
 select IdProducto, Nombre, IdCategoria, IdMarca, Activa from Productos

 exec spListarProductos

 insert into Productos (Nombre, Activa, IdCategoria, IdMarca)
values ('Armani', 1, 1, 1)
 --------------------------------------------------
 create procedure spListarClientes as
 select IdCliente, Nombre, Apellido, DNI from Clientes

 exec spListarClientes
 ---------------------------------------------------

 create procedure spListarVendedores as
 select IdVendedor, Nombre, Apellido, IdUsuario from Vendedor

 exec spListarVendedores

 -----------------------------------------------------------

 create procedure spListarUsuarios as
 select Id, Usuario, Contraseña ,TipoUsuario from Usuarios
 
 exec spListarUsuarios

 ----------------------------------------------------------

 create procedure spListarAdministradores as
 select IdAdministrador, Nombre, Apellido, IdUsuario from Administrador

 exec spListarAdministradores

 ----------------------------------------------------------

