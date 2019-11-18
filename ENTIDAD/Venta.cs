using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Venta
    {
        private int CodigoVenta;
        private Usuario IdCodigoUsuario;
        private DateTime FechaVenta;
        private TipoDePago IdTipoPago;
        private Decimal PrecioTotal;

        public Venta()
        {

        }
        public int getCodigoVenta()
        {
            return CodigoVenta;
        }
        public void setCodigoVenta(int codigoVenta)
        {
            CodigoVenta = codigoVenta;
        }
        public Usuario getIdCodigoUsuario()
        {
            return IdCodigoUsuario;
        }
        public void setIdCodigoUsuario(Usuario idCodigoUsuario)
        {
            IdCodigoUsuario = idCodigoUsuario;
        }
        // ver fecha
        public TipoDePago getIdTipoPago()
        {
            return IdTipoPago;
        }
        public void setIdTipoPago(TipoDePago idTipoPago)
        {
            IdTipoPago = idTipoPago;
        }
        public Decimal getPrecioTotal()
        {
            return PrecioTotal;
        }
        public void setPrecioTotal(Decimal precioTotal)
        {
            PrecioTotal = precioTotal;
        }
    }
}
