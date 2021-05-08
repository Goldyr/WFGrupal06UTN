using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO7
{
    public partial class EJ01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla();              
            }
        }

        protected void CargarTabla()
        {
            GestionProductos gProductos = new GestionProductos();
            grd_Productos.DataSource = gProductos.ObtenerTodosLosProductos();
            grd_Productos.DataBind();
        }
       
        protected void grd_Productos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
            string lbl_id = ((Label) grd_Productos.Rows[e.NewSelectedIndex].FindControl("lbl_it_prod")).Text;
            string lbl_NomProd = ((Label)grd_Productos.Rows[e.NewSelectedIndex].FindControl("lbl_it_NomProd")).Text;
            string lbl_cant = ((Label)grd_Productos.Rows[e.NewSelectedIndex].FindControl("lbl_it_cant")).Text;
            string lbl_preUni = ((Label)grd_Productos.Rows[e.NewSelectedIndex].FindControl("lbl_it_PreUni")).Text;
        }

        protected void grd_Productos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grd_Productos.PageIndex = e.NewPageIndex;
            CargarTabla();
        }

        protected void grd_Productos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string lbl_id = ((Label)grd_Productos.Rows[e.RowIndex].FindControl("lbl_it_prod")).Text;

            Producto prod = new Producto();
            prod.ID = Convert.ToInt32(lbl_id);

            GestionProductos gProductos = new GestionProductos();
            gProductos.EliminarProductos(prod);

            CargarTabla();
        }

        protected void grd_Productos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grd_Productos.EditIndex = e.NewEditIndex;
            CargarTabla();
        }

        protected void grd_Productos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Busco los datos del edit template

            string lbl_id = ((Label)grd_Productos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            string lbl_NomProd = ((TextBox)grd_Productos.Rows[e.RowIndex].FindControl("tb_eit_NombreProducto")).Text;
            string lbl_cant = ((TextBox)grd_Productos.Rows[e.RowIndex].FindControl("tb_eit_CantidadxUnidad")).Text;
            string lbl_preUni = ((TextBox)grd_Productos.Rows[e.RowIndex].FindControl("tb_eit_PrecioUnitario")).Text;

            Producto prod = new Producto();
            prod.ID = Convert.ToInt32(lbl_id);
            prod.Nombre = lbl_NomProd;
            prod.CantidadUnidad = lbl_cant;
            prod.PrecioUnidad = Convert.ToDecimal(lbl_preUni);

            GestionProductos gProductos = new GestionProductos();
            gProductos.ActualizarProductos(prod);

            grd_Productos.EditIndex = -1;
            CargarTabla();

        }

        protected void grd_Productos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grd_Productos.EditIndex = -1;
            CargarTabla();
        }
    }
}