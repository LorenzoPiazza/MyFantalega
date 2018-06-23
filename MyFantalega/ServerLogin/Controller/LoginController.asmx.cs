using System;
using System.IO;
using System.Web.Services;

namespace ServerLogin
{
    /// <summary>
    /// Descrizione di riepilogo per LoginController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class LoginController : System.Web.Services.WebService, ServerLogin.InterfacceController.ILoginController
    {

        [WebMethod]
        public String VerificaCredenziali(String username, String password)
        {
            String usernameInFile;
            String passwordInFile;
            String emailInFile;

            try
            {
                String[] lines = File.ReadAllLines(@"C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLogin\registrazioni.txt");
                char[] seps = {':'};
                foreach (String l in lines)
                {
                    String[] values = l.Split(seps); 
                    usernameInFile = values[0];
                    passwordInFile = values[1];
                    emailInFile = values[2];
                    if (usernameInFile.Equals(username) && passwordInFile.Equals(password))
                    {
                        //Se le credenziali sono verificate viene restituita al client la mail che servirà a identificare l'utente che sta navigando nell'applicazione
                        return emailInFile;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            //A questo punto della funzione ci si arriva solo se non è stato trovato l'username nel file.
            //Le credenziali passate quindi erano errate e non hanno trovato corrispondenza.
            //prima rudimentale implementazione
            return null;
        }


       /* [WebMethod]
        public Utente VerificaCredenzialiProva(String username, String password)
        {
            String usernameInFile;
            String passwordInFile;
            String emailInFile;

            try
            {
                String[] lines = File.ReadAllLines(@"C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLogin\registrazioni.txt");
                char[] seps = { ':' };
                foreach (String l in lines)
                {
                    String[] values = l.Split(seps);
                    usernameInFile = values[0];
                    passwordInFile = values[1];
                    emailInFile = values[2];
                    if (usernameInFile.Equals(username) && passwordInFile.Equals(password))
                    {
                        //Se le credenziali sono verificate viene restituita al client la mail che servirà a identificare l'utente che sta navigando nell'applicazione
                        return new Utente(emailInFile);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            //A questo punto della funzione ci si arriva solo se non è stato trovato l'username nel file.
            //Le credenziali passate quindi erano errate e non hanno trovato corrispondenza.
            //prima rudimentale implementazione
            return null;
        }*/

    }
}
