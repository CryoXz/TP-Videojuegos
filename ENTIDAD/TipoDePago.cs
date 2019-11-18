using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDAD
{
    public class TipoDePago
    {
        private int CodigoTipo;
        private String NombrePago;

        public TipoDePago()
        {

        }
        public int getCodigoTIpo()
        {
            return CodigoTipo;
        }
        public void setcodigoTipo(int codigoTipo)
        {
            CodigoTipo = codigoTipo;
        }
        public String getNombrePago()
        {
            return NombrePago;
        }
        public void setNombrePago(String nombrePago)
        {
            NombrePago = nombrePago;
        }
    }
}
