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
   public class N_PlataformaXProducto
    {
        public DataTable getTabla()
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            return dao.getTablaPlataformaxProducto();
        }

        public PlataformaXProducto get(string id)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            //Validar si existe esa plataforma
            return dao.getPlataformaxProducto(id);
        }


        public bool ActualizarPlataformaxProducto(PlataformaXProducto p)
        {

            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();

            int FilasInsertadas = dao.actualizarPlataformaxProducto(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }


    }
}
