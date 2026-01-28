using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        public static SqlConnection obtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
            return new SqlConnection(cadena);
        }
    }
}
