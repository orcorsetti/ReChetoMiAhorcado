using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entities
{
    public class Ahorcado
    {
        //List<Char> LetrasCorrectas = new List<char>();
        //List<Char> LetrasIncorrectas = new List<char>();

        public bool ControlaLetraActual(char LetraActual)
        {
            return char.IsLetter(char.ToLower(LetraActual));
        }
    }
}
