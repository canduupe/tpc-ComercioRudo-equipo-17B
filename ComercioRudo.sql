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
insert into Usuarios (Usuario, Contraseña, TipoUsuario)
values ('Joa', 'Quin', 1)
------------------------------------------------------


-- PROCEDURES LISTADO
-----------------------------------------------------
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

 insert into Clientes (Nombre, Apellido, DNI)
 values ('Ski','Bidi', '111111')
 ---------------------------------------------------

 create procedure spListarVendedores as
 select IdVendedor, Nombre, Apellido, IdUsuario from Vendedor

 exec spListarVendedores

 insert into Vendedor (Nombre, Apellido, IdUsuario)
 values ('Candela','Peña', 2)
 -----------------------------------------------------------

 create procedure spListarUsuarios as
 select Id, Usuario, Contraseña ,TipoUsuario from Usuarios
 
 exec spListarUsuarios

 
 ----------------------------------------------------------

 create procedure spListarAdministradores as
 select IdAdministrador, Nombre, Apellido, IdUsuario from Administrador

 exec spListarAdministradores

 insert into Administrador (Nombre, Apellido, IdUsuario)
 values ('Joaquin','Lopez', 1)
 ----------------------------------------------------------

 

 --PROCEDURES AGREGADO
 -------------------------------------------------------------
 create procedure spAgregarCli 
 @Nombre varchar (50),
 @Apellido varchar(50),
 @DNI varchar (8)
 as
 insert into Clientes values(@Nombre,@Apellido,@DNI)
 -------------------------------------------------------------
  create procedure spAgregarMarca
 @Nombre varchar (50)
 as
 insert into Marcas values(@Nombre,1)
 -------------------------------------------------------------
 create procedure spAgregarCate
 @Nombre varchar (50)
 as
 insert into Categorias values(@Nombre,1)













