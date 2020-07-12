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
                cargarDropdownListPlataformas();
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
            ddlMarcas.DataSource = n_Marca.getMarcas();
            ddlMarcas.DataTextField = "Nombre_Marca_M";
            ddlMarcas.DataValueField = "Cod_Marca_M";
            ddlMarcas.DataBind();
            ddlMarcas.Items.Insert(0, new ListItem("MARCAS", "0"));
        }
        public void cargarDropdownListPlataformas()
        {
            N_Plataforma n_Plat = new N_Plataforma();
            ddlPlataformas.DataSource = n_Plat.getPlataformas();
            ddlPlataformas.DataTextField = "Nombre_Plataforma_P";
            ddlPlataformas.DataValueField = "Cod_Plataforma_P";
            ddlPlataformas.DataBind();
            ddlPlataformas.Items.Insert(0, new ListItem("PLATAFORMAS", "0"));
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ENTIDAD.Producto producto = new ENTIDAD.Producto();
                PlataformaXProducto PxP = new PlataformaXProducto();


                String s_categoria = ddlCategoria.SelectedValue.ToString();
                String s_genero = ddlGeneros.SelectedValue.ToString();
                String s_marca = ddlMarcas.SelectedValue.ToString();
                String s_plat = ddlPlataformas.SelectedValue.ToString();

                N_Producto n_Producto = new N_Producto();
          
                int n = Int32.Parse(n_Producto.getConsultaUltimoProducto()) + 1;
                string cod = "A"+ n.ToString();

                producto.setCodigoProducto(cod);
                producto.setNombreProducto(txtNombreProducto.Text);
                producto.setIdCodigoCategoria(s_categoria);
                producto.setIdCodigoGenero(s_genero);
                producto.setIdCodigoMarca(s_marca);
                producto.setDescripcion(txtDescripcion.Text);
                producto.setAnioFabricacion(txtAnioFabricacion.Text.ToString());
                producto.setEstado(true);
                PxP.setIdPlataforma(s_plat);
                PxP.setimgURL(txtimgURL.Text);
                PxP.setPrecioUnitario(decimal.Parse(txtPrecio.Text));
                PxP.setStock(Int32.Parse(txtStock.Text));
                PxP.setIdProducto(cod);

                N_PlataformaXProducto n_PXP = new N_PlataformaXProducto();
                if (n_Producto.AltaProducto(producto) == true && n_PXP.AltaPlataformaxProducto(PxP) == true)
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