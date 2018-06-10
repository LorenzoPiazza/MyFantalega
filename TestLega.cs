using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fantacalcio.Dominio;

namespace TestDominio
{
    [TestFixture]
    public class TestLega
    {
        private Lega _lega;
        [SetUp]
        public void LegaSetUp()
        {
            _lega = new Lega("FantacalcioClub", 500, 10, 3, 8, 8, 6);
        }

        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            StringAssert.Equals(_lega.NomeLega, "FantacalcioClub");
            Assert.AreEqual(_lega.CreditiPerSquadra, 500);
            Assert.AreEqual(_lega.NumeroPartecipanti, 10);
            Assert.AreEqual(_lega.NumeroPor, 3);
            Assert.AreEqual(_lega.NumeroDif, 8);
            Assert.AreEqual(_lega.NumeroCen, 8);
            Assert.AreEqual(_lega.NumeroAtt, 6);
        }
    }
}