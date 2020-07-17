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
    public class N_Producto
    {
        //public DataTable getTabla()
        //{

        //    DaoProducto dao = new DaoProducto();
        //    return dao.getTablaProductos();
        //}

        public string getCodigoProdS(string imgUrl, string name)
        {
            DaoProducto daoProd = new DaoProducto();
            return daoProd.getCodigoS(imgUrl, name);
        }
        public int getConsultaUltimoProducto()
        {
            DaoProducto daoProd = new DaoProducto();
            return daoProd.getConsultaUltimoProducto();
        }

        public string getCodigoPlat(string imgUrl, string name)
        {
            DaoProducto daoProd = new DaoProducto();
            return daoProd.getCodigoP(imgUrl, name);
        }

        public DataTable getTablaConPrecioyStock()
        {

            DaoProducto dao = new DaoProducto();
            return dao.getTablaProductosConPrecioyStock();
        }

        public DataTable getNombreProductoDetalleVenta(string codVenta)
        {
            DaoProducto dao = new DaoProducto();
            return dao.getNombreProductoDetalleVenta(codVenta);
        }

        public Producto get(string id)
        {
            DaoProducto dao = new DaoProducto();
            //Validar si existe esa Producto
            return dao.getProducto(id);
        }

        public bool eliminarProducto(string id)
        {
            //Validar id existente 
            DaoProducto dao = new DaoProducto();
            Producto p = new Producto();
            p.setCodigoProducto(id);
            int op = dao.eliminarProducto(p);
            if (op == 1)
                return true;
            else
                return false;
        }
        public bool ActualizarProducto(Producto p)
        {

            DaoProducto dao = new DaoProducto();

            int FilasInsertadas = dao.actualizarProducto(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }
        public bool AltaProducto(Producto p)
        {
            DaoProducto dao = new DaoProducto();
            int FilasInsertadas = dao.AltaProducto(p);
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }

        public string getCodigoProductoConNombre(string name)
        {
            DaoProducto dao = new DaoProducto();
            return dao.getCodigoProductoConNombre(name);
        }

        public DataTable getTablaProductoFoto(string codProd, string codPlat)
        {
            DaoProducto dao = new DaoProducto();
            return dao.getTablaProductoFoto(codProd, codPlat);
        }

        public DataTable getTablaProductoDatos(string codProd, string codPlat)
        {
            DaoProducto dao = new DaoProducto();
            return dao.getTablaProductoDatos(codProd, codPlat);
        }
    }
}