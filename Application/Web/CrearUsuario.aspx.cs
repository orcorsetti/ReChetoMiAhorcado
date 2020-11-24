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
            Usuario usu = (Usuario)this.Session["usuario"];
            if (usu != null)
            {
                Response.Redirect("Menu.aspx");
            }
            phAlerts.Controls.Clear();
        }

        protected void btnCrearUser_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            UsuarioLogic ulogic = new UsuarioLogic();
            if (!string.IsNullOrWhiteSpace(this.txtBoxUserName.Text))
            {
                Usuario uprueba = ulogic.getOne(this.txtBoxUserName.Text);
                if (!string.IsNullOrEmpty(uprueba.UserName))
                {
                    Label alert = new Label();
                    alert.Text = "Este usuario ya existe!";
                    alert.CssClass = "alert alert-danger";
                    phAlerts.Controls.Add(alert);
                }
                else
                {
                    usr.UserName = this.txtBoxUserName.Text;
                    usr.Wins = 0;
                    usr.Losses = 0;
                    ulogic.CreateUser(usr);
                    Label alert = new Label();
                    alert.Text = "Usuario Creado Exitosamente";
                    alert.CssClass = "alert alert-success";
                    phAlerts.Controls.Add(alert);
                    this.txtBoxUserName.Enabled = false;
                    this.btnCrearUser.Visible = false;
                }  
            }
            else
            {
                Label alert = new Label();
                alert.Text = "Ingrese un Nombre de Usuario";
                alert.CssClass = "alert alert-danger";
                phAlerts.Controls.Add(alert);
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }
    }
}