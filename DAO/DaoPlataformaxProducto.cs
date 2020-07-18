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
    public class DaoPlataformaxProducto
    {
        AccesoDatos ds = new AccesoDatos();

        public DaoPlataformaxProducto()
        {

        }

        public PlataformaXProducto getPlataformaxProducto(string id)
        {
            PlataformaXProducto pxp = new PlataformaXProducto();


            DataTable tabla = ds.ObtenerTabla("PlataformaxProducto", "Select * from PlataformasxProducto where =" + id);
            
            pxp.setIdProducto(tabla.Rows[0][0].ToString());
            pxp.setIdPlataforma(tabla.Rows[0][1].ToString());
            pxp.setStock((int)tabla.Rows[0][2]);
            pxp.setPrecioUnitario((decimal)tabla.Rows[0][3]);
            pxp.setimgURL(tabla.Rows[0][4].ToString());
  

            return pxp;
        }

        public DataTable getTablaPlataformaxProducto()
        {
            //List<Plataforma> lista = new List<Plataforma>();
            DataTable tabla = ds.ObtenerTabla("PlataformaxProducto", "Select * from PlataformaxProducto");
            return tabla;
        }

        public DataTable getImagenDetalleVenta(string codVenta)
        {
            DataTable tabla = ds.ObtenerTabla("Imagen", "SELECT Imagen_Producto_PxP FROM PlataformaxProducto INNER JOIN DetalleVentas ON Cod_Producto_PxP = Cod_Producto_DV WHERE Cod_Venta_DV = '" + codVenta + "'" );
            return tabla;
        }

        public string getStockProducto(string codProducto)
        {
            return ds.ConsultarCodigos("SELECT Stock_Producto_PxP FROM PlataformaxProducto WHERE Cod_Producto_PxP = '" + codProducto + "'");
        }

        public int modificarStockProducto(string codProd, string stock)
        {
            return ds.modificar("UPDATE PlataformaxProducto SET Stock_Producto_PxP = " + stock + " WHERE Cod_Producto_PxP = '"+ codProd + "'");
        }

        private void ArmarParametrosPlataformaxProducto(ref SqlCommand Comando, PlataformaXProducto p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Producto_PxP", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdProducto();
            SqlParametros = Comando.Parameters.Add("@Cod_Plataforma_PxP", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdPlataforma();
            SqlParametros = Comando.Parameters.Add("@Stock_Producto_PxP", SqlDbType.Int);
            SqlParametros.Value = p.getStock().ToString();
            SqlParametros = Comando.Parameters.Add("@PrecioUnitario_Producto_PxP", SqlDbType.Money);
            SqlParametros.Value = p.getPrecioUnitario().ToString();
            SqlParametros = Comando.Parameters.Add("@Imagen_Producto_PxP", SqlDbType.VarChar, 100);
            SqlParametros.Value = p.getimgURL();

        }
        public int actualizarPlataformaxProducto(PlataformaXProducto p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformaxProducto(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarPlataformaXProducto");
        }

        public int AltaPlataformaxProducto(PlataformaXProducto p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformaxProducto(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaPlataformaxProducto");
        }


        public DataTable getTablaProductosJuegos(string plat, string cate, int modo ,string sort)
        {
            /*
             modo = 0; ordenar por nombre
             modo = 1; ordenar por precio
             */
            
            DataTable tabla = null;

            if (String.IsNullOrEmpty(cate))
            {
                ////solo plataforma
                
                switch (modo)
                {
                    case 0:
                        tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plat + "' ORDER BY Productos.Nombre_Producto_PR " + sort);
                        return tabla;
                    case 1:
                        tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP, Productos.Nombre_Producto_PR, PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plat + "' ORDER BY PlataformaxProducto.PrecioUnitario_Producto_PxP " + sort);
                        return tabla;
                }

            }
            else if(String.IsNullOrEmpty(plat))
            {
                ////solo categoria
                switch (modo)
                {
                    case 0:
                        tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + cate + "' ORDER BY Productos.Nombre_Producto_PR " + sort);
                        return tabla;
                    case 1:
                        tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + cate + "' ORDER BY PlataformaxProducto.PrecioUnitario_Producto_PxP " + sort);
                        return tabla;
                }
            }
            else
            {
                ////categoria + plataforma
                switch (modo)
                {
                    case 0:
                        tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plat + "' AND Productos.Cod_Categoria_PR = '" + cate + "' ORDER BY Productos.Nombre_Producto_PR " + sort);
                        return tabla;
                    case 1:
                        tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = '" + plat + "' AND Productos.Cod_Categoria_PR = '" + cate + "' ORDER BY PlataformaxProducto.PrecioUnitario_Producto_PxP " + sort);
                        return tabla;
                }
            }

            return tabla;

        }


        public DataTable getTablaProductosJuegosBusqueda(string busqueda,string sort, int modo)
        {
            /*
             modo = 0; ordenar por nombre
             modo = 1; ordenar por precio
             */

            DataTable tabla = null;

            switch (modo)
            {
                case 0:
                    tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Nombre_Producto_PR LIKE '%" + busqueda + "%' ORDER BY Productos.Nombre_Producto_PR " + sort);
                    return tabla;
                case 1:
                    tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Nombre_Producto_PR LIKE '%" + busqueda + "%' ORDER BY PrecioUnitario_Producto_PxP " + sort);
                    return tabla;
            }

            return tabla;
        }

        public DataTable getTablaProductosJuegosO(string cate, string sort, int modo)
        {
            /*
             modo = 0; ordenar por nombre
             modo = 1; ordenar por precio
             */

            DataTable tabla = null;

            switch (modo)
            {
                case 0:
                    tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + cate + "' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF1' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF4' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF7' ORDER BY Productos.Nombre_Producto_PR " + sort);
                    return tabla;
                case 1:
                    tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Imagen_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE Productos.Cod_Categoria_PR = '" + cate + "' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF1' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF4' AND PlataformaxProducto.Cod_Plataforma_PxP != 'PF7' ORDER BY PrecioUnitario_Producto_PxP " + sort);
                    return tabla;
            }

            return tabla;
        }

    }
}
