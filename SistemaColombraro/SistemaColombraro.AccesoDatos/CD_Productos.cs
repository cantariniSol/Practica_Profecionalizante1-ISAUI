using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace SistemaColombraro.AccesoDatos
{
    public class CD_Productos
    {   
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            //Mostrar datos SQL server en la data grid view
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        

        }
        // Insertar datos en SQL Server
        public void Insertar(string categoria, string nombre, int precio, int stock, int codigo)
        {
            //sql server 
            //comando.Connection = conexion.AbrirConexion();
            // comando.CommandText = "insert into Producto values ('"+categoria+ "','" + nombre+"',"+precio+ "," + stock + ", " + codigo+ " )";
            //  comando.CommandType = CommandType.Text;
            // comando.ExecuteNonQuery();

            //Con funciones.
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo",codigo );
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();
        }
        public void Editar(string categoria, string nombre, int precio, int stock, int codigo, int articulo)
        {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarProductos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@precio", precio);
                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@stock", stock);
                comando.Parameters.AddWithValue("@articulo", articulo);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();

            }

        }

}
