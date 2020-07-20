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
    public class DaoPlataforma
    {
        AccesoDatos ds = new AccesoDatos();

        public DaoPlataforma()
        {

        }

        public DataSet getConsultarPlataforma()
        {
            DataSet data = ds.Consultar("select * from plataformas where Estado_Plataforma_P = 1 ");
            return data;
        }
        public Plataforma getPlataforma(string id)
        {
            Plataforma cat = new Plataforma();
            DataTable tabla = ds.ObtenerTabla("Plataforma", "Select * from plataformas where Cod_Plataforma_P=" + id);
            cat.setCodigoPlataforma(tabla.Rows[0][0].ToString());
            cat.setNombrePlataforma(tabla.Rows[0][1].ToString());
            return cat;
        }

        public string getCodigoPlataformaConNombre(string name)
        {
            return ds.ConsultarCodigos("SELECT Cod_Plataforma_P FROM Plataformas WHERE Nombre_Plataforma_P = '" + name + "'");
        }

        public DataTable getTablaPlataformas()
        {
            //List<Plataforma> lista = new List<Plataforma>();
            DataTable tabla = ds.ObtenerTabla("Plataforma", "Select * from plataformas where Estado_Plataforma_P = 1");
            return tabla;
        }
        public DataTable getPlataformaDetalleVenta(string codVenta)
        {
            DataTable tabla = ds.ObtenerTabla("Plataforma", "SELECT Nombre_Plataforma_P FROM Plataformas INNER JOIN DetalleVentas ON Cod_Plataforma_P = Cod_Plataforma_DV WHERE Cod_Venta_DV = '" + codVenta + "'");
            return tabla;
        }          

        private void ArmarParametrosPlataformaEliminar(ref SqlCommand Comando, Plataforma cat)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Plataforma_P", SqlDbType.Char, 4);
            SqlParametros.Value = cat.getCodigoPlataforma();
        }

        public int eliminarPlataforma(Plataforma cat)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformaEliminar(ref comando, cat);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarPlataforma");
        }

        private void ArmarParametrosPlataformas(ref SqlCommand Comando, Plataforma p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Plataforma_p", SqlDbType.Char, 4);
            SqlParametros.Value = p.getCodigoPlataforma();
            SqlParametros = Comando.Parameters.Add("@Nombre_Plataforma_p", SqlDbType.NVarChar, 60);
            SqlParametros.Value = p.getNombrePlataforma();


        }
        public int actualizarPlataforma(Plataforma p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformas(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarPlataforma");
        }

        public int AltaPlataforma(Plataforma p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformas(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaPlataforma");
        }

        public bool getBuscarNombrePlataforma(String NombrePlataforma)
        {             
            DataTable tabla = new DataTable();
            tabla = ds.ObtenerTabla("Plataformas", "select  Cod_Plataforma_P, Nombre_Plataforma_P from Plataformas where Nombre_Plataforma_P like '" + NombrePlataforma.ToString() + "' and Estado_Plataforma_P = 1");
            if (tabla.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getConsultaUltimaPlataforma()
        {
            return ds.ConsultarUsuario("SELECT COUNT(*) FROM Plataformas");
        }

    }
}
