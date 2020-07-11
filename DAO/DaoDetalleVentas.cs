using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDAD;

namespace DAO
{
    public class DaoDetalleVentas
    {

        AccesoDatos ds = new AccesoDatos();
        public DaoDetalleVentas()
        {

        }

        public int GuardarDetalleVenta(DetalleVenta detalleventa)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosDetalleVenta(ref comando, detalleventa);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaDetalleVentas");

        }
        private void ArmarParametrosDetalleVenta(ref SqlCommand Comando, DetalleVenta dv) // funcion que arma los parametros del procedimiento almacenado
        {
            //definir parametro de acuerdo a la base de datos nueva
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Venta_DV", SqlDbType.Int);
            SqlParametros.Value = dv.getIdCodigoVenta().getCodigoVenta();
            SqlParametros = Comando.Parameters.Add("@Cod_Producto_DV ", SqlDbType.Char, 4);
            SqlParametros.Value = dv.getIdCodigoProducto().getCodigoProducto(); 
            SqlParametros = Comando.Parameters.Add("@Cod_Plataforma_DV  ", SqlDbType.Char, 4);
            SqlParametros.Value = dv.getIdCodigoPlataforma().getCodigoPlataforma();
            SqlParametros = Comando.Parameters.Add("@Cantidad_Producto_DV", SqlDbType.Int);
            SqlParametros.Value = dv.getCantidadVendida();
            SqlParametros = Comando.Parameters.Add("@PrecioUnitario_Venta_DV ", SqlDbType.Money);
            SqlParametros.Value = dv.getPrecioUnitario();

        }

        public DataTable getTablaDetalleVentasPrecioTotalPorCodUsuario(string codUser)
        {
            DataTable tabla = ds.ObtenerTabla("PrecioTotal", "SELECT SUM(DetalleVentas.PrecioUnitario_Venta_DV*DetalleVentas.Cantidad_Producto_DV) AS PrecioTotal FROM DetalleVentas INNER JOIN Ventas ON Cod_Venta_DV = Cod_Venta_V WHERE Cod_Usuario_V = '" + codUser + "' GROUP BY Cod_Venta_V");
            return tabla;
        }

    }
}
