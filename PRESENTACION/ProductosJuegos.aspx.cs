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
    public partial class ProductosJuegos : System.Web.UI.Page
    {

        void Page_PreInit(Object sender, EventArgs e)
        {
            if (Session["usertype"] != null)
            {
                this.MasterPageFile = "~/Login.Master";
            }
            else
            {
                this.MasterPageFile = "~/Home.Master";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                if (String.IsNullOrEmpty(Request.QueryString["cate"]))
                {
                    string plataforma;
                    plataforma = Request.QueryString["plat"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plataforma + "'";

                    switch (plataforma)
                    {
                        case "pf1":
                            lblTitulo.Text = "<h1>-OFERTAS SWITCH-</h1>";
                            break;
                        case "pf4":
                            lblTitulo.Text = "<h1>-OFERTAS PLAYSTATION 4-</h1>";
                            break;
                        case "pf7":
                            lblTitulo.Text = "<h1>-OFERTAS XBOX ONE-</h1>";
                            break;
                        default:
                            lblTitulo.Text = "";
                            break;

                    }
                }
                else if (String.IsNullOrEmpty(Request.QueryString["plat"]))
                {
                    string categoria;
                    categoria = Request.QueryString["cate"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + categoria + "'";

                    switch (categoria)
                    {
                        case "ca1":
                            lblTitulo.Text = "<h1>-CONSOLAS-</h1>";
                            break;
                        case "ca2":
                            lblTitulo.Text = "<h1>-VIDEOJUEGOS-</h1>";
                            break;
                        case "ca3":
                            lblTitulo.Text = "<h1>-ACCESORIOS-</h1>";
                            break;
                        default:
                            lblTitulo.Text = "<h1>-OTROS-</h1>";
                            break;

                    }
                }
                else
                {
                    string plataforma;
                    string categoria;
                    plataforma = Request.QueryString["plat"];
                    categoria = Request.QueryString["cate"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plataforma + "' AND Productos.Cod_Categoria_PR = '" + categoria + "'";

                    if (plataforma == "pf1" && categoria == "ca2")
                    {
                        lblTitulo.Text = "<h1>-JUEGOS SWITCH-</h1>";
                    }
                    else if (plataforma == "pf1" && categoria.Trim() == "ca3")
                    {
                        lblTitulo.Text = "<h1>-ACCESORIOS SWITCH-</h1>";
                    }
                    else if (plataforma == "pf4" && categoria.Trim() == "ca2")
                    {
                        lblTitulo.Text = "<h1>-JUEGOS PLAYSTATION 4-</h1>";
                    }
                    else if (plataforma == "pf4" && categoria.Trim() == "ca3")
                    {
                        lblTitulo.Text = "<h1>-ACCESORIOS PLAYSTATION 4-</h1>";
                    }
                    else if (plataforma == "pf7" && categoria.Trim() == "ca2")
                    {
                        lblTitulo.Text = "<h1>-JUEGOS XBOX ONE-</h1>";
                    }
                    else if (plataforma == "pf7" && categoria.Trim() == "ca3")
                    {
                        lblTitulo.Text = "<h1>-ACCESORIOS XBOX ONE-</h1>";
                    }
                    else { lblTitulo.Text = "<h1>-OTROS-</h1>"; }
                }

                if (this.Session["carrito"] == null)
                    this.Session["carrito"] = GestionCompra.CrearCarrito();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void ImgBtnProd_Click(object sender, EventArgs e)
        {

            ImageButton btn = sender as ImageButton;


            ListViewItem item = btn.NamingContainer as ListViewItem;


            Label lbl = item.FindControl("Nombre_Producto_PRLabel") as Label;
            ImageButton img = item.FindControl("ImgBtnProd") as ImageButton;

            string name;
            string imgUrl;
            string codProd;
            string codPlat;

            name = lbl.Text;
            imgUrl = img.ImageUrl;
            //buscar cod prod
            N_Producto n_Producto = new N_Producto();
            codProd = n_Producto.getCodigoProdS(imgUrl, name);
            codPlat = n_Producto.getCodigoPlat(imgUrl, name);
            //redireccionar
            Response.Redirect("Producto.aspx?prod=" + codProd + "&plat=" + codPlat);


        }

        protected void grdProducto_ItemCommand(object sender, ListViewCommandEventArgs e)
        {


        }
    }
}