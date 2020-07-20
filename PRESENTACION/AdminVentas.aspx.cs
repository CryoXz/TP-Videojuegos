using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;

namespace PRESENTACION
{
    public partial class AdminVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGridview();
                cargarDropdownListPlataformas();
                cargarDropdownListGeneros();
                cargarDropdownListCategorias();            
            }           
        }

        public void cargarGridview()
        {
            N_Venta n_Venta = new N_Venta();
            grdVentas.DataSource = n_Venta.getTabla();
            grdVentas.DataBind(); 
        }
        public void cargarDropdownListPlataformas()
        {
            N_Venta n_Venta = new N_Venta();
            ddlPlataformas.DataSource = n_Venta.getPlataformas();
            ddlPlataformas.DataTextField = "Nombre_Plataforma_P";
            ddlPlataformas.DataValueField = "Cod_Plataforma_P";
            ddlPlataformas.DataBind();
            ddlPlataformas.Items.Insert(0, new ListItem("PLATAFORMAS", "0"));
        }
        public void cargarDropdownListGeneros()
        {
            N_Venta n_Venta = new N_Venta();
            ddlGeneros.DataSource = n_Venta.getGeneros();
            ddlGeneros.DataTextField = "Nombre_Genero_G";
            ddlGeneros.DataValueField = "Cod_Genero_G";
            ddlGeneros.DataBind();
            ddlGeneros.Items.Insert(0, new ListItem("GENEROS", "0"));
        }
        public void cargarDropdownListCategorias()
        {
            N_Venta n_Venta = new N_Venta();
            ddlCategorias.DataSource = n_Venta.getCategorias();
            ddlCategorias.DataTextField = "Nombre_Categoria_C";
            ddlCategorias.DataValueField = "Cod_Categoria_C";
            ddlCategorias.DataBind();
            ddlCategorias.Items.Insert(0, new ListItem("CATEGORIAS", "0"));
        }
        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            if(txtNombreBuscar.Text != "")
            {
               
                N_Venta n_Venta = new N_Venta();
                grdVentas.DataSource = n_Venta.getBuscarProductoVendido(txtNombreBuscar.Text);
                grdVentas.DataBind();
            }
                      
        }

        private void ConstruirClausulaSQL(string NombreCampo, // idProducto - nombreCategoria 
                                             string Operador, // > = <
                                             string Valor,
                                             ref string Clausula)
        {
            string d1 = "";  //Delimitador 1
            string d2 = ""; //Delimitador 2
            if (Clausula == "")
                Clausula = Clausula + " WHERE ";
            else
                Clausula = Clausula + " AND ";
            switch (Operador)
            {
                case "Contiene:":
                    d1 = " LIKE '%";
                    d2 = "%'";
                    break;
                case "mayor:":
                    d1 = " >  '";
                    d2 = " ' ";
                    break;
                case "menor:":
                    d1 = " < '";
                    d2 = " ' ";
                    break;
            }
            Clausula =
                Clausula + NombreCampo + d1 + Valor + d2;
        }
        
        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                N_Venta n_Venta = new N_Venta();
                String txtCategoriaElegida = ddlCategorias.SelectedItem.Text;
                String txtPlataformaElegida = ddlPlataformas.SelectedItem.Text;
                String txtGeneroElegido = ddlGeneros.SelectedItem.Text;

                string ClausulaSQLProductos = "";
                if (ddlPlataformas.SelectedItem.Text != "PLATAFORMAS")
                    ConstruirClausulaSQL("Nombre_Plataforma_P",
                                        "Contiene:",
                                        ddlPlataformas.SelectedItem.Text,
                                        ref ClausulaSQLProductos);

                if (ddlCategorias.SelectedItem.Text != "CATEGORIAS")
                    ConstruirClausulaSQL("nombre_categoria_C", // string nombre campo
                                         "Contiene:", // "mayor a" "Menor a" "igual a"
                                         ddlCategorias.SelectedItem.Text, // string con el numero
                                         ref ClausulaSQLProductos);
                if (ddlGeneros.SelectedItem.Text != "GENEROS")
                    ConstruirClausulaSQL("nombre_Genero_g",
                                        "Contiene:",
                                        ddlGeneros.SelectedItem.Text,
                                        ref ClausulaSQLProductos);
                if (TxtFechaInicio.Text != "")
                    ConstruirClausulaSQL("fVenta_V",
                                         "mayor:",
                                         TxtFechaInicio.Text,
                                         ref ClausulaSQLProductos);
                if(TxtFechaFin.Text != "")
                    ConstruirClausulaSQL("fVenta_V",
                                        "menor:",
                                        TxtFechaFin.Text,
                                        ref ClausulaSQLProductos);

                grdVentas.DataSource = n_Venta.getFiltrarProductoVendido(ClausulaSQLProductos);
                grdVentas.DataBind();       
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }    
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {

            N_Venta n_Venta = new N_Venta();
            cargarDropdownListPlataformas();
            cargarDropdownListGeneros();
            cargarDropdownListCategorias();
            TxtFechaInicio.Text = "";
            TxtFechaFin.Text = "";
            grdVentas.DataSource = n_Venta.getTabla();
            grdVentas.DataBind();      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estadisticas.aspx");
        }
    }
}