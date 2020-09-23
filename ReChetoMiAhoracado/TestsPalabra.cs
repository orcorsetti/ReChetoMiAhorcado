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
        Palabra P = new Palabra();

        [TestMethod]
        public void ControlarLargoPalabra()
        {
            Palabra P = new Palabra();

            Assert.AreEqual(P.PalRandom.Length >= 6, true);
        }

        [TestMethod]
        public void ControlarLetraPalabra()
        {
            Regex Val = new Regex(@"^[a-zA-Z]+$");
            
            Assert.AreEqual(Val.IsMatch(P.PalRandom), true);
        }
    }
}
