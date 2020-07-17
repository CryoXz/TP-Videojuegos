using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NEGOCIO;
using ENTIDAD;

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
            string codigo = ((Label)grdUsuarios.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text;


            Usuario usu = new Usuario();
            usu.setCodigoUsuario(codigo);


            N_Usuario n = new N_Usuario();
            n.ModificarUsuario(usu);

            grdUsuarios.EditIndex = -1;
            cargarGridview();
        }

        protected void grdUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdUsuarios.EditIndex = e.NewEditIndex;
            cargarGridview();
        }

        protected void grdUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigo = ((Label)grdUsuarios.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text;

            N_Usuario n = new N_Usuario();
            n.eliminarUsuario(s_codigo);
            cargarGridview();

        }

        protected void grdUsuarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdUsuarios.EditIndex = -1;
            cargarGridview();
        }

        protected void grdUsuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList ddl_tipousuario = (DropDownList)e.Row.FindControl("ddl_eit_tipousuario");
                DropDownList ddl_provincia = (DropDownList)e.Row.FindControl("ddl_eit_provincia");
                DropDownList ddl_localidad = (DropDownList)e.Row.FindControl("ddl_eit_localidad");
                if (ddl_tipousuario != null)
                {
                    N_TipoUsuario n_TipoUsuario= new N_TipoUsuario();
                    ddl_tipousuario.DataSource = n_TipoUsuario.getTabla();

                    ddl_tipousuario.DataTextField = "Nombre_TipoUsuario_TU";
                    ddl_tipousuario.DataValueField = "Cod_TipoUsuario_TU";
                    ddl_tipousuario.DataBind();
                }
                if (ddl_provincia != null)
                {
                    N_Provincia n_Provincia = new N_Provincia();
                    ddl_provincia.DataSource = n_Provincia.getTabla();

                    ddl_provincia.DataTextField = "Nombre_prov";
                    ddl_provincia.DataValueField = "Cod_Provincia_prov";
                    ddl_provincia.DataBind();
                }
                if (ddl_localidad != null)
                {
                    N_Localidad n_Localidad = new N_Localidad();
                    ddl_localidad.DataSource = n_Localidad.getTablaPorID(ddl_provincia.SelectedValue);

                    ddl_localidad.DataTextField = "Nombre_loc";
                    ddl_localidad.DataValueField = "Cod_Localidad_loc";
                    ddl_localidad.DataBind();
                }
            }

        }

        protected void grdUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdUsuarios.PageIndex = e.NewPageIndex;
            cargarGridview();
        }

        protected void grdUsuarios_DataBound(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdUsuarios.Rows)
            {
                DropDownList ddl_tipousuario = row.FindControl("ddl_eit_tipousuario") as DropDownList;
                HiddenField hfTipoUsuarioId = row.FindControl("hfTipoUsuarioId") as HiddenField;

                if (ddl_tipousuario != null && hfTipoUsuarioId != null)
                {
                    ddl_tipousuario.SelectedValue = hfTipoUsuarioId.Value;
                }
            }
            foreach (GridViewRow row in grdUsuarios.Rows)
            {
                DropDownList ddl_provincia = row.FindControl("ddl_eit_provincia") as DropDownList;
                HiddenField hfProvinciaId = row.FindControl("hfProvinciaId") as HiddenField;

                if (ddl_provincia != null && hfProvinciaId != null)
                {
                    ddl_provincia.SelectedValue = hfProvinciaId.Value;
                }
            }
            foreach (GridViewRow row in grdUsuarios.Rows)
            {
                DropDownList ddl_localidad = row.FindControl("ddl_eit_localidad") as DropDownList;
                HiddenField hfLocalidadId = row.FindControl("hfLocalidadId") as HiddenField;

                if (ddl_localidad != null && hfLocalidadId != null)
                {
                    ddl_localidad.SelectedValue = hfLocalidadId.Value;
                }
            }

        }

        protected void ddl_eit_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cod = 
            foreach (GridViewRow row in grdUsuarios.Rows)
            {

                DropDownList ddl_localidad = row.FindControl("ddl_eit_localidad") as DropDownList;

                N_Localidad n_Localidad = new N_Localidad();
                ddl_localidad.DataSource = n_Localidad.getTablaPorID(cod);

                ddl_localidad.DataTextField = "Nombre_loc";
                ddl_localidad.DataValueField = "Cod_Localidad_loc";
                ddl_localidad.DataBind();
            }


        }
    }



}