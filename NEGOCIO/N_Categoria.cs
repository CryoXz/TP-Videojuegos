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
    public class N_Categoria
    {
        public DataTable getTabla()
        {
            DaoCategoria dao = new DaoCategoria();
            return dao.getTablaCategorias();
        }

        public Categoria get(string id)
        {
            DaoCategoria dao = new DaoCategoria();
            //Validar si existe esa categoria
            return dao.getCategoria(id);
        }

        public bool eliminarCategoria(string id)
        {
            //Validar id existente 
            DaoCategoria dao = new DaoCategoria();
            Categoria cat = new Categoria();
            cat.setCodigoCategoria(id);
            int op = dao.eliminarCategoria(cat);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool ActualizarCategoria(Categoria p)
        {

            DaoCategoria dao = new DaoCategoria();

            int FilasInsertadas = dao.actualizarCategoria(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
