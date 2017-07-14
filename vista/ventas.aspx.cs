using System;
using venta.modelo;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace venta.vista
{
    public partial class ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            vent pvent = new vent();
            pvent.codigo_venta = Convert.ToInt32(cod.Text.Trim());
            pvent.Codigo = Convert.ToInt32(DropDownList1.Text.Trim());
            pvent.nombre_cli = nom.Text.Trim();
            pvent.apellido = ape.Text.Trim();
            pvent.direccion = direc.Text.Trim();
            pvent.telefono = Convert.ToInt32(tele.Text.Trim());
            pvent.correo = correo.Text.Trim();



            int resultado = vent.Agregar(pvent);

            if (resultado > 0)
            {
                Response.Write("<script>window.alert('venta Guardado Con Exito en MYSQL');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('venta no Guardado en MYSQL');</script>");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            vent pvent = new vent();
            pvent.codigo_venta = Convert.ToInt32(cod.Text.Trim());
            pvent.Codigo = Convert.ToInt32(DropDownList1.Text.Trim());
            pvent.nombre_cli = nom.Text.Trim();
            pvent.apellido = ape.Text.Trim();
            pvent.direccion = direc.Text.Trim();
            pvent.telefono = Convert.ToInt32(tele.Text.Trim());
            pvent.correo = correo.Text.Trim();



            int resultado = vent.Actualizar(pvent);

            if (resultado > 0)
            {
                Response.Write("<script>window.alert('venta Actualizado Con Exito en MYSQL');</script>");
            }
            else
            {
                Response.Write("<script>window.alert('venta no Actualizado en MYSQL');</script>");

            }
        }
    }
}