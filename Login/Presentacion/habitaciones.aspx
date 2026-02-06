<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="habitaciones.aspx.cs" Inherits="Presentacion.habitaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Agregar Habitaciones</h2>
            <asp:Label ID="lblNumero" runat="server" Text="Numero de Habitacion:"></asp:Label> <br />
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox> <br />
            <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion General:"></asp:Label><br />
            <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox><br />
            <asp:Label ID="Lblcant" runat="server" Text="Cantidad de Huespedes Permitidos:"></asp:Label><br />
            <asp:TextBox ID="txtCant" runat="server"></asp:TextBox> <br />

            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
            
        </div>
        <hr />
           
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <columns> 
                <asp:BoundField DataField="id_habitaciones" HeaderText="ID" />
                <asp:BoundField DataField="numero" HeaderText="#" />
                <asp:BoundField DataField="descripcion" HeaderText="Descripcion"/>
                <asp:BoundField DataField="cant_huespedes" HeaderText="Max-Personas" />
            </columns> 
        </asp:GridView>
           
    </form>
</body>
</html>
