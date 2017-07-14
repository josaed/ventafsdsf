using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace venta.modelo
{
    public class cliente
    {
        public int id_cliente;
        public string nombre_cli;
        public string apellido;
        public string direccion;
        public int telefono;
        public string correo;
        
        
        public cliente(){
    
        }

        public cliente(int id_cliente,string nombre_cli,string apellido,string direccion,int telefono,string correo){

            this.id_cliente = id_cliente;
            this.nombre_cli = nombre_cli;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }
    }
}