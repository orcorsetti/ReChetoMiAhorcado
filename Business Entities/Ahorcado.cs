using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        public bool ControlaLetraActual(char Letra)
        {
            return (char.IsLetter(char.ToLower(Letra)) & !LetrasCorrectas.Contains(Letra) & !LetrasIncorrectas.Contains(Letra));
        }

        public int RetornaCantLetras()
        {
            return Pal.PalabraActual.Length;
        }

        public bool PreguntaLetra(char Letra)
        {
            return Pal.PalabraActual.Contains(Letra);
        }

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
