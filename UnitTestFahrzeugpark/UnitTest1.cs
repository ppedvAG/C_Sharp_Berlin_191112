using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace UnitTestFahrzeugpark
{
    //UNIT-TESTS sind kleinteilige Software-Tests, welche jeweils zum Testen einer einzige Funktion gedacht sind. Ausgeführt werden sie
    ///über den Test-Explorer
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            PKW pkw1 = new PKW("BMW", 260, 26000, 4);

            pkw1.StarteMotor();
            pkw1.Beschleunige(300);

            //Dies ASSERT-Klasse enthält diverse Vergleichsmethoden, welche in Unit-Tests verwendet werden können. Pro Test-Methode
            ///muss es mindesten einen Assert-Aufruf geben
            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit);
        }
    }
}
