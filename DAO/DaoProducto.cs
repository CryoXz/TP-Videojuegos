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
    public class DaoProducto
    {
        AccesoDatos ds = new AccesoDatos();
        //public DataTable getTablaProductos()
        //{

        //    DataTable tabla = ds.ObtenerTabla("Productos", "SELECT PlataformaxProducto.Stock_Producto_PxP,Productos.Nombre_Producto_PR,PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP WHERE PlataformaxProducto.Cod_Plataforma_PxP = 'PF1'");
        //    return tabla;
        //}
        public DataTable getTablaProductosConPrecioyStock()
        {

            DataTable tabla = ds.ObtenerTabla("Productos", "SELECT Productos.Cod_Producto_PR as Codigo, Productos.Nombre_Producto_PR as Nombre, Productos.Descripcion_Producto_PR as Descripcion, Marcas.Cod_Marca_M as CodMarca, Marcas.Nombre_Marca_M as NombreMarca, Categorias.Cod_Categoria_C as CodCategoria, Categorias.Nombre_Categoria_C as NombreCategoria, Generos.Cod_Genero_G as CodGenero, Generos.Nombre_Genero_G as NombreGenero, " +
            "Productos.fPublicacion_Producto_PR as FPublicacion, Productos.Estado_Producto_PR as Estado, PlataformaxProducto.Cod_Plataforma_PxP as CodPlataforma, PlataformaxProducto.Stock_Producto_PxP as Stock, PlataformaxProducto.PrecioUnitario_Producto_PxP as PrecioUnitario, PlataformaxProducto.Imagen_Producto_PxP as imgURL, Plataformas.Nombre_Plataforma_P as NombrePlataforma " +
            "FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP inner join Plataformas on Cod_Plataforma_P = Cod_Plataforma_PxP "+
            "inner join Marcas on Cod_Marca_M = Cod_Marca_PR inner join Categorias on Cod_Categoria_C = Cod_Categoria_PR inner join Generos on Cod_Genero_G = Cod_Genero_PR");
            return tabla;
        }


        public DataSet getConsultaProductos()
        {
            DataSet data = ds.Consultar("select * from Productos");
            return data;
        }

        public string getCodigoS(string imgUrl, string name)
        {
            return ds.ConsultarCodigos("SELECT PlataformaxProducto.Cod_Producto_PxP FROM PlataformaxProducto INNER JOIN Productos ON PlataformaxProducto.Cod_Producto_PxP = Productos.Cod_Producto_PR WHERE PlataformaxProducto.Imagen_Producto_PxP = '" + imgUrl + "' AND Productos.Nombre_Producto_PR = '" + name + "'");
        }

        public string getCodigoProductoConNombre(string name)
        {
            return ds.ConsultarCodigos("SELECT Cod_Producto_PR FROM Productos WHERE Nombre_Producto_PR = '" + name + "'");
        }

        public string getCodigoP(string imgUrl, string name)
        {
            return ds.ConsultarCodigos("SELECT PlataformaxProducto.Cod_Plataforma_PxP FROM PlataformaxProducto INNER JOIN Productos ON PlataformaxProducto.Cod_Producto_PxP = Productos.Cod_Producto_PR WHERE PlataformaxProducto.Imagen_Producto_PxP = '" + imgUrl + "' AND Productos.Nombre_Producto_PR = '" + name + "'");
        }

        public Producto getProducto(string id)
        {
            Producto p = new Producto();
            DataTable tabla = ds.ObtenerTabla("Producto", "Select * from Productos where Productos.Cod_Producto_PR = '" + id + "'");
            p.setCodigoProducto(tabla.Rows[0][0].ToString());
            p.setNombreProducto(tabla.Rows[0][1].ToString());
            return p;
        }



        public int eliminarProducto(Producto cat)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductoEliminar(ref comando, cat);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarProducto");
        }

        private void ArmarParametrosProductoEliminar(ref SqlCommand Comando, Producto p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDProducto", SqlDbType.Char, 4);
            SqlParametros.Value = p.getCodigoProducto();
        }

        private void ArmarParametrosProductos(ref SqlCommand Comando, Producto p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            //SqlParametros = Comando.Parameters.Add("@Cod_Producto_PR", SqlDbType.Char, 4);
            //SqlParametros.Value = p.getCodigoProducto();
            SqlParametros = Comando.Parameters.Add("@Nombre_Producto_PR", SqlDbType.NVarChar, 100);
            SqlParametros.Value = p.getNombreProducto();
            SqlParametros = Comando.Parameters.Add("@Descripcion_Producto_PR", SqlDbType.NVarChar, 500);
            SqlParametros.Value = p.getDescripcion();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_PR", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdCodigoMarca();
            SqlParametros = Comando.Parameters.Add("@Cod_Categoria_PR", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdCodigoCategoria();
            SqlParametros = Comando.Parameters.Add("@Cod_Genero_PR", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdCodigoGenero();
            SqlParametros = Comando.Parameters.Add("@fPublicacion_Producto_PR", SqlDbType.SmallDateTime);
            SqlParametros.Value = p.getAnioFabricacion().ToString();
            SqlParametros = Comando.Parameters.Add("@Estado_Producto_PR", SqlDbType.Bit);
            SqlParametros.Value = p.getEstado();

        }
        
        private void ArmarParametrosProductoModificar(ref SqlCommand Comando, Producto p)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@Cod_Producto_PR", SqlDbType.Char, 4);
            SqlParametros.Value = p.getCodigoProducto();
            SqlParametros = Comando.Parameters.Add("@Nombre_Producto_PR", SqlDbType.NVarChar, 100);
            SqlParametros.Value = p.getNombreProducto();
            SqlParametros = Comando.Parameters.Add("@Descripcion_Producto_PR", SqlDbType.NVarChar, 500);
            SqlParametros.Value = p.getDescripcion();
            SqlParametros = Comando.Parameters.Add("@Cod_Marca_PR", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdCodigoMarca();
            SqlParametros = Comando.Parameters.Add("@Cod_Categoria_PR", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdCodigoCategoria();
            SqlParametros = Comando.Parameters.Add("@Cod_Genero_PR", SqlDbType.Char, 4);
            SqlParametros.Value = p.getIdCodigoGenero();
            SqlParametros = Comando.Parameters.Add("@fPublicacion_Producto_PR", SqlDbType.SmallDateTime);
            SqlParametros.Value = p.getAnioFabricacion();
           
            //SqlParametros = Comando.Parameters.Add("@Estado_Producto_PR", SqlDbType.Bit);
            //SqlParametros.Value = p.getEstado();
        }

        public int actualizarProducto(Producto p)
        {
            SqlCommand comando = new SqlCommand();
             ArmarParametrosProductoModificar(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarProducto");
        }

        public int AltaProducto(Producto p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductos(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaProducto");
        }
    }
}