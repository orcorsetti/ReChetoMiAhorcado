using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Entities
{
    public class Palabra
    {
        private string _PalRandom = "salero";

        public string PalRandom { get => _PalRandom; set => _PalRandom = value; }
    }
}
