using ServerLega.Dominio;
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
        [WebMethod]
        public Lega CreaLega(String nome, int numeroPartecipanti, Utente utente)
        {
            if (nome.Equals(null) || numeroPartecipanti < 4 || numeroPartecipanti > 12)
            {
                return null;
            }
            //la squadra ancora non esiste, come faccio a creare la lega?
        }

        public Boolean selezionaLega(Lega nomeLega)
        {
           //non credo abbia senso di esistere questo metodo, noi visualizziamo nella WELCOMEHOME solo leghe a cui un utente fa parte per cui la view farà show della home passando la lega e basta
           
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

        Lega[] getLeghe(Utente utente)
        {
            Lega[] leghe;
            SqlConnection conn = null;
            try
            {
                //ho messo il mio DbFileName anche se non vedo il Db, forse devo mettere quello di alan
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand select = new SqlCommand("????", conn); //inserisci query
                leghe = select.ExecuteNonQuery();
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

        Boolean uniscitiAMercato()
        {
            //mercato dovrà avere una lista di squadre (quelle che sono unite)
        }
    }
}
