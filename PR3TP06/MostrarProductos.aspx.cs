using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TP6_GRUPO7
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Productos_seleccionados"] != null)
            {
                grd_Productos_seleccionados.DataSource = Session["Productos_seleccionados"];
                grd_Productos_seleccionados.DataBind();
            }

        }

      
    }
}