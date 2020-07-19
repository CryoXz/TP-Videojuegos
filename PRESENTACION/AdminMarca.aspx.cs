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
            String s_codigoMarca = ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lbl_it_codigo")).Text.Trim();

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
            String s_codigoMarca = ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text.Trim();
            String s_nombreMarca = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_nombre")).Text.Trim();
            String s_contacto = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_contacto")).Text.Trim();
            String s_direccion = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_direccion")).Text.Trim();
            String s_ciudad = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_ciudad")).Text.Trim();
            String s_telefono = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_telefono")).Text.Trim();
            String s_email = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_email")).Text.Trim();

            Marca m = new Marca();
            
            m.setCodigoMarca(s_codigoMarca);
            m.setNombreMarca(s_nombreMarca);
            m.setNombreContacto(s_contacto);
            m.setDireccion(s_direccion);
            m.setCiudad(s_ciudad);
            m.setTelefono(s_telefono);
            m.setEmail(s_email);           

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
            string nombreMarca = txtNombreMarca.Text.Trim();
            if(nombreMarca != "")
            {
                grdMarcas.DataSource = n_Marca.getBuscarMarca(nombreMarca);
                grdMarcas.DataBind();
                if (grdMarcas.Rows.Count != 0)
                {
                    txtNombreMarca.Text = "";                   
                }
                else
                {
                    Response.Write("<script>alert('No se entontro marca');</script>");
                    txtNombreMarca.Text = "";
                    cargarGridview();
                }               
            }
            else
            {
                Response.Write("<script>alert('Debe agregar un nombre');</script>");
                cargarGridview();
            }
                  
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        { 
            Response.Redirect("AdminAltaMarca.aspx");
        }
    }
}




   
