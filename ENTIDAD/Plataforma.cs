using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Plataforma
    {
        private string CodigoPlataforma;

        private String NombrePlataforma;

        public Plataforma()
        {

        }
        public string getCodigoPlataforma()
        {
            return CodigoPlataforma;
        }
        public void setCodigoPlataforma(string codigoPlataforma)
        {
            CodigoPlataforma = codigoPlataforma;
        }
        public String getNombrePlataforma()
        {
            return NombrePlataforma;
        }
        public void setNombrePlataforma(String nombrePlataforma)
        {
            NombrePlataforma = nombrePlataforma;
        }
    }
}
