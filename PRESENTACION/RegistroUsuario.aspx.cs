using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IniciarLlenadoDropdownList();
            }
        }

        private void IniciarLlenadoDropdownList()
        {
            //carga dropdownlist con los tipos de usuarios
            N_TipoUsuario n_Tipo = new N_TipoUsuario();
            ddlTipoUsuario.DataSource = n_Tipo.getTipoUsuario();
            ddlTipoUsuario.DataTextField = "Nombre_TipoUsuario_TU";
            ddlTipoUsuario.DataValueField = "Cod_TipoUsuario_TU";
            ddlTipoUsuario.DataBind();
            ddlTipoUsuario.Items.Insert(0, new ListItem("[seleccionar]", "0"));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            N_Usuario N_usuario = new N_Usuario();
            //  DateTime fechaNacimiento = new DateTime();
            //  fechaNacimiento = DateTime.Parse(txtfNacimiento_Usuario.ToString());

            // se pasa por parametro los el selectdValue de dropdown.tostring, y los demas textbox en .text
            N_usuario.GuardarUsuario(ddlTipoUsuario.SelectedValue.ToString(), txtNombre_Usuario.Text, txtApellido_Usuario.Text, txtNickname_Usuario.Text, txtContraseña_usuario.Text, txtDni_Usuario.Text, /*fechaNacimiento,*/ txtEmail_Usuario.Text, txtTelefono_Usuario.Text, txtDireccion_Usuario.Text);
            
        }
    }
}