using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Marca
    {
        private int CodigoMarca;
        private String NombreMarca;
        private String NombreContacto;
        // private String direccion;
        // private String 
        private int Telefono;
        private String Email;
        //chequear si estado como se representa en la base de datos que tiene bit
        private int Estado;

        public Marca()
        {

        }
        public int getCodigoMarca()
        {
            return CodigoMarca;
        }
        public void setCodigoMarca(int codigoMarca)
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

        //hacer direccion
        public int getTelefono()
        {
            return Telefono;
        }
        public void setTelefono(int telefono)
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

