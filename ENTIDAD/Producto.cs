using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Producto
    {
        private String CodigoProducto;
        
        Marca marca = new Marca();
        Categoria categoria = new Categoria();
        Genero genero = new Genero();
        private String NombreProducto;
        private String Descripcion;
        //private imgen
        private String AnioFabricacion;
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
        public string getIdCodigoGenero()
        {
            return genero.getCodigoGenero();
        }
        public void setIdCodigoGenero(string idCodigoGenero)
        {
            genero.setCodigoGenero(idCodigoGenero);
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
        
        public String getAnioFabricacion()
        {
            return AnioFabricacion;
        }
        public void setAnioFabricacion(String anioFabricacion)
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

