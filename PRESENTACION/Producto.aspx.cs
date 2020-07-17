using System;
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
                if (!String.IsNullOrEmpty(Request.QueryString["prod"]) && !String.IsNullOrEmpty(Request.QueryString["plat"]))
                {
                    N_Producto negP = new N_Producto();
                    string producto;
                    string plataforma;
                    producto = Request.QueryString["prod"];
                    plataforma = Request.QueryString["plat"];

                    DataTable tabla = negP.getTablaProductoFoto(producto, plataforma);
                    grdProd.DataSource = tabla;
                    grdProd.DataBind();

                    DataTable tabla2 = negP.getTablaProductoDatos(producto, plataforma);
                    grdDatos.DataSource = tabla2;
                    grdDatos.DataBind();
                }
            }

        }

        protected void btnCarrito_Click(object sender, EventArgs e)
        {
            ///buscar en db segun prod y plat
            ///encontrar img url
            GestionCompra gc = new GestionCompra();


            Image imgbtn = this.grdProd.Items[0].FindControl("ImgProd") as Image;
            Label lbl2 = this.grdDatos.Items[0].FindControl("Nombre_Producto_PRLabel") as Label;
            Label lbl3 = this.grdDatos.Items[0].FindControl("PrecioUnitario_Producto_PxPLabel") as Label;
            Label lbl4 = this.grdDatos.Items[0].FindControl("Nombre_Plataforma_PLabel") as Label;
            TextBox txt = this.grdDatos.Items[0].FindControl("txtCant") as TextBox;
            

            string imgUrl, name, plat;
            int cant;
            float precio, preciototal;

            imgUrl = imgbtn.ImageUrl;
            name = lbl2.Text;
            plat = lbl4.Text;
            cant = Convert.ToInt32(txt.Text);
            precio = (float) Convert.ToDouble(lbl3.Text.Trim());
            preciototal = precio * cant;
            



            gc.AgregarCarrito((DataTable)this.Session["carrito"], imgUrl, name, plat, cant, preciototal);

            Response.Redirect("Carrito.aspx");

        }

    }
}