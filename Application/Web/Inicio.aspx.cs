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

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            UsuarioLogic ul = new UsuarioLogic();
            usr = ul.getOne("JoacoRomero");
            this.lbl1.Text = String.Format("Usuario: " + usr.UserName);
            this.lbl2.Text = string.Format("Cantidad ganadas: " + Convert.ToString(usr.Wins));
        }
    }
}