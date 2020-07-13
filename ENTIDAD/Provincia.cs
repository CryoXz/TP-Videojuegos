using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Provincia
    {
        private string CodigoProvincia;
        private string NombreProvincia;

        public Provincia() { }
        public string getCodigoProvincia()
        {
            return CodigoProvincia;
        }
        public void setCodigoProvincia(string codigoprovincia)
        {
            CodigoProvincia = codigoprovincia;
        }
        public string getNombreProvincia()
        {
            return NombreProvincia;
        }
        public void setNombreProvincia(string nombreprovincia)
        {
            NombreProvincia = nombreprovincia;
        }

    }
}
