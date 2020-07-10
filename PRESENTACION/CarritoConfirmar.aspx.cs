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
    public partial class CarritoConfirmar : System.Web.UI.Page
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

        }

        protected void btnComprar_Click(object sender, EventArgs e)
        {
            int filasventa = 0;
            int filasdet = 0;
            int codVenta;
            Venta venta = new Venta();
            Usuario usr = new Usuario();
            TipoDePago tp = new TipoDePago();
            TipoUsuario tu = new TipoUsuario();
            N_Usuario negu = new N_Usuario();
            N_Venta negv = new N_Venta();
            N_Producto negp = new N_Producto();
            N_Plataforma negpl = new N_Plataforma();

            string codUsuario  = negu.getIDporUsername(this.Session["username"].ToString().Trim());
            string tipoUsuario = this.Session["usertype"].ToString();
            string tipoPago = ddlTipoPago.SelectedValue.ToString();

            tu.setCodigoTipoUsuario(tipoUsuario);
            usr.setCodigoUsuario(codUsuario);
            usr.setIdTipoUsuario(tu);
            venta.setIdCodigoUsuario(usr);
            venta.setFechaVenta(DateTime.Now);
            tp.setcodigoTipo(tipoPago);
            venta.setIdTipoPago(tp);

            filasventa = negv.GuardarVenta(venta);

            codVenta = negv.getCodVenta(venta);

            DataTable dt = (DataTable)Session["carrito"];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                N_DetalleVenta negd = new N_DetalleVenta();
                DetalleVenta detalle = new DetalleVenta();
                Venta v = new Venta();
                ENTIDAD.Producto p = new ENTIDAD.Producto();
                ENTIDAD.Plataforma pl = new Plataforma();
                string codProd = negp.getCodigoProductoConNombre(dt.Rows[i]["Nombre"].ToString());
                string codPlat = negpl.getCodigoPlataformaConNombre(dt.Rows[i]["Plataforma"].ToString());
                int cant = Convert.ToInt32(dt.Rows[i]["Cantidad"].ToString());
                float preciototal = float.Parse(dt.Rows[i]["PrecioUnitario"].ToString());

                v.setCodigoVenta(codVenta);
                detalle.setIdCodigoVenta(v);
                p.setCodigoProducto(codProd);
                detalle.setIdCodigoProducto(p);
                pl.setCodigoPlataforma(codPlat);
                detalle.setIdCodigoPlataforma(pl);
                detalle.setCantidadVendida(cant);
                detalle.setPrecioUnitario(preciototal / cant);

                filasdet = negd.GuardarDetalleVenta(detalle);
            }

            if(filasventa > 0 && filasdet > 0)
            {
                Response.Redirect("CarritoCheckout.aspx");
            }
            else
            {
                Response.Redirect("CarritoError.aspx");
            }

        }
    }
}