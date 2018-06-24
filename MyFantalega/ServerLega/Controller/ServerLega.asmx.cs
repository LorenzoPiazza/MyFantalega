using ServerLega.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.InterfacceController;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per ServerLega
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServerLega : System.Web.Services.WebService
    {

        [WebMethod]
        public Lega CreaLega(String nome, int numeroPartecipanti, Utente utente)
        {
            IGestioneUtenteController gestioneUtenteController = new GestioneUtenteController();
            Lega lega = gestioneUtenteController.CreaLega(nome, numeroPartecipanti, utente);
            return lega;
        }


        //PARTECIPA ASTA CONTROLLER
        [WebMethod]
        public Boolean AbbandonaGiocatore(Asta asta, Squadra squadra)
        {
            IPartecipaAstaController partecipaAstaController = new PartecipaAstaController();
            return partecipaAstaController.AbbandonaGiocatore(asta, squadra);
        }

        [WebMethod]
        public Boolean RialzaOfferta(Asta asta, Squadra squadra)
        {
            IPartecipaAstaController partecipaAstaController = new PartecipaAstaController();
            return partecipaAstaController.RialzaOfferta(asta, squadra);
        }


         //CREAZIONE ASTA CONTROLLER
        [WebMethod]
        public Boolean ChiamaGiocatore(Giocatore giocatore, Asta asta)
        {
            ICreazioneAstaController creazioneAstaController = new CreazioneAstaController();
            return creazioneAstaController.ChiamaGiocatore(giocatore, asta);
        }

        [WebMethod]
        public Boolean OffriCrediti(int offerta, Asta asta, Squadra squadra)
        {
            ICreazioneAstaController creazioneAstaController = new CreazioneAstaController();
            return creazioneAstaController.OffriCrediti(offerta, asta, squadra);
        }


        //GESTIONE ADMIN CONTROLLER
        [WebMethod]
        public Mercato creaMercato(Lega lega)
        {
            IGestioneAdminController adminController = new GestioneAdminController();
            return adminController.CreaMercato(lega);
        }


        //GESTIONE ASTA CONTROLLER
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

 
