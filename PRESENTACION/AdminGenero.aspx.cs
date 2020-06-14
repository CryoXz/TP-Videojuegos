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
            String s_codigoGenero = ((Label)grdGeneros.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text;

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
            String s_codigoGenero = ((Label)grdGeneros.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text;
            String s_nombreGenero = ((TextBox)grdGeneros.Rows[e.RowIndex].FindControl("txt_eit_nombre")).Text;



            Genero plat = new Genero();
            plat.setCodigoGenero(s_codigoGenero);
            plat.setNombreGenero(s_nombreGenero);

            N_Genero n_Genero = new N_Genero();
            n_Genero.ActualizarGenero(plat);

            grdGeneros.EditIndex = -1;
            cargarGridview();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Genero p = new Genero();


            int N_filas = grdGeneros.Rows.Count - 1;
            string s_codigoGenero = ((Label)grdGeneros.Rows[N_filas].FindControl("lbl_it_codigo")).Text;
            char[] CharsToTream = { 'G' };
            int codNum = Convert.ToInt32(s_codigoGenero.TrimStart(CharsToTream)) + 1;

            p.setCodigoGenero("G" + codNum);
            p.setNombreGenero(TxtNombre.Text);


            N_Genero n_Genero = new N_Genero();
            n_Genero.AltaGenero(p);

            grdGeneros.EditIndex = -1;
            cargarGridview();

        }

        protected void grdGeneros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdGeneros.PageIndex = e.NewPageIndex;
            cargarGridview();
        }

    }
}