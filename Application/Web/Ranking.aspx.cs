using Business_Entities;
using Bussiness.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Ranking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usr = (Usuario)Session["usuario"];

            loadUserData(usr);
            loadGrid();
        }

        private void loadUserData(Usuario usr)
        {
            lblUserName.Text = usr.UserName;
            lblWins.Text = usr.Wins.ToString();
            lblLosses.Text = usr.Losses.ToString();
        }

        private void loadGrid()
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            RankingGridView.DataSource = usuarioLogic.getTopTen();
            RankingGridView.DataBind();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

    }
}