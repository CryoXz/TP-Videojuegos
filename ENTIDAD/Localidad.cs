using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Localidad
    {
        Provincia provincia = new Provincia();
        private string CodigoLocalidad;
        private Provincia CodigoProvincia;
        private string NombreLocalidad;
        public Localidad() { }

        public string getCodigolocalidad()
        {
            return CodigoLocalidad;
        }
        public void setCodigoLocalidad(string codigolocalidad)
        {
            CodigoLocalidad = codigolocalidad;
        }
        public string getCodigoProvincia()
        {
           return provincia.getCodigoProvincia();
        }
        public void setCodigoProvincia(string codigoprovincia)
        {
            provincia.setCodigoProvincia(codigoprovincia);
        }
        public string getNombrelocalidad()
        {
            return NombreLocalidad;
        }
        public void setNombreLocalidad(string nombrelocalidad)
        {
            NombreLocalidad = nombrelocalidad;
        }
    }
}
