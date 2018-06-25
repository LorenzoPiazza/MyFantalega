using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServerLega;
using System.Data.SqlClient;

namespace TestDominio
{
    [TestFixture]
    public class TestImpostazioni
    {
        private Lega _lega;

        [SetUp]
        public void LegaSetUp()
        {
            Utente _utente = new Utente();
            _utente.Email = "mailtestLega.com";
            _utente.IsAdmin = true;
            _lega = new Lega();
            _lega.NumeroSquadreTotali = 10;
            _lega.NomeLega = "FantacalcioClub";
            Squadra _squadraAdmin = new Squadra();
            _squadraAdmin.Lega = _lega;
            _squadraAdmin.Utente = _utente;
            _squadraAdmin.Nome = "SquareFC";
            _lega.Squadre.Add(_squadraAdmin);
            _lega.SquadraAdmin = _squadraAdmin;    
            ServerLegaSoapClient myGestioneAdminController = new ServerLegaSoapClient();
            myGestioneAdminController.SetImpostazioni(8, 100, 2, 6, 6, 4, _lega);
            myGestioneAdminController.Close();
        }

        [TestCase]
        public void TestConstructor()
        {
            //variabili per test da database
            int sqTot = 0;
            int cre = 0;
            int por = 0;
            int dif = 0;
            int cen = 0;
            int att = 0;

            //Verifica dei nuovi parametri settati nell'oggetto
            Assert.AreEqual(8, _lega.NumeroSquadreTotali);
            Assert.AreEqual(100, _lega.CreditiInizialiSquadra);
            Assert.AreEqual(2, _lega.NumeroPor);
            Assert.AreEqual(6, _lega.NumeroDif);
            Assert.AreEqual(6, _lega.NumeroCen);
            Assert.AreEqual(4, _lega.NumeroAtt);

            //Verifica dei settaggi dal database
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\source\repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand selectLega = new SqlCommand("SELECT * FROM Lega WHERE nome = "+_lega.NomeLega, conn);
                SqlDataReader reader = selectLega.ExecuteReader();
                
                while (reader.Read())
                {
                    sqTot = int.Parse(reader["numSquadreTot"].ToString());
                    cre = int.Parse(reader["creditiIniziali"].ToString());
                    por = int.Parse(reader["numPor"].ToString());
                    dif = int.Parse(reader["numDif"].ToString());
                    cen = int.Parse(reader["numCen"].ToString());
                    att = int.Parse(reader["numAtt"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            Assert.AreEqual(8, sqTot);
            Assert.AreEqual(100, cre);
            Assert.AreEqual(2, por);
            Assert.AreEqual(6, dif);
            Assert.AreEqual(6, cen);
            Assert.AreEqual(4, att);
        }
    }
}