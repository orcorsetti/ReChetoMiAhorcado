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
            string testMode = Request.QueryString["testMode"];
            if (testMode == "true")
            {
                Session["testMode"] = true;
            }
            else
            {
                Session["testMode"] = false;
            }
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
                this.lblEstado.Text = string.Format("Usuario no encontrado");
                this.txtBoxUserName.Text = "";
            }
        }

        protected void lnkCrearUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearUsuario.aspx");
        }
    }
}