using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using NEGOCIO;
using System.Collections.Specialized;

namespace PRESENTACION
{
    public partial class Carrito : System.Web.UI.Page
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
                
                
                float preciototal = 0;

                if (this.Session["carrito"] != null)
                {
                    cargarGridview();

                    DataTable dt = (DataTable)Session["carrito"];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        preciototal += float.Parse(dt.Rows[i]["PrecioUnitario"].ToString());

                    }
                }


                this.Session["PrecioTotal"] = preciototal;
            }


            /*if (this.Session["carrito"] == null)
                this.Session["carrito"] = GestionCompra.CrearCarrito();*/

        }

        public void cargarGridview()
        {
            grdCarrito.DataSource = (DataTable)this.Session["carrito"];
            grdCarrito.DataBind();
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            if(this.Session["carrito"] != null)
            {
                if (Session["usertype"] != null)
                {
                    Response.Redirect("CarritoConfirmar.aspx");
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Redirect("CarritoError.aspx");
            }
        }

        protected void grdCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            float total = 0;
            if (index == 0)
            {
                DataTable dt = (DataTable)Session["carrito"];
                dt.Rows[index].Delete();
                Session["carrito"] = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += float.Parse(dt.Rows[i]["PrecioUnitario"].ToString());

                }
                this.Session["PrecioTotal"] = total;
                grdCarrito.DataSource = dt;
                grdCarrito.DataBind();
                this.Session["carrito"] = null;
            }
            else
            {
                
                DataTable dt = (DataTable)Session["carrito"];
                dt.Rows[index].Delete();
                Session["carrito"] = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    total += float.Parse(dt.Rows[i]["PrecioUnitario"].ToString());

                }
                this.Session["PrecioTotal"] = total;
                grdCarrito.DataSource = dt;
                grdCarrito.DataBind();
            }
            

        }

        protected void grdCarrito_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdCarrito.EditIndex = e.NewEditIndex;
            cargarGridview();
        }

        protected void grdCarrito_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdCarrito.EditIndex = -1;
            cargarGridview();
        }

        protected void grdCarrito_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DataTable dt = (DataTable)Session["carrito"];
            float total = 0;
            int cantidadvieja = Convert.ToInt32(dt.Rows[e.RowIndex]["Cantidad"]);
            int cantidadnueva = Convert.ToInt32(((DropDownList)grdCarrito.Rows[e.RowIndex].FindControl("ddlCantidad")).SelectedValue);
            float preciototal = float.Parse(((Label)grdCarrito.Rows[e.RowIndex].FindControl("lblPrecio")).Text);
            float preciounitario = preciototal / cantidadvieja;
            float precionuevo = preciounitario * cantidadnueva;
            dt.Rows[e.RowIndex]["Cantidad"] = cantidadnueva;
            dt.Rows[e.RowIndex]["PrecioUnitario"] = precionuevo;
            Session["carrito"] = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += float.Parse(dt.Rows[i]["PrecioUnitario"].ToString());

            }
            this.Session["PrecioTotal"] = total;
            grdCarrito.EditIndex = -1;
            grdCarrito.DataSource = dt;
            grdCarrito.DataBind();
        }
    }
}