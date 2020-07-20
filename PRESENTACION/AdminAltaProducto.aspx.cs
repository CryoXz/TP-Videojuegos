using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using ENTIDAD;
using System.Web.Configuration;

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
                String nom = txtNombreProducto.Text;
                String desc = txtDescripcion.Text;
                String fecha = txtAnioFabricacion.Text;
                String img = txtimgURL.Text;
                String pu = txtPrecio.Text;
                String stock = txtStock.Text;

                if (solonumeros(Int32.Parse(pu)) == false)
                {
                    Response.Write("<script>alert('Solo se aceptan numeros con decimal');</script>");
                }

                N_Producto n_Producto = new N_Producto();
                if (s_categoria != "" && s_genero != "" && s_marca != "" && s_plat != "" && nom!= "" && desc != "" && fecha != "" && img != "" && pu != "" && stock != "")
                {
                    int n = n_Producto.getConsultaUltimoProducto() + 1;
                    string cod = "A" + n.ToString();

                    producto.setCodigoProducto(cod);
                    producto.setNombreProducto(nom);
                    producto.setIdCodigoCategoria(s_categoria);
                    producto.setIdCodigoGenero(s_genero);
                    producto.setIdCodigoMarca(s_marca);
                    producto.setDescripcion(desc);
                    producto.setFechaPublicacion(DateTime.Parse(fecha));
                    producto.setEstado(true);
                    PxP.setIdPlataforma(s_plat);
                    PxP.setimgURL(img);
                    PxP.setPrecioUnitario(decimal.Parse(pu));
                    PxP.setStock(Int16.Parse(stock));
                    PxP.setIdProducto(cod);

                    N_PlataformaXProducto n_PXP = new N_PlataformaXProducto();
                    if (n_Producto.AltaProducto(producto) == true && n_PXP.AltaPlataformaxProducto(PxP) == true)
                    {
                        Response.Write("<script>alert('Marca agregada con exito');</script>");
                        Response.Redirect("AdminProductos.aspx");

                    }

               

                }
                else
                {
                    Response.Write("<script>alert('Debe completar todos los campos');</script>");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        public bool solonumeros(int code)
        {
            bool resultado;

            if (code == 44 )//se evalua si es coma
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
            {
                resultado = false;
            }
            else
            {
                resultado = true;
            }

            return resultado;

        }




        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}