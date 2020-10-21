using Business_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bussiness.Logic
{
    public class AhorcadoLogic
    {
        private Ahorcado ahorcado;

        public Ahorcado Ahorcado { get => ahorcado; set => ahorcado = value; }

        public AhorcadoLogic(Ahorcado a)
        {
            Ahorcado = a;
        }

        //Verifica que la letra sea efectivamente una letra y que no haya sido ingresada previamente
        public bool ControlaLetraActual(char Letra)
        {
            return (char.IsLetter(char.ToLower(Letra)) & !Ahorcado.LetrasCorrectas.Contains(Letra) & !Ahorcado.LetrasIncorrectas.Contains(Letra));
        }

        //Controla que texto tenga solo caracteres alfabeticos
        public bool ControlaSoloLetras(string texto)
        {
            Regex Val = new Regex(@"^[a-zA-Z]+$");
            return Val.IsMatch(texto);
        }


        //Controla que la letra pertenezca a la palabra
        public bool PreguntaLetra(char Letra)
        {
            return Ahorcado.Palabra.PalabraActual.Contains(Letra);
        }

        public bool ControlaVictoria()
        {
            UsuarioLogic ul = new UsuarioLogic();


            //Hay que ver que se hace
            if( Ahorcado.Palabra.PalabraActual.All(Ahorcado.LetrasCorrectas.Contains)== true)   
            {
                ul.ActualizaCantidadesWL(Ahorcado.Usuario,true);
            } else 
            {
                ul.ActualizaCantidadesWL(Ahorcado.Usuario,false);
            }


            return Ahorcado.Palabra.PalabraActual.All(Ahorcado.LetrasCorrectas.Contains);
        }

        //Proceso de jugar una letra 
        public void JuegaLetra(char Letra)
        {
            if (PreguntaLetra(Letra))
            {
                Ahorcado.LetrasCorrectas.Add(Letra);
            }
            else
            {
                Ahorcado.LetrasIncorrectas.Add(Letra);
                Ahorcado.CantIntentos -= 1;
            }
        }
    }
}
