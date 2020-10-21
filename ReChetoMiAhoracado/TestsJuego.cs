using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Entities;
using System.Linq;
using System.Text.RegularExpressions;
using Bussiness.Logic;

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
            bool bandera = Juego.ControlaVictoria();

            //Assert
            Assert.IsFalse(bandera);
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
            bool bandera = Juego.ControlaVictoria();

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

        [TestMethod]
        public void CantidadPartidasGanadas()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);
            AhorcadoLogic Juego1 = new AhorcadoLogic(a);
            AhorcadoLogic Juego2 = new AhorcadoLogic(a);

            UsuarioLogic ul = new UsuarioLogic();

            List<char> ListDeLetrasGana = new List<char>();
            ListDeLetrasGana.Add('s');
            ListDeLetrasGana.Add('a');
            ListDeLetrasGana.Add('l');
            ListDeLetrasGana.Add('e');
            ListDeLetrasGana.Add('r');
            ListDeLetrasGana.Add('o');

            List<char> ListDeLetrasGana1 = new List<char>();
            ListDeLetrasGana1.Add('s');
            ListDeLetrasGana1.Add('a');
            ListDeLetrasGana1.Add('l');
            ListDeLetrasGana1.Add('e');
            ListDeLetrasGana1.Add('r');
            ListDeLetrasGana1.Add('t');
            ListDeLetrasGana1.Add('g');
            ListDeLetrasGana1.Add('o');

            List<char> ListDeLetrasPierde = new List<char>();
            ListDeLetrasPierde.Add('v');
            ListDeLetrasPierde.Add('x');
            ListDeLetrasPierde.Add('t');
            ListDeLetrasPierde.Add('y');
            ListDeLetrasPierde.Add('s');
            ListDeLetrasPierde.Add('a');
            ListDeLetrasPierde.Add('w');
            ListDeLetrasPierde.Add('q');
            ListDeLetrasPierde.Add('m');

            //Act
            foreach (var i in ListDeLetrasGana) 
            {
                Juego.JuegaLetra(i);
            }
            Juego.ControlaVictoria();

            foreach (var i in ListDeLetrasGana1)   
            {
                Juego1.JuegaLetra(i);
            }
            Juego1.ControlaVictoria();

            foreach(var i in ListDeLetrasPierde) 
            {
                Juego2.JuegaLetra(i);
            }
            Juego2.ControlaVictoria();

            u = ul.getOne(u.UserName);

            //Assert
            Assert.AreEqual(2, u.Wins);
        }

        [TestMethod]
        public void CantidadPartidasPerdidas()
        {
            //Arrange
            Usuario u = new Usuario();
            Palabra p = new Palabra("salero");
            Ahorcado a = new Ahorcado(p, u);
            AhorcadoLogic Juego = new AhorcadoLogic(a);
            AhorcadoLogic Juego1 = new AhorcadoLogic(a);
            AhorcadoLogic Juego2 = new AhorcadoLogic(a);

            UsuarioLogic ul = new UsuarioLogic();

            List<char> ListDeLetrasGana = new List<char>();
            ListDeLetrasGana.Add('s');
            ListDeLetrasGana.Add('a');
            ListDeLetrasGana.Add('l');
            ListDeLetrasGana.Add('e');
            ListDeLetrasGana.Add('r');
            ListDeLetrasGana.Add('o');

            List<char> ListDeLetrasGana1 = new List<char>();
            ListDeLetrasGana1.Add('s');
            ListDeLetrasGana1.Add('a');
            ListDeLetrasGana1.Add('l');
            ListDeLetrasGana1.Add('e');
            ListDeLetrasGana1.Add('r');
            ListDeLetrasGana1.Add('t');
            ListDeLetrasGana1.Add('g');
            ListDeLetrasGana1.Add('o');

            List<char> ListDeLetrasPierde = new List<char>();
            ListDeLetrasPierde.Add('v');
            ListDeLetrasPierde.Add('x');
            ListDeLetrasPierde.Add('t');
            ListDeLetrasPierde.Add('y');
            ListDeLetrasPierde.Add('s');
            ListDeLetrasPierde.Add('a');
            ListDeLetrasPierde.Add('w');
            ListDeLetrasPierde.Add('q');
            ListDeLetrasPierde.Add('m');

            //Act
            foreach (var i in ListDeLetrasGana)
            {
                Juego.JuegaLetra(i);
            }
            Juego.ControlaVictoria();

            foreach (var i in ListDeLetrasGana1)
            {
                Juego1.JuegaLetra(i);
            }
            Juego1.ControlaVictoria();

            foreach (var i in ListDeLetrasPierde)
            {
                Juego2.JuegaLetra(i);
            }
            Juego2.ControlaVictoria();

            u = ul.getOne(u.UserName);

            //Assert
            Assert.AreEqual(1, u.Losses);
        }
    }
}
