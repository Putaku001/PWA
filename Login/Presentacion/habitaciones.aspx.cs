using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class habitaciones : System.Web.UI.Page
    {
        CNHabitaciones _habitaciones = new CNHabitaciones();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrid();
            }
        }
        protected void CargarGrid()
        {
            GridView1.DataSource = _habitaciones.ObtenerhabitacionesN();
            GridView1.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            string descripcion = txtDescripcion.Text;
            int cant = Convert.ToInt32(txtCant.Text);

            bool correcto = _habitaciones.agregar_habitaciones(numero, descripcion, cant);
            
                if (correcto)
                {
                    Response.Write("<script>alert('Habitacion Agregada')</script>");
                    CargarGrid();
                }
                else
                {
                    Response.Write("<script>alert('Error al agregar Habitacion')</script>");
                }

             
        }
    }
}