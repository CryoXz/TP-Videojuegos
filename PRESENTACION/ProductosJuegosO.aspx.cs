using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class ProductosJuegosO : System.Web.UI.Page
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

                string categoria;
                categoria = Request.QueryString["cate"];
                SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + categoria + "' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF1' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF4' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF7'";


            }
        }
    }
}