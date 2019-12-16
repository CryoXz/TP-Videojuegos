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
    public partial class Formulario_web11 : System.Web.UI.Page
    {
        int codNum;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.Session["codigoMarca"] != null)             

            codNum = Convert.ToInt32( this.Session["codigoMarca"].ToString()) ;
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();
                
                marca.setCodigoMarca("M" + codNum);
                marca.setNombreMarca(txtNombreMarca.Text);
                marca.setNombreContacto(txtNombreContacto.Text);
                marca.setDireccion(txtDireccion.Text);
                marca.setCiudad(txtCiudad.Text);
                marca.setTelefono(txtTelefono.Text);
                marca.setEmail(txtEmail.Text);
                marca.setEstado(1);

                N_Marca n_Marca = new N_Marca();
                n_Marca.AltaMarca(marca);

                Response.Redirect("AdminMarca.aspx");

            }
            catch (Exception ex)
            {

                throw;
            }
            
            //grdMarcas.EditIndex = -1;
            //cargarGridview();
        }
    }
}