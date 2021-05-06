using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PR3TP06
{
    public class Producto
    {

        int ID_i;
        string Nombre_s;
        int IDProveedor_i;
        int CantidadUnidad_i;
        int PrecioUnidad_i;

        public Producto()
        {
        }

        public Producto(int id, string nombre, int idproveedor, int cantidadunidad, int preciounidad)
        {
            this.ID_i = id;
            this.Nombre_s = nombre;
            this.IDProveedor_i = idproveedor;
            this.CantidadUnidad_i = cantidadunidad;
            this.PrecioUnidad_i = preciounidad;
        }

        public int ID
        {
            set { ID_i = value; }
            get { return ID_i; }
        }
        public string Nombre
        {
            set { Nombre_s = value; }
            get { return Nombre_s; }
        }
        public int IDProveedor
        {
            set { IDProveedor_i = value; }
            get { return IDProveedor_i; }
        }
        public int CantidadUnidad
        {
            set { CantidadUnidad_i = value; }
            get { return CantidadUnidad_i; }
        }
        public int PrecioUnidad
        {
            set { PrecioUnidad_i = value; }
            get { return PrecioUnidad_i; }
        }
    }
}