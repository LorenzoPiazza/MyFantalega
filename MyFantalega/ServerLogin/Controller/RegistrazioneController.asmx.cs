using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerLogin.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per RegistrazioneController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class RegistrazioneController : System.Web.Services.WebService, ServerLogin.InterfacceController.IRegistrazioneController
    {

        [WebMethod]
        public String RegistraUtente(string username, string password, string email, string domanda, string risposta)
        {
            try
            {
                String [] lines = File.ReadAllLines(@"C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLogin\registrazioni.txt");
                char[] seps = { ' ', '\t' };
                foreach (String l in lines)
                {
                    String [] values = l.Split(seps);
                    String usernameInFile = values[0];
                    if (usernameInFile.Equals(username))
                    { 
                        return null;
                    }
                }
            }catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            //A questo punto della funzione ci si arriva solo se non è stato trovato l'username nel file.
            //Ora registro l'utente
            try
            {
                String line = username + "\t\t\t\t\t\t" + password + "\t\t\t\t\t\t" + email + "\t\t\t\t\t\t" + domanda + "\t\t\t\t\t\t" + risposta;
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLogin\registrazioni.txt", true))
                {
                    sw.WriteLine(line);
                }
                
            }catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return email;

        }
    }
}
