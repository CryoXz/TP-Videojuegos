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
    public class DaoLocalidad
    {
        AccesoDatos ds = new AccesoDatos();
        public Localidad getLocalidad(string id)
        {
            Localidad Localidad = new Localidad();
            DataTable tabla = ds.ObtenerTabla("Localidades", "Select * from Localidades where Cod_Localidad_loc=" + id);
            Localidad.setCodigoProvincia(tabla.Rows[0][0].ToString());
            Localidad.setCodigoLocalidad(tabla.Rows[0][1].ToString());
            Localidad.setNombreLocalidad(tabla.Rows[0][2].ToString());

            return Localidad;
        }

        public DataTable getTablaLocalidades()
        {
            //List<Localidad> lista = new List<Localidad>();
            DataTable tabla = ds.ObtenerTabla("Localidad", "Select * from Localidades");
            return tabla;
        }


        public DataSet getConsultarLocalidad()
        {
            DataSet data = ds.Consultar("select * from Localidades");
            return data;
        }
    }
}
