using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using ENTIDAD;

namespace NEGOCIO
{
    public class N_Venta
    {

        public int GuardarVenta(Venta venta)
        {
            DaoVenta dao = new DaoVenta();
            return dao.GuardarVenta(venta);
        }

        public DataTable getTabla()
        {
            DaoVenta dao = new DaoVenta();
            return dao.getTablaVentas();
        }

        public DataTable getTablaVentasPorUsuario(string codUser)
        {
            DaoVenta dao = new DaoVenta();
            return dao.getTablaVentasPorUsuario(codUser);
        }

        public DataTable getBuscarProductoVendido(String nombreBuscado)
        {
            DaoVenta daoVenta = new DaoVenta();
            return daoVenta.getBuscarNombre(nombreBuscado);
        }

        public DataSet getPlataformas()
        {
            DaoVenta daoVenta = new DaoVenta();
            DataSet data = daoVenta.getConsultarPlataformas(); // getConsultalataformas
            return data;
        }
        public DataSet getGeneros()
        {
            DaoVenta daoVenta = new DaoVenta();
            DataSet data = daoVenta.getConsultarGeneros(); // getConsultargenerosas
            return data;
        }
        public DataSet getCategorias()
        {
            DaoVenta daoVenta = new DaoVenta();
            DataSet data = daoVenta.getConsultarCategorias(); // getConsulcategorias
            return data;
        } 
        public DataSet getFiltrarProductoVendido(String n_ClausulaSqlProductos)
        {
            DaoVenta daoVenta = new DaoVenta();
            return daoVenta.getBuscarProductoFiltrado(n_ClausulaSqlProductos);
        }

        public int getCodVenta()
        {
            DaoVenta daoVenta = new DaoVenta();
            return daoVenta.getCodVenta();
        }

        public Double getVentasporMes(int mes) {
            DaoVenta dao = new DaoVenta();
            DateTime fechaactual = DateTime.Today;
            string año = fechaactual.Year.ToString(); 
            string fecha1="0";
            string fecha2="0";
            switch (mes) {
                case 1:
                    fecha1 =año+"0101";
                    fecha2 =año+"0131";
                    break;
                case 2:
                    fecha1 = año + "0201";
                    fecha2 = año + "0229";
                    break;
                case 3:
                    fecha1 = año + "0301";
                    fecha2 = año + "0331";
                    break;
                case 4:
                    fecha1 = año + "0401";
                    fecha2 = año + "0430";
                    break;
                case 5:
                    fecha1 = año + "0501";
                    fecha2 = año + "0531";
                    break;
                case 6:
                    fecha1 = año + "0601";
                    fecha2 = año + "0630";
                    break;
                case 7:
                    fecha1 = año + "0701";
                    fecha2 = año + "0731";
                    break;
                case 8:
                    fecha1 = año + "0801";
                    fecha2 = año + "0831";
                    break;
                case 9:
                    fecha1 = año + "0901";
                    fecha2 = año + "0930";
                    break;
                case 10:
                    fecha1 = año + "1001";
                    fecha2 = año + "1031";
                    break;
                case 11:
                    fecha1 = año + "1101";
                    fecha2 = año + "1130";
                    break;
                case 12:
                    fecha1 = año + "1201";
                    fecha2 = año + "1231";
                    break;
            }

            Double result = dao.getVentasPorMes(fecha1, fecha2);
            return result;
        }

    }
}
