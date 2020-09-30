using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Entities;

namespace ReChetoMiAhoracado
{
    [TestClass]
    public class TestsJuego
    {
        Ahorcado Juego = new Ahorcado();
        public void IniciaJuego(char c)
        {
            Juego.Letra = c;
        }

        [TestMethod]
        public void ControlaLetraIngresada()
        {
            IniciaJuego('c');
            Assert.AreEqual(Juego.ControlaLetraActual(), true);
        }

        [TestMethod]

        public void ControlaCantLetrasPalabra()
        {
            IniciaJuego('c');
            Assert.AreEqual(Juego.RetornaCantLetras(), 6);
        }

        [TestMethod]

        public void VerificarLetraEnPalabra()
        {
            IniciaJuego('a');
            Assert.AreEqual(Juego.PreguntaLetra() , true);
        }

        [TestMethod]

        public void ControlaCantIntentos()
        {
            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('a');
            ListDeLetras.Add('s');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('l');
            foreach(var i in ListDeLetras)
            {
                IniciaJuego(i);
                Juego.JuegaLetra();
            }

            Assert.AreEqual(Juego.CantIntentos, 5);
        }

        [TestMethod]

        public void ControlaListaCorrecta()
        {
            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('a');
            ListDeLetras.Add('s');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('l');
            foreach (var i in ListDeLetras)
            {
                IniciaJuego(i);
                Juego.JuegaLetra();
            }
            List<char> letrasCorrectas = new List<char>();
            letrasCorrectas.Add('a');
            letrasCorrectas.Add('s');
            letrasCorrectas.Add('l');

            Assert.Equals(Juego.LetrasCorrectas.Equals(letrasCorrectas), true );
        }

        /*[TestMethod]

        public void ControlaListaIncorrecta()
        {
            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('a');
            ListDeLetras.Add('s');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('l');
            foreach (var i in ListDeLetras)
            {
                IniciaJuego(i);
                Juego.JuegaLetra();
            }
            Assert.AreEqual(Juego.CantIntentos, 5);
        }*/

    }
}
