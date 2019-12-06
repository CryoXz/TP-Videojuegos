using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoProducto
    {
        AccesoDatos ds = new AccesoDatos();
        public DataTable getTablaProductos()
        {

            DataTable tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Stock_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = 'PF1'");
            return tabla;
        }

        public DataSet getConsultaProductos()
        {
            DataSet data = ds.Consultar("select * from Productos");
            return data;
        }
    }
}
