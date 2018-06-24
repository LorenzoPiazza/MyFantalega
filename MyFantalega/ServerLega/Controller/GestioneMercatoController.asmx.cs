using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.Dominio;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per GestioneMercatoController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class GestioneMercatoController : System.Web.Services.WebService, InterfacceController.IGestioneMercatoController
    {

        [WebMethod]
        public Boolean ChiudiMercato(Mercato mercato)
        {
            Lega lega = mercato.Lega;
            Mercato attivo = lega.MercatoAttivo;
            if(!attivo.Equals(mercato))
            {
                return false;
            }
            lega.MercatoAttivo = null;
            return true;
        }
    }
}
