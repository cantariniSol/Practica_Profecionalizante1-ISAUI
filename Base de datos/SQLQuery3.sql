USE [Colombraro]
GO
/****** Object:  StoredProcedure [dbo].[MostrarProductos]    Script Date: 28/10/2020 21:10:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[MostrarProductos]
as 
select articulo, codigo, nombre, categoria, precio, stock from Producto
