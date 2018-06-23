using ServerLega.Dominio;
using ServerLega.InterfacceController;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per GestioneUtenteController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class GestioneUtenteController : System.Web.Services.WebService, ServerLega.InterfacceController.IGestioneUtenteController
    {
        public GestioneUtenteController() { }

        [WebMethod]
        public Lega CreaLega(String nome, int numeroPartecipanti, Utente utente)
        {
            SqlConnection conn = null;
            try
            {
                Lega lega = null;
                lega = new Lega(nome, numeroPartecipanti);
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                //FAI QUERY
                SqlCommand insert = new SqlCommand("insert into Lega values ( nomeLega=" + lega.NomeLega + ", numSquadreTot=" + lega.NumeroSquadreTotali + ", creditiIniziali=" + lega.CreditiInizialiSquadra + ", numPor=" + lega.NumeroPor + ", numDif=" + lega.NumeroDif + ", numCen=" + lega.NumeroCen + ", numAtt=" + lega.NumeroAtt + ", lista=" + lega.ListaSvincolati + ", )", conn);
                insert.ExecuteNonQuery();
                return lega;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public Boolean cambiaPassword(String vecchiaPass, String nuovaPass, String domanda, String risposta, Utente utente)
        {
            String usernameInFile;
            String passwordInFile;
            String emailInFile;
            String domandaInFile;
            String rispostaInFile;
            String line;
            
            try
            {
                    StreamWriter writer = new StreamWriter(@"C: \Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLogin\registrazioni.txt");
                    StreamReader reader = new StreamReader(@"C: \Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLogin\registrazioni.txt");
                while ((line = reader.ReadLine()) != null)
                {
                    char[] seps = { ':' };
                    String[] values = line.Split(seps);
                    usernameInFile = values[0];
                    passwordInFile = values[1];
                    emailInFile = values[2];
                    domandaInFile = values[3];
                    rispostaInFile = values[4];
                    if (emailInFile.Equals(utente.Email) && passwordInFile.Equals(vecchiaPass) && domandaInFile.Equals(domanda) && rispostaInFile.Equals(risposta))
                    {
                        String lineToWrite = usernameInFile + ":" + nuovaPass + ":" + emailInFile + ":" + domandaInFile + ":" + rispostaInFile;
                        writer.WriteLine(lineToWrite);
                            return true;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            return false;
        }

        /*Lega[] getLeghe(Utente utente)
        {
            Lega[] leghe;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                //INSERISCI QUERY CHE RESTITUISCE LE LEGHE
                SqlCommand select = new SqlCommand("????", conn);
                TextReader reader;
                reader select.ExecuteReader();
                return leghe;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }*/

        void uniscitiAMercato(Squadra squadra)
        {
            squadra.Lega.MercatoAttivo.Squadre.Add(squadra);

        }

        public Lega CreaLega(string nome, int numeroPartecipanti)
        {
            throw new NotImplementedException();
        }

        public bool cambiaPassword(string vecchiaPass, string nuovaPass, string domanda, string risposta)
        {
            throw new NotImplementedException();
        }

        public Lega[] getLeghe()
        {
            throw new NotImplementedException();
        }

        bool IGestioneUtenteController.uniscitiAMercato()
        {
            throw new NotImplementedException();
        }
    }
}
