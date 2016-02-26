using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiWrapper;

namespace ConsoleUnitTest
{
    [TestClass]
    public class WriteTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(ApiWrapper.API.WriteMessage("Hello World"));

            Assert.IsFalse(ApiWrapper.API.WriteMessage(""));

            Assert.IsFalse(ApiWrapper.API.WriteMessage(null));
        }
    }
}
