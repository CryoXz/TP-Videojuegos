using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;








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

            //protected void btnEliminar_Click(object sender, EventArgs e)
            //{
            //    N_Plataforma n_plat = new N_Plataforma();
            //    n_plat.eliminarCategoria(Convert.ToInt32(txtIdCat.Text));
            //    txtIdCat.Text = "";
            //    cargarGridview();
            //}
            public void cargarGridview()
            {
                N_Plataforma n_plat = new N_Plataforma();
                GrdPlataformas.DataSource = n_plat.getTabla();
                GrdPlataformas.DataBind();
            }

        protected void GrdPlataformas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

           int Id = Convert.ToInt32(GrdPlataformas.DataKeys[e.RowIndex].Value);


     

            N_Plataforma n_plat = new N_Plataforma();
            n_plat.eliminarPlataforma(Id);
            
            cargarGridview();

        }

        protected void GrdPlataformas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GrdPlataformas.EditIndex = e.NewEditIndex;
            cargarGridview();

        }

        protected void GrdPlataformas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GrdPlataformas.EditIndex = -1;
            cargarGridview();
        }

        protected void GrdPlataformas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}