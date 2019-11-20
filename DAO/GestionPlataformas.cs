using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    class GestionPlataformas
    {
        public GestionPlataformas()
        {

        }
        AccesoDatos obj = new AccesoDatos();
        public DataTable ObtenerTodasLasPlataformas()
        {
            return obj.ObtenerTabla("Plataformas", "Select * from Plataformas");
        }

    }
}
