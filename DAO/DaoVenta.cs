using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ENTIDAD;

namespace DAO
{
    public class DaoVenta
    {
        AccesoDatos ds = new AccesoDatos();
        public DaoVenta()
        {

        }

        public int GuardarVenta(Venta venta)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosVenta(ref comando, venta);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpAltaVentas");

        }
        private void ArmarParametrosVenta(ref SqlCommand Comando, Venta v) // funcion que arma los parametros del procedimiento almacenado
        {
            //definir parametro de acuerdo a la base de datos nueva
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Usuario_V", SqlDbType.Char, 4);
            SqlParametros.Value = v.getIdCodigoUsuario().getCodigoUsuario();
            SqlParametros = Comando.Parameters.Add("@Cod_TipoUsuario_V", SqlDbType.Char, 4);
            SqlParametros.Value = v.getIdCodigoUsuario().getIdTipoUsuario().getCodigoTipoUsuario();  // composicion se hace getIdTipoUsuario en usuario que devuelve un objeto tipoUsuario y de ahi se hace el getCodigoTIpoUsuario() para traer el codigo 
            SqlParametros = Comando.Parameters.Add("@fVenta_V", SqlDbType.SmallDateTime);
            SqlParametros.Value = v.getFechaVenta();
            SqlParametros = Comando.Parameters.Add("@Cod_TipoPago_V", SqlDbType.Char, 4);
            SqlParametros.Value = v.getIdTipoPago().getCodigoTIpo();

        }
        public DataTable getTablaVentas()
        {
            DataTable tabla = ds.ObtenerTabla("Ventas", "select Cod_Producto_DV, Nombre_Producto_PR, nombre_categoria_C, Nombre_Plataforma_P,  sum(cantidad_Producto_DV) as Vendidos,Nombre_Genero_G, estado_Producto_PR from ventas inner join DetalleVentas on cod_Venta_Dv = cod_Venta_V inner join Productos on Cod_Producto_PR = cod_Producto_DV inner join categorias on Cod_Categoria_C = Cod_Categoria_PR inner join PlataformaxProducto on Cod_Producto_PxP = Cod_Producto_PR inner join plataformas on Cod_Plataforma_PxP = cod_plataforma_P inner join Generos on Cod_Genero_G = Cod_Genero_PR group by Cod_Producto_DV, Nombre_Producto_PR, nombre_categoria_C, Nombre_Genero_G, estado_Producto_PR, Nombre_Plataforma_P");
            return tabla;
        }

        public DataTable getBuscarNombre(String nombreBuscado)
        {
            DataTable tabla = ds.ObtenerTabla("VentasBuscarNombre", "select Cod_Producto_DV, Nombre_Producto_PR, Nombre_categoria_C, Nombre_Plataforma_P, Nombre_Genero_G, sum(cantidad_Producto_DV) as Vendidos, estado_Producto_PR from ventas inner join DetalleVentas on cod_Venta_Dv = cod_Venta_V inner join Productos on Cod_Producto_PR = cod_Producto_DV inner join categorias on Cod_Categoria_C = Cod_Categoria_PR inner join PlataformaxProducto on Cod_Producto_PxP = Cod_Producto_PR inner join plataformas on cod_plataforma_P = Cod_Plataforma_PxP inner join Generos on Cod_Genero_G = Cod_Genero_PR where Nombre_Producto_PR like '%" + nombreBuscado.ToString() + "%' group by Cod_Producto_DV, Nombre_Producto_PR, nombre_categoria_C, Nombre_Plataforma_P, Nombre_Genero_G, estado_Producto_PR");
            return tabla;
        }
        public DataSet getConsultarPlataformas()
        {
            DataSet data = ds.Consultar("select * from Plataformas");
            return data;
        }

        public DataSet getConsultarGeneros()
        {
            DataSet data = ds.Consultar("select * from Generos");
            return data;
        }
        public DataSet getConsultarCategorias()
        {
            DataSet data = ds.Consultar("select * from Categorias");
            return data;
        }
        public DataSet getBuscarProductoFiltrado(String ClausulaSqlProductos)
        {
            DataSet data = ds.Consultar("select Cod_Producto_DV, Nombre_Producto_PR, Nombre_categoria_C, Nombre_Plataforma_P, Nombre_Genero_G, sum(cantidad_Producto_DV) as Vendidos, estado_Producto_PR from ventas inner join DetalleVentas on cod_Venta_Dv = cod_Venta_V inner join Productos on Cod_Producto_PR = cod_Producto_DV inner join categorias on Cod_Categoria_C = Cod_Categoria_PR inner join PlataformaxProducto on Cod_Producto_PxP = Cod_Producto_PR inner join plataformas on cod_plataforma_P = Cod_Plataforma_PxP inner join Generos on Cod_Genero_G = Cod_Genero_PR" + ClausulaSqlProductos + " group by Cod_Producto_DV, Nombre_Producto_PR, nombre_categoria_C, Nombre_Plataforma_P, Nombre_Genero_G, estado_Producto_PR");
            return data;
        }

        public int getCodVenta(Venta venta)
        {
            return ds.ConsultarUsuario("SELECT Cod_Venta_V FROM Ventas WHERE Cod_Usuario_V = '" + venta.getIdCodigoUsuario().getCodigoUsuario().ToString() + "' AND fVenta_V = '" + venta.getFechaVenta() + "'");
        }
    }
}
