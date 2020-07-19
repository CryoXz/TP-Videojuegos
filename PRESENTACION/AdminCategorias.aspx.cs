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
            String s_codigoCategoria = ((Label)grdCategorias.Rows[e.RowIndex].FindControl("lbl_eit_codigoCategoria")).Text.Trim();

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
            String s_codigoCategoria = ((Label)grdCategorias.Rows[e.RowIndex].FindControl("lbl_eit_codigoCategoria")).Text.Trim();
            String s_nombreCategoria = ((TextBox)grdCategorias.Rows[e.RowIndex].FindControl("txt_eit_nombreCategoria")).Text.Trim();



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
            N_Categoria n_Categoria = new N_Categoria();

           
            string nombreCategoria = txtNombreCategoria.Text.Trim();
            if (nombreCategoria != "")
            {
                if (!n_Categoria.getBuscarNombreCategoria(nombreCategoria))
                {
                    int ultimaCategoria = n_Categoria.getConsultaUltimaCategoria() + 1;
                    categoria.setCodigoCategoria("CA" + ultimaCategoria);
                    categoria.setNombreCategoria(nombreCategoria);
                    n_Categoria.AltaCategoria(categoria);
                    Response.Write("<script>alert('Categoria agregada con exito');</script>");
                    txtNombreCategoria.Text = "";                     
                    cargarGridview();
                }
                else
                {
                    Response.Write("<script>alert('La categoria ya existe');</script>");
                    txtNombreCategoria.Text = "";                                         
                    cargarGridview();
                }
            }
            else
            {                
                Response.Write("<script>alert('Debe ingresar una categoria');</script>");
                txtNombreCategoria.Text = "";                          
                cargarGridview();
            }

        }
        protected void grdCategorias_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCategorias.PageIndex = e.NewPageIndex;
            cargarGridview();
        }
    }
}    