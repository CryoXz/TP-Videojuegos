using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDAD;

namespace DAO
{
    public class DaoUsuario
    {
        AccesoDatos ds = new AccesoDatos();
        public DaoUsuario()
        {

        }
        // recibe por parametro el objeto usuario cargado
        public int GuardarUsuario(Usuario usuario)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosUsuario(ref comando, usuario); 
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaUsuario");

        }
        private void ArmarParametrosUsuario(ref SqlCommand Comando, Usuario u) // funcion que arma los parametros del procedimiento almacenado
        {
            //definir parametro de acuerdo a la base de datos nueva
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Usuario_U", SqlDbType.Char, 4);
            SqlParametros.Value = u.getCodigoUsuario();
            SqlParametros = Comando.Parameters.Add("@Cod_TipoUsuario_U", SqlDbType.Char, 4);
            SqlParametros.Value = u.getIdTipoUsuario().getCodigoTipoUsuario();  // composicion se hace getIdTipoUsuario en usuario que devuelve un objeto tipoUsuario y de ahi se hace el getCodigoTIpoUsuario() para traer el codigo 
            SqlParametros = Comando.Parameters.Add("@Nombre_Usuario_U", SqlDbType.VarChar, 60);
            SqlParametros.Value = u.getNombre();
            SqlParametros = Comando.Parameters.Add("@Apellido_Usuario_U", SqlDbType.VarChar, 60);
            SqlParametros.Value = u.getApellido();
            SqlParametros = Comando.Parameters.Add("@Nickname_Usuario_U", SqlDbType.VarChar, 100);
            SqlParametros.Value = u.getNickname();
            SqlParametros = Comando.Parameters.Add("@Contraseña_Usuario_U", SqlDbType.VarChar, 100);
            SqlParametros.Value = u.getContraseña();
            SqlParametros = Comando.Parameters.Add("@DNI_Usuario_U", SqlDbType.VarChar, 10);
            SqlParametros.Value = u.getDni();
           // SqlParametros = Comando.Parameters.Add("@fNacimiento_Usuario_U", SqlDbType.SmallDateTime);
           // SqlParametros.Value = u.getFechaNacimiento().ToString("yyyy-mm-dd");
            SqlParametros = Comando.Parameters.Add("@Telefono_Usuario_U", SqlDbType.VarChar, 15);
            SqlParametros.Value = u.getTelefono();
            SqlParametros = Comando.Parameters.Add("@EMail_Usuario_U", SqlDbType.VarChar, 100);
            SqlParametros.Value = u.getEmail();
            SqlParametros = Comando.Parameters.Add("@Direccion_Usuario_U", SqlDbType.VarChar, 100);
            SqlParametros.Value = u.getDireccion();
            SqlParametros = Comando.Parameters.Add("@Estado_Usuario_U", SqlDbType.Bit);
            SqlParametros.Value = u.getEstado();

        }

        public int getLogin(string username, string password)
        {

            return ds.ConsultarUsuario("SELECT COUNT(*) FROM Usuarios WHERE Usuarios.Nickname_Usuario_U = '" + username + "' AND Usuarios.Contraseña_Usuario_U = '" + password + "'");

        }

        public string getUserType(string username)
        {
            return ds.ConsultarTipoUsuario("SELECT Usuarios.Cod_TipoUsuario_U FROM Usuarios WHERE Usuarios.Nickname_Usuario_U = '" + username + "'");
        }
    }
}
