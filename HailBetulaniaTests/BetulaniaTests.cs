using Microsoft.VisualStudio.TestTools.UnitTesting;
using HailBetulania;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HailBetulania.Tests
{
    [TestClass()]
    public class BetulaniaTests
    {
        private const string msgExpected = "All Hail Betulania!";

        [TestMethod()]
        public void AllHailBetulaniaTest()
        {
            //Arrange
            Betulania bt = new Betulania();

            //Act
            string msgFound = bt.AllHailBetulania();

            //Assert
            Assert.AreEqual(msgFound, msgExpected);
        }
    }
}