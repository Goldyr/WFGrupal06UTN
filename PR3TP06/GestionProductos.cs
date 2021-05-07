using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de GestionProductos
/// </summary>

namespace TP6_GRUPO7
{
    public class GestionProductos
    {
        public GestionProductos()
        {
        }


        private DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }

        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "Select * from Productos");
        }

        /*

        public DataTable ObtenerTodosLosProductosConTemas()
        {
            return ObtenerTabla("Productos", "Select Productos.IdProductos As IdProductos, Productos.Autor As Autor , Productos.Titulo As Titulo, Productos.Precio As Precio ," +
                                    "Temas.IdTema as IdTema, Temas.Tema as Tema from Productos inner join Temas on Temas.IdTema = Productos.IdTema");
        }

         */

        private void ArmarParametrosProductosEliminar(ref SqlCommand Comando, Producto prod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = prod.ID;
        }

        private void ArmarParametrosProductos(ref SqlCommand Comando, Producto prod)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = prod.ID;
            SqlParametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar,40);
            SqlParametros.Value = prod.Nombre;
            SqlParametros = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 40);
            SqlParametros.Value = prod.CantidadUnidad;
            SqlParametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            SqlParametros.Value = prod.PrecioUnidad;   
        }


        public bool ActualizarProductos(Producto prod)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosProductos(ref Comando, prod);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarProducto");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
       


        public bool EliminarProductos(Producto prod)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosProductosEliminar(ref Comando, prod);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarProducto");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}