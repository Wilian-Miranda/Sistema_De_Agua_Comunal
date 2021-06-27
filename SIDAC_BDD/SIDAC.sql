use master;
go
Drop database if exists SIDAC;
go
go
create database SIDAC;
go

go
use SIDAC;
go

go
--entidades fuertes
create table Estados(
	idEstado int not null primary key identity,
	nombre varchar(20) not null

);
go
go
--entidades debiles
create table Consumidores(
	idConsumidor int not null primary key,
	nombres varchar(50) not null,
	apellidos varchar(50) not null,
	telefono varchar(20),
	correo varchar(30),
	estado int not null
);

create table Pagos(
	idPago int not null primary key identity,
	mes varchar(20) not null,
	montoBase smallmoney not null,
	montoCancelado smallmoney not null,
	montoPendiente smallmoney not null,
	descripcion varchar(255) null,
	fecha date not null,
	FK_estado int not null foreign key references  Estados(idEstado),
	FK_consumidor int not null foreign key references  Consumidores(idConsumidor)

);

go

go
--entidades fuertes 
create table Administradores(
	idAdmin int not null primary key identity,
	nombres varchar(50) not null,
	apellidos varchar(50) not null,
	telefono varchar(20)
);
go
go
--entidades debiles
create table Compras(
	idCompra int not null primary key,
	proveedor varchar(50) not null,
	fecha date not null,
	valor smallmoney not null,
	foto image,
	FK_admnin int not null foreign key references Administradores(idAdmin)
);

create table Inventarios(
	idInventario int not null primary key identity(1,1),
	cantidad int not null,
	descripcion varchar(80) not null,
	precioUnitario smallmoney not null,
	total smallmoney not null,
	estado int not null,
	FK_compra int not null foreign key references Compras(idCompra)
);
