using System;
using DataAssignmentTwo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestVideoRental
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Common common = new Common();
            Assert.AreEqual(common.CheckConnection(), true); 
        }

        [TestMethod]
        public void TestMethod2()
        {
            string value = "mre";
            Assert.AreEqual(Checks.checkNumber(value), false);
        }
    }
}
