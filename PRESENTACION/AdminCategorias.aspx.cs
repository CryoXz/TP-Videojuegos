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
    public partial class AdminCategorias : System.Web.UI.Page
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
            N_Categoria n_Categoria = new N_Categoria();
            grdCategorias.DataSource = n_Categoria.getTabla();
            grdCategorias.DataBind();
        }

        protected void grdCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigoCategoria = ((Label)grdCategorias.Rows[e.RowIndex].FindControl("lbl_eit_codigoCategoria")).Text;

            N_Categoria n_Categoria = new N_Categoria();
            n_Categoria.eliminarCategoria(s_codigoCategoria);
            cargarGridview();
        }

        protected void grdCategorias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdCategorias.EditIndex = e.NewEditIndex;
            cargarGridview();

        }

        protected void grdCategorias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdCategorias.EditIndex = -1;
            cargarGridview();
        }

        protected void grdCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_codigoCategoria = ((Label)grdCategorias.Rows[e.RowIndex].FindControl("lbl_eit_codigoCategoria")).Text;
            String s_nombreCategoria = ((TextBox)grdCategorias.Rows[e.RowIndex].FindControl("txt_eit_nombreCategoria")).Text;



            Categoria categoria = new Categoria();
            categoria.setCodigoCategoria(s_codigoCategoria);
            categoria.setNombreCategoria(s_nombreCategoria);

            N_Categoria n_Categoria = new N_Categoria();
            n_Categoria.ActualizarCategoria(categoria);

            grdCategorias.EditIndex = -1;
            cargarGridview();

        }
               
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();

            int N_Filas = grdCategorias.Rows.Count - 1;
            string s_codigoCategoria = ((Label)grdCategorias.Rows[N_Filas].FindControl("lbl_eit_codigoCategoria")).Text;
            char[] charsToTream = { 'C', 'A' };
            int codNum = Convert.ToInt32(s_codigoCategoria.TrimStart(charsToTream)) + 1;

            categoria.setCodigoCategoria("CA" + codNum);
            categoria.setNombreCategoria(txtNombreCategoria.Text);

            N_Categoria n_Categoria = new N_Categoria();
            n_Categoria.AltaCategoria(categoria);

            grdCategorias.EditIndex = -1;
            cargarGridview();

        }
        protected void grdCategorias_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCategorias.PageIndex = e.NewPageIndex;
            cargarGridview();
        }
    }
}    