using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class PerfilPass : System.Web.UI.Page
    {
        void Page_PreInit(Object sender, EventArgs e)
        {
            if (Session["usertype"] != null)
            {
                switch (Session["usertype"])
                {
                    case "TU1":
                        this.MasterPageFile = "~/AdminHome.Master";
                        break;
                    case "TU2":
                        this.MasterPageFile = "~/Login.Master";
                        break;
                }

            }
            else
            {
                this.MasterPageFile = "~/Home.Master";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["er"] == "1")
                {
                    lblMensaje.Text = "LAS CONTRASEÑAS NO COINCIDEN!";
                }
            }
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            N_Usuario negu = new N_Usuario();
            DataTable dt = negu.getUsuarioPorUsername(this.Session["username"].ToString());
            string password = dt.Rows[0]["Contraseña_Usuario_U"].ToString();
            if (txtActual.Text == password)
            {
                if(txtNueva.Text == txtNueva2.Text)
                {
                    Usuario user = new Usuario();
                    TipoUsuario tu = new TipoUsuario();
                    Provincia pr = new Provincia();
                    Localidad lo = new Localidad();

                    user.setCodigoUsuario(dt.Rows[0]["Cod_Usuario_U"].ToString());
                    tu.setCodigoTipoUsuario(dt.Rows[0]["Cod_TipoUsuario_U"].ToString());
                    user.setIdTipoUsuario(tu);
                    user.setNombre(dt.Rows[0]["Nombre_Usuario_U"].ToString());
                    user.setApellido(dt.Rows[0]["Apellido_Usuario_U"].ToString());
                    user.setNickname(dt.Rows[0]["Nickname_Usuario_U"].ToString());
                    user.SetContraseña(txtNueva.Text);
                    user.setDni(dt.Rows[0]["DNI_Usuario_U"].ToString());
                    user.setFechaNacimiento(DateTime.Parse(dt.Rows[0]["fNacimiento_Usuario_U"].ToString()));
                    user.setTelefono(dt.Rows[0]["Telefono_Usuario_U"].ToString());
                    user.setEmail(dt.Rows[0]["EMail_Usuario_U"].ToString());
                    user.setDireccion(dt.Rows[0]["Direccion_Usuario_U"].ToString());
                    pr.setCodigoProvincia(dt.Rows[0]["Provincia_Usuario_U"].ToString());
                    user.setProvincia(pr);
                    lo.setCodigoLocalidad(dt.Rows[0]["Localidad_Usuario_U"].ToString());
                    user.setLocalidad(lo);
                    user.setEstado(Convert.ToBoolean(dt.Rows[0]["Estado_Usuario_U"].ToString()));

                    int filas = negu.ModificarUsuario(user);

                    if (filas > 0)
                    {
                        Response.Redirect("Perfil.aspx?us=3");
                    }
                }
                else
                {
                    Response.Redirect("PerfilPass.aspx?er=1");
                }
            }
            else
            {
                Response.Redirect("Perfil.aspx?us=2");
            }
        }
    }
}