using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using venta.modelo;

namespace venta.vista
{
    public partial class eliminarproducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            productos pp = new productos();
            pp.Codigo = Convert.ToInt32(tb_id.Text.Trim());

            if (productos.Eliminar(pp) > 0)
            {
                Response.Write("<script>window.alert('Se elimino exitosamente');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('no se pudo eliminar el producto');</script>");

            }
        }
    }
}