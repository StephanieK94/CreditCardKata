using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaskingClasses;

namespace MaskingTests
{
    [TestClass]
    public class UnitTestsForMasking
    {
        [TestMethod]
        public void ReturnsEmptyString()
        {
            string input = "12345";

            Masker ms = new Masker();

            string actual = ms.MaskSecureNumbers(input);

            Assert.AreEqual("#2345", actual);
        }
    }
}
