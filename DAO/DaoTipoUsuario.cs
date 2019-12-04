using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoTipoUsuario
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable getTablaTipoUsuario()
        {

            DataTable tabla = ds.ObtenerTabla("TipoUsuario", "select * from Tipo_Usuarios");
            return tabla;
        }

        public DataSet getConsultaTipoUsuario()
        {
            DataSet data = ds.Consultar("select * from Tipo_Usuarios");
            return data;
        }

    }
}
