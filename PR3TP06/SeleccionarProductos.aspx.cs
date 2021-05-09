using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace TP6_GRUPO7
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                Cargar_Tabla();
            }
            
        }

        protected void Cargar_Tabla()
        {
            GestionProductos gestion = new GestionProductos();
            grd_SelProductos.DataSource = gestion.ObtenerTodosLosProductos();
            grd_SelProductos.DataBind();
            

        }

        protected void grd_SelProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grd_SelProductos.PageIndex = e.NewPageIndex;
            Cargar_Tabla();
        }

        protected void grd_SelProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            string IdProd = ((Label)grd_SelProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProducto")).Text;
            string NombreProd= ((Label)grd_SelProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NombreProducto")).Text;
            string IdProv = ((Label)grd_SelProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_IdProveedor")).Text;
            string Precio = ((Label)grd_SelProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_Precio")).Text;

            lblProducto.Text = "Producto agregado: " + IdProd + " " + NombreProd + " " + IdProv + " " + Precio + " ";

            if (Session["Productos_seleccionados"] == null) Session["Productos_seleccionados"] = creartabla();
            else agregarfila((DataTable)Session["Productos_seleccionados"], IdProd, NombreProd, IdProv, Precio);
            
        }

        public DataTable creartabla()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("IdProd", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("NombreProd", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("IdProv", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("Precio", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);


            return dt;
        }

        public void agregarfila(DataTable dt, string IdProd, string NombreProd, string IdProv, string Precio)
        {

            if (!VerificarSiElProductoYaSeSelecciono(dt, IdProd))   // Si encuentra coincidencias con el id de producto no agrego a la tabla
                                                                    // de seleccion
            {
                DataRow dr = dt.NewRow();
                dr["IdProd"] = IdProd;
                dr["NombreProd"] = NombreProd;
                dr["IdProv"] = IdProv;
                dr["Precio"] = Precio;
                dt.Rows.Add(dr);
            }

        }

        protected bool VerificarSiElProductoYaSeSelecciono(DataTable tb, string IDProd)
        {
            foreach(DataRow dr in tb.Rows)
            {
                if (dr["IdProd"].ToString() == IDProd) return true;
            }

            return false;
        }

    }
}