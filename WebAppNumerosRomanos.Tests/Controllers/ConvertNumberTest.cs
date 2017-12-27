using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppNumerosRomanos.Controllers;
using System.Collections.Generic;

namespace WebAppNumerosRomanos.Tests.Controllers
{
    [TestClass]
    public class ConvertNumberTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ConvertNumberController controller = new ConvertNumberController();

            // Act
            string result = controller.Get(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("I", result);
        }
    }
}
