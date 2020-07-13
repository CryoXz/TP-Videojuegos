using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ENTIDAD;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class HistorialCompras : System.Web.UI.Page
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
                if(this.Session["username"] != null)
                {
                    N_Usuario negU = new N_Usuario();
                    N_Venta negV = new N_Venta();
                    N_DetalleVenta negDV = new N_DetalleVenta();
                    
                    string codUsuario = negU.getIDporUsername(this.Session["username"].ToString());

                    DataTable tabla = negV.getTablaVentasPorUsuario(codUsuario);
                    DataTable tabla2 = negDV.getTablaDetalleVentasPrecioTotalPorCodUsuario(codUsuario);
                    tabla.Columns.Add("PrecioTotal", typeof(string));
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        tabla.Rows[i]["PrecioTotal"] = tabla2.Rows[i]["PrecioTotal"];

                    }
                    grdVentas.DataSource = tabla;
                    grdVentas.DataBind();
                }
            }
        }

        protected void grdVentas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdVentas.PageIndex = e.NewPageIndex;
            N_Usuario negU = new N_Usuario();
            N_Venta negV = new N_Venta();
            N_DetalleVenta negDV = new N_DetalleVenta();

            string codUsuario = negU.getIDporUsername(this.Session["username"].ToString());

            DataTable tabla = negV.getTablaVentasPorUsuario(codUsuario);
            DataTable tabla2 = negDV.getTablaDetalleVentasPrecioTotalPorCodUsuario(codUsuario);
            tabla.Columns.Add("PrecioTotal", typeof(string));
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                tabla.Rows[i]["PrecioTotal"] = tabla2.Rows[i]["PrecioTotal"];

            }
            grdVentas.DataSource = tabla;
            grdVentas.DataBind();
        }

        protected void btnDetalle_Click(object sender, EventArgs e)
        {
            
            
            Button lb = (Button)sender;
            GridViewRow row = (GridViewRow)lb.NamingContainer;
            if (row != null)
            {
                int index = row.RowIndex; //gets the row index selected
                string codVenta = ((Label)grdVentas.Rows[index].FindControl("lblCodVenta")).Text;
                Response.Redirect("HistorialDetalle.aspx?ven=" + codVenta);
            }

            

        }

        
    }
}