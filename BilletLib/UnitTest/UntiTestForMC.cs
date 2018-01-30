using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestForMc
    {
        [TestMethod]
        public void TestMcKoster125()
        {
            // arrange
            MC suzuki = new MC();
            // act
            int pris = suzuki.Pris();
            // assert
            Assert.AreEqual(125, pris);

        }

        [TestMethod]
        public void TestOmDenReturnerMC()
        {
            // arrange
            MC Suzuki = new MC();
            //act
            string køretøj = Suzuki.køretøj();
            // Assert
            Assert.AreEqual("MC", køretøj);

        
        }
    }
}
