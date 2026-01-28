using Datos;

namespace Negocios
{
    public class CNPersonas
    {
        private CDPersonas dal = new CDPersonas();

        public bool Login(string usuario, string clave)
        {
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
                return false;

            return dal.ValidarUsuario(usuario, clave);
        }
    }
}
