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
    public class TestCreaLega
    {
        private Lega _lega;
        private Squadra _squadraAdmin;

        [SetUp]
        public void SetUp()
        {
            Utente _utente = new Utente();
            _utente.Email = "lollo96.piazza@gmail.com";
            _utente.IsAdmin = true;
            //INVOCAZIONE DEL METODO REMOTO
            ServerLegaSoapClient myGestioneUtenteController = new ServerLegaSoapClient();
            _lega = myGestioneUtenteController.CreaLega("TestCreaLega", 4, "SquareFC", _utente);
            myGestioneUtenteController.Close();
        }

        [TestCase]
        public void TestMethod()
        {
            //Variabili per testare l'avvenuto inserimento della lega nel database
            int sqTot = 0;
            int crediti = 0;
            int por = 0;
            int dif = 0;
            int cen = 0;
            int att = 0;
            String utente=null;

            //VERIFICA CHE LA LEGA SIA STATA INSERITA CORRETTAMENTE NEL DB
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\source\repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand selectLega = new SqlCommand("SELECT * FROM Lega WHERE nome = '"+_lega.NomeLega+"'", conn);
                SqlDataReader reader = selectLega.ExecuteReader();
                
                while (reader.Read())
                {
                    sqTot = int.Parse(reader["numSquadreTot"].ToString());
                    crediti = int.Parse(reader["creditiIniziali"].ToString());
                    por = int.Parse(reader["numPor"].ToString());
                    dif = int.Parse(reader["numDif"].ToString());
                    cen = int.Parse(reader["numCen"].ToString());
                    att = int.Parse(reader["numAtt"].ToString());
                }

                Assert.AreEqual(4, sqTot);
                Assert.AreEqual(500, crediti);
                Assert.AreEqual(3, por);
                Assert.AreEqual(8, dif);
                Assert.AreEqual(8, cen);
                Assert.AreEqual(6, att);

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


            //VERIFICA CHE SIA STATA INSERITA ANCHE LA SQUADRA ADMIN NEL DB
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\source\repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand selectLega = new SqlCommand("SELECT * FROM Squadra WHERE nome = 'SquareFC' AND lega = 'TestCreaLega" , conn);
                SqlDataReader reader = selectLega.ExecuteReader();

                while (reader.Read())
                {
                    crediti = int.Parse(reader["creditiResidui"].ToString());
                    utente = reader["utente"].ToString();
                }

                Assert.AreEqual(crediti, 500);
                Assert.AreEqual(utente, "lollo");

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

        }
    }
}