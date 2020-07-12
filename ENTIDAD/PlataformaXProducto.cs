using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class PlataformaXProducto
    {
        Producto producto = new Producto();
        Plataforma plataforma = new Plataforma();

        private Producto IdProducto;
        private Plataforma IdPlataforma;
        private int Stock;
        private Decimal PrecioUnitario;
        private String imgURL;

        public PlataformaXProducto()
        {

        }
        public string getIdProducto()
        {
            return producto.getCodigoProducto();
        }
        public void setIdProducto(String idProducto)
        {
            producto.setCodigoProducto(idProducto);
        }
        public string getIdPlataforma()
        {
            return plataforma.getCodigoPlataforma();
        }
        public void setIdPlataforma(string idPlataforma)
        {
            plataforma.setCodigoPlataforma(idPlataforma);
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
        public string getimgURL()
        {
            return imgURL;
        }
        public void setimgURL(string img)
        {
            imgURL=img;
        }
    }
}
