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

        public DataTable getBuscarMarca(String nombreBuscado)
        {
            DaoMarca daoMarca = new DaoMarca();
            return daoMarca.getBuscarNombre(nombreBuscado);
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
            Marca marca = new Marca();
            marca.setCodigoMarca(id);
            int op = dao.eliminarMarca(marca);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool ActualizarMarca(Marca marca)
        {

            DaoMarca dao = new DaoMarca();

            int FilasInsertadas = dao.actualizarMarca(marca);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
        public bool AltaMarca(Marca marca)
        {
            DaoMarca dao = new DaoMarca();
            int FilasInsertadas = dao.AltaMarca(marca);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
    }
}
