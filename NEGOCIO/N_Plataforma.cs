using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DAO;

using System.Data;


namespace NEGOCIO
{
   public class N_Plataforma
    {
        public DataTable getTabla()
        {
            DaoPlataforma dao = new DaoPlataforma();
            return dao.getTablaPlataformas();
        }

        public Plataforma get(string id)
        {
            DaoPlataforma dao = new DaoPlataforma();
            //Validar si existe esa plataforma
            return dao.getPlataforma(id);
        }

        public bool eliminarPlataforma(string id)
        {
            //Validar id existente 
            DaoPlataforma dao = new DaoPlataforma();
            Plataforma p = new Plataforma();
            p.setCodigoPlataforma(id);
            int op = dao.eliminarPlataforma(p);
            if (op == 1)
                return true;
            else
                return false;
        }
        public bool ActualizarPlataforma(Plataforma p)
        {

            DaoPlataforma dao = new DaoPlataforma();

            int FilasInsertadas = dao.actualizarPlataforma(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
        public bool AltaPlataforma(Plataforma p)
        {
            DaoPlataforma dao = new DaoPlataforma();
            int FilasInsertadas = dao.AltaPlataforma(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

    }
}
