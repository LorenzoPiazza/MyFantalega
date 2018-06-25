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

     
        public Asta ChiamaGiocatore(Giocatore giocatore, Asta asta)
        {
            
            if(giocatore==null || asta == null)
            {
                return null;
            }
            asta.Giocatore = giocatore;
            return asta;
        }


       
        public Asta OffriCrediti(int offerta, Asta asta,Squadra squadra)
        {
            if (offerta.Equals(null) || asta == null || squadra==null)
            {
                return null;
            }
            asta.UltimaOfferta=offerta;
            asta.UltimoOfferente = squadra;
            return asta;
        }
    }
}
