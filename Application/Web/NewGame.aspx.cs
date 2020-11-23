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
            ahlogic = (AhorcadoLogic)Session["Juego"];
            generarLabelsLetras(ahlogic.Ahorcado);
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
                lblIncorrectLetter.Text = letrasinc;

                lblRemainingAttempts.Text = ahlogic.Ahorcado.CantIntentos.ToString();
            }
            if(ahlogic.Ahorcado.LetrasCorrectas.Count > 0)
            {
                generarLabelsLetras(ahlogic.Ahorcado);
            }
        }

        private void generarLabelsLetras(Ahorcado ahorcado)
        {
            phLetters.Controls.Clear();

            int largo = ahorcado.Palabra.PalabraActual.Length;
            for (int i = 0; i < largo; i++)
            {
                Label label = new Label();
                label.ID = "lblLetter" + i.ToString();
                if (ahorcado.LetrasCorrectas.Contains(ahorcado.Palabra.PalabraActual[i]))
                {
                    label.Text = ahorcado.Palabra.PalabraActual[i].ToString()+" ";
                }
                else
                {
                    label.Text = "_ ";
                }

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

                    System.Diagnostics.Debug.WriteLine(ahlogic.Ahorcado.LetrasIncorrectas.Count);

                    actualizarJuego();

                    txtBoxLetter.Text = "";

                    if (ahlogic.PreguntaLetra(Convert.ToChar(l)))
                    {
                        if (ahlogic.ControlaVictoria())
                        {
                            int cantInt = ahlogic.Ahorcado.LetrasCorrectas.Count + ahlogic.Ahorcado.LetrasIncorrectas.Count;

                            txtBoxLetter.ReadOnly = true;
                            btnPlayLetter.Enabled = false;
                            lblGameResult.Text = "Felicidades! Ganó en "+cantInt+" intentos!";
                            lblGameResult.Visible = true;
                            btnReturn.Visible = true;
                        }
                    }
                    else
                    {
                        if (ahlogic.ControlaDerrota())
                        {
                            txtBoxLetter.ReadOnly = true;
                            btnPlayLetter.Enabled = false;
                            lblWord.Text = "La palabra era " + ahlogic.Ahorcado.Palabra.PalabraActual;
                            lblWord.Visible = true;
                            lblGameResult.Text = "Casi Casi! Perdió el Juego, intente nuevamente.";
                            lblGameResult.Visible = true;
                            btnTryAgain.Visible = true;
                            btnReturn.Visible = true;
                        }
                    }
                }
                else
                {
                    Response.Write("<script language=javascript>alert('Ingrese una letra que no haya utilizado previamente.')</script>");
                }
            } else 
            {
                Response.Write("<script language=javascript>alert('Debe ingresar una letra.')</script>");
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void btnTryAgain_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewGame.aspx");
        }
    }
}