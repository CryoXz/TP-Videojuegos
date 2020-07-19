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
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                N_Provincia negp = new N_Provincia();
                DataTable dtP = negp.getTabla();
                ddlProvincia.DataSource = dtP;
                ddlProvincia.DataTextField = "Nombre_prov";
                ddlProvincia.DataValueField = "Cod_Provincia_prov";
                ddlProvincia.DataBind();

                N_Localidad negl = new N_Localidad();
                DataTable dtL = negl.getTablaPorID(ddlProvincia.SelectedValue.ToString());
                ddlLocalidad.DataSource = dtL;
                ddlLocalidad.DataTextField = "Nombre_loc";
                ddlLocalidad.DataValueField = "Cod_Localidad_loc";
                ddlLocalidad.DataBind();

                switch (Request.QueryString["e"])
                {
                    case "1":
                        lblIncorrecto.Text = "ERROR, VUELVA A INTENTARLO";
                        break;
                    case "2":
                        lblIncorrecto.Text = "ERROR, CAMPOS VACIOS!";
                        break;
                    case "3":
                        lblIncorrecto.Text = "ERROR, FECHA INCORRECTA!";
                        break;
                    case "4":
                        lblIncorrecto.Text = "ERROR, EMAIL INCORRECTO!";
                        break;
                    case "5":
                        lblIncorrecto.Text = "ERROR, LAS CONTRASEÑAS NO COINCIDEN!";
                        break;
                }
            }

        }

        private bool isvalidEmail(string address)
        {
            EmailAddressAttribute e = new EmailAddressAttribute();
            if (e.IsValid(address))
                return true;
            else
                return false;
        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            N_Usuario negu = new N_Usuario();
            Usuario user = new Usuario();
            TipoUsuario tu = new TipoUsuario();
            Provincia pr = new Provincia();
            Localidad lo = new Localidad();

            bool vacio = true, fecha = true , mail, pass = true;

            if(txtNombre.Text == "" || txtApellido.Text == "" || txtUsername.Text == "" || txtContraseña.Text == ""
                || txtContraseña2.Text == "" || txtDNI.Text == "" || txtFecha.Text == "" || txtDireccion.Text == ""
                || txtMail.Text == "" || txtTelefono.Text == "")
            {
                vacio = false;
            }

            if (DateTime.Compare(DateTime.Parse(txtFecha.Text), DateTime.Now) > 0)
            {
                fecha = false;
            }

            mail = isvalidEmail(txtMail.Text);

            if(txtContraseña.Text != txtContraseña2.Text)
            {
                pass = false;
            }

            if(vacio && fecha && mail && pass)
            {
                int cantUsers = negu.getCantidadUsuarios();
                int coduser = cantUsers + 1;
                user.setCodigoUsuario("U" + coduser.ToString());
                tu.setCodigoTipoUsuario("TU2");
                user.setIdTipoUsuario(tu);
                user.setNombre(txtNombre.Text);
                user.setApellido(txtApellido.Text);
                user.setNickname(txtUsername.Text);
                user.SetContraseña(txtContraseña.Text);
                user.setDni(txtDNI.Text);
                user.setFechaNacimiento(DateTime.Parse(txtFecha.Text));
                user.setTelefono(txtTelefono.Text);
                user.setEmail(txtMail.Text);
                user.setDireccion(txtDireccion.Text);
                pr.setCodigoProvincia(ddlProvincia.SelectedValue);
                user.setProvincia(pr);
                lo.setCodigoLocalidad(ddlLocalidad.SelectedValue);
                user.setLocalidad(lo);
                user.setEstado(true);

                int filas = negu.GuardarUsuario(user);

                if(filas > 0)
                {
                    Response.Redirect("Login.aspx?u=1");
                }
                else
                {
                    Response.Redirect("Registrarse.aspx?e=1");///error general
                }

            }
            else if(!vacio)
            {
                Response.Redirect("Registrarse.aspx?e=2");///textos vacios
            }
            else if (!fecha)
            {
                Response.Redirect("Registrarse.aspx?e=3");///error fecha
            }
            else if (!mail)
            {
                Response.Redirect("Registrarse.aspx?e=4");///mail invalido
            }
            else if (!pass)
            {
                Response.Redirect("Registrarse.aspx?e=5");///contraseña incorrecta
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
    }
}
