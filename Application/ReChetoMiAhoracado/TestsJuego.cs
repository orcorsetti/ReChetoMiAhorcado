using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Entities;
using System.Linq;
using System.Text.RegularExpressions;
using Bussiness.Logic;
using Data.Database;

namespace ReChetoMiAhoracado
{
    [TestClass]
    public class TestsJuego
    {
        [TestMethod]
        public void ControlaValidezLetraIngresada()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

            //Act
            bool bandera = Juego.ControlaLetraActual('s');

            //Assert
            Assert.IsTrue(bandera);
        }

        [TestMethod]

        public void VerificarLetraPerteneceAPalabraLogic()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

            //Act
            bool bandera = Juego.PreguntaLetra('a');

            //Assert
            Assert.IsTrue(bandera);
        }

        [TestMethod]

        public void ControlaCantIntentosQuedan5()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

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
            Assert.AreEqual(5, Juego.Ahorcado.CantIntentos);
        }

        [TestMethod]

        public void ControlaListaCorrecta()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

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
            Assert.IsTrue(letrasCorrectas.All(Juego.Ahorcado.LetrasCorrectas.Contains));
        }

        [TestMethod]

        public void ControlaListaIncorrecta()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

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
            Assert.IsTrue(letrasIncorrectas.All(Juego.Ahorcado.LetrasIncorrectas.Contains));
        }


        [TestMethod]

        public void CantidadIntetosDerrota()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

            List<char> ListDeLetras = new List<char>();
            ListDeLetras.Add('v');
            ListDeLetras.Add('x');
            ListDeLetras.Add('t');
            ListDeLetras.Add('y');
            ListDeLetras.Add('s');
            ListDeLetras.Add('a');
            ListDeLetras.Add('w');
            ListDeLetras.Add('q');
            ListDeLetras.Add('m');

            //Act
            foreach (var i in ListDeLetras)
            {
                Juego.JuegaLetra(i);
            }
            bool bandera = Juego.Ahorcado.CantIntentos == 0;

            //Assert
            Assert.IsTrue(bandera);
        }


        [TestMethod]
        public void ControlaVictoria()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

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
            bool bandera = Juego.Ahorcado.Palabra.PalabraActual.All(Juego.Ahorcado.LetrasCorrectas.Contains);

            //Assert
            Assert.IsTrue(bandera);
        }


        [TestMethod]
        public void VerificarNombreUsuario()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);

            //Act
            bool bandera = Juego.ControlaSoloLetras("pepito");

            //Assert
            Assert.IsTrue(bandera);
        }
    }
}
