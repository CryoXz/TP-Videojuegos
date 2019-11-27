using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class Plataforma
    {
        private int CodigoPlataforma;
        private String NombrePlataforma;

        public Plataforma()
        {

        }
        public int getCodigoPlataforma()
        {
            return CodigoPlataforma;
        }
        public void setCodigoPlataforma(int codigoPlataforma)
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
