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
            if(!IsPostBack)
            {
               
                if (String.IsNullOrEmpty(Request.QueryString["cate"]))
                {
                    string plataforma;
                    plataforma = Request.QueryString["plat"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plataforma + "'";
                }
                else if (String.IsNullOrEmpty(Request.QueryString["plat"]))
                {
                    string categoria;
                    categoria = Request.QueryString["cate"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + categoria + "'";
                }
                else
                {
                    string plataforma;
                    string categoria;
                    plataforma = Request.QueryString["plat"];
                    categoria = Request.QueryString["cate"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plataforma + "' AND Productos.Cod_Categoria_PR = '" + categoria + "'";
                }

                
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void grdProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}