using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Usuario
    {
        private String CodigoUsuario;
        private TipoUsuario IdTipoUsuario;
        private String Nombre;
        private String Apellido;
        private String Nickname;
        private String Contraseña;
        private String Dni;
        private DateTime FechaNacimiento;
        private String Telefono;
        private String Email;
        private String Direccion;
        private bool Estado;
        private Provincia IdProvincia;
        private Localidad IdLocalidad;

        Provincia provincia = new Provincia();
        Localidad localidad = new Localidad();
        public Usuario()
        {
        }
        public String getCodigoUsuario()
        {
            return CodigoUsuario;
        }
        public void setCodigoUsuario(String codigoUsuario)
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
        public String getNickname()
        {
            return Nickname;
        }
        public void setNickname(String nickname)
        {
            Nickname = nickname;
        }
        public String getContraseña()
        {
            return Contraseña;
        }
        public void SetContraseña(String contraseña)
        {
            Contraseña = contraseña;
        }
        public String getDni()
        {
            return Dni;
        }
        public void setDni(String dni)
        {
            Dni = dni;
        }        
        public DateTime getFechaNacimiento()
        {
            return FechaNacimiento;
        }
        public void setFechaNacimiento(DateTime fechaNacimiento)
        {
            FechaNacimiento = fechaNacimiento;
        }
        public String getTelefono()
        {
            return Telefono;
        }
        public void setTelefono(String telefono)
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
        public String getDireccion()
        {
            return Direccion;
        }
        public void setDireccion(String direccion)
        {
            Direccion = direccion;

        }
        public bool getEstado()
        {
            return Estado;
        }
        public void setEstado(bool estado)
        {
            Estado = estado;
        }

        public string getIdProvincia()
        {
            return provincia.getCodigoProvincia();
        }
        public void setProvincia(string p)
        {
            provincia.setCodigoProvincia(p);
        }

        public string getIdLocalidad()
        {
            return localidad.getCodigoProvincia();
        }
        public void setLocalidad(string p)
        {
            localidad.setCodigoLocalidad(p);
        }
    }
}
