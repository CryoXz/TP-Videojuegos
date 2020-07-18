using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;


namespace PRESENTACION
{
    public partial class PerfilEditar : System.Web.UI.Page
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

                    txtNombre.Text = dt.Rows[0]["Nombre_Usuario_U"].ToString();
                    txtApellido.Text = dt.Rows[0]["Apellido_Usuario_U"].ToString();
                    txtUsername.Text = dt.Rows[0]["Nickname_Usuario_U"].ToString();
                    txtEmail.Text = dt.Rows[0]["EMail_Usuario_U"].ToString();
                    txtDNI.Text = dt.Rows[0]["DNI_Usuario_U"].ToString();
                    DateTime date = DateTime.Parse(dt.Rows[0]["fNacimiento_Usuario_U"].ToString());
                    txtFecha.Text = date.ToString("dd/MM/yyyy");

                    N_Provincia negp = new N_Provincia();
                    DataTable dtP = negp.getTabla();
                    ddlProvincia.DataSource = dtP;
                    ddlProvincia.SelectedValue = dt.Rows[0]["Provincia_Usuario_U"].ToString();
                    ddlProvincia.DataTextField = "Nombre_prov";
                    ddlProvincia.DataValueField = "Cod_Provincia_prov";
                    ddlProvincia.DataBind();

                    N_Localidad negl = new N_Localidad();
                    DataTable dtL = negl.getTablaPorID(ddlProvincia.SelectedValue.ToString());
                    ddlLocalidad.DataSource = dtL;
                    ddlLocalidad.SelectedValue = dt.Rows[0]["Localidad_Usuario_U"].ToString();
                    ddlLocalidad.DataTextField = "Nombre_loc";
                    ddlLocalidad.DataValueField = "Cod_Localidad_loc";
                    ddlLocalidad.DataBind();
                    txtDireccion.Text = dt.Rows[0]["Direccion_Usuario_U"].ToString();
                    txtTelefono.Text = dt.Rows[0]["Telefono_Usuario_U"].ToString();
                }

            }  

        }

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            N_Localidad negl = new N_Localidad();
            DataTable dtL = negl.getTablaPorID(ddlProvincia.SelectedValue.ToString());
            ddlLocalidad.DataSource = dtL;
            ddlLocalidad.DataTextField = "Nombre_loc";
            ddlLocalidad.DataValueField = "Cod_Localidad_loc";
            ddlLocalidad.DataBind();
        }

        private bool isvalidEmail(string address)
        {
            EmailAddressAttribute e = new EmailAddressAttribute();
            if (e.IsValid(address))
                return true;
            else
                return false;
        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            N_Usuario negu = new N_Usuario();
            DataTable dt = negu.getUsuarioPorUsername(this.Session["username"].ToString());
            Usuario user = new Usuario();
            TipoUsuario tu = new TipoUsuario();
            Provincia pr = new Provincia();
            Localidad lo = new Localidad();

            user.setCodigoUsuario(dt.Rows[0]["Cod_Usuario_U"].ToString());
            tu.setCodigoTipoUsuario(dt.Rows[0]["Cod_TipoUsuario_U"].ToString());
            user.setIdTipoUsuario(tu);
            user.setNombre(txtNombre.Text);
            user.setApellido(txtApellido.Text);
            user.setNickname(txtUsername.Text);
            user.SetContraseña(dt.Rows[0]["Contraseña_Usuario_U"].ToString());
            user.setDni(txtDNI.Text);
            if(txtFecha.Text != "")
            {
                user.setFechaNacimiento(DateTime.Parse(txtFecha.Text));
            }
            user.setTelefono(txtTelefono.Text);
            user.setEmail(txtEmail.Text);
            user.setDireccion(txtDireccion.Text);
            pr.setCodigoProvincia(ddlProvincia.SelectedValue);
            user.setProvincia(pr);
            lo.setCodigoLocalidad(ddlLocalidad.SelectedValue);
            user.setLocalidad(lo);
            user.setEstado(Convert.ToBoolean(dt.Rows[0]["Estado_Usuario_U"].ToString()));

            bool mail = isvalidEmail(txtEmail.Text);
            bool fecha = true;
            if(txtFecha.Text == "" || DateTime.Compare(DateTime.Parse(txtFecha.Text), DateTime.Now) > 0)
            {
                fecha = false;
            }

            if(fecha && mail)
            {
                int filas = negu.ModificarUsuario(user);
                if (filas > 0)
                {
                    Response.Redirect("Perfil.aspx?us=1");
                }
                else
                {
                    Response.Redirect("Perfil.aspx?us=5");
                }
            }
            else if(fecha && !mail)
            {
                Response.Redirect("Perfil.aspx?us=4");
            }
            else if(!fecha && mail)
            {
                Response.Redirect("Perfil.aspx?us=6");
            }

            
        }
    }
}