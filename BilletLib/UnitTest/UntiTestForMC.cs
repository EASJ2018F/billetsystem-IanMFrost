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
            string køretøj = Suzuki.Køretøj();
            // Assert
            Assert.AreEqual("MC", køretøj);
        }

        [TestMethod]
        public void TestLængdeForNummerplade()
        {
            // arrange
            MC GrimCykel = new MC();

            // act
            string nummerplade = GrimCykel.NummerPladeBegrænsing();

            // Assert
            Assert.AreEqual(7,nummerplade);
        }
    }
}
