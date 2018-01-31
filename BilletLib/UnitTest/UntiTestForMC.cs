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
        [ExpectedException((typeof(ArgumentException)))]
        public void TestLængdeForNummerplade()
        {
            // arrange
            MC GrimCykel = new MC();

            // act
            GrimCykel.Nummerplade = "12345678";

            // Assert
            Assert.AreEqual(8,GrimCykel.NummerPladeBegrænsing());
        }
    }
}
