using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Entities;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReChetoMiAhoracado
{
    [TestClass]
    public class TestsPalabra
    {
        [TestMethod]
        public void ControlarLargoPalabra()
        {
            //Arrange
            Palabra P = new Palabra("Salero");

            //Act
            bool bandera = P.ControlaLargoPalabra();

            //Assert
            Assert.IsTrue(bandera);
        }

        [TestMethod]
        public void ControlarLetraPalabra()
        {
            //Arrange
            Palabra P = new Palabra("Salero");

            //Act
            bool bandera = P.ControlaSoloLetrasEnPalabra();
            
            //Assert
            Assert.IsTrue(bandera);
        }
    }
}
