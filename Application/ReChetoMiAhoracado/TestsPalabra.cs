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
        public void ControlaPalabraTest()
        {
            //Arrange
            Palabra pal = new Palabra("salero");
            PalabraLogic P = new PalabraLogic();
            bool bandera;

            //Act
            if (P.ControlaLargoPalabra(pal.PalabraActual) && P.ControlaSoloLetrasEnPalabra(pal.PalabraActual))
            {
                bandera = true;
            }
            else
            {
                bandera = false;
            }

            //Assert
            Assert.IsTrue(bandera);
        }

        [TestMethod]
        public void ControlaPalabraRandom()
        {
            //Arrange
            Palabra pal = new Palabra();
            PalabraLogic palLogic = new PalabraLogic();
            bool bandera;

            //Act
            if(palLogic.ControlaLargoPalabra(pal.PalabraActual) && palLogic.ControlaSoloLetrasEnPalabra(pal.PalabraActual))
            {
                bandera = true;
            }else
            {
                bandera = false;
            }

            //Assert
            Assert.IsTrue(bandera);
        }
    }
}
