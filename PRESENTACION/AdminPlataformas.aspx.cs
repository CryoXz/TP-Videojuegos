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
    public partial class AdminPlataformas : System.Web.UI.Page
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
                N_Plataforma n_plat = new N_Plataforma();
                grdPlataformas.DataSource = n_plat.getTabla();
                grdPlataformas.DataBind();
            }

        protected void grdPlataformas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_codigoPlataforma = ((Label)grdPlataformas.Rows[e.RowIndex].FindControl("lbl_eit_codigoPlataforma")).Text;

            N_Plataforma n_plat = new N_Plataforma();
            n_plat.eliminarPlataforma(s_codigoPlataforma);
            cargarGridview();


        }

        protected void grdPlataformas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdPlataformas.EditIndex = e.NewEditIndex;
            cargarGridview();

        }

        protected void grdPlataformas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdPlataformas.EditIndex = -1;
            cargarGridview();
        }

        protected void grdPlataformas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_codigoPlataforma = ((Label)grdPlataformas.Rows[e.RowIndex].FindControl("lbl_eit_codigoPlataforma")).Text;
            String s_nombrePlataforma = ((TextBox)grdPlataformas.Rows[e.RowIndex].FindControl("txt_eit_nombrePlataforma")).Text;



            Plataforma plat = new Plataforma();
            plat.setCodigoPlataforma(s_codigoPlataforma);
            plat.setNombrePlataforma(s_nombrePlataforma);

            N_Plataforma n_Plataforma= new N_Plataforma();
            n_Plataforma.ActualizarPlataforma(plat);

            grdPlataformas.EditIndex = -1;
            cargarGridview();

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Plataforma p = new Plataforma();
 

            int N_filas = grdPlataformas.Rows.Count-1;
            string s_codigoPlataforma=((Label)grdPlataformas.Rows[N_filas].FindControl("lbl_eit_codigoPlataforma")).Text;
            char[] CharsToTream = { 'P', 'F' };
            int codNum=Convert.ToInt32( s_codigoPlataforma.TrimStart(CharsToTream))+1;

            p.setCodigoPlataforma ( "PF"+codNum) ;
            p.setNombrePlataforma(TxtNombre.Text);

          
            N_Plataforma n_Plataforma = new N_Plataforma();
            n_Plataforma.AltaPlataforma(p);

            grdPlataformas.EditIndex = -1;
            cargarGridview();

        }

        protected void grdPlataformas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPlataformas.PageIndex = e.NewPageIndex;
            cargarGridview();
        }
    }
}