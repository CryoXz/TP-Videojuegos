using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class DetalleVenta
    {
        private Venta IdCodigoVenta;
        private Producto IdCodigoProducto;
        private Plataforma IdCodigoPlataforma;
        private int CantidadVendida;
        private float PrecioUnitario;

        public DetalleVenta()
        {
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
        public Plataforma getIdCodigoPlataforma()
        {
            return IdCodigoPlataforma;
        }
        public void setIdCodigoPlataforma(Plataforma codplataforma)
        {
            IdCodigoPlataforma = codplataforma;
        }
        public int getCantidadVendida()
        {
            return CantidadVendida;
        }
        public void setCantidadVendida(int cantidadVendida)
        {
            CantidadVendida = cantidadVendida;
        }
        public float getPrecioUnitario()
        {
            return PrecioUnitario;
        }
        public void setPrecioUnitario(float precioUnitario)
        {
            PrecioUnitario = precioUnitario;
        }
    }
}
