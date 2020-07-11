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
    public class N_DetalleVenta
    {
        public int GuardarDetalleVenta(DetalleVenta detalleventa)
        {
            DaoDetalleVentas dao = new DaoDetalleVentas();
            return dao.GuardarDetalleVenta(detalleventa);
        }

        public DataTable getTablaDetalleVentasPrecioTotalPorCodUsuario(string codUser)
        {
            DaoDetalleVentas dao = new DaoDetalleVentas();
            return dao.getTablaDetalleVentasPrecioTotalPorCodUsuario(codUser);
        }
    }
}
