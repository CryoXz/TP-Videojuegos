using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using NEGOCIO;
using ENTIDAD;

namespace PRESENTACION
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIncorrecto.Visible = false;
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            int count;
            string userType;
            N_Usuario usuario = new N_Usuario();
            count = usuario.resultadoUsuarios(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());

            if (count == 1)
            {
                Session["username"] = txtUsuario.Text.Trim();
                userType = usuario.getUserType(txtUsuario.Text.Trim());

                if (userType.Trim() == "TU1")
                {
                    Session["usertype"] = userType.Trim();
                    Response.Redirect("AdminMarca.aspx");
                }
                else if (userType.Trim() == "TU2")
                {
                    Session["usertype"] = userType.Trim();
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }
            else
            {
                lblIncorrecto.Visible = true;
            }

            if (chkRecordar.Checked)
            {
                Response.Cookies["username"].Value = txtUsuario.Text.Trim();
                Response.Cookies["username"].Expires = DateTime.Today.AddDays(1);
            }
        }
    }
}