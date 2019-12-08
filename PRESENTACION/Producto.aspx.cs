﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class Producto : System.Web.UI.Page
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
                if (!String.IsNullOrEmpty(Request.QueryString["prod"]) && !String.IsNullOrEmpty(Request.QueryString["plat"]))
                {

                    string producto;
                    string plataforma;
                    producto = Request.QueryString["prod"];
                    plataforma = Request.QueryString["plat"];
                    SqlDataSource1.SelectCommand = "SELECT PlataformaxProducto.Imagen_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP INNER JOIN Plataformas ON PlataformaxProducto.Cod_Plataforma_PxP = Plataformas.Cod_Plataforma_P WHERE PlataformaxProducto.Cod_Producto_PxP = '" + producto + "' AND PlataformaxProducto.Cod_Plataforma_PxP = '" + plataforma + "'";

                    SqlDataSource2.SelectCommand = "SELECT Productos.Nombre_Producto_PR, Plataformas.Nombre_Plataforma_P, PlataformaxProducto.PrecioUnitario_Producto_PxP  FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP INNER JOIN Plataformas ON PlataformaxProducto.Cod_Plataforma_PxP = Plataformas.Cod_Plataforma_P WHERE PlataformaxProducto.Cod_Producto_PxP = '" + producto + "' AND PlataformaxProducto.Cod_Plataforma_PxP = '" + plataforma + "'";
                }
            }

        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            ///buscar en db segun prod y plat
            ///encontrar img url
            GestionCompra gc = new GestionCompra();


            Image imgbtn = this.ListView1.Items[0].FindControl("ImgProd") as Image;
            Label lbl2 = this.ListView2.Items[0].FindControl("Nombre_Producto_PRLabel") as Label;
            Label lbl3 = this.ListView2.Items[0].FindControl("PrecioUnitario_Producto_PxPLabel") as Label;
            DropDownList ddl = this.ListView2.Items[0].FindControl("ddlCant") as DropDownList;

            string imgUrl, name, plat;
            int cant, precio, preciototal;

            imgUrl = imgbtn.ImageUrl;
            name = lbl2.Text;
            plat = Request.QueryString["plat"];
            cant = Convert.ToInt32(ddl.SelectedValue);


            gc.AgregarCarrito((DataTable)this.Session["carrito"], imgUrl, name, plat, cant);

            Response.Redirect("Carrito.aspx");

        }
    }
}