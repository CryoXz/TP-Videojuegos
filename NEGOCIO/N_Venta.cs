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

        public int getCodVenta(Venta venta)
        {
            DaoVenta daoVenta = new DaoVenta();
            return daoVenta.getCodVenta(venta);
        }



    }
}
