using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaskingClasses;

namespace MaskingTests
{
    [TestClass]
    public class UnitTestsForMasking
    {
        [TestMethod]
        public void ReturnsMaskedString()
        {
            var expected = "#2345";
            var input = "12345";

            var ms = new Masker();

            var actual = ms.MaskSecureNumbers(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsEmptyStringWhenGivenShorterThan4()
        {
            var expected = String.Empty;
            var input = "1234";

            var ms = new Masker();

            var actual = ms.MaskSecureNumbers(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
