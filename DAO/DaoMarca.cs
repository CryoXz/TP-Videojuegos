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

        public DaoMarca ()
        {

        }

        public Marca getMarca(string id)
        {
            Marca marca = new Marca();
            DataTable tabla = ds.ObtenerTabla("Marca", "Select * from Marcas where Cod_Marca_m=" + id);
            marca.setCodigoMarca(tabla.Rows[0][0].ToString());
            marca.setNombreMarca(tabla.Rows[0][1].ToString());

            return marca;
        }

        public DataTable getTablaMarcas()
        {
            //List<Marca> lista = new List<Marca>();
            DataTable tabla = ds.ObtenerTabla("Marca", "Select * from Marcas");
            return tabla;
        }

        public DataTable getBuscarNombre(String nombreBuscado)
        {
            DataTable tabla = ds.ObtenerTabla("MarcasBuscarNombre", "select * from marcas where Nombre_Marca_M like '%" + nombreBuscado + "%'");
            return tabla;
        }


        public int eliminarMarca(Marca marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcaEliminar(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarMarca");
        }

        private void ArmarParametrosMarcaEliminar(ref SqlCommand Comando, Marca marca)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_M", SqlDbType.Char, 4);
            SqlParametros.Value = marca.getCodigoMarca();
        }
        private void ArmarParametrosMarcas(ref SqlCommand Comando, Marca marca)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_M", SqlDbType.Char, 4);
            SqlParametros.Value = marca.getCodigoMarca();
            SqlParametros = Comando.Parameters.Add("@Nombre_Marca_M", SqlDbType.NVarChar, 60);
            SqlParametros.Value = marca.getNombreMarca();
            SqlParametros = Comando.Parameters.Add("@Nombre_Contacto_M", SqlDbType.NVarChar, 100);
            SqlParametros.Value = marca.getNombreContacto();
            SqlParametros = Comando.Parameters.Add("@Direccion_Marca_M", SqlDbType.NVarChar, 100);
            SqlParametros.Value = marca.getDireccion();
            SqlParametros = Comando.Parameters.Add("@Ciudad_Marca_M", SqlDbType.NVarChar, 100);
            SqlParametros.Value = marca.getCiudad();
            SqlParametros = Comando.Parameters.Add("@Telefono_Marca_M", SqlDbType.NVarChar, 15);
            SqlParametros.Value = marca.getTelefono();
            SqlParametros = Comando.Parameters.Add("@Email_Marca_M", SqlDbType.NVarChar, 200);
            SqlParametros.Value = marca.getEmail();
            SqlParametros = Comando.Parameters.Add("@Estado_Marca_M", SqlDbType.Bit);
            SqlParametros.Value = marca.getEstado();            
        }
        public int actualizarMarca(Marca marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcas(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarMarca");
        }
        public int AltaMarca(Marca marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcas(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaMarca");
        }

    }
}
