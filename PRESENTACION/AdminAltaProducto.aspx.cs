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
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {              
                cargarDropdownListGeneros();
                cargarDropdownListMarcas();
                cargarDropdownListCategorias();
            }
        }
    

        public void cargarDropdownListCategorias()
        {
            N_Venta n_Venta = new N_Venta();
            ddlCategoria.DataSource = n_Venta.getCategorias();
            ddlCategoria.DataTextField = "Nombre_Categoria_C";
            ddlCategoria.DataValueField = "Cod_Categoria_C";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("CATEGORIAS", "0"));
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

        public void cargarDropdownListMarcas()
        {
            N_Marca n_Marca = new N_Marca();
            ddlMarcas.DataSource = n_Marca.getMarcass();
            ddlMarcas.DataTextField = "Nombre_Marca_M";
            ddlMarcas.DataValueField = "Cod_Marca_M";
            ddlMarcas.DataBind();
            ddlMarcas.Items.Insert(0, new ListItem("MARCAS", "0"));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ENTIDAD.Producto producto = new ENTIDAD.Producto();

                String s_categoria = ddlCategoria.SelectedValue.ToString();
                String s_genero = ddlGeneros.SelectedValue.ToString();
                String s_marca = ddlMarcas.SelectedValue.ToString();


                producto.setNombreProducto(txtNombreProducto.Text);
                producto.setIdCodigoCategoria(s_categoria);
                producto.setIdCodigoGenero(s_genero);
                producto.setIdCodigoMarca(s_marca);
                producto.setDescripcion(txtDescripcion.Text);
                //  producto.setAnioFabricacion(txtAnioFabricacion.Text);
                producto.setEstado(true);


                N_Producto n_Producto = new N_Producto();
                if (n_Producto.AltaProducto(producto) == true)
                {
                    Label1.Text = "Se ha agregado con exito";
                }

                Response.Redirect("AdminProductos.aspx");
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}