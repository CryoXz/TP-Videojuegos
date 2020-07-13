using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTIDAD;
using DAO;

namespace DAO
{
    public class N_Localidad
    {
        public DataTable getTabla()
        {
            DaoLocalidad dao = new DaoLocalidad();
            return dao.getTablaLocalidades();
        }


        public Localidad get(string id)
        {
            DaoLocalidad dao = new DaoLocalidad();
            //Validar si existe esa Localidad
            return dao.getLocalidad(id);
        }

        public DataSet getLocalidads()
        {
            DaoLocalidad daoLocalidad = new DaoLocalidad();
            DataSet data = daoLocalidad.getConsultarLocalidad();
            return data;
        }
    }
}
