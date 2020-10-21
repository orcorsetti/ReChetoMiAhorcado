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

        private string _palabra;
        public string PalabraActual { get => _palabra; set => _palabra = value; }

        public Palabra(string p)
        {
            PalabraActual = p;
        }

    }
}
