<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewUser.aspx.cs" Inherits="Web.NewUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" Text="UserName: "></asp:Label>
            <asp:TextBox ID="txtBoxUserName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click"/>
            <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click"/>
            <br />
        </div>
    </form>
</body>
</html>
