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

        private List<Char> _letrasCorrectas = new List<char>();

        private List<Char> _letrasIncorrectas = new List<char>();

        private char _letra;

        private int _cantIntentos;

        private string _nombUsuario;

        #region Properties
        public char Letra { get => _letra; set => _letra = char.ToLower(value); }
        public int CantIntentos { get => _cantIntentos; set => _cantIntentos = value; }
        public List<char> LetrasCorrectas { get => _letrasCorrectas; set => _letrasCorrectas = value; }
        public List<char> LetrasIncorrectas { get => _letrasIncorrectas; set => _letrasIncorrectas = value; }
        public string NombUsuario { get => _nombUsuario; set => _nombUsuario = value; }

        #endregion

        Palabra pal = new Palabra();
        
        public bool ControlaLetraActual()
        {
            return (char.IsLetter(char.ToLower(Letra)) & !LetrasCorrectas.Contains(Letra) & !LetrasIncorrectas.Contains(Letra));
        }

        public int RetornaCantLetras()
        {
            return pal.PalRandom.Length;
        }

        public bool PreguntaLetra()
        {
            return pal.PalRandom.Contains(Letra);
        }

        public void JuegaLetra()
        {
            if (PreguntaLetra())
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
        public void Jugar()
        {
            while (CantIntentos != 0 )
            {
                JuegaLetra();
            }
        }
    }
}
