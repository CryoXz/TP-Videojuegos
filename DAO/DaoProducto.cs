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
            "inner join Marcas on Cod_Marca_M = Cod_Marca_PR inner join Categorias on Cod_Categoria_C = Cod_Categoria_PR inner join Generos on Cod_Genero_G = Cod_Genero_PR WHERE Productos.Estado_Producto_PR=1");
            return tabla;
        }


        public DataSet getConsultaProductos()
        {
            DataSet data = ds.Consultar("select * from Productos");
            return data;
        }
        public int getConsultaUltimoProducto()
        {

            return ds.ConsultarUsuario("SELECT COUNT(*) FROM Productos");
        }

        public DataTable getNombreProductoDetalleVenta(string codVenta)
        {
            DataTable table = ds.ObtenerTabla("NombreProducto", "SELECT Nombre_Producto_PR FROM Productos INNER JOIN DetalleVentas ON Cod_Producto_PR = Cod_Producto_DV WHERE Cod_Venta_DV = '" + codVenta + "'");
            return table;
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



        public int eliminarProducto(Producto p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductoEliminar(ref comando, p);
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
            SqlParametros.Value = p.getFechaPublicacion().ToString("dd/MM/yyyy");
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
            SqlParametros.Value = p.getFechaPublicacion().ToString("dd/MM/yyyy");

        }

        public int actualizarProducto(Producto p)
        {
            SqlCommand comando = new SqlCommand();
             ArmarParametrosProductoModificar(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spModificarProductos");
        }

        public int AltaProducto(Producto p)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosProductos(ref comando, p);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAltaProductos");
        }
        
        public DataTable getTablaProductoFoto(string codProd, string codPlat)
        {
            DataTable table = ds.ObtenerTabla("Producto", "SELECT PlataformaxProducto.Imagen_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP INNER JOIN Plataformas ON PlataformaxProducto.Cod_Plataforma_PxP = Plataformas.Cod_Plataforma_P WHERE PlataformaxProducto.Cod_Producto_PxP = '" + codProd + "' AND PlataformaxProducto.Cod_Plataforma_PxP = '" + codPlat + "'");
            return table;
        }

        public DataTable getTablaProductoDatos(string codProd, string codPlat)
        {
            DataTable table = ds.ObtenerTabla("Producto", "SELECT Productos.Nombre_Producto_PR, Plataformas.Nombre_Plataforma_P, Productos.Descripcion_Producto_PR, PlataformaxProducto.PrecioUnitario_Producto_PxP FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP INNER JOIN Plataformas ON PlataformaxProducto.Cod_Plataforma_PxP = Plataformas.Cod_Plataforma_P WHERE PlataformaxProducto.Cod_Producto_PxP = '" + codProd + "' AND PlataformaxProducto.Cod_Plataforma_PxP = '" + codPlat + "'");
            return table;
        }

        public DataTable getBuscarNombre(String nombreBuscado)
        {
            DataTable tabla = ds.ObtenerTabla("Producto", "SELECT Productos.Cod_Producto_PR as Codigo, Productos.Nombre_Producto_PR as Nombre, Productos.Descripcion_Producto_PR as Descripcion, Marcas.Cod_Marca_M as CodMarca, Marcas.Nombre_Marca_M as NombreMarca, Categorias.Cod_Categoria_C as CodCategoria, Categorias.Nombre_Categoria_C as NombreCategoria, Generos.Cod_Genero_G as CodGenero, Generos.Nombre_Genero_G as NombreGenero, Productos.fPublicacion_Producto_PR as FPublicacion, Productos.Estado_Producto_PR as Estado, PlataformaxProducto.Cod_Plataforma_PxP as CodPlataforma, PlataformaxProducto.Stock_Producto_PxP as Stock, PlataformaxProducto.PrecioUnitario_Producto_PxP as PrecioUnitario, PlataformaxProducto.Imagen_Producto_PxP as imgURL, Plataformas.Nombre_Plataforma_P as NombrePlataforma FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP inner join Plataformas on Cod_Plataforma_P = Cod_Plataforma_PxP inner join Marcas on Cod_Marca_M = Cod_Marca_PR inner join Categorias on Cod_Categoria_C = Cod_Categoria_PR inner join Generos on Cod_Genero_G = Cod_Genero_PR WHERE Productos.Estado_Producto_PR = 1 AND Nombre_Producto_PR like '%" + nombreBuscado + "%'");
            return tabla;
        }
        public DataSet getBuscarProductoFiltrado(String ClausulaSqlProductos)
        {
            DataSet data = ds.Consultar("SELECT Productos.Cod_Producto_PR as Codigo, Productos.Nombre_Producto_PR as Nombre, Productos.Descripcion_Producto_PR as Descripcion, Marcas.Cod_Marca_M as CodMarca, Marcas.Nombre_Marca_M as NombreMarca, Categorias.Cod_Categoria_C as CodCategoria, Categorias.Nombre_Categoria_C as NombreCategoria, Generos.Cod_Genero_G as CodGenero, Generos.Nombre_Genero_G as NombreGenero, " +
            "Productos.fPublicacion_Producto_PR as FPublicacion, Productos.Estado_Producto_PR as Estado, PlataformaxProducto.Cod_Plataforma_PxP as CodPlataforma, PlataformaxProducto.Stock_Producto_PxP as Stock, PlataformaxProducto.PrecioUnitario_Producto_PxP as PrecioUnitario, PlataformaxProducto.Imagen_Producto_PxP as imgURL, Plataformas.Nombre_Plataforma_P as NombrePlataforma " +
            "FROM Productos INNER JOIN PlataformaxProducto ON Productos.Cod_Producto_PR = PlataformaxProducto.Cod_Producto_PxP inner join Plataformas on Cod_Plataforma_P = Cod_Plataforma_PxP " +
            "inner join Marcas on Cod_Marca_M = Cod_Marca_PR inner join Categorias on Cod_Categoria_C = Cod_Categoria_PR inner join Generos on Cod_Genero_G = Cod_Genero_PR" + ClausulaSqlProductos +" AND Productos.Estado_Producto_PR = 1" );
            return data;
        }
    }
}