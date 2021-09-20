--Crud PAGOS
--Insertar
use SIDAC;
go
create proc sp_InsertarPago
	@montoBase smallmoney,
	@montoCancelado smallmoney,
	@descripcion varchar(255),
	@fecha date,
	@FK_estado int,
	@FK_consumidor int
as
begin
	set nocount on;
	declare @mes varchar(20);
	--obteniendo el mes en español dada una fecha
	set language Spanish;
	set @mes=DATENAME(MONTH, @fecha);
	insert into Pagos values(@mes, @montoBase,@montoCancelado,@montoBase-@montoCancelado,
							@descripcion, @fecha,@FK_estado,@FK_consumidor);
end
go

--Actualizar
go
create proc sp_ActualizarPago
	@id int,
	@montoCancelado smallmoney,
	@descripcion varchar(255),
	@FK_estado int
as
begin
	set nocount on;
	update Pagos set montoCancelado = @montoCancelado, montoPendiente=montoBase-@montoCancelado,
										descripcion=@descripcion, FK_estado=@FK_estado
										where Pagos.idPago = @id;
end
go

--Mostrar
go
create proc sp_MostrarPagos
as
select a.idPago 'Código', (c.nombres+' '+c.apellidos)Nombre,a.mes 'Mes',a.montoBase 'Monto base',
	a.montoCancelado 'Cancelado', a.montoPendiente 'Pendiente', a.descripcion'Descripción',
	b.nombre'Estado', a.fecha'Fecha'
from Pagos a
	inner join Estados b on a.FK_estado = b.idEstado
	inner join Consumidores c on a.FK_consumidor = c.idConsumidor
go
go
create proc sp_MostrarPagosDefault
as
select a.idPago 'Código', (c.nombres+' '+c.apellidos)Nombre,a.mes 'Mes',a.montoBase 'Monto base',
	a.montoCancelado 'Cancelado', a.montoPendiente 'Pendiente', a.descripcion'Descripción',
	b.nombre'Estado', a.fecha'Fecha'
from Pagos a
	inner join Estados b on a.FK_estado = b.idEstado
	inner join Consumidores c on a.FK_consumidor = c.idConsumidor

	where b.nombre = 'Pendiente';
go

--Eliminar
go
create proc sp_EliminarPago
	@id int
as
	set nocount on;
	delete from Pagos where idPago=@id;
go

--CRUD Consumidor
--mostrar
go
create proc sp_MostrarConsumidores
as
	set nocount on;
	select a.idConsumidor'Código',a.nombres'Nombre',a.apellidos'Apellido',
			a.telefono'Teléfono', a.correo'Correo Electrónico', a.estado'Estado'
	from Consumidores a

go
go
create proc sp_MostrarConsumidoresDefault
as
	set nocount on;
	select a.idConsumidor'Código',a.nombres'Nombre',a.apellidos'Apellido',
			a.telefono'Teléfono', a.correo'Correo Electrónico', a.estado'Estado'
	from Consumidores a
	where a.estado= 1;
go

--Insertar
go
create proc sp_InsertarConsumidor
	@id int,
	@nombre varchar(50),
	@apellido varchar(50),
	@telefono varchar(20),
	@correo varchar(30),
	@estado int
as
	set nocount on;
	insert into Consumidores values (@id,@nombre,@apellido,@telefono,@correo,@estado);
go
go
create proc sp_ActualizarConsumidor
	@id int,
	@nombre varchar(50),
	@apellido varchar(50),
	@telefono varchar(20),
	@correo varchar(30),
	@estado int
as
	set nocount on;
	update Consumidores set nombres= @nombre,apellidos= @apellido,telefono= @telefono,
		   correo=@correo,estado= @estado
		   where Consumidores.idConsumidor=@id;
go

--Eliminar
go
create proc sp_EliminarConsumidor
	@id int
as
	set nocount on;
	delete from Consumidores where Consumidores.idConsumidor=@id;
go

--CRUD Admin
--mostrar
go
create proc sp_MostrarAdministradores
as
	set nocount on;
	select (a.nombres+' '+a.apellidos)'Nombre', a.telefono'Teléfono' 
	from Administradores a
go
create proc sp_MostrarAdministradoresDefault
as
	set nocount on;
	select a.nombres'Nombres',a.apellidos'Apellidos', a.telefono'Teléfono' 
	from Administradores a
go

--Insertar
go
create proc sp_InsertarAdministrador
	@nombres varchar(50),
	@apellidos varchar(50),
	@telefono varchar(20)
as
	set nocount on;
	insert into Administradores values (@nombres, @apellidos, @telefono);
go
go
create proc sp_ActualizarAdministrador
	@id int,
	@nombres varchar(50),
	@apellidos varchar(50),
	@telefono varchar(20)
as
	set nocount on;
	update Administradores set nombres= @nombres,apellidos= @apellidos,telefono= @telefono
	where Administradores.idAdmin = @id;
go

--Eliminar
go
create proc sp_EliminarAdministrador
	@id int
as
	set nocount on;
	delete from Administradores where Administradores.idAdmin=@id;
go

--CRUD compras
--Mostrar
go
create proc sp_MostrarCompras
as
	Select a.idCompra,a.proveedor,a.valor,Cast(a.fecha as date)fecha,(b.nombres+' '+b.apellidos)Comprador from Compras  a
		inner join Administradores b on a.FK_admnin=b.idAdmin
go
exec sp_MostrarCompras
--Insertar
go
create proc sp_InsertarCompra
	@id int,
	@proveedor varchar(50),
	@fecha date,
	@valor smallmoney,
	@foto image,
	@FK_Admin int
as
	set nocount on;
	insert into Compras values(@id,@proveedor,@fecha,@valor,@foto,@FK_Admin);
go

--Actualizar
go
create proc sp_ActualizarCompra
	@id int,
	@proveedor varchar(50),
	@fecha date,
	@valor smallmoney,
	@foto image
as
	set nocount on;
	update Compras set proveedor= @proveedor,fecha=@fecha,valor= @valor,foto= @foto
					where Compras.idCompra=@id;
go

--Eliminar
go
create proc sp_EliminarCompra
@id int
as
	set nocount on;
	delete from Compras where Compras.idCompra=@id;
go

--CRUD
--detalles compras
--mostrar
go
create proc sp_MostrarInventarios
as
select * from Inventarios
go

--Insertar
go
create proc sp_InsertarItemInventario
	@cantidad int,
	@descripcion varchar(80),
	@precioUnitario smallmoney,
	@total smallmoney,
	@estado  int,
	@FK_compra int
as
	set nocount on;
	insert into Inventarios values(@cantidad,@descripcion,@precioUnitario,@total,@estado,@FK_compra);
go
exec sp_InsertarItemInventario 10,'camisa lisa 1 1/4',0.50,5,1,2;

--Actualizar
go
Create proc sp_ActualizarInventarios
	@id int,
	@cantidad int,
	@descripcion varchar(80),
	@precioUnitario smallmoney,
	@total smallmoney,
	@estado  int,
	@FK_compra int
as
	set nocount on;
	update Inventarios
	set 
	cantidad= @cantidad,
	descripcion= @descripcion,
	precioUnitario= @precioUnitario,
	total= @total,
	estado = @estado,
	FK_compra= @FK_compra
	where Inventarios.idInventario=@id;
go

--Eliminar 
go
create proc sp_EliminarInventario
	@id int
as
	set nocount on;
	delete from Inventarios where idInventario=@id;
go
