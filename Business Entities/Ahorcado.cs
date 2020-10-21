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
        private Palabra _pal;

        private List<Char> _letrasCorrectas = new List<char>();

        private List<Char> _letrasIncorrectas = new List<char>();

        private int _cantIntentos;

        private Usuario _usuario;

        #region Properties
        public int CantIntentos { get => _cantIntentos; set => _cantIntentos = value; }
        public List<char> LetrasCorrectas { get => _letrasCorrectas; set => _letrasCorrectas = value; }
        public List<char> LetrasIncorrectas { get => _letrasIncorrectas; set => _letrasIncorrectas = value; }
        public Palabra Palabra { get => _pal; set => _pal = value; }
        public Usuario Usuario { get => _usuario; set => _usuario = value; }

        #endregion

        public Ahorcado(Palabra p, Usuario u)
        {
            _cantIntentos = 7;
            Palabra = p;
            Usuario = u;
        }
    }
}
