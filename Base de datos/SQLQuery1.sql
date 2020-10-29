CREATE DATABASE Colombraro;

ALTER TABLE Producto (
articulo int identity (1,1) primary key
categoria varchar (50) NOT NULL,
nombre varchar (50) NOT NULL,
precio int NOT NULL,
stock int NOT NULL,
);

INSERT INTO Producto
VALUES ('Hogar','Mesa Orlando','12000','20'
),
('Hogar','Silla Orlando','2000','4'
),
('Exterior','Reposera Miami','6000','20'
),
('Exterior','Conservadora','7000','5'
),
('Baño','Jabonera','600','10'
)


---PROCEDIMIENTOS ALMACENADOS 
--------------------------MOSTRAR
select * from Producto;

create proc MostrarProductos
as 
select * from Producto
go

exec MostrarProductos

create proc InsetarProductos
@categoria nvarchar (100),
@nombre nvarchar (100),
@precio int,
@stock int,
@codigo int
as
insert into Producto values (@categoria,@nombre,@precio,@stock,@codigo) go
exec InsetarProductos

truncate table Producto;