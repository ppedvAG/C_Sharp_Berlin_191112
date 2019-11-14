using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace UnitTestFahrzeugpark
{
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            PKW pkw1 = new PKW("BMW", 260, 26000, 4);

            pkw1.StarteMotor();
            pkw1.Beschleunige(300);

            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit);
        }
    }
}
