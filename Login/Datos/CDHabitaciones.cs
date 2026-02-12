using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
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
        public bool AgregarHabitacion( int numero, string descripcion, int cantidad)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO habitaciones" + 
                    "(numero, descripcion, cant_huespedes) VALUES (@numero, @descripcion, @cant)", con))
                {
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@cant", cantidad);

                    int filas = cmd.ExecuteNonQuery();

                    con.Close();
                    return filas > 0;
                }
            }
        }

        public bool ActualizarHabitacion(int id, int numero, string descripcion, int cantidad)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE habitaciones SET numero=@numero, descripcion=@descripcion, cant_huespedes=@cant WHERE id_habitaciones=@id",
                    con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@cant", cantidad);

                    int filas = cmd.ExecuteNonQuery();

                    con.Close();
                    return filas > 0;
                }
            }
        }

        public bool EliminarHabitacion(int id)
        {
            using (SqlConnection con = Conexion.obtenerConexion())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM habitaciones WHERE id_habitaciones=@id",
                    con))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    int filas = cmd.ExecuteNonQuery();

                    con.Close();
                    return filas > 0;
                }
            }
        }
    }
}
