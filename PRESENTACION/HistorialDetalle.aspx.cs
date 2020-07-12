using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION
{
    public partial class HistorialDetalle : System.Web.UI.Page
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
                string codVenta = Request.QueryString["ven"];
                N_PlataformaXProducto negPxP = new N_PlataformaXProducto();
                N_Producto negP = new N_Producto();
                N_Plataforma negPlat = new N_Plataforma();
                N_DetalleVenta negDV = new N_DetalleVenta();

                DataTable tabla = negPxP.getImagenDetalleVenta(codVenta);
                DataTable nombre = negP.getNombreProductoDetalleVenta(codVenta);
                DataTable plat = negPlat.getPlataformaDetalleVenta(codVenta);
                DataTable cp = negDV.getCantPrecioDetalleVenta(codVenta);

                tabla.Columns.Add("Nombre", typeof(string));
                tabla.Columns.Add("Plataforma", typeof(string));
                tabla.Columns.Add("Cantidad", typeof(int));
                tabla.Columns.Add("PrecioTotal", typeof(int));

                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    tabla.Rows[i]["Nombre"] = nombre.Rows[i]["Nombre_Producto_PR"];
                    tabla.Rows[i]["Plataforma"] = plat.Rows[i]["Nombre_Plataforma_P"];
                    tabla.Rows[i]["Cantidad"] = cp.Rows[i]["Cantidad_Producto_DV"];
                    tabla.Rows[i]["PrecioTotal"] = cp.Rows[i]["PrecioTotal"];

                }

                grdDetalle.DataSource = tabla;
                grdDetalle.DataBind();

            }

        }
    }
}