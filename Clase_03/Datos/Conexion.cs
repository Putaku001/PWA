using System.Configuration;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        // Lee la cadena desde Web.config de la capa Presentacion
        public static SqlConnection obtenerConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
            return new SqlConnection(cadena);
        }
    }
}
