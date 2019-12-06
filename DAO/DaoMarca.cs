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
    class DaoMarca
    {
        AccesoDatos ds = new AccesoDatos();

        public Marca getMarca(string id)
        {
            Marca m = new Marca();
            DataTable tabla = ds.ObtenerTabla("Marca", "Select * from Marcas where Cod_Marca_m=" + id);
            m.setCodigoMarca(tabla.Rows[0][0].ToString());
            m.setNombreMarca(tabla.Rows[0][1].ToString());

            return m;
        }

        public DataTable getTablaMarcas()
        {
            //List<Marca> lista = new List<Marca>();
            DataTable tabla = ds.ObtenerTabla("Marca", "Select * from Marcas");
            return tabla;
        }

        public int eliminarMarca(Marca m)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcaEliminar(ref comando, m);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarMarca");
        }

        private void ArmarParametrosMarcaEliminar(ref SqlCommand Comando, Marca m)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_C", SqlDbType.Char, 4);
            SqlParametros.Value = m.getNombreMarca();
        }
        private void ArmarParametrosMarcas(ref SqlCommand Comando, Marca m)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_C", SqlDbType.Char, 4);
            SqlParametros.Value = m.getCodigoMarca();
            SqlParametros = Comando.Parameters.Add("@Nombre_Marca_C", SqlDbType.NVarChar, 40);
            SqlParametros.Value = m.getNombreMarca();
            ;
        }
        public int actualizarMarca(Marca m)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcas(ref comando, m);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarMarca");
        }
    }
}
