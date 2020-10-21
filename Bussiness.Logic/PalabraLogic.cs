using Business_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bussiness.Logic
{
    public class PalabraLogic
    {
        public bool ControlaLargoPalabra(string PalabraActual)
        {
            if (PalabraActual.Length >= 6)
            {
                return true;
            }
            return false;
        }

        public bool ControlaSoloLetrasEnPalabra(string PalabraActual)
        {
            Regex Val = new Regex(@"^[a-zA-Z]+$");
            return Val.IsMatch(PalabraActual);
        }
    }
}
