using ServerLega.InterfacceController;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.Dominio;


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
                Lega lega = new Lega(nome, numeroPartecipanti);
                //CAMBIARE IL PATH A SECONDA DEL DB USATO!!
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                conn.Open();
                //QUERY DI INSERIMENTO
                SqlCommand insert = new SqlCommand("INSERT INTO Lega (nome, numSquadreTot, creditiIniziali, numPor, numDif, numCen, numAtt, squadraAdmin, lista, legaAdmin ) VALUES ( '" + lega.NomeLega + "', " + lega.NumeroSquadreTotali + ", " + lega.CreditiInizialiSquadra + ", " + lega.NumeroPor + ", " + lega.NumeroDif + ", " + lega.NumeroCen + ", " + lega.NumeroAtt + ", NULL" + ", NULL" + ", '" + lega.NomeLega + "' )", conn);

                insert.ExecuteNonQuery();
                return lega;
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


        [WebMethod]
        public List<Lega> getLeghe(Utente utente)
        {
            List<Lega> leghe = new List<Lega>();
            SqlConnection conn = null;
            try
            {   //CAMBIARE IL PATH A SECONDA DEL DB USATO!!
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                conn.Open();
                //QUERY CHE RESTITUISCE LE LEGHE
                SqlCommand select = new SqlCommand("SELECT * FROM Lega WHERE nome IN (SELECT S.lega FROM Squadra S JOIN Utente U ON U.username = S.utente WHERE U.[e-mail]='" + utente.Email + "')", conn);
                SqlDataReader reader = select.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Lega lega = new Lega(reader.GetString(0), reader.GetInt32(1));
                        lega.CreditiInizialiSquadra = reader.GetInt32(2);
                        lega.NumeroPor = reader.GetInt32(3);
                        lega.NumeroDif = reader.GetInt32(4);
                        lega.NumeroCen = reader.GetInt32(5);
                        lega.NumeroAtt = reader.GetInt32(6);
                        Squadra squadraAdmin = new Squadra();
                        squadraAdmin.Nome = reader.GetString(7);
                        ListaSvincolati lista = new ListaSvincolati();
                        lista.IdLista = reader.GetInt32(8);
                        squadraAdmin.Lega = lega;
                        squadraAdmin.Utente = utente;

                        leghe.Add(lega);

                    }
                }

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
        }

        [WebMethod]
        public Boolean uniscitiAMercato(Mercato mercato, Squadra squadra)
        {
            if (mercato.Squadre.Contains(squadra))
                return false;

            mercato.Squadre.Add(squadra);
            return true;

        }

    }
}