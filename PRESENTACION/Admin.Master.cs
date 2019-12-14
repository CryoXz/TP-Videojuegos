using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUsuarios.aspx");
        }

        protected void btnVentas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminVentas.aspx");
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AminProductos.aspx");
        }

        protected void btnPedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminCompras.aspx");
        }

        protected void btnPlatafomas_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPlataformas.aspx");
        }
    }
}