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
    public class N_Marca
    {
        public DataTable getTabla()
        {
            DaoMarca dao = new DaoMarca();
            return dao.getTablaMarcas();
        }

        public Marca get(string id)
        {
            DaoMarca dao = new DaoMarca();
            //Validar si existe esa Marca
            return dao.getMarca(id);
        }

        public bool eliminarMarca(string id)
        {
            //Validar id existente 
            DaoMarca dao = new DaoMarca();
            Marca m = new Marca();
            m.setCodigoMarca(id);
            int op = dao.eliminarMarca(m);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool ActualizarMarca(Marca m)
        {

            DaoMarca dao = new DaoMarca();

            int FilasInsertadas = dao.actualizarMarca(m);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
        public bool AltaMarca(Marca m)
        {
            DaoMarca dao = new DaoMarca();
            int FilasInsertadas = dao.AltaMarca(m);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
