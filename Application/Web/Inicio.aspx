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
    <nav class="navbar navbar-dark bg-secondary">
        <div class="container">
              <a class="navbar-brand" href="#">
                <img src="/Resources/Logo_utn.png" width="30" height="30" class="d-inline-block align-top " alt="" loading="lazy">
                    Ahorcado
              </a>
        </div>
    </nav>
    <div class="container">
        <br />
        <div class="row justify-content-end">
            <asp:PlaceHolder ID="phAlerts" runat="server"></asp:PlaceHolder>
        </div>
        <div class="row justify-content-center p-5">
        <div class="card">
        <div class="card-body">
        <h5 class="card-title"> Inicio de Sesión</h5>
                <div class="row p-1">
                    <label for="txtBoxUserName">Usuario:</label>
                    <asp:TextBox ID="txtBoxUserName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="row p-1">
                    <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary btn-block p-1 " Text="Ingresar" OnClick="btnLogin_Click" />
                </div>
            <p>
                <asp:Label ID="lblEstado" runat="server" align="right" ForeColor="#FF3300"></asp:Label>
            </p>
            <div> 
                <hr />
                <asp:LinkButton ID="lnkCrearUsuario" runat="server" OnClick="lnkCrearUsuario_Click">Nunca jugaste? Create un usuario!</asp:LinkButton>
            </div>
        </div>
        </div>
        </div>
    </div>

        <footer class="navbar navbar-dark bg-secondary auto-mt">
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
    </form>
</body>
</html>