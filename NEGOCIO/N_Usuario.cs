using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using ENTIDAD;

namespace NEGOCIO
{
    public class N_Usuario
    {
        public void GuardarUsuario(String tipoUsuario, String nombre, String apellido, String nickname, String contraseña, String dni, DateTime fechaNacimiento, String email, String telefono, String direccion)
        {
            TipoUsuario o_tipoUsuario = new TipoUsuario();
            o_tipoUsuario.setCodigoTipoUsuario(tipoUsuario);
            DaoUsuario daoUsuario = new DaoUsuario();
            Usuario usuarioNuevo = new Usuario();
            usuarioNuevo.setCodigoUsuario("u4");
            usuarioNuevo.setIdTipoUsuario(o_tipoUsuario);
            usuarioNuevo.setNombre(nombre);
            usuarioNuevo.setApellido(apellido);
            usuarioNuevo.setNickname(nickname);
            usuarioNuevo.SetContraseña(contraseña);
            usuarioNuevo.setDni(dni);
            usuarioNuevo.setFechaNacimiento(fechaNacimiento);
            usuarioNuevo.setEmail(email);
            usuarioNuevo.setTelefono(telefono);
            usuarioNuevo.setDireccion(direccion);
            usuarioNuevo.setEstado(true);

            daoUsuario.GuardarUsuario(usuarioNuevo);
        }

        public int resultadoUsuarios(string user, string pass)
        {

            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.getLogin(user, pass);
        }

        public string getUserType(string user)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.getUserType(user);
        }

    }
}
