using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public Boolean VerificaCredenziali(String username, String password)
        {
            //prima rudimentale implementazione
            if (username.Equals("lollo") && password.Equals("ciao"))
            {
                return true;
            }

            return false;
        }
    }
}
