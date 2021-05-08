using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO7
{
    public partial class EJ02_Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lbtEliminar_Click(object sender, EventArgs e)
        {
            Session["Productos_seleccionados"] = null;
        }
    }
}