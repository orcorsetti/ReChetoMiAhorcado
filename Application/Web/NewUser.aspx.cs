using Business_Entities;
using Bussiness.Logic;
using System;

namespace Web
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtBoxUserName.Text;
            if (!string.IsNullOrEmpty(username))
            {
                Usuario usr = new Usuario();
                usr.UserName = username;
                
                UsuarioLogic usrLogic = new UsuarioLogic();

                usr = usrLogic.CreateUser(usr);

                Session["usuario"] = usr;

                Response.Redirect("Menu.aspx");
            }
        }
    }
}