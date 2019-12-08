using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using ENTIDAD;

namespace PRESENTACION
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGridview();

            }
        }
        public void cargarGridview()
        {
            N_Marca n_plat = new N_Marca();
            grdMarcas.DataSource = n_plat.getTabla();
            grdMarcas.DataBind();

        }

        protected void grdMarcas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigoMarca = ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lbl_it_codigo")).Text;

            N_Marca n_plat = new N_Marca();
            n_plat.eliminarMarca(s_codigoMarca);
            cargarGridview();


        }

        protected void grdMarcas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdMarcas.EditIndex = e.NewEditIndex;
            cargarGridview();

        }

        protected void grdMarcas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdMarcas.EditIndex = -1;
            cargarGridview();
        }

        protected void grdMarcas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_codigoMarca = ((Label)grdMarcas.Rows[e.RowIndex].FindControl("lbl_eit_codigo")).Text;
            String s_nombreMarca = ((TextBox)grdMarcas.Rows[e.RowIndex].FindControl("txt_eit_nombre")).Text;



            Marca plat = new Marca();
            plat.setCodigoMarca(s_codigoMarca);
            plat.setNombreMarca(s_nombreMarca);

            N_Marca n_Marca = new N_Marca();
            n_Marca.ActualizarMarca(plat);

            grdMarcas.EditIndex = -1;
            cargarGridview();

        }

        protected void grdMarcas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdMarcas.PageIndex = e.NewPageIndex;
            cargarGridview();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreMarca.Text.Length != 0)
            {
                // NO ME SALEEEE
              
                //DataTable dt = new DataTable();
                //using (SqlConnection conn = new SqlConnection("Data Source=LABINF201B13;Initial Catalog=REGISTRO;Integrated Security=True"))
                //{

                //    SqlCommand cmd = new SqlCommand("BUSCARCODIGO", conn);
                //    cmd.CommandType = CommandType.StoredProcedure;

                //    cmd.Parameters.AddWithValue("@codigo", this.TEXTO1.Text);

                //    SqlDataAdapter da = new SqlDataAdapter(cmd);
                //    da.Fill(dt);
                //}

                //GridView1.DataSource = dt;
                //GridView1.DataBind();
                //Label3.Text = "BUSQUEDA REALIZADA CON EXITO";
            }
        }
    }
}