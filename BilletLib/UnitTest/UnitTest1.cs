using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPrisEr240()
        {
            // arrange
             Bil Toyota =new Bil();

            // act
            int pris = Toyota.Pris();
            // Assert
            Assert.AreEqual(240,pris);
        }


        [TestMethod]
        public void TestForKøretøj()
        {
            // arrage
            Bil Toyota = new Bil();

            // act
            string køretøj = Toyota.Køretøj();

            // assert

            Assert.AreEqual("bil",køretøj);
        }
    }
}
