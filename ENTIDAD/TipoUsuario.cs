using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class TipoUsuario
    {
        private String CodigoTipoUsuario;
        private String NombreTipoUsuario;

        public TipoUsuario()
        {

        }
        public String getCodigoTipoUsuario()
        {
            return CodigoTipoUsuario;
        }
        public void setCodigoTipoUsuario(String codigoTipoUsuario)
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
