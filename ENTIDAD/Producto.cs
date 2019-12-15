using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Producto
    {
        private string CodigoProducto;
        Marca marca = new Marca();
        Categoria categoria = new Categoria();
        private string NombreProducto;
        private string Descripcion;
        //private imgen
        private int AnioFabricacion;
        // ver Estado
        private bool Estado;

        public Producto()
        {

        }
        public string getCodigoProducto()
        {
            return CodigoProducto;
        }
        public void setCodigoProducto(string codigoProducto)
        {
            CodigoProducto = codigoProducto;
        }
        public string getIdCodigoMarca()
        {
            return marca.getCodigoMarca();
        }
        public void setIdCodigoMarca(string idCodigoMarca)
        {
            marca.setCodigoMarca(idCodigoMarca);
        }
        public string getIdCodigoCategoria()
        {
            return categoria.getCodigoCategoria();
        }
        public void setIdCodigoCategoria(string idCodigoCategoria)
        {
            categoria.setCodigoCategoria(idCodigoCategoria);
        }
        public String getNombreProducto()
        {
            return NombreProducto;
        }
        public void setNombreProducto(string nombreProducto)
        {
            NombreProducto = nombreProducto;
        }
        public String getDescripcion()
        {
            return Descripcion;
        }
        public void setDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }
        //imagen
        public int getAnioFabricacion()
        {
            return AnioFabricacion;
        }
        public void setAnioFabricacion(int anioFabricacion)
        {
            AnioFabricacion = anioFabricacion;
        }
        public bool getEstado()
        {
            return Estado;
        }
        public void setEstado(bool estado)
        {
            Estado = estado;
        }
    }
}
