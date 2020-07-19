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

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();
                N_Marca n_Marca = new N_Marca();

                string nombreMarca = txtNombreMarca.Text.Trim();
                string nombreContacto = txtNombreContacto.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string ciudad = txtCiudad.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (nombreMarca !="" && nombreContacto !="" && direccion !="" && ciudad !="" && telefono !="" && email !="")
                {
                    if(!n_Marca.getBuscarNombreMarca(nombreMarca))
                    {
                        int ultimaMarca = n_Marca.getConsultaUltimaMarca() + 1;
                        marca.setCodigoMarca("M" + ultimaMarca);                       
                        marca.setNombreMarca(nombreMarca);
                        marca.setNombreContacto(nombreContacto);
                        marca.setDireccion(direccion);
                        marca.setCiudad(ciudad);
                        marca.setTelefono(telefono);
                        marca.setEmail(email);

                        n_Marca.AltaMarca(marca);
                        Response.Write("<script>alert('Marca agregada con exito');</script>");
                        Response.Redirect("AdminMarca.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('La marca ya existe');</script>");
                    }                   
                }
                else
                {
                    Response.Write("<script>alert('Debe completar todos los campos');</script>");                     
                }                         

            }
            catch (Exception ex)
            {
                throw;
            }           
          
        }
    }
}