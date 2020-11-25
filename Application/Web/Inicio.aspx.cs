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
            phAlerts.Controls.Clear();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUserName.Text;
            if (!String.IsNullOrEmpty(username))
            {
                Usuario usr;
                UsuarioLogic ulogic = new UsuarioLogic();
                usr = ulogic.getOne(username);
                if(usr.UserName != null)
                {
                    Session["usuario"] = usr;
                    Response.Redirect("Menu.aspx");
                }
                else
                {
                    Label lblAlert = new Label();
                    lblAlert.Text = "Usuario no encontrado.";
                    lblAlert.CssClass = "alert alert-danger";
                    phAlerts.Controls.Add(lblAlert);
                    this.txtBoxUserName.Text = "";
                }
            } else
            {
                Label lblAlert = new Label();
                lblAlert.Text = "Ingrese un Nombre de Usuario.";
                lblAlert.CssClass = "alert alert-danger";
                phAlerts.Controls.Add(lblAlert);
            }
        }

        protected void lnkCrearUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("CrearUsuario.aspx");
        }
    }
}