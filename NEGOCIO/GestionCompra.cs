using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENTIDAD;
using DAO;

namespace NEGOCIO
{
    public class GestionCompra
    {
        public static DataTable CrearCarrito()
        {
            DataTable dt = new DataTable();
            //el DataTable de la cesta tendrá
            //tres campos: idLibro, titulo y precio
            DataColumn dc = new DataColumn("ImgUrl", System.Type.GetType("System.String"));
            dt.Columns.Add(dc);
            dc = new DataColumn("Nombre", System.Type.GetType("System.String"));
            dt.Columns.Add(dc);
            dc = new DataColumn("Plataforma", System.Type.GetType("System.String"));
            dt.Columns.Add(dc);
            dc = new DataColumn("Cantidad", System.Type.GetType("System.Int32"));
            dt.Columns.Add(dc);
            dc = new DataColumn("PrecioTotal", System.Type.GetType("System.Decimal"));
            dt.Columns.Add(dc);
            return dt;
        }
        /*public void EjecutarCompra(DataTable carrito, String usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            SqlConnection conexion = datos.ObtenerConexion();
            //inserta un registro en la tabla de ventas
            //por cada elemento del DataTable cesta
            for (int i = 0; i < carrito.Rows.Count; i++)
            {
                String sql = "Insert into ventas ";
                sql += "(idLibro,usuario,fecha) Values(";
                sql += carrito.Rows[i]["idLibro"];
                sql += ",'" + usuario + "','";
                sql += DateTime.Now.ToShortDateString() + "')";
                SqlCommand cmd = new SqlCommand(sql, conexion);
                cmd.ExecuteNonQuery();
            }
            conexion.Close();
        }*/
        public void AgregarCarrito(DataTable Carrito, string img, string name, string plat, int cant, float preciototal)
        {
            DataRow dr = Carrito.NewRow();
            dr["ImgUrl"] = img;
            dr["Nombre"] = name;
            dr["Plataforma"] = plat;
            dr["Cantidad"] = cant;
            dr["PrecioTotal"] = preciototal;
            Carrito.Rows.Add(dr);
        }
        public void EliminaCarrito(DataTable Carrito, int pos)
        {
            Carrito.Rows.RemoveAt(pos);
            if (Carrito.Rows.Count == 0)
                Carrito = null;
        }





    }
}
