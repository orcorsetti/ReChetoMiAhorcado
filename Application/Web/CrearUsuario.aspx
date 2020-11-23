<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="Web.CrearUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="lblTitulo" runat="server" Text="Crear Usuario"></asp:Label>
            <hr />
            <asp:Label ID="lblNombre" runat="server" Text="Escriba su nombre de usuario"></asp:Label>
            <asp:TextBox ID="txtBoxUserName" runat="server"></asp:TextBox>
            <hr />
            <asp:Button ID="btnCrearUser" runat="server" Text="Crear Usuario" OnClick="btnCrearUser_Click" />

            
            <asp:Button ID="btnVolver" runat="server" Text="Volver al Menu" OnClick="btnVolver_Click" />

            
        </div>
    </form>
</body>
</html>
