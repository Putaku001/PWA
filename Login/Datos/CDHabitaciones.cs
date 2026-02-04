using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CDHabitaciones
    {
        
        public DataTable ObtenerHabitaciones()
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using( SqlCommand cmd = new SqlCommand("select * From habitaciones", con))
                {
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                con.Close();
            }
                return dt;
        }
        
    }
}
