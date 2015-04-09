Create Table Articulos(
IdArticulo int identity(1,1) primary key,
Descripcion varchar(50),
Tipo varchar,
Existencia int,
Costo float, 
Precio float
)
go

Create Table Clientes(
IdCliente int identity(1,1) primary key,
Nombres varchar(50),
Telefono varchar(50),
Celular varchar(50),
Direccion varchar(50),
Email varchar(50),
)
go

Create Table Compras(
IdCompra int identity(1,1) primary key,
Fecha Datetime,
IdUsuario int,
IdSuplidor int, 
Monto float
)
go

Create Table ComprasDetalle(
IdCompraDetalle int identity(1,1) primary key,
IdCompra int, 
IdArticulo int,
Cantidad int,
Costo float
) 
go

Create Table Diagnosticos(
IdDiagnostico int identity(1,1) primary key,
Descripcion varchar
)
go
 
Create Table Entregas(
IdEntrega int identity(1,1) primary key,
Fecha Datetime, 
IdRecepcion int, 
IdUsuario int,
Observaciones varchar,
Monto float,
Descuento int
)
go

Create Table Estados(
IdEstado int identity(1,1) primary key,
Descripcion varchar
)
go

Create Table PagoTecnico(
IdPagoTecnico int identity(1,1) primary key,
Fecha Datetime,
IdTecnico int,
IdUsuario int,
FechaCorte Datetime,
Monto float
)
go

Create Table PagoTecnicosDetalle(
IdPagoTecnico int identity(1,1) primary key,
IdPago int,
IdTrabajo int
)
go

Create Table Recepciones(
IdRecepciones int identity(1,1) primary key,
Fecha Datetime,
IdCliente int,
IdEquipo int,
IdDiagnostico int, 
IdEstado int,
IdUsuario int,
Serial int,
Observaciones varchar
)
go

Create Table Suplidor(
IdSuplidor int identity(1,1) primary key,
Nombres varchar
)
go

Create Table Tecnicos(
IdTecnicos int identity(1,1) primary key,
Nombres varchar,
Direccion varchar, 
Telefono int, 
Email varchar,
PctComision float
)
go

Create Table TiposEquipos(
IdEquipo int identity(1,1) primary key,
Descripcion varchar
)
go

Create Table TrabajoRecepciones(
IdTrabajoRecepciones int identity(1,1) primary key,
IdRecepcion int,
IdArticulo int,
IdTecnico int,
IdUsuario int,
Precio float,
Costo float,
esPago bit
)
go

Create Table Usuarios(
IdUsuario int identity(1,1) primary key,
Nombre varchar
)
