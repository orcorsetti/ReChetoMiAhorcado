using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business_Entities
{
    public class Ahorcado
    {

        public Ahorcado()
        {
            _cantIntentos = 7;
        }

        private Palabra _pal;

        private List<Char> _letrasCorrectas = new List<char>();

        private List<Char> _letrasIncorrectas = new List<char>();

        private int _cantIntentos;

        private string _nombUsuario;

        #region Properties
        public int CantIntentos { get => _cantIntentos; set => _cantIntentos = value; }
        public List<char> LetrasCorrectas { get => _letrasCorrectas; set => _letrasCorrectas = value; }
        public List<char> LetrasIncorrectas { get => _letrasIncorrectas; set => _letrasIncorrectas = value; }
        public string NombUsuario { get => _nombUsuario; set => _nombUsuario = value; }
        public Palabra Pal { get => _pal; set => _pal = value; }

        #endregion


        //Verifica que la letra sea efectivamente una letra y que no haya sido ingresada previamente
        public bool ControlaLetraActual(char Letra)
        {
            return (char.IsLetter(char.ToLower(Letra)) & !LetrasCorrectas.Contains(Letra) & !LetrasIncorrectas.Contains(Letra));
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
            return Pal.PalabraActual.Contains(Letra);
        }

        public bool ControlaVictoria() 
        {
            return Pal.PalabraActual.All(LetrasCorrectas.Contains);
        }

        //Proceso de jugar una letra 
        public void JuegaLetra(char Letra)
        {
            if (PreguntaLetra(Letra))
            {
                LetrasCorrectas.Add(Letra);
            }
            else
            {
                LetrasIncorrectas.Add(Letra);
                CantIntentos -= 1;
            }
        }


        //Metodo principal, despues verlo entre los 3
        //public void Jugar()
        //{
        //    while (CantIntentos != 0 )
        //    {
        //        JuegaLetra(Letra);
        //    }
        //}
    }
}
