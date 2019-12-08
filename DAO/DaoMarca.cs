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
    public class DaoMarca
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
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_M", SqlDbType.Char, 4);
            SqlParametros.Value = m.getNombreMarca();
        }
        private void ArmarParametrosMarcas(ref SqlCommand Comando, Marca m)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_M", SqlDbType.Char, 4);
            SqlParametros.Value = m.getCodigoMarca();
            SqlParametros = Comando.Parameters.Add("@Nombre_Marca_M", SqlDbType.NVarChar, 60);
            SqlParametros.Value = m.getNombreMarca();
            SqlParametros = Comando.Parameters.Add("@Nombre_Contacto_M", SqlDbType.NVarChar, 100);
            SqlParametros.Value = m.getNombreContacto();
            SqlParametros = Comando.Parameters.Add("@Direccion_Marca_M", SqlDbType.NVarChar, 100);
            SqlParametros.Value = m.getDireccion();
            SqlParametros = Comando.Parameters.Add("@Ciudad_Marca_M", SqlDbType.NVarChar, 100);
            SqlParametros.Value = m.getCiudad();
            SqlParametros = Comando.Parameters.Add("@Telefono_Marca_M", SqlDbType.NVarChar, 15);
            SqlParametros.Value = m.getTelefono();
            SqlParametros = Comando.Parameters.Add("@Email_Marca_M", SqlDbType.NVarChar, 200);
            SqlParametros.Value = m.getEmail();
            SqlParametros = Comando.Parameters.Add("@Estado_Marca_M", SqlDbType.Bit);
            SqlParametros.Value = m.getEstado();


            ;
        }
        public int actualizarMarca(Marca m)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcas(ref comando, m);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarMarca");
        }
        public int AltaMarca(Marca x)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcas(ref comando, x);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaMarca");
        }

    }
}
