using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Marca
    {
        private string CodigoMarca;
        private String NombreMarca;
        private String NombreContacto;
        private String Direccion;
        private String Ciudad;
        private string Telefono;
        private String Email;
        //chequear si estado como se representa en la base de datos que tiene bit
        private int Estado;

        public Marca()
        {

        }
        public string getCodigoMarca()
        {
            return CodigoMarca;
        }
        public void setCodigoMarca(string codigoMarca)
        {
            CodigoMarca = codigoMarca;
        }
        public String getNombreMarca()
        {
            return NombreMarca;
        }
        public void setNombreMarca(String nombreMarca)
        {
            NombreMarca = nombreMarca;
        }
        public String getNombreContacto()
        {
            return NombreContacto;
        }
        public void setNombreContacto(String nombreContacto)
        {
            NombreContacto = nombreContacto;
        }
        public String getDireccion()
        {
            return Direccion;
        }
        public void setDireccion(String direccion)
        {
            Direccion = direccion;
        }

        public String getCiudad()
        {
            return Ciudad;
        }
        public void setCiudad(String ciudad)
        {
            Ciudad = ciudad;
        }

        public string getTelefono()
        {
            return Telefono;
        }
        public void setTelefono(string telefono)
        {
            Telefono = telefono;
        }
        public String getEmail()
        {
            return Email;
        }
        public void setEmail(String email)
        {
            Email = email;
        }
        public int getEstado()
        {
            return Estado;
        }
        public void setEstado(int estado)
        {
            Estado = estado;
        }
    }
}

