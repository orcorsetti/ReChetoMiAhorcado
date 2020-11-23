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
        <nav class="navbar navbar-dark bg-secondary">
            <div class="container">
                <div class="col-9">
                  <a class="navbar-brand" href="#">
                    <img src="/Resources/Logo_utn.png" width="30" height="30" class="d-inline-block align-top" alt="">
                        Ahorcado
                  </a>
                </div>
            <div class="col-1">
                <asp:Label ID="lblUserName" runat="server" CssClass="text-white" Text="Label"></asp:Label>
            </div>
            <div class="col-2">
                <asp:LinkButton ID="lnkSalir" runat="server" CssClass="nav-link text-white " OnClick="lnkSalir_Click">Cerrar Sesión</asp:LinkButton>
            </div>
            </div>
        </nav>
        <div class="container">
        <div class="row justify-content-center p-4">
        <div class="card col-4">
            <div class="card-body"></div>
            <h5 class="card-title">Menu</h5>
            <asp:Button ID="btnStartGame" runat="server" CssClass="btn btn-primary btn-lg btn-block p-1" Text="New Game" OnClick="btnStartGame_Click" />
            <asp:Button ID="btnRanking" runat="server" CssClass="btn btn-primary btn-lg btn-block p-1" Text="Top Ranking" OnClick="btnRanking_Click" />
            <br />
        </div>
        </div>

    </div>

    <footer class="navbar fixed-bottom navbar-dark bg-secondary">
        <div class="container">
            <a class="navbar-brand lead" href="#">Metodologías Ágiles en Desarrollo de Software</a>
                <div class="card text-white bg-secondary" style="width: 18rem;">
                <div class="card-header bg-info">
                        Integrantes
                    </div>
                    <ul class="list-group list-group-flush bg-secondary">
                        <li class="list-group-item bg-secondary">Romero, Joaquin      Legajo: 43740</li>
                        <li class="list-group-item bg-secondary">Corsetti, Ornela     Legajo: 44034</li>
                        <li class="list-group-item bg-secondary">Mateo, Lara          Legajo: xxxxx</li>
                    </ul>
                </div>
            </div>
        </footer>
    </form>
</body>
</html>
