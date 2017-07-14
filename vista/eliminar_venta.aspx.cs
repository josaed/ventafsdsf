using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using venta.modelo;

namespace venta.vista
{
    public partial class eliminar_venta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            vent pp = new vent();
            pp.codigo_venta = Convert.ToInt32(cod_venta.Text.Trim());

            if (vent.Eliminar(pp) > 0)
            {
                Response.Write("<script>window.alert('Se elimino exitosamente');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('no se pudo eliminar la venta');</script>");

            }
        }
    }
}