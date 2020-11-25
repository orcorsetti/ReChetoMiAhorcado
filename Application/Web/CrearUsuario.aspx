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
        <nav class="navbar navbar-dark bg-secondary">
            <div class="container">
                    <a class="navbar-brand" href="Inicio.aspx">
                    <img src="/Resources/Logo_utn.png" width="30" height="30" class="d-inline-block align-top " alt="">
                        Ahorcado
                    </a>
            </div>
        </nav>
        <div class="container">
            <br />
            <div class="row justify-content-end">
                <asp:PlaceHolder ID="phAlerts" runat="server"></asp:PlaceHolder>
            </div>
            <div class="row justify-content-center p-3">
                <div class="card">
                    <div class="card-body">
                        <asp:Label ID="lblTitulo" runat="server" CssClass="card-title h5" Text="Crear Usuario"></asp:Label>
                        <div class="form-group">
                            <div class="row p-1">
                                <asp:Label ID="lblNombre" runat="server" Text="Nombre de Usuario"></asp:Label>
                                <asp:TextBox ID="txtBoxUserName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="row p-1">
                                <div class="col">
                                    <asp:Button ID="btnVolver" runat="server" Text="Volver al Menu" CssClass="btn btn-secondary" OnClick="btnVolver_Click" />
                                </div>
                                <div class="col">
                                    <asp:Button ID="btnCrearUser" runat="server" Text="Crear Usuario" CssClass="btn btn-primary" OnClick="btnCrearUser_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <footer class="navbar fixed-bottom navbar-dark bg-secondary">
            <div class="container">
                <a class="navbar-brand lead">Metodologías Ágiles en Desarrollo de Software</a>
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
