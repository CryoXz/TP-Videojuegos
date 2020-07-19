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
            DataTable tabla = ds.ObtenerTabla("Marca", "Select * from Marcas where Estado_Marca_M = 1");
            return tabla;
        }

        public DataTable getBuscarNombre(String nombreBuscado)
        {
            DataTable tabla = ds.ObtenerTabla("MarcasBuscarNombre", "select * from marcas where Nombre_Marca_M like '%" + nombreBuscado + "%' and Estado_Marca_M = 1");
            return tabla;
        }

        public DataSet getConsultarMarca()
        {
            DataSet data = ds.Consultar("select * from marcas");
            return data;
        }
              

        private void ArmarParametrosMarcaEliminar(ref SqlCommand Comando, Marca marca)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_M", SqlDbType.Char, 4);
            SqlParametros.Value = marca.getCodigoMarca();
        }

        public int eliminarMarca(Marca marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcaEliminar(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarMarca");
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
                    
        }
        public int actualizarMarca(Marca marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcas(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpModificarMarca");
        }
        public int AltaMarca(Marca marca)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosMarcas(ref comando, marca);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SpAltaMarca");
        }

        /// agregados 19-07
        public bool getBuscarNombreMarca(String NombreMarca)
        {            
            DataTable tabla = new DataTable();
            tabla = ds.ObtenerTabla("Marcas", "select  Cod_Marca_M, Nombre_Marca_M, Nombre_Contacto_M, Direccion_Marca_M, Ciudad_Marca_M, EMail_Marca_M   from Marcas   where Nombre_Marca_M like '" + NombreMarca.ToString() + "' and Estado_Marca_M = 1");

            if (tabla.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getConsultaUltimaMarca()
        {
            return ds.ConsultarUsuario("SELECT COUNT(*) FROM Marcas");
        }

    }
}
