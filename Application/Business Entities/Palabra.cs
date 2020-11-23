using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Business_Entities
{
    public class Palabra
    {
        string[] PalabrasPosibles = {"chancleta", "salero", 
                                    "utensillo", "facultad", 
                                    "ahorcado", "universidad", 
                                    "agilidad", "metodologia"};

        private string _palabra;
        public string PalabraActual { get => _palabra; set => _palabra = value; }

        public Palabra(string p)
        {
            PalabraActual = p;
        }

        public Palabra()
        {
            Random r = new Random();
            int index = r.Next(0, PalabrasPosibles.Length-1);
            PalabraActual = PalabrasPosibles[index];
        }

    }
}
