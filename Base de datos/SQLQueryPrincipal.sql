USE [Colombraro]
GO
/****** Object:  StoredProcedure [dbo].[MostrarProductos]    Script Date: 28/10/2020 21:14:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[MostrarProductos]
as 
select articulo, codigo, nombre, categoria, precio, stock  from Producto

create proc InsetarProducto
@codigo int,
@nombre nvarchar (100),
@categoria nvarchar (100),
@precio int,
@stock int
as
insert into Producto values (@categoria,@nombre,@precio,@stock,@codigo)
go

exec InsetarProducto  1323, 'colo', 'rrrr', 5, 1;
exec MostrarProductos



--PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR
create proc MostrarProductos
as 
select * from Producto
go

 


-------- EDITAR

create proc EditarProductos
@codigo int,
@nombre nvarchar (100),
@categoria nvarchar (100),
@precio int,
@stock int,
@articulo int
as
update Producto set codigo=@codigo,nombre=@nombre,categoria=@categoria,precio=@precio,stock=@stock  where articulo=@articulo
go
exec EditarProductos 113, 'colo', 'rrrr', 5, 3,1;
exec MostrarProductos

------ELIMINAR
create proc EliminarProductos
@codigo int
as
delete from Producto where codigo=@codigo
go

exec EditarProductos 113, 'colo', 'rrrr', 5, 3,1;
exec MostrarProductos
exec EliminarProductos 112;