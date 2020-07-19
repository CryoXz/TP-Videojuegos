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
            String s_codigoPlataforma = ((Label)grdPlataformas.Rows[e.RowIndex].FindControl("lbl_eit_codigoPlataforma")).Text.Trim();

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
            String s_codigoPlataforma = ((Label)grdPlataformas.Rows[e.RowIndex].FindControl("lbl_eit_codigoPlataforma")).Text.Trim();
            String s_nombrePlataforma = ((TextBox)grdPlataformas.Rows[e.RowIndex].FindControl("txt_eit_nombrePlataforma")).Text.Trim();



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
            Plataforma plataforma = new Plataforma();
            N_Plataforma n_Plataforma = new N_Plataforma();

            string nombrePlataforma = TxtNombrePlataforma.Text.Trim();
            if(nombrePlataforma != "")
            {
                if(!n_Plataforma.getBuscarNombrePlataforma(nombrePlataforma))
                {
                    int ultimaPlataforma = n_Plataforma.getConsultaUltimaPlataforma() + 1;
                    plataforma.setCodigoPlataforma("PF" + ultimaPlataforma);
                    plataforma.setNombrePlataforma(nombrePlataforma);
                    n_Plataforma.AltaPlataforma(plataforma);
                    Response.Write("<script>alert('Plataforma agregada con exito');</script>");
                    TxtNombrePlataforma.Text = "";
                    grdPlataformas.EditIndex = -1;
                    cargarGridview();
                }
                else
                {
                    Response.Write("<script>alert('La plataforma ya existe');</script>");
                    TxtNombrePlataforma.Text = "";
                    grdPlataformas.EditIndex = -1;
                    cargarGridview();
                }
            }
            else
            {
                Response.Write("<script>alert('Debe ingresar una Plataforma');</script>");
                TxtNombrePlataforma.Text = "";
                grdPlataformas.EditIndex = -1;
                cargarGridview();
            }
        }

        protected void grdPlataformas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPlataformas.PageIndex = e.NewPageIndex;
            cargarGridview();
        }
    }
}