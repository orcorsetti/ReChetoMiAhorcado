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
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usr;
            UsuarioLogic ulogic = new UsuarioLogic();
            usr = ulogic.getOne(txtBoxUserName.Text);
            if(usr.UserName != null)
            {
                Session["usuario"] = usr;
                Response.Redirect("Menu.aspx");
            }
            else
            {
                Response.Redirect("Inicio.aspx");
            }
        }
    }
}