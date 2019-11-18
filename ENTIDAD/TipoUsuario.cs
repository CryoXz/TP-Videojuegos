using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class TipoUsuario
    {
        private int CodigoTipoUsuario;
        private String NombreTipoUsuario;

        public TipoUsuario()
        {

        }
        public int getCodigoTipoUsuario()
        {
            return CodigoTipoUsuario;
        }
        public void setCodigoTipoUsuario(int codigoTipoUsuario)
        {
            CodigoTipoUsuario = codigoTipoUsuario;
        }
        public String getNombreTipoUsuario()
        {
            return NombreTipoUsuario;
        }
        public void setNombreTipoUsuario(String nombreTipoUsuario)
        {
            NombreTipoUsuario = nombreTipoUsuario;
        }
    }
}
