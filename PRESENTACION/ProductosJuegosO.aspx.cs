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
    public partial class ProductosJuegosO : System.Web.UI.Page
    {

        void Page_PreInit(Object sender, EventArgs e)
        {
            if (Session["usertype"] != null)
            {
                switch (Session["usertype"])
                {
                    case "TU1":
                        this.MasterPageFile = "~/AdminHome.Master";
                        break;
                    case "TU2":
                        this.MasterPageFile = "~/Login.Master";
                        break;
                }

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

                if (!String.IsNullOrEmpty(Request.QueryString["s"]))
                {
                    string busqueda;
                    busqueda = Request.QueryString["s"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Nombre_Producto_PR LIKE '%" + busqueda + "%'";
                    lblTitulo.Text = "<h1>-RESULTADOS-</h1>";

                }
                else
                {
                    string categoria;
                    categoria = Request.QueryString["cate"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + categoria + "' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF1' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF4' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF7'";

                    lblTitulo.Text = "<h1>-OTROS-</h1>";
                }


            }
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
    }
}