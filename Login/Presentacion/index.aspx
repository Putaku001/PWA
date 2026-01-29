<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Presentacion.index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link rel="stylesheet" href="Style/Style.css" />

</head>
<body>
    <form id="form1" runat="server">
        <!-- NAV -->
   <div class="navbar">
       <h1>Sistema</h1>

       <div class="login-form">
           <asp:TextBox ID="txtUsuario" runat="server" Placeholder="Usuario" />

           <asp:TextBox ID="txtClave" runat="server" TextMode="Password" Placeholder="Contraseña" />

           <asp:Button ID="Button1" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
       </div>
   </div>

   <!-- MENSAJE -->
   <asp:Label ID="lblMensaje" runat="server" CssClass="mensaje" />

    </form>
</body>
</html>
