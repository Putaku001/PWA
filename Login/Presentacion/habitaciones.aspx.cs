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

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            CargarGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            CargarGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            GridViewRow row = GridView1.Rows[e.RowIndex];
            int numero = Convert.ToInt32(((TextBox)row.Cells[1].Controls[0]).Text);
            string descripcion = ((TextBox)row.Cells[2].Controls[0]).Text;
            int cant = Convert.ToInt32(((TextBox)row.Cells[3].Controls[0]).Text);

            bool correcto = _habitaciones.actualizar_habitaciones(id, numero, descripcion, cant);
            if (correcto)
            {
                Response.Write("<script>alert('Habitacion Actualizada')</script>");
                GridView1.EditIndex = -1;
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al actualizar Habitacion')</script>");
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            bool correcto = _habitaciones.eliminar_habitaciones(id);
            if (correcto)
            {
                Response.Write("<script>alert('Habitacion Eliminada')</script>");
                CargarGrid();
            }
            else
            {
                Response.Write("<script>alert('Error al eliminar Habitacion')</script>");
            }
        }
    }
}