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
            Usuario usr = (Usuario)Session["Usuario"];
            if(usr != null)
            {
                if (!IsPostBack)
                {
                    Palabra pal;
                    if ((bool)Session["testMode"])
                    {
                        pal = new Palabra("salero");
                    }
                    else
                    {
                        pal = new Palabra();
                    }
                    Ahorcado ah = new Ahorcado(pal, usr);
                    Session["Juego"] = new AhorcadoLogic(ah);
                }
                ahlogic = (AhorcadoLogic)Session["Juego"];
                generarLabelsLetras(ahlogic.Ahorcado);    
                actualizarJuego();         
            }
            else
            {
                Response.Redirect("Inicio.aspx");
            }

           

        }

        private void actualizarJuego()
        {
            phAlerts.Controls.Clear();

            if(ahlogic.Ahorcado.LetrasIncorrectas.Count > 0)
            {
                string letrasinc = "";
                foreach (char c in ahlogic.Ahorcado.LetrasIncorrectas)
                {
                    letrasinc = letrasinc + c + ", ";
                }
                lblIncorrectLetter.Text = letrasinc;

            }
            lblRemainingAttempts.Text = ahlogic.Ahorcado.CantIntentos.ToString();
            if(ahlogic.Ahorcado.LetrasCorrectas.Count > 0)
            {
                generarLabelsLetras(ahlogic.Ahorcado);
            }

            switch (ahlogic.Ahorcado.CantIntentos)
            {
                case 0: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 0).png";
                    break;
                case 1: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 1).png";
                    break;
                case 2: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 2).png";
                    break;
                case 3: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 3).png";
                    break;
                case 4: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 4).png";
                    break;
                case 5: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 5).png";
                    break;
                case 6: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 6).png";
                    break;
                case 7: this.imgAhorcado.ImageUrl = "~/Resources/Horca(intento 7).png";
                    break;

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
                label.CssClass = "lead p-2 text-white";
                if (ahorcado.LetrasCorrectas.Contains(ahorcado.Palabra.PalabraActual[i]))
                {
                    label.Text = ahorcado.Palabra.PalabraActual[i].ToString();
                }
                else
                {
                    label.Text = "_";
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
                            lblGameResult.CssClass = "card text-white bg-success p-2";
                            lblGameResult.Text = "Felicidades! Ganó en "+cantInt+" intentos!";
                            lblGameResult.Visible = true;
                            btnTryAgain.Visible = true;
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
                            lblGameResult.CssClass = "card text-white bg-danger p-2";
                            lblGameResult.Text = "Casi Casi! Perdió el Juego, intente nuevamente.";
                            lblGameResult.Visible = true;
                            btnTryAgain.Visible = true;
                        }
                    }
                }
                else
                {
                    Label alert = new Label();
                    alert.Text = "Ingrese una letra que no haya utilizado previamente";
                    alert.CssClass = "alert alert-warning";
                    phAlerts.Controls.Add(alert);
                }
            } else 
            {
                Label alert = new Label();
                alert.Text = "Ingrese una letra";
                alert.CssClass = "alert alert-warning";
                phAlerts.Controls.Add(alert);
            }
        }

        protected void btnTryAgain_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewGame.aspx");
        }

        protected void lnkBtnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}