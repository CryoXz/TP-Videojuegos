using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class DetalleVenta
    {
        private int IdDetalleVenta;
        private Venta IdCodigoVenta;
        private Producto IdCodigoProducto;
        private int CantidadVendida;
        private Decimal PrecioUnitario;

        public DetalleVenta()
        {
        }
        public int getIdDetalleVenta()
        {
            return IdDetalleVenta;
        }
        public void setDetalleVenta(int idDetalleVenta)
        {
            IdDetalleVenta = idDetalleVenta;
        }        
        public Venta getIdCodigoVenta()
        {
            return IdCodigoVenta;
        }
        public void setIdCodigoVenta(Venta idCodigoVenta)
        {
            IdCodigoVenta = idCodigoVenta;
        }
        public Producto getIdCodigoProducto()
        {
            return IdCodigoProducto;
        }
        public void setIdCodigoProducto(Producto idCodigoProducto)
        {
            IdCodigoProducto = idCodigoProducto;
        }
        public int getCantidadVendida()
        {
            return CantidadVendida;
        }
        public void setCantidadVendida(int cantidadVendida)
        {
            CantidadVendida = cantidadVendida;
        }
        public decimal getPrecioUnitario()
        {
            return PrecioUnitario;
        }
        public void setPrecioUnitario(Decimal precioUnitario)
        {
            PrecioUnitario = precioUnitario;
        }
    }
}
