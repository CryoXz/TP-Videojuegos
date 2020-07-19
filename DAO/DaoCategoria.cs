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

        public Categoria getCategoria(string id)
        {
            Categoria cat = new Categoria();
            DataTable tabla = ds.ObtenerTabla("Categorias", "Select * from categorias where Cod_Categoria_C=" + id);
            cat.setCodigoCategoria(tabla.Rows[0][0].ToString());
            cat.setNombreCategoria(tabla.Rows[0][1].ToString());

            return cat;
        }

        public DataTable getTablaCategorias()
        {
            //List<Categoria> lista = new List<Categoria>();
            DataTable tabla = ds.ObtenerTabla("Categoria", "Select * from Categorias");
            return tabla;
        }        

        private void ArmarParametrosCategoriaEliminar(ref SqlCommand Comando, Categoria cat)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Categoria_C", SqlDbType.Char, 4);
            SqlParametros.Value = cat.getCodigoCategoria();
        }

        public int eliminarCategoria(Categoria cat)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosCategoriaEliminar(ref comando, cat);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarCategoria");
        }

        private void ArmarParametrosCategorias(ref SqlCommand Comando, Categoria p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Categoria_C", SqlDbType.Char, 4);
            SqlParametros.Value = p.getCodigoCategoria();
            SqlParametros = Comando.Parameters.Add("@Nombre_Categoria_C", SqlDbType.NVarChar, 60);
            SqlParametros.Value = p.getNombreCategoria();
        }
        public int actualizarCategoria(Categoria p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosCategorias(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarCategoria");
        }
        public int AltaCategoria(Categoria x)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosCategorias(ref comando, x);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaCategorias");
        }

        public bool getBuscarNombreCategoria(String NombreCategoria)
        {
            Categoria cat = new Categoria();
            DataTable tabla = new DataTable();
            tabla = ds.ObtenerTabla("Categorias", "select  Cod_Categoria_C, Nombre_Categoria_C  from Categorias where  Nombre_Categoria_C like '" + NombreCategoria.ToString() + "' ");

            if (tabla.Rows.Count != 0)
            {
                return true;               
            }
            else
            {
                return false;
            }
        }

        public int getConsultaUltimaCategoria()
        {
            return ds.ConsultarUsuario("SELECT COUNT(*) FROM Categorias");
        }
    }
}
