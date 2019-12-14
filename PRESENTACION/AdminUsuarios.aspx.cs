using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class AdminUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItemCollection coleccion = new ListItemCollection();

                coleccion.Add(new ListItem("Administrador", "1"));
                coleccion.Add(new ListItem("Cliente", "2"));
                ddlTipoUsuario.DataValueField = "Value";
                ddlTipoUsuario.DataTextField = "Text";
                ddlTipoUsuario.DataSource = coleccion;
                ddlTipoUsuario.DataBind();

                cargarGridview("");                    

            }
        }



        public void cargarGridview(String codigoTipo)
        {
            N_Usuario N_usuario = new N_Usuario();     
           if(codigoTipo == "")
            {
                grdUsuarios.DataSource = N_usuario.getTabla();
                grdUsuarios.DataBind();

            }
           else
            {
                // no muestra la grilla con el filtro
                
            }

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {           
            N_Usuario n_Usuario = new N_Usuario();
            if(txtBuscarNombre.Text == "")
            {
                Response.Write("<script>alert('debe ingresar un nombre');</script>");
            }
            else
            {
                grdUsuarios.DataSource = n_Usuario.getbuscarUsuario(txtBuscarNombre.Text);
                grdUsuarios.DataBind();
            }

            
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            N_Usuario n_usuario = new N_Usuario();
            Char codigoTipo = Convert.ToChar(ddlTipoUsuario.SelectedValue);
            grdUsuarios.DataSource = n_usuario.getTablaConFiltro(codigoTipo);
            grdUsuarios.DataBind();
        }

       
    }



}