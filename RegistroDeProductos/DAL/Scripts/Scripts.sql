Create DATABASE ProductoDb
go
use ProductoDb
go

create table Producto
(
	ProductoId int primary key identity,
	Descripcion varchar(80),
	Existencia varchar(80),
	Costo varchar(80),
	ValorInventario varchar(80)
);

create table Consultas
(
	ValorInventario varchar(80),
);

create table Ubicacion
(
	ID int primary key identity,
	Descripcion varchar(80)
);