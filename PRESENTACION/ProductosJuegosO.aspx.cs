using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
                N_PlataformaXProducto negpxp = new N_PlataformaXProducto();
                DataTable tabla = null;

                if (String.IsNullOrEmpty(Request.QueryString["s"]))
                {
                    string categoria;
                    categoria = Request.QueryString["cate"];
                    tabla = negpxp.getTablaProductosJuegosO(categoria, "ASC", 0);
                    grdProducto.DataSource = tabla;
                    grdProducto.DataBind();
                    lblTitulo.Text = "<h1>-OTROS-</h1>";
                }
                else
                {
                    string busqueda;
                    busqueda = Request.QueryString["s"].Trim();
                    tabla = negpxp.getTablaProductosJuegosBusqueda(busqueda, "ASC", 0);
                    grdProducto.DataSource = tabla;
                    grdProducto.DataBind();
                    lblTitulo.Text = "<h1>-RESULTADOS-</h1>";



                    ///SqlDataSource1.SelectCommand = ";


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

        protected void ddlOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdProducto.DataSource = null;
            grdProducto.DataBind();
            N_PlataformaXProducto negpxp = new N_PlataformaXProducto();
            DataTable tabla = null;

            if (String.IsNullOrEmpty(Request.QueryString["s"]))
            {
                string categoria;
                categoria = Request.QueryString["cate"];

                switch (ddlOrden.SelectedValue)
                {
                    case "1":
                        tabla = negpxp.getTablaProductosJuegosO(categoria, "ASC", 0);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-OTROS-</h1>";
                        break;
                    case "2":
                        tabla = negpxp.getTablaProductosJuegosO(categoria, "DESC", 0);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-OTROS-</h1>";
                        break;
                    case "3":
                        tabla = negpxp.getTablaProductosJuegosO(categoria, "ASC", 1);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-OTROS-</h1>";
                        break;
                    case "4":
                        tabla = negpxp.getTablaProductosJuegosO(categoria, "DESC", 1);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-OTROS-</h1>";
                        break;
                }

            }
            else
            {
                string busqueda;
                busqueda = Request.QueryString["s"].Trim();

                switch (ddlOrden.SelectedValue)
                {
                    case "1":
                        tabla = negpxp.getTablaProductosJuegosBusqueda(busqueda, "ASC", 0);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-RESULTADOS-</h1>";
                        break;
                    case "2":
                        tabla = negpxp.getTablaProductosJuegosBusqueda(busqueda, "DESC", 0);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-RESULTADOS-</h1>";
                        break;
                    case "3":
                        tabla = negpxp.getTablaProductosJuegosBusqueda(busqueda, "ASC", 1);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-RESULTADOS-</h1>";
                        break;
                    case "4":
                        tabla = negpxp.getTablaProductosJuegosBusqueda(busqueda, "DESC", 1);
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        lblTitulo.Text = "<h1>-RESULTADOS-</h1>";
                        break;
                }


            }
        }
    }
}