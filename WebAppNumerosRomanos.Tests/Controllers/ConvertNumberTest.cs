﻿using System;
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

        [TestMethod]
        public void NumeroMaiorQue3999()
        {

            Assert.AreEqual(Models.Convert.toRoman(4000), String.Empty);
            Assert.AreEqual(Models.Convert.toRoman(5000), String.Empty);

        }

        [TestMethod]
        public void NumeroIgualUm()
        {
            Assert.AreEqual(Models.Convert.toRoman(1), "I");
        }
    }
}
