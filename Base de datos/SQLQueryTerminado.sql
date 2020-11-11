CREATE DATABASE Colombraro;

CREATE TABLE Productos (
articulo int identity (1,1) primary key,
codigo int not null,
categoria varchar (50) NOT NULL,
nombre varchar (50) NOT NULL,
precio int NOT NULL,
stock int NOT NULL,
);

INSERT INTO Productos
VALUES ('123','Hogar','Mesa Orlando','12000','20'
),
('145', 'Hogar','Silla Orlando','2000','4'
),
('456', 'Exterior','Reposera Miami','6000','20'
),
('705','Exterior','Conservadora','7000', '5'
),
('456', 'Baño','Jabonera','600','10' 
);


---PROCEDIMIENTOS ALMACENADOS 


---------------------------------MOSTRAR
select * from Productos;

create proc MostrarProductos1
as 
select * from Productos
go

exec MostrarProductos1;

----------------------------------INSERTAR
create proc InsetarProducto
@codigo int,
@categoria nvarchar (100),
@nombre nvarchar (100),
@precio int,
@stock int

as
insert into Productos values (@codigo,@categoria,@nombre,@precio,@stock) 
go
exec InsetarProducto  12,'Hogar', 'Mesita', 567, 6
exec MostrarProductos1


-------------------------------------- EDITAR

create proc EditarProducto
@codigo int,
@categoria nvarchar (100),
@nombre nvarchar (100),
@precio int,
@stock int,
@articulo int
as
update Productos set codigo=@codigo,categoria=@categoria,nombre=@nombre,precio=@precio,stock=@stock  where articulo=@articulo
go
exec EditarProducto 113, 'colo', 'rrrr', 5, 3,1;
exec MostrarProductos1

----------------------------------------ELIMINAR
create proc EliminarProducto
@codigo int
as
delete from Productos where codigo=@codigo
go

exec EditarProducto 113, 'colo', 'rrrr', 5, 3,1;
exec MostrarProductos1
exec EliminarProducto 112;
