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
                cargarGridview();
            }


            if (this.Session["carrito"] == null)
                this.Session["carrito"] = GestionCompra.CrearCarrito();


        }

        public void cargarGridview()
        {
            grdCarrito.DataSource = (DataTable)this.Session["carrito"];
            grdCarrito.DataBind();
        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            if(Session["usertype"] != null)
            {
                ///redirect checkout
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void grdCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            DataTable dt = (DataTable)Session["carrito"];
            dt.Rows[index].Delete();
            Session["carrito"] = dt;
            grdCarrito.DataSource = dt;
            grdCarrito.DataBind();

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
            int cantidad = Convert.ToInt32(((DropDownList)grdCarrito.Rows[e.RowIndex].FindControl("ddlCantidad")).SelectedValue);
            DataTable dt = (DataTable)Session["carrito"];
            dt.Rows[e.RowIndex]["Cantidad"] = cantidad;
            Session["carrito"] = dt;
            grdCarrito.EditIndex = -1;
            grdCarrito.DataSource = dt;
            grdCarrito.DataBind();
        }
    }
}