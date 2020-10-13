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
        [TestMethod]
        public void ControlaLetraIngresada()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

            //Act
            bool bandera = Juego.ControlaLetraActual('s');

            //Assert
            Assert.IsTrue(bandera);
        }

        [TestMethod]

        public void ControlaCantLetrasPalabra()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

            //Act
            int cantLetras = Juego.RetornaCantLetras();

            //Assert
            Assert.AreEqual(6, cantLetras);
        }

        [TestMethod]

        public void VerificarLetraEnPalabra()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

            //Act
            bool bandera = Juego.PreguntaLetra('a');

            //Assert
            Assert.IsTrue(bandera);
        }

        [TestMethod]

        public void ControlaCantIntentos()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('a');
            ListDeLetras.Add('s');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('l');

            //Act
            foreach (var i in ListDeLetras)
            {
                Juego.JuegaLetra(i);
            }

            //Assert
            Assert.AreEqual(5, Juego.CantIntentos);
        }

        [TestMethod]

        public void ControlaListaCorrecta()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('a');
            ListDeLetras.Add('s');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('l');

            List<char> letrasCorrectas = new List<char>();
            letrasCorrectas.Add('a');
            letrasCorrectas.Add('s');
            letrasCorrectas.Add('l');

            //Act
            foreach (var i in ListDeLetras)
            {
                Juego.JuegaLetra(i);
            }
            
            //Assert
            Assert.IsTrue(letrasCorrectas.All(Juego.LetrasCorrectas.Contains));
        }

        [TestMethod]

        public void ControlaListaIncorrecta()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('a');
            ListDeLetras.Add('s');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('l');

            List<char> letrasIncorrectas = new List<char>();
            letrasIncorrectas.Add('t');
            letrasIncorrectas.Add('y');

            //Act
            foreach (var i in ListDeLetras)
            {
                Juego.JuegaLetra(i);
            }

            //Assert
            Assert.IsTrue(letrasIncorrectas.All(Juego.LetrasIncorrectas.Contains));
        }


        [TestMethod]

        public void JugarDeNuevoDerrota()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

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
                Juego.JuegaLetra(i);
            }

            //Assert
            Assert.AreEqual(Juego.CantIntentos, 0);
        }

        //Agregar setear palabra en el juego
        [TestMethod]
        public void JugarDeNuevoGanar()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
            Palabra pal = new Palabra("salero");
            Juego.Pal = pal;

            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('s');
            ListDeLetras.Add('a');
            ListDeLetras.Add('l');
            ListDeLetras.Add('e');
            ListDeLetras.Add('r');
            ListDeLetras.Add('o');
            
            //Act
            foreach (var i in ListDeLetras)
            {
                Juego.JuegaLetra(i);
            }

            //Assert
            Assert.AreEqual(true, ListDeLetras.All(Juego.LetrasCorrectas.Contains));
        }


        [TestMethod]
        public void VerificarNombre()
        {
            //Arrange
            Ahorcado Juego = new Ahorcado();
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
