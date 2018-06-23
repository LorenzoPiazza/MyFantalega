using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerLega.Dominio;

namespace TestDominio
{
    [TestFixture]
    public class TestLega
    {
        private Lega _lega;
        private Squadra _squadraAdmin;
        private Utente _utente;
        [SetUp]
        public void LegaSetUp()
        {
            _utente = new Utente("mailtestLega.com");
            _utente.IsAdmin = true;
            _lega = new Lega("FantacalcioClub", 10);
            _squadraAdmin = new Squadra("SquareFC", _lega, _utente);
            _lega.AggiungiSquadra(_squadraAdmin);
            _lega.SquadraAdmin = _squadraAdmin;

        }

        [TestCase]
        public void TestConstructor()
        {
            //Verifica dei parametri passati al costruttore
            Assert.AreEqual("FantacalcioClub", _lega.NomeLega);
            Assert.AreEqual(10, _lega.NumeroSquadreTotali);
            Assert.AreEqual("SquareFC", _lega.SquadraAdmin.Nome);

            //Verifica dei parametri settati di default
            Assert.AreEqual(_lega.NumeroPor, 3);
            Assert.AreEqual(_lega.NumeroDif, 8);
            Assert.AreEqual(_lega.NumeroCen, 8);
            Assert.AreEqual(_lega.NumeroAtt, 6);
            Assert.AreEqual(_lega.CreditiInizialiSquadra, 500);
            CollectionAssert.IsNotEmpty(_lega.Squadre);
            Assert.Null(_lega.MercatoAttivo);
            Assert.Null(_lega.ListaSvincolati);

        }
    }
}