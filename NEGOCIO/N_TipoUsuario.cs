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
    public class N_TipoUsuario
    {
        public DataTable getTabla()
        {
            DaoTipoUsuario dao = new DaoTipoUsuario();
            return dao.getTablaTipoUsuario();
        }
        public DataSet getTipoUsuario()
        {

            DaoTipoUsuario dao = new DaoTipoUsuario();
            DataSet data = dao.getConsultaTipoUsuario();
            return data;
        }
    }
}
