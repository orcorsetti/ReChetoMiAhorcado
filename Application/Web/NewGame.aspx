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
        <nav class="navbar navbar-dark bg-secondary">
            <div class="container">
                <div class="col-9">
                  <a class="navbar-brand" href="Menu.aspx">
                    <img src="/Resources/Logo_utn.png" width="30" height="30" class="d-inline-block align-top" alt="">
                        Ahorcado
                  </a>
                </div>
            <div class="col-1">
                <asp:Label ID="lblUserName" runat="server" CssClass="text-white"></asp:Label>
            </div>
            <div class="col-2">
                <asp:LinkButton ID="lnkBtnReturn" CssClass="nav-item text-white" runat="server" OnClick="lnkBtnReturn_Click">Volver al Menu</asp:LinkButton>
            </div>
            </div>
        </nav>
        <div class="container">
            <br />
            <div class="row pb-2 pt-2">
                <div class="col-7">
                    <div class="form-inline">
                        <div class="form-group mx-sm-2 mb-1 ">
                            <asp:TextBox ID="txtBoxLetter"  runat="server" CssClass="form-control" placeholder="Letra" MaxLength="1"></asp:TextBox>
                        </div>
                            <asp:Button ID="btnPlayLetter" runat="server" CssClass="btn btn-primary mb-2" Text="Juega Letra!" OnClick="btnPlayLetter_Click" />
                    </div>
                </div>
                <div class="col-5">
                    <asp:PlaceHolder ID="phAlerts" runat="server"></asp:PlaceHolder>
                </div>
            </div>
        <div class ="row">
            <div class="list-group list-group-horizontal">
                <asp:Label ID="lblWrongLetter" runat="server" CssClass="list-group-item list-group-item-info" Text="Letras Incorrectas: "></asp:Label>
                <asp:Label ID="lblIncorrectLetter" CssClass="list-group-item" runat="server"></asp:Label>
                <asp:Label ID="RemainingAttempts" runat="server" CssClass="list-group-item list-group-item-info " Text="Intentos Restantes: "></asp:Label>
                <asp:Label ID="lblRemainingAttempts" runat="server" CssClass="list-group-item "></asp:Label>
            </div>
        </div>

        <div class="row pb-2 pt-2 align-content-end">
            <div class="col-2">
                <asp:Image ID="imgAhorcado" runat="server" CssClass="img-thumbnail" Width="150" Height="200"/>
            </div>
            <div class="col-6">
                <div class="card d-inline bg-info p-1">
                    <asp:PlaceHolder ID="phLetters" runat="server"></asp:PlaceHolder>
                </div>
            </div>
            <div class="col-4">
                <div class="row d-block p-1">
                        <asp:Label ID="lblGameResult" runat="server" Text="Oculto" Visible="false"></asp:Label>
                </div>
                <div class="row d-block p-1">
                        <asp:Label ID="lblWord" runat="server" CssClass="card card-danger border-danger p-2" Visible="false"></asp:Label>
                </div>
                <div class="row p-1">
                    <asp:Button ID="btnTryAgain" runat="server" CssClass="btn btn-primary btn-block" Text="Volver a Jugar" Visible ="false" OnClick="btnTryAgain_Click"/>
                </div>
            </div>
        </div>
        </div>
        <footer class="navbar fixed-bottom navbar-dark bg-secondary mt-auto">
            <div class="container">
                <a class="navbar-brand lead" href="#">Metodologías Ágiles en Desarrollo de Software</a>
                <div class="card text-white bg-secondary" style="width: 18rem;">
                <div class="card-header bg-info">
                        Integrantes
                    </div>
                    <ul class="list-group list-group-flush bg-secondary">
                        <li class="list-group-item bg-secondary">Romero, Joaquin | Legajo: 43740</li>
                        <li class="list-group-item bg-secondary">Corsetti, Ornela | Legajo: 44034</li>
                        <li class="list-group-item bg-secondary">Mateo, Lara | Legajo: 44795</li>
                    </ul>
                </div>
            </div>
        </footer>

    <!-- Scripts -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>

    </form>
</body>
</html>
