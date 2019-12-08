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

    }
}