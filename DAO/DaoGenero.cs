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
    public class DaoGenero
    {
        AccesoDatos ds = new AccesoDatos();

        public DaoGenero()
        {

        }

        public Genero getGenero(string id)
        {
            Genero gen = new Genero();
            DataTable tabla = ds.ObtenerTabla("Generos", "Select * from Generos where Generos.Cod_Genero_G = '" + id + "'");
            gen.setCodigoGenero(tabla.Rows[0][0].ToString());
            gen.setNombreGenero(tabla.Rows[0][1].ToString());

            return gen;
        }

        public DataTable getTablaGenero()
        {
            DataTable tabla = ds.ObtenerTabla("Generos", "Select * from Generos where Estado_Genero_G = 1 ");
            return tabla;
        }

        

        private void ArmarParametrosGeneroEliminar(ref SqlCommand Comando, Genero gen)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Genero_G", SqlDbType.Char, 4);
            SqlParametros.Value = gen.getCodigoGenero();         
        }

        public int eliminarGenero(Genero gen)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosGeneroEliminar(ref comando, gen);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarGenero");
        }

        private void ArmarParametrosGenero(ref SqlCommand Comando, Genero p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Genero_G", SqlDbType.Char, 4);
            SqlParametros.Value = p.getCodigoGenero();
            SqlParametros = Comando.Parameters.Add("@Nombre_Genero_G", SqlDbType.NVarChar, 60);
            SqlParametros.Value = p.getNombreGenero();            
        }

        public int actualizarGenero(Genero p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosGenero(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarGenero");
        }

        public int AltaGenero(Genero x)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosGenero(ref comando, x);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaGeneros");
        }

        public bool getBuscarNombreGenero(String NombreGenero)
        {            
            DataTable tabla = new DataTable();
            tabla = ds.ObtenerTabla("Genero", "select Cod_Genero_G, Nombre_Genero_G from Generos where Nombre_Genero_G like '" + NombreGenero.ToString() + "' and Estado_Genero_G = 1");
            if (tabla.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getConsultaUltimoGenero()
        {
            return ds.ConsultarUsuario("SELECT COUNT(*) FROM Generos");
        }
    }
}
