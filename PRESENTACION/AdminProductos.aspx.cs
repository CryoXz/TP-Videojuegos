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

                cargarDropdownListPlataformas();
                cargarDropdownListGeneros();
                cargarDropdownListCategorias();
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

            N_Producto n = new N_Producto();
            n.eliminarProducto(s_codigoProducto);
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
            string s_FechaPublicacion = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_FPublicacion")).Text;
            string s_CodigoPlataforma = ((DropDownList)grdProductos.Rows[e.RowIndex].FindControl("ddl_eit_plataforma")).SelectedValue; 
            string s_Stock = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_Stock")).Text;
            string s_PU =((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnitario")).Text;
            string s_img = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_Imagen")).Text;


            ENTIDAD.Producto p = new ENTIDAD.Producto();
            PlataformaXProducto PxP = new PlataformaXProducto();


            p.setCodigoProducto(s_codigoProducto);
            p.setNombreProducto(s_nombreProducto);
            p.setDescripcion(s_DescripcionProducto);
            p.setIdCodigoMarca(s_MarcaProducto);
            p.setIdCodigoCategoria(s_CategoriaProducto);
            p.setIdCodigoGenero(s_GeneroProducto);
            p.setFechaPublicacion(DateTime.Parse(s_FechaPublicacion));
            PxP.setIdProducto(s_codigoProducto);
            PxP.setIdPlataforma(s_CodigoPlataforma);
            PxP.setStock(Int32.Parse(s_Stock));
            PxP.setPrecioUnitario(decimal.Parse(s_PU));
            PxP.setimgURL(s_img);

            
            N_Producto n_Producto = new N_Producto();
            n_Producto.ActualizarProducto(p);
            N_PlataformaXProducto n_PxP = new N_PlataformaXProducto();
            n_PxP.ActualizarPlataformaxProducto(PxP);

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
                DropDownList ddl_Plataforma = (DropDownList)e.Row.FindControl("ddl_eit_plataforma");

                if (ddl_Marca != null)
                {
                    N_Marca n_marca = new N_Marca();
                    ddl_Marca.DataSource = n_marca.getTabla();

                    ddl_Marca.DataTextField = "Nombre_Marca_M";
                    ddl_Marca.DataValueField = "Cod_Marca_M";
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
                if (ddl_Plataforma != null)
                {
                    N_Plataforma n_Plat = new N_Plataforma();
                    ddl_Plataforma.DataSource = n_Plat.getTabla();
                    ddl_Plataforma.DataTextField = "Nombre_Plataforma_P";
                    ddl_Plataforma.DataValueField = "Cod_Plataforma_P";
                    ddl_Plataforma.DataBind();
                }

            }
        }

 

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAltaProducto.aspx");
        }

        protected void grdProductos_DataBound(object sender, EventArgs e)
        {
            foreach (GridViewRow row in grdProductos.Rows)
            {
                DropDownList ddlMarcas = row.FindControl("ddl_eit_marca") as DropDownList;
                HiddenField hfMarcaId = row.FindControl("hfMarcaId") as HiddenField;

                if (ddlMarcas != null && hfMarcaId != null)
                {
                    ddlMarcas.SelectedValue = hfMarcaId.Value;
                }
            }
            foreach (GridViewRow row2 in grdProductos.Rows)
            {
                DropDownList ddlCategoria = row2.FindControl("ddl_eit_categoria") as DropDownList;
                HiddenField hfCategoriaId = row2.FindControl("hfCategoriaId") as HiddenField;

                if (ddlCategoria != null && hfCategoriaId != null)
                {
                    ddlCategoria.SelectedValue = hfCategoriaId.Value;
                }
            }
            foreach (GridViewRow row3 in grdProductos.Rows)
            {
                DropDownList ddlGenero = row3.FindControl("ddl_eit_genero") as DropDownList;
                HiddenField hfGeneroId = row3.FindControl("hfGeneroId") as HiddenField;

                if (ddlGenero != null && hfGeneroId != null)
                {
                    ddlGenero.SelectedValue = hfGeneroId.Value;
                }
            }
            foreach (GridViewRow row4 in grdProductos.Rows)
            {
                DropDownList ddlPlataforma = row4.FindControl("ddl_eit_plataforma") as DropDownList;
                HiddenField hfPlataformaId = row4.FindControl("hfPlataformaId") as HiddenField;

                if (ddlPlataforma != null && hfPlataformaId != null)
                {
                    ddlPlataforma.SelectedValue = hfPlataformaId.Value;
                }
            }

        }

        public void cargarDropdownListPlataformas()
        {
            N_Venta n_Venta = new N_Venta();
            ddlPlataformas.DataSource = n_Venta.getPlataformas();
            ddlPlataformas.DataTextField = "Nombre_Plataforma_P";
            ddlPlataformas.DataValueField = "Cod_Plataforma_P";
            ddlPlataformas.DataBind();
            ddlPlataformas.Items.Insert(0, new ListItem("PLATAFORMAS", "0"));
        }
        public void cargarDropdownListGeneros()
        {
            N_Venta n_Venta = new N_Venta();
            ddlGeneros.DataSource = n_Venta.getGeneros();
            ddlGeneros.DataTextField = "Nombre_Genero_G";
            ddlGeneros.DataValueField = "Cod_Genero_G";
            ddlGeneros.DataBind();
            ddlGeneros.Items.Insert(0, new ListItem("GENEROS", "0"));
        }
        public void cargarDropdownListCategorias()
        {
            N_Venta n_Venta = new N_Venta();
            ddlCategorias.DataSource = n_Venta.getCategorias();
            ddlCategorias.DataTextField = "Nombre_Categoria_C";
            ddlCategorias.DataValueField = "Cod_Categoria_C";
            ddlCategorias.DataBind();
            ddlCategorias.Items.Insert(0, new ListItem("CATEGORIAS", "0"));
        }
        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            if (txtNombreBuscar.Text != "")
            {

                N_Producto n_Producto = new N_Producto();
                grdProductos.DataSource = n_Producto.getBuscarProducto(txtNombreBuscar.Text);
                grdProductos.DataBind();
            }

        }

        private void ConstruirClausulaSQL(string NombreCampo, // idProducto - nombreCategoria 
                                             string Operador, // > = <
                                             string Valor,
                                             ref string Clausula)
        {
            string d1 = "";  //Delimitador 1
            string d2 = ""; //Delimitador 2
            if (Clausula == "")
                Clausula = Clausula + " WHERE ";
            else
                Clausula = Clausula + " AND ";
            switch (Operador)
            {
                case "Contiene:":
                    d1 = " LIKE '%";
                    d2 = "%'";
                    break;
                case "mayor:":
                    d1 = " >  '";
                    d2 = " ' ";
                    break;
                case "menor:":
                    d1 = " < '";
                    d2 = " ' ";
                    break;
            }
            Clausula =
                Clausula + NombreCampo + d1 + Valor + d2;
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                N_Producto n_Producto = new N_Producto();
                String txtCategoriaElegida = ddlCategorias.SelectedItem.Text;
                String txtPlataformaElegida = ddlPlataformas.SelectedItem.Text;
                String txtGeneroElegido = ddlGeneros.SelectedItem.Text;

                string ClausulaSQLProductos = "";
                if (ddlPlataformas.SelectedItem.Text != "PLATAFORMAS")
                    ConstruirClausulaSQL("Nombre_Plataforma_P",
                                        "Contiene:",
                                        ddlPlataformas.SelectedItem.Text,
                                        ref ClausulaSQLProductos);

                if (ddlCategorias.SelectedItem.Text != "CATEGORIAS")
                    ConstruirClausulaSQL("nombre_categoria_C", // string nombre campo
                                         "Contiene:", // "mayor a" "Menor a" "igual a"
                                         ddlCategorias.SelectedItem.Text, // string con el numero
                                         ref ClausulaSQLProductos);
                if (ddlGeneros.SelectedItem.Text != "GENEROS")
                    ConstruirClausulaSQL("nombre_Genero_g",
                                        "Contiene:",
                                        ddlGeneros.SelectedItem.Text,
                                        ref ClausulaSQLProductos);
                if (TxtFechaInicio.Text != "")
                    ConstruirClausulaSQL("fVenta_V",
                                         "mayor:",
                                         TxtFechaInicio.Text,
                                         ref ClausulaSQLProductos);
                if (TxtFechaFin.Text != "")
                    ConstruirClausulaSQL("fVenta_V",
                                        "menor:",
                                        TxtFechaFin.Text,
                                        ref ClausulaSQLProductos);

                grdProductos.DataSource = n_Producto.getFiltrarProducto(ClausulaSQLProductos);
                grdProductos.DataBind();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {

            N_Producto n_Producto = new N_Producto();
            cargarDropdownListPlataformas();
            cargarDropdownListGeneros();
            cargarDropdownListCategorias();
            TxtFechaInicio.Text = "";
            TxtFechaFin.Text = "";
            grdProductos.DataSource = n_Producto.getTablaConPrecioyStock();
            grdProductos.DataBind();
        }
    }
}
