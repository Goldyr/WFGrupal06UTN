using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6_GRUPO7
{
    public class Producto
    {

        int ID_i;
        string Nombre_s;
        string CantidadUnidad_i;
        decimal PrecioUnidad_i;

        public Producto()
        {
        }

        public Producto(int id, string nombre, string cantidadunidad, decimal preciounidad)
        {
            this.ID_i = id;
            this.Nombre_s = nombre;
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
        public string CantidadUnidad
        {
            set { CantidadUnidad_i = value; }
            get { return CantidadUnidad_i; }
        }
        public decimal PrecioUnidad
        {
            set { PrecioUnidad_i = value; }
            get { return PrecioUnidad_i; }
        }
    }
}