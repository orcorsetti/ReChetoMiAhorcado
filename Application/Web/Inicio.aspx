<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Web.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>El Ahorcado</title>
</head>
<body>
    <form id="form1" runat="server">
       <div>


           <asp:Label ID="lblUsuario" runat="server" Text="Ingrese su Usuario"></asp:Label>


       </div>
        <div>
            <asp:TextBox ID="txtBoxUserName" runat="server"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
        </div>
        <div> 
            <hr />
            <asp:LinkButton ID="lnkCrearUsuario" runat="server" OnClick="lnkCrearUsuario_Click">Nunca jugaste? Create un usuario!</asp:LinkButton>
        </div>
        <p>
        
            <asp:Label ID="lblEstado" runat="server" align="right" ForeColor="#FF3300"></asp:Label>
        </p>
    </form>
</body>
</html>