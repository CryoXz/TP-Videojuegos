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
    public class DaoProvincia
    {
        AccesoDatos ds = new AccesoDatos();

        public Provincia getProvincia(string id)
        {
            Provincia Provincia = new Provincia();
            DataTable tabla = ds.ObtenerTabla("Provincias", "Select * from Provincias where Cod_Provincia_prov=" + id);
            Provincia.setCodigoProvincia(tabla.Rows[0][0].ToString());
            Provincia.setNombreProvincia(tabla.Rows[0][1].ToString());

            return Provincia;
        }

        public DataTable getTablaProvincias()
        {
            //List<Provincia> lista = new List<Provincia>();
            DataTable tabla = ds.ObtenerTabla("Provincia", "Select * from Provincias");
            return tabla;
        }


        public DataSet getConsultarProvincia()
        {
            DataSet data = ds.Consultar("select * from Provincias");
            return data;
        }
    }
}
