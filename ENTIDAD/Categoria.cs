using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Categoria
    {
        private string CodigoCategoria;
        private String NombreCategoria;

        public Categoria()
        {

        }
        public string getCodigoCategoria()
        {
            return CodigoCategoria;
        }
        public void setCodigoCategoria(string codigoCategoria)
        {
            CodigoCategoria = codigoCategoria;
        }
        public String getNombreCategoria()
        {
            return NombreCategoria;
        }
        public void setNombreCategoria(String nombreCategoria)
        {
            NombreCategoria = nombreCategoria;
        }
    }
}
