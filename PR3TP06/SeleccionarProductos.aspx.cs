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
        }
    }
}