using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;


namespace PRESENTACION
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblIncorrecto.Visible = false;
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {

            N_Usuario N_usuario = new N_Usuario();

            N_usuario.GuardarUsuario("TU2", txtNombre.Text, txtApellido.Text, txtUsername.Text, txtContraseña.Text, txtDni.Text, txtMail.Text, txtTelefono.Text, txtDireccion.Text);

            Response.Redirect("Home.aspx");
        }
    }
}
