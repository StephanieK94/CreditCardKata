using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaskingClasses;

namespace MaskingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "12345";

            Masker ms = new Masker();

            string actual = ms.MaskSecureNumbers(input);

            Assert.AreEqual("", actual);
        }
    }
}
