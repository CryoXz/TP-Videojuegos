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

        public int GuardarUsuario(Usuario usuario)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            return daoUsuario.GuardarUsuario(usuario);

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

        public int getCantidadUsuarios()
        {
            DaoUsuario dao = new DaoUsuario();
            return dao.getCantidadUsuarios();
        }

    }
}
