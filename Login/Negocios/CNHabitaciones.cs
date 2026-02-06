using System;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocios
{

    public class CNHabitaciones
    {
        CDHabitaciones _habitaiones = new CDHabitaciones();
        public DataTable ObtenerhabitacionesN()
        {
            return _habitaiones.ObtenerHabitaciones();
        }

        public bool agregar_habitaciones(int numero, string descripcion, int cant)
        {
            return _habitaiones.AgregarHabitacion(numero, descripcion, cant);
        }
    }

    
}
