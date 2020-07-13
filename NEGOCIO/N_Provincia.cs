using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENTIDAD;
using DAO;


namespace NEGOCIO
{
    public class N_Provincia
    {
        public DataTable getTabla()
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincias();
        }


        public Provincia get(string id)
        {
            DaoProvincia dao = new DaoProvincia();
            //Validar si existe esa Provincia
            return dao.getProvincia(id);
        }

        public DataSet getProvincias()
        {
            DaoProvincia daoProvincia = new DaoProvincia();
            DataSet data = daoProvincia.getConsultarProvincia();
            return data;
        }
    }
}
