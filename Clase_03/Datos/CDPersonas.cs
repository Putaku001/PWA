using System.Data.SqlClient;

namespace Datos
{
    public class CDPersonas
    {
        public bool ValidarUsuario(string usuario, string clave)
        {
            bool existe = false;

            using (SqlConnection cn = Conexion.obtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM Usuario WHERE Usuario=@u AND Clave=@c";
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@u", usuario);
                    cmd.Parameters.AddWithValue("@c", clave);

                    cn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    existe = (count > 0);
                }
            }

            return existe;
        }
    }
}
