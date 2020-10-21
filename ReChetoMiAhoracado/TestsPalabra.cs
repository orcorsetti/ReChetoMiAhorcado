using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Entities;
using System.Linq;
using System.Text.RegularExpressions;
using Bussiness.Logic;

namespace ReChetoMiAhoracado
{
    [TestClass]
    public class TestsPalabra
    {
        [TestMethod]
        public void ControlarLargoPalabra()
        {
            //Arrange
            PalabraLogic P = new PalabraLogic();

            //Act
            bool bandera = P.ControlaLargoPalabra("salero");

            //Assert
            Assert.IsTrue(bandera);
        }

        [TestMethod]
        public void ControlarLetraPalabra()
        {
            //Arrange
            PalabraLogic P = new PalabraLogic();

            //Act
            bool bandera = P.ControlaSoloLetrasEnPalabra("salero");
            
            //Assert
            Assert.IsTrue(bandera);
        }
    }
}
