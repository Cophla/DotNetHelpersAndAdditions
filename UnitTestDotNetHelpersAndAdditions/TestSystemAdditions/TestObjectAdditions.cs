using DotNetHelpersAndAdditions.SystemAdditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestDotNetHelpersAndAdditions.TestSystemAdditions
{
    [TestClass]
    public class TestObjectAdditions
    {
        #region Public Methods

        [TestMethod]
        public void TestDaEquals()
        {
            Assert.IsFalse(1.DaEquals(5));
            Assert.IsTrue(10.DaEquals(10));
            Assert.IsFalse(DateTime.Now.DaEquals(DateTime.Today));
            Assert.IsTrue(((object)"").DaEquals(""));
        }

        [TestMethod]
        public void TestDaHasAllEquals()
        {
            Assert.IsFalse(1.DaHasAllEquals(2, 5));
            Assert.IsTrue(10.DaHasAllEquals(10, 10, 10));
            Assert.IsFalse(10.DaHasAllEquals(10, 10, 11));
            Assert.IsFalse(((object)"TestDaIndexOf").DaHasAllEquals("False", "kingstone"));
            Assert.IsTrue(((object)"TestDaIndexOf").DaHasAllEquals(
                "tESTeXiNDEXoF", "tESTeXiNDexof", "testeXiNDEXoF"
            ));
            Assert.IsFalse(((object)"TestDaIndexOf").DaHasAllEquals(
                "tEST", "tESTeXiNDEXoF", "tESTeXiNDexof"
            ));
        }

        [TestMethod]
        public void TestDaIsNone()
        {
            Assert.IsTrue(((object)"   ").DaIsNone());
            Assert.IsTrue(((object)"").DaIsNone());
            Assert.IsTrue(((object)string.Empty).DaIsNone());
            Assert.IsTrue(((object)(null as string)).DaIsNone());
            Assert.IsFalse(((object)" 1 ").DaIsNone());
            Assert.IsFalse(((object)"123").DaIsNone());
            Assert.IsTrue(DBNull.Value.DaIsNone());
            Assert.IsTrue((null as object).DaIsNone());
            Assert.IsFalse(new Object().DaIsNone());
        }

        [TestMethod]
        public void TestDaNotEquals()
        {
            Assert.IsTrue(1.DaNotEquals(5));
            Assert.IsFalse(10.DaNotEquals(10));
            Assert.IsTrue(DateTime.Now.DaNotEquals(DateTime.Today));
            Assert.IsFalse(((object)"").DaNotEquals(""));
        }

        #endregion Public Methods
    }
}