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
    public partial class NewGame : System.Web.UI.Page
    {
        private AhorcadoLogic ahlogic;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Usuario usr = (Usuario)Session["Usuario"];
                Palabra pal = new Palabra("salero");
                Ahorcado ah = new Ahorcado(pal, usr);
                Session["Juego"] = new AhorcadoLogic(ah);
            }
            else
            {
                ahlogic = (AhorcadoLogic)Session["Juego"];
                this.lblIncorrectLetter.Text = Convert.ToString(ahlogic.Ahorcado.LetrasIncorrectas.Count);
            }
            ahlogic = (AhorcadoLogic)Session["Juego"];
            esconderLabels(ahlogic.Ahorcado.Palabra.PalabraActual);
            actualizarJuego();

        }

        private void actualizarJuego()
        {
            if(ahlogic.Ahorcado.LetrasIncorrectas.Count > 0)
            {
                string letrasinc = "";
                foreach (char c in ahlogic.Ahorcado.LetrasIncorrectas)
                {
                    letrasinc = letrasinc + c + ", ";
                }
                //lblIncorrectLetter.Text = letrasinc;
            }
        }

        private void esconderLabels(string palabra)
        {
            int largo = palabra.Length;
            for (int i = 1; i <= palabra.Length; i++)
            {
                Label label = new Label();
                label.ID = "lblLetter" + i.ToString();
                label.Text = "L" + i.ToString();
                phLetters.Controls.Add(label);
            }
        }

        protected void btnPlayLetter_Click(object sender, EventArgs e)
        {
            string l = txtBoxLetter.Text;
            if (l != null && l != "")
            {
                if (ahlogic.ControlaLetraActual(Convert.ToChar(l)))
                {
                    ahlogic.JuegaLetra(Convert.ToChar(l));
                    Session["Juego"] = ahlogic;
                    Response.Redirect("NewGame.aspx");
                }
            }
        }
    }
}