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
        Ahorcado juego = new Ahorcado();
        
        [TestMethod]
        public void ControlaLetraIngresada()
        {
            Assert.AreEqual(juego.ControlaLetraActual('C'), true);
        }
    }
}
