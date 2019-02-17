using DotNetHelpersAndAdditions.SystemAdditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDotNetHelpersAndAdditions.TestSystemAdditions
{
    [TestClass]
    public class TestStringAdditions
    {
        #region Public Methods

        [TestMethod]
        public void TestDaContains()
        {
            Assert.IsFalse("TestDaIndexOf".DaContains("False"));
            Assert.IsTrue("TestDaIndexOf".DaContains("Ex"));
            Assert.IsFalse("TestDaIndexOf".DaContains("false"));
            Assert.IsTrue("TestDaIndexOf".DaContains("exi"));
        }

        [TestMethod]
        public void TestDaEquals()
        {
            Assert.IsFalse("TestDaIndexOf".DaEquals("False"));
            Assert.IsTrue("TestDaIndexOf".DaEquals("tESTeXiNDEXoF"));
            Assert.IsFalse("TestDaIndexOf".DaEquals("tEST"));
        }

        [TestMethod]
        public void TestDaHasAllEquals()
        {
            Assert.IsFalse("TestDaIndexOf".DaHasAllEquals("False", "kingstone"));
            Assert.IsTrue("TestDaIndexOf".DaHasAllEquals("tESTeXiNDEXoF", "tESTeXiNDexof", "testeXiNDEXoF"));
            Assert.IsFalse("TestDaIndexOf".DaHasAllEquals("tEST", "tESTeXiNDEXoF", "tESTeXiNDexof"));
        }

        [TestMethod]
        public void TestDaHasEquals()
        {
            Assert.IsFalse("TestDaIndexOf".DaHasEquals("False", "kingstone"));
            Assert.IsTrue("TestDaIndexOf".DaHasEquals("tESTeXiNDEXoF", "tESTeXiNDexof", "testeXiNDEXoF"));
            Assert.IsTrue("TestDaIndexOf".DaHasEquals("tEST", "tESTeXiNDEXoF", "tESTeXiNDexof"));
        }

        [TestMethod]
        public void TestDaHasNoEquals()
        {
            Assert.IsTrue("TestDaIndexOf".DaHasNoEquals("False", "kingstone"));
            Assert.IsFalse("TestDaIndexOf".DaHasNoEquals("tESTeXiNDEXoF", "tESTeXiNDexof", "testeXiNDEXoF"));
            Assert.IsFalse("TestDaIndexOf".DaHasNoEquals("tEST", "tESTeXiNDEXoF", "tESTeXiNDexof"));
        }

        [TestMethod]
        public void TestDaHasNotAllEquals()
        {
            Assert.IsTrue("TestDaIndexOf".DaHasNotAllEquals("False", "kingstone"));
            Assert.IsFalse("TestDaIndexOf".DaHasNotAllEquals("tESTeXiNDEXoF", "tESTeXiNDexof", "testeXiNDEXoF"));
            Assert.IsFalse("TestDaIndexOf".DaHasNotAllEquals("tEST", "tESTeXiNDEXoF", "tESTeXiNDexof"));
        }

        [TestMethod]
        public void TestDaIndexOf()
        {
            Assert.AreEqual("TestDaIndexOf".DaIndexOf("False"), -1);
            Assert.AreEqual("TestDaIndexOf".DaIndexOf("Da"), 4);
            Assert.AreEqual("TestDaIndexOf".DaIndexOf("false"), -1);
            Assert.AreEqual("TestDaIndexOf".DaIndexOf("exi"), 4);
        }

        [TestMethod]
        public void TestDaIsNone()
        {
            Assert.IsTrue("   ".DaIsNone());
            Assert.IsTrue("".DaIsNone());
            Assert.IsTrue(string.Empty.DaIsNone());
            Assert.IsTrue((null as string).DaIsNone());
            Assert.IsFalse(" 1 ".DaIsNone());
            Assert.IsFalse("123".DaIsNone());
        }

        [TestMethod]
        public void TestDaNotEquals()
        {
            Assert.IsTrue("TestDaIndexOf".DaNotEquals("False"));
            Assert.IsFalse("TestDaIndexOf".DaNotEquals("tESTeXiNDEXoF"));
            Assert.IsTrue("TestDaIndexOf".DaNotEquals("tEST"));
        }

        #endregion Public Methods
    }
}