using ServerLega.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per GestioneAdminController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class GestioneAdminController : System.Web.Services.WebService
    {

        [WebMethod]
        public Mercato creaMercato(Lega lega)
        {
            //id del mercato generato random, non esistono conflitti con altri mercati!?
            Random random = new Random();
            int id = random.Next(0, 100);
            return new Mercato(id, lega);
        }
    }
}
