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
    public partial class AdminProductos : System.Web.UI.Page
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
            N_Producto n = new N_Producto();
            grdProductos.DataSource = n.getTablaConPrecioyStock();
            grdProductos.DataBind();
        }

        protected void grdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigoProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_eit_codigoProducto")).Text;

            N_Producto n_plat = new N_Producto();
            n_plat.eliminarProducto(s_codigoProducto);
            cargarGridview();


        }

        protected void grdProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdProductos.EditIndex = e.NewEditIndex;
            cargarGridview();

        }

        protected void grdProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdProductos.EditIndex = -1;
            cargarGridview();
        }

        protected void grdProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string s_codigoProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_eit_Codigo")).Text;
            string s_nombreProducto = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_nombre")).Text;
            string s_DescripcionProducto = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_descripcion")).Text;
            string s_MarcaProducto = ((DropDownList)grdProductos.Rows[e.RowIndex].FindControl("ddl_eit_marca")).SelectedValue;
            string s_CategoriaProducto = ((DropDownList)grdProductos.Rows[e.RowIndex].FindControl("ddl_eit_categoria")).SelectedValue;
            string s_GeneroProducto = ((DropDownList)grdProductos.Rows[e.RowIndex].FindControl("ddl_eit_genero")).SelectedValue;
            //DateTime s_FechaPublicacion = ((DateTime)grdProductos.Rows[e.RowIndex].FindControl("lbl_eit_FPublicacion")).ToString();
          //  int s_Estado =  (CheckBox)grdProductos.Rows[e.RowIndex].FindControl("CheckBox1");
        
            ENTIDAD.Producto p = new ENTIDAD.Producto();

            p.setCodigoProducto(s_codigoProducto);
            p.setNombreProducto(s_nombreProducto);
            p.setDescripcion(s_DescripcionProducto);
            p.setIdCodigoMarca(s_MarcaProducto);
            p.setIdCodigoCategoria(s_CategoriaProducto);
            p.setIdCodigoGenero(s_GeneroProducto);
            //  p.setAnioFabricacion(s_FechaPublicacion);
           // p.setEstado();

            N_Producto n_Producto = new N_Producto();
            n_Producto.ActualizarProducto(p);

            grdProductos.EditIndex = -1;
            cargarGridview();

        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            cargarGridview();
        }

        protected void grdProductos_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DropDownList ddl_Marca = (DropDownList)e.Row.FindControl("ddl_eit_marca");
                DropDownList ddl_Categoria = (DropDownList)e.Row.FindControl("ddl_eit_categoria");
                DropDownList ddl_Genero = (DropDownList)e.Row.FindControl("ddl_eit_genero");
                if (ddl_Marca != null)
                {
                    N_Marca n_marca = new N_Marca();
                    ddl_Marca.DataSource = n_marca.getTabla();
                    ddl_Marca.DataTextField = "Nombre_Marca_M";
                    ddl_Marca.DataValueField = "Cod_Marca_M";
                    ddl_Marca.SelectedValue = null;
                
                    ddl_Marca.DataBind();
                }
                if (ddl_Categoria != null)
                {
                    N_Categoria n_Categoria = new N_Categoria();
                    ddl_Categoria.DataSource = n_Categoria.getTabla();
                    ddl_Categoria.DataTextField = "Nombre_Categoria_C";
                    ddl_Categoria.DataValueField = "Cod_Categoria_C";
                    ddl_Categoria.DataBind();
                }

                if (ddl_Genero != null)
                {
                    N_Genero n_Genero = new N_Genero();
                    ddl_Genero.DataSource = n_Genero.getTabla();
                    ddl_Genero.DataTextField = "Nombre_Genero_G";
                    ddl_Genero.DataValueField = "Cod_Genero_G";
                    ddl_Genero.DataBind();
                }


            }
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAltaProducto.aspx");
        }
    }
}