<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="Presentacion.Principal" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Principal</title>
    <link rel="stylesheet" href="Style/Style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Bienvenido</h1>
            <h1>Usuario:</h1><asp:Label ID="lblUsuario" runat="server" Text="Label"></asp:Label>
        </div>
        <asp:Button ID="out" runat="server" Text="Cerrar Sesion" onclik="out_Click" OnClick="out_Click"/>

    </form>
</body>
</html>
