using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class Login : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Session["usertype"])
            {
                case "TU1":
                    btnPerfil.Text = "ADMINISTRACIÓN";
                    break;
                case "TU2":
                    btnPerfil.Text = "PERFIL";
                    break;
                default:
                    btnPerfil.Text = "PERFIL";
                    break;
            }
        }

        public void btnLogout_click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBusqueda.Text.Trim()))
            {
                Response.Redirect("ProductosJuegosO.aspx?s=" + txtBusqueda.Text);
            }
        }

        protected void btnPerfil_Click(object sender, EventArgs e)
        {
            switch (Session["usertype"])
            {
                case "TU1":
                    Response.Redirect("AdminVentas.aspx");
                    break;
                case "TU2":
                    Response.Redirect("Perfil.aspx");
                    break;
                default:
                    Response.Redirect("Perfil.aspx");
                    break;
            }
        }
    }
}