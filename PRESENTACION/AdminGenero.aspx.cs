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
    public partial class Formulario_web15 : System.Web.UI.Page
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
            N_Genero n_plat = new N_Genero();
            grdGeneros.DataSource = n_plat.getTabla();
            grdGeneros.DataBind();
        }

        protected void grdGeneros_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigoGenero = ((Label)grdGeneros.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text.Trim();

            N_Genero n_plat = new N_Genero();
            n_plat.eliminarGenero(s_codigoGenero);
            cargarGridview();


        }

        protected void grdGeneros_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdGeneros.EditIndex = e.NewEditIndex;
            cargarGridview();

        }

        protected void grdGeneros_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdGeneros.EditIndex = -1;
            cargarGridview();
        }

        protected void grdGeneros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_codigoGenero = ((Label)grdGeneros.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text.Trim();
            String s_nombreGenero = ((TextBox)grdGeneros.Rows[e.RowIndex].FindControl("txt_eit_nombre")).Text.Trim();



            Genero genero = new Genero();
            genero.setCodigoGenero(s_codigoGenero);
            genero.setNombreGenero(s_nombreGenero);

            N_Genero n_Genero = new N_Genero();
            n_Genero.ActualizarGenero(genero);

            grdGeneros.EditIndex = -1;
            cargarGridview();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            N_Genero n_Genero = new N_Genero();

            string nombreGenero = txtNombreGenero.Text.Trim();
            if(nombreGenero != "")
            {
                if(!n_Genero.getBuscarNombreGenero(nombreGenero))
                {
                    int ultimoGenero = n_Genero.getConsultaUltimoGenero() + 1;
                    genero.setCodigoGenero("G" + ultimoGenero);
                    genero.setNombreGenero(nombreGenero);
                    n_Genero.AltaGenero(genero);
                    Response.Write("<script>alert('Genero agregado con exito');</script>");
                    txtNombreGenero.Text = "";
                    cargarGridview();
                }
                else
                {
                    Response.Write("<script>alert('El genero ya existe');</script>");
                    txtNombreGenero.Text = "";
                    cargarGridview();
                }
            }
            else
            {
                Response.Write("<script>alert('Debe ingresar un genero');</script>");
                txtNombreGenero.Text = "";
                cargarGridview();
            }  
        }

        protected void grdGeneros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdGeneros.PageIndex = e.NewPageIndex;
            cargarGridview();
        }
    }
}