using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.Dominio;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per CreazioneAstaController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class CreazioneAstaController : System.Web.Services.WebService, InterfacceController.ICreazioneAstaController
    {

     
        public Boolean ChiamaGiocatore(Giocatore giocatore, Asta asta)
        {
            Boolean result=false;
            if(giocatore==null || asta == null)
            {
                return result;
            }
            asta.Giocatore = giocatore;
            result = true;
            return result;
        }


       
        public Boolean OffriCrediti(int offerta, Asta asta,Squadra squadra)
        {
            Boolean result=false;
            if (offerta.Equals(null) || asta == null || squadra==null)
            {
                return result;
            }
            asta.UltimaOfferta=offerta;
            asta.UltimoOfferente = squadra;
            result = true;
            return result;
        }
    }
}
