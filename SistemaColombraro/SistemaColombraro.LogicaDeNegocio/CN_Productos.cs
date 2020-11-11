using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaColombraro.AccesoDatos;

namespace SistemaColombraro.LogicaDeNegocio
{
     public class CN_Productos
    {
        public CD_Productos objetoCD = new CD_Productos();
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod(string categoria, string nombre, string precio, string stock, string codigo)
        {
            objetoCD.Insertar(categoria, nombre, Convert.ToInt32(precio), Convert.ToInt32(stock), Convert.ToInt32(codigo));
        }

        public void EditarProd(string categoria, string nombre, string precio, string stock, string codigo, string articulo)
        {
            objetoCD.Editar(categoria, nombre, Convert.ToInt32(precio), Convert.ToInt32(stock), Convert.ToInt32(codigo), Convert.ToInt32(articulo));
        }
        public void EliminarPRod(string codigo)
        {
            objetoCD.Eliminar(Convert.ToInt32(codigo));
        }


    }
}
