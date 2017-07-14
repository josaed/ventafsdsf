using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace venta.vista
{
    public partial class reporteventa : System.Web.UI.Page
    {

        MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=venta; Uid=root; pwd=;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void b_listar_Click(object sender, EventArgs e)
        {
            conectar.Open();
            MySqlCommand cmd = conectar.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT venta.codigo_venta as 'codigo venta',venta.nombre_cli as 'nombre cliente',producto.nombre as 'nombre producto',producto.stock,producto.marca,producto.precio,producto.cantidad as 'cantidad comprada',producto.cantidad*producto.precio as 'total de la compra' FROM venta INNER JOIN producto ON venta.codigo = producto.codigo;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            t_lista.DataSource = dt;
            t_lista.DataBind();
            conectar.Close();

           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void b_total_Click(object sender, EventArgs e)
        {
            conectar.Open();
            MySqlCommand cmds = conectar.CreateCommand();
            cmds.CommandType = CommandType.Text;
            cmds.CommandText = "SELECT SUM(producto.cantidad*producto.Precio) as 'total de todas las compras' FROM venta INNER JOIN producto ON venta.codigo = producto.codigo;";
            cmds.ExecuteNonQuery();
            DataTable dts = new DataTable();
            MySqlDataAdapter das = new MySqlDataAdapter(cmds);
            das.Fill(dts);
            t_total.DataSource = dts;
            t_total.DataBind();
            conectar.Close();
        }
    }
}