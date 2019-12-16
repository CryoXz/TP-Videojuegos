using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using ENTIDAD;

namespace PRESENTACION
{
    public partial class Formulario_web13 : System.Web.UI.Page
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
            N_Marca n_Marca = new N_Marca();
            grdMarcas.DataSource = n_Marca.getTabla();
            grdMarcas.DataBind();

        }

        protected void grdMarcas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigoMarca = ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lbl_it_codigo")).Text;

            N_Marca n_Marca = new N_Marca();
            n_Marca.eliminarMarca(s_codigoMarca);
            cargarGridview();


        }

        protected void grdMarcas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdMarcas.EditIndex = e.NewEditIndex;
            cargarGridview();

        }

        protected void grdMarcas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdMarcas.EditIndex = -1;
            cargarGridview();
        }

        protected void grdMarcas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {            
            String s_codigoMarca = ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text;
            String s_nombreMarca = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_nombre")).Text;
            String s_contacto = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_contacto")).Text;
            String s_direccion = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_direccion")).Text;
            String s_ciudad = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_ciudad")).Text;
            String s_telefono = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_telefono")).Text;
            String s_email = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_email")).Text;

            Marca m = new Marca();
            m.setCodigoMarca(s_codigoMarca);
            m.setNombreMarca(s_nombreMarca);
            m.setNombreContacto(s_contacto);
            m.setDireccion(s_direccion);
            m.setCiudad(s_ciudad);
            m.setTelefono(s_telefono);
            m.setEmail(s_email);
            m.setEstado(1);

            N_Marca n_Marca = new N_Marca();
            n_Marca.ActualizarMarca(m);

            grdMarcas.EditIndex = -1;
            cargarGridview();

        }

        protected void grdMarcas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdMarcas.PageIndex = e.NewPageIndex;
            cargarGridview();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
                N_Marca n_Marca = new N_Marca();
                grdMarcas.DataSource = n_Marca.getBuscarMarca(txtNombreMarca.Text);
                grdMarcas.DataBind();        
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int N_filas = grdMarcas.Rows.Count - 1;
            string s_codigoMarca = ((Label)grdMarcas.Rows[N_filas].FindControl("lbl_it_codigo")).Text;
            char[] CharsToTream = { 'M' };
            int codNum = Convert.ToInt32(s_codigoMarca.TrimStart(CharsToTream)) + 1;

            this.Session["codigoMarca"] = codNum;
            Response.Redirect("AdminAltaMarca.aspx");
        }
    }
}




   
