﻿using System;
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

        public Plataforma getPlataforma(int id)
        {
            Plataforma cat = new Plataforma();
            DataTable tabla = ds.ObtenerTabla("Plataforma", "Select * from plataformas where IdCategoría=" + id);
            cat.setCodigoPlataforma(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            cat.setNombrePlataforma(tabla.Rows[0][1].ToString());
            return cat;
        }

        public DataTable getTablaPlataformas()
        {
            //List<Plataforma> lista = new List<Plataforma>();
            DataTable tabla = ds.ObtenerTabla("Plataforma", "Select * from plataformas");
            return tabla;
        }

        public int eliminarPlataforma(Plataforma cat)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformaEliminar(ref comando, cat);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarPlataforma");
        }

        private void ArmarParametrosPlataformaEliminar(ref SqlCommand Comando, Plataforma cat)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDPlataforma", SqlDbType.Int);
            SqlParametros.Value = cat.getCodigoPlataforma();
        }

        private void ArmarParametrosPlataformas(ref SqlCommand Comando, Plataforma p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@codigoPlataforma", SqlDbType.Int);
            SqlParametros.Value = p.getCodigoPlataforma();
            SqlParametros = Comando.Parameters.Add("@nombrePlataforma", SqlDbType.NVarChar, 40);
            SqlParametros.Value = p.getNombrePlataforma();
;
        }
        public int actualizarPlataforma(Plataforma cat)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosPlataformas(ref comando, cat);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spActualizarPlataforma");
        }

    }
}