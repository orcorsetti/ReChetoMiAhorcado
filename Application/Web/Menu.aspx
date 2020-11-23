<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Web.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="btnCloseSession" runat="server" Text="Close Session" OnClick="btnCloseSession_Click" />
            <br />
            <br />
            <asp:Button ID="btnStartGame" runat="server" Text="New Game" OnClick="btnStartGame_Click" />
            <br />
            <asp:Button ID="btnRanking" runat="server" Text="Top Ranking" OnClick="btnRanking_Click" />
        </div>
    </form>
</body>
</html>
