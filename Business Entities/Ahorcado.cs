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

        private List<Char> letrasCorrectas;

        private List<Char> letrasIncorrectas;

        private char _letra;

        private int _cantIntentos;

        public char Letra { get => _letra; set => _letra = char.ToLower(value); }
        public int CantIntentos { get => _cantIntentos; set => _cantIntentos = value; }
        public List<char> LetrasCorrectas { get => letrasCorrectas; set => letrasCorrectas = value; }
        public List<char> LetrasIncorrectas { get => letrasIncorrectas; set => letrasIncorrectas = value; }

        Palabra pal = new Palabra();
        
        public bool ControlaLetraActual()
        {
            return char.IsLetter(char.ToLower(Letra));
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
    }
}
