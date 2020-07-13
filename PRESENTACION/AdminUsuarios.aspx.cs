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

                cargarGridview();                    

            }
        }



        public void cargarGridview()
        {
            N_Usuario n_Usuario = new N_Usuario();
            grdUsuarios.DataSource = n_Usuario.getTabla();
            grdUsuarios.DataBind();


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

        protected void grdUsuarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void grdUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void grdUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigo = ((Label)grdUsuarios.Rows[e.RowIndex].FindControl("")).Text;

            N_Producto n_plat = new N_Producto();
            n_plat.eliminarProducto(s_codigo);
            cargarGridview();

        }

        protected void grdUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }

        protected void grdUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void grdUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }
    }



}