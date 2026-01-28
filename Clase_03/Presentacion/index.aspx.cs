using System;
using Negocios;

namespace Presentacion
{
    public partial class index : System.Web.UI.Page
    {
        CNPersonas bll = new CNPersonas();

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool acceso = bll.Login(txtUsuario.Text, txtClave.Text);

            if (acceso)
            {
                Response.Redirect("Principal.aspx");
            }
            else
            {
                lblMensaje.Text = "Usuario o clave incorrectos";
            }
        }
    }
}
