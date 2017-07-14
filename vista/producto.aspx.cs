using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using venta.modelo;

namespace venta.vista
{
    public partial class producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        protected void Button2_Click1(object sender, EventArgs e)
        {
            productos pproducto = new productos();
            pproducto.Codigo = Convert.ToInt32(tb_codigop.Text.Trim());
            pproducto.Nombre = tb_nombre.Text.Trim();
            pproducto.Categoria = tb_categoria.Text.Trim();
            pproducto.Stock = Convert.ToInt32(tb_stock.Text.Trim());
            pproducto.Marca = tb_marca.Text.Trim();
            pproducto.Cantidad = Convert.ToInt32(tb_cantidad.Text.Trim());
            pproducto.Precio = Convert.ToInt32(tb_Precio.Text.Trim());


            int resultado = productos.Agregar(pproducto);

            if (resultado > 0)
            {
                Response.Write("<script>window.alert('producto Guardado Con Exito en MYSQL');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('producto no Guardado en MYSQL');</script>");

            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            productos pproducto = new productos();
            pproducto.Codigo = Convert.ToInt32(tb_codigop.Text.Trim());
            pproducto.Nombre = tb_nombre.Text.Trim();
            pproducto.Categoria = tb_categoria.Text.Trim();
            pproducto.Stock = Convert.ToInt32(tb_stock.Text.Trim());
            pproducto.Marca = tb_marca.Text.Trim();
            pproducto.Cantidad = Convert.ToInt32(tb_cantidad.Text.Trim());
            pproducto.Precio = Convert.ToInt32(tb_Precio.Text.Trim());


            int resultado = productos.Actualizar(pproducto);

            if (resultado > 0)
            {
                Response.Write("<script>window.alert('producto Actualizado Con Exito en MYSQL');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('producto no Actualizado en MYSQL');</script>");

            }
        }
    }
}