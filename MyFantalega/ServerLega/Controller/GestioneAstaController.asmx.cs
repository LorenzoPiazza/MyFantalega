using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.Dominio;
using ServerLega.InterfacceController;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per GestioneAstaController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class GestioneAstaController : System.Web.Services.WebService,ServerLega.InterfacceController.IGestioneAstaController
    {
        //variabile per mantenere la asta attiva da passare agli altri controller
        private Asta _asta;

        //li creo gia qui perche tanto ai controller non cambia se sono usate su aste diverse
        private IPartecipaAstaController _partecipaAstaController = new PartecipaAstaController();
        private IPartecipaAstaController _creazioneAstaController = new PartecipaAstaController();

        /*[WebMethod]
        public void GestisciAsta(Lega lega)
        {

        }

        [WebMethod]
        public Asta CreaAsta(Giocatore giocatore, int offerta)
        {

        }

        [WebMethod]
        public Boolean AssegnaGiocatore(Giocatore giocatore, Squadra squadra)
        {
            
        }

        [WebMethod]
        public Boolean AssegnaTurnoAsta(Turno turno, Asta asta)
        {

        }

        [WebMethod]
        public Boolean AssegnaTurnoChiamata(Turno turno, Asta asta)
        {

        }

        [WebMethod]
        public Boolean Offri(int offerta)
        {

        }

        [WebMethod]
        public Boolean Rialza()
        {

        }

        [WebMethod]
        public Boolean Abbandona()
        {

        }*/

    }
}
