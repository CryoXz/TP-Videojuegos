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
            Producto p = new Producto();
            Plataforma plat = new Plataforma();

            DataTable tabla = ds.ObtenerTabla("PlataformaxProducto", "Select * from PlataformasxProducto where =" + id);
            p.setCodigoProducto(tabla.Rows[0][0].ToString());
            plat.setCodigoPlataforma(tabla.Rows[0][1].ToString());
            pxp.setIdProducto(p);
            pxp.setIdPlataforma(plat);
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


        private void ArmarParametrosPlataformaxProducto(ref SqlCommand Comando, PlataformaXProducto p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Producto_PxP", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdProducto();
            SqlParametros = Comando.Parameters.Add("@Cod_Plataforma_PxP", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdPlataforma();
            SqlParametros = Comando.Parameters.Add("@Stock_Producto_PxP", SqlDbType.Int);
            SqlParametros.Value = p.getIdPlataforma();
            SqlParametros = Comando.Parameters.Add("@PrecioUnitario_Producto_PxP", SqlDbType.Money);
            SqlParametros.Value = p.getIdPlataforma();
            SqlParametros = Comando.Parameters.Add("@Imagen_Producto_PxP", SqlDbType.VarChar, 100);
            SqlParametros.Value = p.getIdPlataforma();

        }
        public int actualizarPlataformaxProducto(PlataformaXProducto p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformaxProducto(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarPlataformaXProducto");
        }


    }
}
