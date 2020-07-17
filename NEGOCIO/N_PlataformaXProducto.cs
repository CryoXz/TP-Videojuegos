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

        public DataTable getImagenDetalleVenta(string codVenta)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            return dao.getImagenDetalleVenta(codVenta);
        }

        public PlataformaXProducto get(string id)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            //Validar si existe esa plataforma
            return dao.getPlataformaxProducto(id);
        }

        public string getStockProducto(string codProducto)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            return dao.getStockProducto(codProducto);
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
        public bool AltaPlataformaxProducto(PlataformaXProducto p)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            int FilasInsertadas = dao.AltaPlataformaxProducto(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

        public int modificarStockProducto(string codProd, string stock)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            return dao.modificarStockProducto(codProd, stock);
        }

        public DataTable getTablaProductosJuegos(string plat, string cate, int modo, string sort)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            return dao.getTablaProductosJuegos(plat, cate, modo, sort);
        }

        public DataTable getTablaProductosJuegosBusqueda(string busqueda, string sort, int modo)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            return dao.getTablaProductosJuegosBusqueda(busqueda, sort, modo);
        }

        public DataTable getTablaProductosJuegosO(string cate, string sort, int modo)
        {
            DaoPlataformaxProducto dao = new DaoPlataformaxProducto();
            return dao.getTablaProductosJuegosO(cate, sort, modo);
        }

    }
}
