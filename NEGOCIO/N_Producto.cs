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

    }
}
