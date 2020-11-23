<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Web.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label>
            <asp:LinkButton ID="lnkSalir" runat="server" OnClick="lnkSalir_Click">Cerrar Sesión</asp:LinkButton>
            <br />
            <br />
            <asp:Button ID="btnStartGame" runat="server" Text="New Game" OnClick="btnStartGame_Click" />
            <br />
            <asp:Button ID="btnRanking" runat="server" Text="Top Ranking" OnClick="btnRanking_Click" />
            <br />

        </div>

    </form>
</body>
</html>
