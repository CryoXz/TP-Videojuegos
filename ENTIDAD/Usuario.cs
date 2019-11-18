using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario
    {
        private int CodigoUsuario;
        private TipoUsuario IdTipoUsuario;
        private String Nombre;
        private String Apellido;
        private String NombreUsuario;
        private String Contraseña;
        private int Dni;
        private DateTime FechaNacimiento;
        private int Telefono;
        private String Email;        
        // Direccion direcion 
        //ver estado
        private bool Estado;

        public Usuario()
        {
        }
        public int getCodigoUsuario()
        {
            return CodigoUsuario;
        }
        public void setCodigoUauario(int codigoUsuario)
        {
            CodigoUsuario = codigoUsuario;
        }       
        public TipoUsuario getIdTipoUsuario()
        {
            return IdTipoUsuario;
        }
        public void setIdTipoUsuario(TipoUsuario idTipoUsuario)
        {
            IdTipoUsuario = idTipoUsuario;
        }
        public String getNombre()
        {
            return Nombre;
        }
        public void setNombre(String nombre)
        {
            Nombre = nombre;
        }
        public String getApellido()
        {
            return Apellido;
        }
        public void setApellido(String apellido)
        {
            Apellido = apellido;
        }
        public String getNombreUsuario()
        {
            return NombreUsuario;
        }
        public void setNombreUsuario(String nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
        }
        public String getContraseña()
        {
            return Contraseña;
        }
        public void SetContraseña(String contraseña)
        {
            Contraseña = contraseña;
        }
        public int getDni()
        {
            return Dni;
        }
        public void setDni(int dni)
        {
            Dni = dni;
        }
        // ver date time
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
        public bool getEstado()
        {
            return Estado;
        }
        public void setEstado(bool estado)
        {
            Estado = estado;
        }
    }
}
