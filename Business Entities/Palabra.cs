using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entities
{
    public class Palabra
    {
        public Palabra(string Pal) 
        { 
            PalabraActual= Pal.ToLower();
        }

        private string _palabra;

        public string PalabraActual { get => _palabra; set => _palabra = value; }
    }
}
