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
        public DataTable getTabla()
        {
            
            DaoProducto dao = new DaoProducto();
            return dao.getTablaProductos();
        }

        public string getCodigoProdS(string imgUrl, string name)
        {
            DaoProducto daoProd = new DaoProducto();
            return daoProd.getCodigoS(imgUrl, name);
        }

        public string getCodigoPlat(string imgUrl, string name)
        {
            DaoProducto daoProd = new DaoProducto();
            return daoProd.getCodigoP(imgUrl, name);
        }

    }
}
