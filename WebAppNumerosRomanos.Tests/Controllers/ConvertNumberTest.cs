using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppNumerosRomanos.Controllers;
using System.Collections.Generic;

namespace WebAppNumerosRomanos.Tests.Controllers
{
    [TestClass]
    public class ConvertTest
    {
        [TestMethod]
        public void NumeroMenorQueUm()
        {

            Assert.AreEqual(Models.Convert.toRoman(-1), String.Empty);
            Assert.AreEqual(Models.Convert.toRoman(0), String.Empty);
            Assert.AreEqual(Models.Convert.toRoman(-14), String.Empty);

        }
    }
}
