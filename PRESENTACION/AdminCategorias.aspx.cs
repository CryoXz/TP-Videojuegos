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
            N_Categoria n_plat = new N_Categoria();
            grdCategorias.DataSource = n_plat.getTabla();
            grdCategorias.DataBind();

        }

        protected void grdCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigoCategoria = ((Label)grdCategorias.Rows[e.RowIndex].FindControl("lbl_it_codigoCategoria")).Text;

            N_Categoria n_plat = new N_Categoria();
            n_plat.eliminarCategoria(s_codigoCategoria);
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



            Categoria plat = new Categoria();
            plat.setCodigoCategoria(s_codigoCategoria);
            plat.setNombreCategoria(s_nombreCategoria);

            N_Categoria n_Categoria = new N_Categoria();
            n_Categoria.ActualizarCategoria(plat);

            grdCategorias.EditIndex = -1;
            cargarGridview();

        }

    }
}    