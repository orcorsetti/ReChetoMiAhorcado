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
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrearUser_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            UsuarioLogic ulogic = new UsuarioLogic();
            if (!string.IsNullOrWhiteSpace(this.txtBoxUserName.Text))
            {
                usr.UserName = this.txtBoxUserName.Text;
                usr.Wins = 0;
                usr.Losses = 0;
                ulogic.CreateUser(usr);
                Response.Write("<script language=javascript>alert('Usuario creado exitosamente!')</script>");
                this.txtBoxUserName.Enabled = false;
                this.btnCrearUser.Visible = false;
            }
            else
            {
                Response.Write("<script language=javascript>alert('Ingrese un nombre de usuario')</script>");
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}