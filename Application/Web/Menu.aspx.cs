using Business_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usu = (Usuario)this.Session["usuario"];
            lblUserName.Text = usu.UserName;
        }

        protected void btnStartGame_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewGame.aspx");
        }

        protected void btnRanking_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ranking.aspx");
        }

        protected void lnkSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("Inicio.aspx");
        }
    }
}