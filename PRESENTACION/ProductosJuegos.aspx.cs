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
    public partial class ProductosJuegos : System.Web.UI.Page
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

                if (String.IsNullOrEmpty(Request.QueryString["cate"]))
                {
                    string plataforma;
                    plataforma = Request.QueryString["plat"];

                    tabla = negpxp.getTablaProductosJuegos(plataforma, "", 0, "ASC");
                    grdProducto.DataSource = tabla;
                    grdProducto.DataBind();


                    switch (plataforma)
                    {
                        case "pf1":
                            lblTitulo.Text = "<h1>-OFERTAS SWITCH-</h1>";
                            break;
                        case "pf4":
                            lblTitulo.Text = "<h1>-OFERTAS PLAYSTATION 4-</h1>";
                            break;
                        case "pf7":
                            lblTitulo.Text = "<h1>-OFERTAS XBOX ONE-</h1>";
                            break;
                        default:
                            lblTitulo.Text = "";
                            break;

                    }
                }
                else if (String.IsNullOrEmpty(Request.QueryString["plat"]))
                {
                    string categoria;
                    categoria = Request.QueryString["cate"];
                    tabla = negpxp.getTablaProductosJuegos("", categoria, 0, "ASC");
                    grdProducto.DataSource = tabla;
                    grdProducto.DataBind();

                    switch (categoria)
                    {
                        case "ca1":
                            lblTitulo.Text = "<h1>-CONSOLAS-</h1>";
                            break;
                        case "ca2":
                            lblTitulo.Text = "<h1>-VIDEOJUEGOS-</h1>";
                            break;
                        case "ca3":
                            lblTitulo.Text = "<h1>-ACCESORIOS-</h1>";
                            break;
                        default:
                            lblTitulo.Text = "<h1>-OTROS-</h1>";
                            break;

                    }
                }
                else
                {
                    string plataforma;
                    string categoria;
                    plataforma = Request.QueryString["plat"];
                    categoria = Request.QueryString["cate"];
                    tabla = negpxp.getTablaProductosJuegos(plataforma, categoria, 0, "ASC");
                    grdProducto.DataSource = tabla;
                    grdProducto.DataBind();

                    if (plataforma == "pf1" && categoria == "ca2")
                    {
                        lblTitulo.Text = "<h1>-JUEGOS SWITCH-</h1>";
                    }
                    else if (plataforma == "pf1" && categoria.Trim() == "ca3")
                    {
                        lblTitulo.Text = "<h1>-ACCESORIOS SWITCH-</h1>";
                    }
                    else if (plataforma == "pf4" && categoria.Trim() == "ca2")
                    {
                        lblTitulo.Text = "<h1>-JUEGOS PLAYSTATION 4-</h1>";
                    }
                    else if (plataforma == "pf4" && categoria.Trim() == "ca3")
                    {
                        lblTitulo.Text = "<h1>-ACCESORIOS PLAYSTATION 4-</h1>";
                    }
                    else if (plataforma == "pf7" && categoria.Trim() == "ca2")
                    {
                        lblTitulo.Text = "<h1>-JUEGOS XBOX ONE-</h1>";
                    }
                    else if (plataforma == "pf7" && categoria.Trim() == "ca3")
                    {
                        lblTitulo.Text = "<h1>-ACCESORIOS XBOX ONE-</h1>";
                    }
                    else { lblTitulo.Text = "<h1>-OTROS-</h1>"; }
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

            if (String.IsNullOrEmpty(Request.QueryString["cate"]))
            {
                string plataforma;
                plataforma = Request.QueryString["plat"];

                switch (ddlOrden.SelectedValue)
                {
                    case "1":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, "", 0, "ASC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "2":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, "", 0, "DESC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "3":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, "", 1, "ASC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "4":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, "", 1, "DESC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                }

                switch (plataforma)
                {
                    case "pf1":
                        lblTitulo.Text = "<h1>-OFERTAS SWITCH-</h1>";
                        break;
                    case "pf4":
                        lblTitulo.Text = "<h1>-OFERTAS PLAYSTATION 4-</h1>";
                        break;
                    case "pf7":
                        lblTitulo.Text = "<h1>-OFERTAS XBOX ONE-</h1>";
                        break;
                    default:
                        lblTitulo.Text = "";
                        break;

                }
            }
            else if (String.IsNullOrEmpty(Request.QueryString["plat"]))
            {
                string categoria;
                categoria = Request.QueryString["cate"];

                switch (ddlOrden.SelectedValue)
                {
                    case "1":
                        tabla = negpxp.getTablaProductosJuegos("", categoria, 0, "ASC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "2":
                        tabla = negpxp.getTablaProductosJuegos("", categoria, 0, "DESC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "3":
                        tabla = negpxp.getTablaProductosJuegos("", categoria, 1, "ASC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "4":
                        tabla = negpxp.getTablaProductosJuegos("", categoria, 1, "DESC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                }

                switch (categoria)
                {
                    case "ca1":
                        lblTitulo.Text = "<h1>-CONSOLAS-</h1>";
                        break;
                    case "ca2":
                        lblTitulo.Text = "<h1>-VIDEOJUEGOS-</h1>";
                        break;
                    case "ca3":
                        lblTitulo.Text = "<h1>-ACCESORIOS-</h1>";
                        break;
                    default:
                        lblTitulo.Text = "<h1>-OTROS-</h1>";
                        break;

                }
            }
            else
            {
                string plataforma;
                string categoria;
                plataforma = Request.QueryString["plat"];
                categoria = Request.QueryString["cate"];

                switch (ddlOrden.SelectedValue)
                {
                    case "1":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, categoria, 0, "ASC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "2":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, categoria, 0, "DESC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "3":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, categoria, 1, "ASC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                    case "4":
                        tabla = negpxp.getTablaProductosJuegos(plataforma, categoria, 1, "DESC");
                        grdProducto.DataSource = tabla;
                        grdProducto.DataBind();
                        break;
                }

                if (plataforma == "pf1" && categoria == "ca2")
                {
                    lblTitulo.Text = "<h1>-JUEGOS SWITCH-</h1>";
                }
                else if (plataforma == "pf1" && categoria.Trim() == "ca3")
                {
                    lblTitulo.Text = "<h1>-ACCESORIOS SWITCH-</h1>";
                }
                else if (plataforma == "pf4" && categoria.Trim() == "ca2")
                {
                    lblTitulo.Text = "<h1>-JUEGOS PLAYSTATION 4-</h1>";
                }
                else if (plataforma == "pf4" && categoria.Trim() == "ca3")
                {
                    lblTitulo.Text = "<h1>-ACCESORIOS PLAYSTATION 4-</h1>";
                }
                else if (plataforma == "pf7" && categoria.Trim() == "ca2")
                {
                    lblTitulo.Text = "<h1>-JUEGOS XBOX ONE-</h1>";
                }
                else if (plataforma == "pf7" && categoria.Trim() == "ca3")
                {
                    lblTitulo.Text = "<h1>-ACCESORIOS XBOX ONE-</h1>";
                }
                else { lblTitulo.Text = "<h1>-OTROS-</h1>"; }
            }
        }
    }
}