using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Producto
    {
        private int CodigoProducto;
        private Marca IdCodigoMarca;
        private Categoria IdCodigoCategoria;
        private String NombreProducto;
        private String Descripcion;
        //private imgen
        private int AnioFabricacion;
        // ver Estado
        private bool Estado;

        public Producto()
        {

        }
        public int getCodigoProducto()
        {
            return CodigoProducto;
        }
        public void setCodigoProducto(int codigoProducto)
        {
            CodigoProducto = codigoProducto;
        }
        public Marca getIdCodigoMarca()
        {
            return IdCodigoMarca;
        }
        public void setIdCodigoMarca(Marca idCodigoMarca)
        {
            IdCodigoMarca = idCodigoMarca;
        }
        public Categoria getIdCodigoCategoria()
        {
            return IdCodigoCategoria;
        }
        public void setIdCodigoCategoria(Categoria idCodigoCategoria)
        {
            IdCodigoCategoria = idCodigoCategoria;
        }
        public String getNombreProducto()
        {
            return NombreProducto;
        }
        public void setNombreProducto(String nombreProducto)
        {
            NombreProducto = nombreProducto;
        }
        public String getDescripcion()
        {
            return Descripcion;
        }
        public void setDescripcion(String descripcion)
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
