using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using ENTIDAD;

namespace NEGOCIO
{
    public class N_Usuario
    {
        public DataTable getTabla()
        {
            DaoUsuario dao = new DaoUsuario();
            return dao.getTablaUsuarios();
        }
        public DataTable getTablaConFiltro(Char tipoUsuario)
        {
            DaoUsuario dao = new DaoUsuario();
            return dao.getTablaUsuariosConFiltro(tipoUsuario);
        }

        public DataTable getbuscarUsuario(String nombreBuscado)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.getBuscarNombre(nombreBuscado);
        }

        public int ModificarUsuario(Usuario usuario)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.ModificarUsuario(usuario);
        }

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

        public DataTable getUsuarioPorUsername(String username)
        {
            DaoUsuario dao = new DaoUsuario();
            return dao.getUsuarioPorUsername(username);
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

        public string getIDporUsername(string user)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.getIDporUsername(user);
        }

        public bool eliminarUsuario(string id)
        {

            DaoUsuario dao = new DaoUsuario();
            Usuario u = new Usuario();
            u.setCodigoUsuario(id);
            int op = dao.eliminarUsuario(u);
            if (op == 1)
                return true;
            else
                return false;
        }

    }
}
