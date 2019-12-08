using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAO
{
    class AccesoDatos
    {

        String rutaBDNeptuno =
          //"Data Source=DESKTOP-F5N5JLR\\SQL;Initial Catalog=TiendaVideojuegos;Integrated Security=True";
         // "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
         "Data Source=localhost\\sqlexpress;Initial Catalog=TiendaVideojuegos;Integrated Security=True";

        public AccesoDatos()
        {
            // TODO: Agregar aquí la lógica del constructor
        }

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDNeptuno);
            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String NombreTabla, String Sql)
        {
            DataSet ds = new DataSet();
            SqlConnection Conexion = ObtenerConexion();
            SqlDataAdapter adp = ObtenerAdaptador(Sql, Conexion);
            adp.Fill(ds, NombreTabla);
            Conexion.Close();
            return ds.Tables[NombreTabla];
        }

        public int EjecutarProcedimientoAlmacenado(SqlCommand Comando, String NombreSP)
        {
            int FilasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;
            FilasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return FilasCambiadas;
        }
        public DataSet Consultar(string ConsultaSQL)
        {
            SqlConnection cn = new SqlConnection(rutaBDNeptuno);//cambiar a DBtpVideojuego
            cn.Open();
            SqlCommand comando = new SqlCommand(ConsultaSQL, cn);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }

        public int ConsultarUsuario(string ConsultaSQL)
        {

            SqlConnection cn = new SqlConnection(rutaBDNeptuno);//cambiar a DBtpVideojuego
            cn.Open();
            SqlCommand comando = new SqlCommand(ConsultaSQL, cn);
            int count = Convert.ToInt32(comando.ExecuteScalar());
            cn.Close();
            return count;
        }

        public string ConsultarTipoUsuario(string ConsultaSQL)
        {
            
            SqlConnection cn = new SqlConnection(rutaBDNeptuno);//cambiar a DBtpVideojuego
            cn.Open();
            SqlCommand comando = new SqlCommand(ConsultaSQL, cn);
            string type = Convert.ToString(comando.ExecuteScalar());
            cn.Close();
   

            return type;
        }

        public string ConsultarCodigos(string ConsultaSQL)
        {

            SqlConnection cn = new SqlConnection(rutaBDNeptuno);//cambiar a DBtpVideojuego
            cn.Open();
            SqlCommand comando = new SqlCommand(ConsultaSQL, cn);
            string cod = Convert.ToString(comando.ExecuteScalar());
            cn.Close();


            return cod;
        }

    }
}
