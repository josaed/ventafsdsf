using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace venta.modelo
{
    public class vent
    {
        public int codigo_venta;
        [Required]
        public int Codigo { get; set; }
        public productos producto { get; set; }
        public int id_cliente;
        public string nombre_cli;
        public string apellido;
        public string direccion;
        public int telefono;
        public string correo;

        public vent(){
    
        }

        public vent(int codigo_venta, int Codigo, int id_cliente, string nombre_cli, string apellido, string direccion, int telefono, string correo)
        {
            this.codigo_venta = codigo_venta;
            this.Codigo = Codigo;
            this.id_cliente = id_cliente;
            this.nombre_cli = nombre_cli;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        public static int Agregar(vent pventa)
        {


            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into ventas (codigo_venta,codigo,nombre_cli,apellido,direccion,telefono,correo) values ({0},{1},'{2}','{3}','{4}',{5},'{6}')",
                pventa.codigo_venta, pventa.Codigo, pventa.nombre_cli, pventa.apellido, pventa.direccion, pventa.telefono, pventa.correo), conectarmysql.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static int Actualizar(vent pventa)
        {
            int retorno = 0;
            MySqlConnection conexion = conectarmysql.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("Update ventas set codigo={1}, nombre_cli='{2}',apellido= '{3}', direccion='{4}', telefono={5},correo= '{6}' where codigo_venta ={0}",
                pventa.codigo_venta, pventa.Codigo, pventa.nombre_cli, pventa.apellido, pventa.direccion, pventa.telefono, pventa.correo), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }

        public static int Eliminar(vent pventa)
        {
            int retorno = 0;
            MySqlConnection conexion = conectarmysql.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("delete from ventas where codigo_venta ={0}",
           pventa.codigo_venta), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

    }
}