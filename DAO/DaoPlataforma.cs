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
    class GestionPlataformas
    {
        public GestionPlataformas()
        {

        }
        AccesoDatos obj = new AccesoDatos();
        public DataTable ObtenerTodasLasPlataformas()
        {
            return obj.ObtenerTabla("Plataformas", "Select * from Plataformas");
        }
        private void ArmarParametrosPlataformasEliminar(ref SqlCommand Comando, Plataforma plataforma)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CodigoPlataforma", SqlDbType.Int);
            SqlParametros.Value = plataforma.getCodigoPlataforma();/// esto nose si funciona tendria que ser plataforma.codigoplataforma
            /// creo que hay que cambiar algo en las clases de entidad
        }

        private void ArmarParametrosPlataformas(ref SqlCommand Comando, Plataforma plataforma)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@CodigoPlataforma", SqlDbType.Int);
            SqlParametros.Value = plataforma.getCodigoPlataforma();
            SqlParametros = Comando.Parameters.Add("@NombrePlataforma", SqlDbType.Int);
            SqlParametros.Value = plataforma.getNombrePlataforma();

        }

        public bool ActualizarPlataformas(Plataforma p)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosPlataformas(ref Comando, p);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spActualizarPlataforma");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }


        public bool EliminarPlataformas(Plataforma p)
        {
            SqlCommand Comando = new SqlCommand();
            ArmarParametrosPlataformasEliminar(ref Comando, p);
            AccesoDatos ad = new AccesoDatos();
            int FilasInsertadas = ad.EjecutarProcedimientoAlmacenado(Comando, "spEliminarPlataforma");
            if (FilasInsertadas == 1)
                return true;
            else
                return false;
        }


    }
}
