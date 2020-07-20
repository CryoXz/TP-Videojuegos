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
    public class N_Genero
    {
        public DataTable getTabla()
        {
            DaoGenero dao = new DaoGenero();
            return dao.getTablaGenero();
        }

        public Genero get(string id)
        {
            DaoGenero dao = new DaoGenero();
            //Validar si existe esa categoria
            return dao.getGenero(id);
        }

        public bool eliminarGenero(string id)
        {
            //Validar id existente 
            DaoGenero dao = new DaoGenero();
            Genero gen = new Genero();
            gen.setCodigoGenero(id);
            int op = dao.eliminarGenero(gen);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool ActualizarGenero(Genero p)
        {

            DaoGenero dao = new DaoGenero();

            int FilasInsertadas = dao.actualizarGenero(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

        public bool AltaGenero(Genero genero)
        {
            DaoGenero dao = new DaoGenero();
            int FilasInsertadas = dao.AltaGenero(genero);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

        public bool getBuscarNombreGenero(String nombreGenero)
        {
            DaoGenero dao = new DaoGenero();
            return dao.getBuscarNombreGenero(nombreGenero);
        }

        public int getConsultaUltimoGenero()
        {
            DaoGenero dao = new DaoGenero();
            return dao.getConsultaUltimoGenero();
        }
    }
}
