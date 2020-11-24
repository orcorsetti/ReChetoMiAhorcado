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
                    <asp:LinkButton ID="lnkBtnReturn" CssClass="nav-item text-white" runat="server" OnClick="btnReturn_Click">Volver al Menu</asp:LinkButton>
                </div>
            </div>
        </nav>
        <div class="container">
            <div class="row p-2 justify-content-center">
                <div class="col-4">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title">Tus Partidas:</h5>
                                <div class="list-group list-group-horizontal-sm">
                                    <asp:Label ID="lblWinsTitle" runat="server" CssClass="list-group-item bg-success text-white" Text="Ganadas:"></asp:Label>
                                    <asp:Label ID="lblWins" runat="server" CssClass="list-group-item"></asp:Label>
                                    <asp:Label ID="lblLossesTitle" runat="server" CssClass="list-group-item bg-danger text-white" Text="Perdidas:"></asp:Label>
                                    <asp:Label ID="lblLosses" runat="server" CssClass="list-group-item" Text=""></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                <div class="col-3">
                    <div class="card">
                        <div class="card-body">
                            <h5 class="card-title">Top 10 Jugadores</h5>
                            <asp:Panel ID="RankingPanel" runat="server">
                                <asp:GridView ID="RankingGridView" runat="server" AutoGenerateColumns="False" BorderStyle="None" CssClass="table table-sm striped">
                                    <Columns>
                                        <asp:BoundField HeaderText="User"  DataField="UserName" ReadOnly="true"/>
                                        <asp:BoundField HeaderText="Wins" DataField="Wins" ReadOnly="true"/>
                                    </Columns>
                                    <EditRowStyle CssClass="row" />
                                    <HeaderStyle CssClass="col" />
                                </asp:GridView>
                            </asp:Panel>
                        </div>
                    </div>
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
                        <li class="list-group-item bg-secondary">Romero, Joaquin | Legajo: 43740</li>
                        <li class="list-group-item bg-secondary">Corsetti, Ornela | Legajo: 44034</li>
                        <li class="list-group-item bg-secondary">Mateo, Lara | Legajo: xxxxx</li>
                    </ul>
                </div>
            </div>
        </footer>
    </form>
</body>
</html>
