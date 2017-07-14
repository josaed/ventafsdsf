using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace venta.modelo
{
    public class productos
    {
        public int Codigo;
        public string Nombre;
        public string Categoria;
        public int Stock;
        public string Marca;
        public int Cantidad;
        public int Precio;


        public productos()
        {
            // TODO: Complete member initialization
        }

        public productos(int Codigo,string Nombre,string Categoria,int Stock,string Marca,int Cantidad,int Precio)
        {
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Categoria = Categoria;
            this.Stock = Stock;
            this.Marca = Marca;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
        }

        public static int Agregar(productos pproductos)
        {


            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into producto (codigo,nombre,categoria,stock,marca,cantidad,precio) values ({0},'{1}','{2}',{3},'{4}',{5},{6})",
                pproductos.Codigo, pproductos.Nombre, pproductos.Categoria, pproductos.Stock, pproductos.Marca, pproductos.Cantidad, pproductos.Precio), conectarmysql.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int Actualizar(productos pproductos)
        {
            int retorno = 0;
            MySqlConnection conexion = conectarmysql.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update producto set nombre='{1}', categoria='{2}',stock= {3}, marca='{4}', cantidad={5},precio= {6} where codigo ={0}",
                pproductos.Codigo, pproductos.Nombre, pproductos.Categoria, pproductos.Stock, pproductos.Marca, pproductos.Cantidad, pproductos.Precio), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminar(productos pproductos)
        {
            int retorno = 0;
            MySqlConnection conexion = conectarmysql.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("delete from producto where codigo ={0}",
           pproductos.Codigo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }


    }
      

    
}