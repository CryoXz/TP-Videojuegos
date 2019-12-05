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
        //recibe por parametros desde RegistroUsuario.aspx los parametros en tipo texto.
        public void GuardarUsuario(String tipoUsuario, String nombre, String apellido, String nickname, String contraseña, String dni, /*DateTime fechaNacimiento,*/ String email, String telefono, String direccion)
        {
            
            TipoUsuario o_tipoUsuario = new TipoUsuario(); // se crea un objeto tipo usuario
            o_tipoUsuario.setCodigoTipoUsuario(tipoUsuario);// en el objeto o_tipousuario se carga en setCodigoTipoUsuario el string tipoUsuario
            DaoUsuario daoUsuario = new DaoUsuario(); //se crea un objeto DaoUsuario
            Usuario usuarioNuevo = new Usuario(); //se crea un objeto Usuario

            //se carga el objeto usuario con los datos recibidos por parametros y los objetos creados
            usuarioNuevo.setCodigoUsuario("u4"); 
            usuarioNuevo.setIdTipoUsuario(o_tipoUsuario); // se guarda el objeto o_TipoUsuario(que tiene el Cod_TipoUsuario_U)
            usuarioNuevo.setNombre(nombre);
            usuarioNuevo.setApellido(apellido);
            usuarioNuevo.setNickname(nickname);
            usuarioNuevo.SetContraseña(contraseña);
            usuarioNuevo.setDni(dni);
           //usuarioNuevo.setFechaNacimiento(fechaNacimiento);
            usuarioNuevo.setEmail(email);
            usuarioNuevo.setTelefono(telefono);
            usuarioNuevo.setDireccion(direccion);
            usuarioNuevo.setEstado(true);

            daoUsuario.GuardarUsuario(usuarioNuevo); // ahora daoUsuario llama al metodo GuardarUsuario y se le envia el objeto cargado.
        }

    }
}
