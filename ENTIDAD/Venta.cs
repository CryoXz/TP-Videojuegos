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
        private float PrecioTotal;

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

        public DateTime getFechaVenta()
        {
            return FechaVenta;
        }
        public void setFechaVenta(DateTime fecha)
        {
            FechaVenta = fecha;
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
        public float getPrecioTotal()
        {
            return PrecioTotal;
        }
        public void setPrecioTotal(float precioTotal)
        {
            PrecioTotal = precioTotal;
        }
    }
}
