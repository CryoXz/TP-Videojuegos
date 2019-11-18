using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class PlataformaXProducto
    {
        private Producto IdProducto;
        private Plataforma IdPlataforma;
        private int Stock;
        private Decimal PrecioUnitario;

        public PlataformaXProducto()
        {

        }
        public Producto getIdProducto()
        {
            return IdProducto;
        }
        public void setIdProducto(Producto idProducto)
        {
            IdProducto = idProducto;
        }
        public Plataforma getIdPlataforma()
        {
            return IdPlataforma;
        }
        public void setIdPlataforma(Plataforma idPlataforma)
        {
            IdPlataforma = idPlataforma;
        }
        public int getStock()
        {
            return Stock;
        }
        public void setStock(int stock)
        {
            Stock = stock;
        }
        public Decimal getPrecioUnitario()
        {
            return PrecioUnitario;
        }
        public void setPrecioUnitario(Decimal precioUnitario)
        {
            PrecioUnitario = precioUnitario;
        }
    }
}
