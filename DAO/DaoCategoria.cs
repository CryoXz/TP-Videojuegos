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
    public class DaoCategoria
    {
        AccesoDatos ds = new AccesoDatos();

        public Categoria getCategoria(int id)
        {
            Categoria cat = new Categoria();
            DataTable tabla = ds.ObtenerTabla("Categoria", "Select * from categorías where IdCategoría=" + id);
            cat.setCodigoCategoria(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            cat.setNombreCategoria(tabla.Rows[0][1].ToString());
         
            return cat;
        }

        public DataTable getTablaCategorias()
        {
            //List<Categoria> lista = new List<Categoria>();
            DataTable tabla = ds.ObtenerTabla("Categoria", "Select * from categorías");
            return tabla;
        }

        public int eliminarCategoria(Categoria cat)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosCategoriaEliminar(ref comando, cat);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarCategoria");
        }

        private void ArmarParametrosCategoriaEliminar(ref SqlCommand Comando, Categoria cat)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDCATEGORIA", SqlDbType.Int);
            SqlParametros.Value = cat.getNombreCategoria();
        }
    }
}
