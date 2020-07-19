using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NEGOCIO;
using ENTIDAD;
using System.Data;

namespace PRESENTACION
{
    public partial class WebForm1 : System.Web.UI.Page
    {
    
 
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }

        public string ObtenerDatos()
        {

            N_Venta n_Venta = new N_Venta();
            Double enero = n_Venta.getVentasporMes(1);
            Double feb = n_Venta.getVentasporMes(2);
            Double mar = n_Venta.getVentasporMes(3);
            Double abr = n_Venta.getVentasporMes(4);
            Double may = n_Venta.getVentasporMes(5);
            Double jun = n_Venta.getVentasporMes(6);
            Double jul = n_Venta.getVentasporMes(7);
            Double ago = n_Venta.getVentasporMes(8);
            Double sep = n_Venta.getVentasporMes(9);
            Double oct = n_Venta.getVentasporMes(10);
            Double nov = n_Venta.getVentasporMes(11);
            Double dic = n_Venta.getVentasporMes(12);


            string strDatos = "[['Mes', 'Ventas en pesos'], ['Enero', "+enero+"], ['Febrero', "+feb+"], ['Marzo', "+mar+"], ['Abril', "+abr+"], ['Mayo', "+may+"], ['Junio', "+jun+"], ['Julio', "+jul+"], ['Agosto', "+ago+"], ['Septiembre', "+sep+"], ['Octubre', "+oct+"], ['Noviembre', "+nov+"], ['Diciembre', "+dic+"]]";



            return strDatos;
        }



    }
}