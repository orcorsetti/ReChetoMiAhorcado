<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewGame.aspx.cs" Inherits="Web.NewGame" %>

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
            <asp:TextBox ID="txtBoxLetter" runat="server" MaxLength="1" Width="40px"></asp:TextBox>
            <asp:Button ID="btnPlayLetter" runat="server" Text="Play Letter!" OnClick="btnPlayLetter_Click" />
        </div>
        <div>
            <asp:Label ID="lblWrongLetter" runat="server" Text="Wrong Letters: "></asp:Label>
             <asp:Label ID="lblIncorrectLetter" runat="server"></asp:Label>
            <br />
            <asp:Label ID="RemainingAttempts" runat="server" Text="Remaining Attempts: "></asp:Label>
            <asp:Label ID="lblRemainingAttempts" runat="server"></asp:Label>

        </div>

        <div>
            <br /> 
            <asp:PlaceHolder ID="phLetters" runat="server"></asp:PlaceHolder>
            <br />

            <br />
            <asp:Label ID="lblWord" runat="server" Visible="false"></asp:Label>
            <br />
            <asp:Label ID="lblGameResult" runat="server" Text="Oculto" Visible="false"></asp:Label>
            <br />
            <asp:Button ID="btnTryAgain" runat="server" Text="Try Again" Visible ="false" OnClick="btnTryAgain_Click"/>
            <asp:Button ID="btnReturn" runat="server" Text="Return to Menu" Visible ="false" OnClick="btnReturn_Click"/>
        </div>

    </form>
</body>
</html>
