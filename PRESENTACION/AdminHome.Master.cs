using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class AdminHome : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnLogout_click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }
        public void btnAdmin_click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUsuarios.aspx");
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBusqueda.Text.Trim()))
            {
                Response.Redirect("ProductosJuegosO.aspx?s=" + txtBusqueda.Text);
            }
        }
    }
}