<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ranking.aspx.cs" Inherits="Web.Ranking" %>

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
            <asp:Label ID="lblUserName" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="lblWinsTitle" runat="server" Text="Wins: "></asp:Label>
            <asp:Label ID="lblWins" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblLossesTitle" runat="server" Text="Losses: "></asp:Label>
            <asp:Label ID="lblLosses" runat="server" Text=""></asp:Label>
            <br />
        </div>
        <div>
            <asp:Panel ID="RankingPanel" runat="server">
                <asp:GridView ID="RankingGridView" runat="server" AutoGenerateColumns="False">

                    <Columns>
                        <asp:BoundField HeaderText="User" DataField="UserName" ReadOnly="true"/>
                        <asp:BoundField HeaderText="Wins" DataField="Wins" ReadOnly="true"/>
                    </Columns>

                </asp:GridView>
            </asp:Panel>
            
        </div>
        <div>
            <br />
            <asp:Button ID="btnReturn" runat="server" Text="Return to Menu" OnClick="btnReturn_Click" />
        </div>
    </form>
</body>
</html>
