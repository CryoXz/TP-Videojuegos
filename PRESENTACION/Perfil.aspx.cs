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
    public partial class Perfil : System.Web.UI.Page
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
                if (this.Session["username"] != null)
                {
                    N_Usuario negu = new N_Usuario();
                    DataTable dt = negu.getUsuarioPorUsername(this.Session["username"].ToString());

                    lblNombre.Text = dt.Rows[0]["Nombre_Usuario_U"].ToString();
                    lblApellido.Text = dt.Rows[0]["Apellido_Usuario_U"].ToString();
                    lblUsername.Text = dt.Rows[0]["Nickname_Usuario_U"].ToString();

                    string pass = new string('*', dt.Rows[0]["Contraseña_Usuario_U"].ToString().Length);
                    lblPassword.Text = pass;

                    lblEmail.Text = dt.Rows[0]["EMail_Usuario_U"].ToString();
                    lblDNI.Text = dt.Rows[0]["DNI_Usuario_U"].ToString();
                    lblFecha.Text = ((DateTime)dt.Rows[0]["fNacimiento_Usuario_U"]).ToString("dd/MM/yyyy");

                    N_Provincia negp = new N_Provincia();
                    string prov = negp.getStringProvincia(dt.Rows[0]["Provincia_Usuario_U"].ToString());
                    lblProvincia.Text = prov;

                    N_Localidad negl = new N_Localidad();
                    string loc = negl.getStringLocalidad(dt.Rows[0]["Localidad_Usuario_U"].ToString());
                    lblLocalidad.Text = loc;

                    lblDireccion.Text = dt.Rows[0]["Direccion_Usuario_U"].ToString();
                    lblTelefono.Text = dt.Rows[0]["Telefono_Usuario_U"].ToString();
                }

                switch (Request.QueryString["us"])
                {
                    case "1":
                        lblMensaje.Text = "SE HA MODIFICADO CON EXITO!";
                        break;
                    case "2":
                        lblMensaje.Text = "LA CONTRASEÑA INGRESADA NO ES CORRECTA!";
                        break;
                    case "3":
                        lblMensaje.Text = "SE HA ACTUALIZADO LA CONTRASEÑA CON EXITO!";
                        break;
                    default:
                        lblMensaje.Text = "HA OCURRIDO UN ERROR";
                        break;
                }
            }
            

        }
    }
}