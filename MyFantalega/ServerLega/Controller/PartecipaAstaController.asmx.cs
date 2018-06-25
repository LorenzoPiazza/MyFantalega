using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.Dominio;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per ParecipaAstaController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class PartecipaAstaController : System.Web.Services.WebService, InterfacceController.IPartecipaAstaController
    {

        [WebMethod]
        public Boolean AbbandonaGiocatore(Asta asta, Squadra squadra)
        {
            Boolean result = false;
            if (asta == null || squadra == null)
            {
                return result;
            }
            //ho pensato che il controllo se e' l'ultima squadra lo faccia gestisci asta
            asta.Squadre.Remove(squadra);
            result = true;
            return result;
        }

        [WebMethod]
        public Boolean RialzaOfferta(Asta asta, Squadra squadra)
        {
            Boolean result = false;
            if (asta == null || squadra == null)
            {
                return result;
            }
            asta.UltimaOfferta = asta.UltimaOfferta+1;
            asta.UltimoOfferente = squadra;
            result = true;
            return result;
        }

        [WebMethod]
        public Boolean OffriCrediti(int offerta, Asta asta, Squadra squadra)
        {
            Boolean result = false;
            if (offerta.Equals(null) || asta == null || squadra == null)
            {
                return result;
            }
            asta.UltimaOfferta = offerta;
            asta.UltimoOfferente = squadra;
            result = true;
            return result;
        }
    }
}
