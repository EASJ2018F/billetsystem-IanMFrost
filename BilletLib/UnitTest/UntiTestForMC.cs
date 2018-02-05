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
            string køretøj = Suzuki.KøretøjType();
            // Assert
            Assert.AreEqual("MC", køretøj);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Nummerplade er længere end 7 cifrer")]
        public void TestLængdeForNummerplade()
        {
            // arrange
            MC GrimCykel = new MC();

            // act
            GrimCykel.Nummerplade = "12345678";
            GrimCykel.NummerPladeBegrænsing();

            // Assert
            
        }

        [TestMethod]
        public void TestPrisMcBrugerBrobizz()
        {
            // arrange
            MC BrobizzCykel = new MC();

            // act
            BrobizzCykel.BrobizzBrugt = true;
            // assert
            Assert.AreEqual(119,BrobizzCykel.Pris());
        }

        [TestMethod]
        public void McOverBroPris()
        {
            // arrange 
            MC motorcykel2 = new MC();
            // act
            motorcykel2.Øresundsbroen = true;
            // assert
            Assert.AreEqual(210,motorcykel2.Pris());
        }

        [TestMethod]
        public void McOverBroMedBroBizz()
        {
            // arrange
            MC motorcykel3 = new MC();
            // act
            motorcykel3.Øresundsbroen = true;
            motorcykel3.BrobizzBrugt = true;
            // assert
            Assert.AreEqual(73, motorcykel3.Pris());
        }
 
    }
}
