using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Entities;
using System.Linq;
using System.Text.RegularExpressions;

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
            Assert.AreEqual(true , Juego.PreguntaLetra());
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
            foreach (var i in ListDeLetras)
            {
                IniciaJuego(i);
                Juego.JuegaLetra();
            }

            Assert.AreEqual(5, Juego.CantIntentos);
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


            Assert.AreEqual(true, letrasCorrectas.All(Juego.LetrasCorrectas.Contains));
        }

        [TestMethod]

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

            List<char> letrasIncorrectas = new List<char>();
            letrasIncorrectas.Add('t');
            letrasIncorrectas.Add('y');

            Assert.AreEqual(true, letrasIncorrectas.All(Juego.LetrasIncorrectas.Contains));
        }


        [TestMethod]

        public void JugarDeNuevoDerrota()
        {
            //Arrange
            Palabra pal = new Palabra();
            pal.PalRandom = "salero";

            //Act
            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('v');
            ListDeLetras.Add('x');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('w');
            ListDeLetras.Add('q');
            ListDeLetras.Add('m');
            foreach (var i in ListDeLetras)
            {
                IniciaJuego(i);
                Juego.JuegaLetra();
            }

            //Assert
            Assert.AreEqual(Juego.CantIntentos, 0);
        }


        [TestMethod]
        public void JugarDeNuevoGanar()
        {
            //Arrange
            Palabra pal = new Palabra();
            pal.PalRandom = "salero";

            //Act
            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('s');
            ListDeLetras.Add('a');
            ListDeLetras.Add('l');
            ListDeLetras.Add('e');
            ListDeLetras.Add('r');
            ListDeLetras.Add('o');
            foreach (var i in ListDeLetras)
            {
                IniciaJuego(i);
                Juego.JuegaLetra();
            }

            //Assert
            Assert.AreEqual(true, ListDeLetras.All(Juego.LetrasCorrectas.Contains));
        }


        [TestMethod]
        public void VerificarNombre()
        {
            //Arrange
            Juego.NombUsuario = "Ingrese nombre de Usuario";
            Regex Val = new Regex(@"^[a-zA-Z]+$");

            //Act
            Juego.NombUsuario = "Pepito";

            //Assert
            Assert.IsTrue(Val.IsMatch(Juego.NombUsuario));
        }

        //[TestMethod]
        //public void IngresaPalabraAAdivinar()
        //{
        //    //Arrange
        //    Palabra pal = new Palabra();
        //    Palabra. = "Ingrese nombre de Usuario";
        //    Regex Val = new Regex(@"^[a-zA-Z]+$");

        //    //Act
        //    Juego.NombUsuario = "Pepito";

        //    //Assert
        //    Assert.IsTrue(Val.IsMatch(Juego.NombUsuario));
        //}

    }
}
