using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Genero
    {
        private string CodigoGenero;
        private string NombreGenero;

        public Genero()
        {

        }
        public string getCodigoGenero()
        {
            return CodigoGenero;
        }
        public void setCodigoGenero(string codigoGenero)
        {
            CodigoGenero = codigoGenero;
        }
        public string getNombreGenero()
        {
            return NombreGenero;
        }
        public void setNombreGenero(string nombreGenero)
        {
            NombreGenero = nombreGenero;
        }
    }
}
