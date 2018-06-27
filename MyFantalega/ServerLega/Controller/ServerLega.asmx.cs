﻿using ServerLega.Dominio;
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


        [WebMethod]
        public Boolean OffriCreditiPartecipaAsta(int offerta, Asta asta, Squadra squadra)
        {
            IPartecipaAstaController partecipaAstaController = new PartecipaAstaController();
            return partecipaAstaController.OffriCrediti(offerta, asta, squadra);
        }

        //GESTIONE UTENTE CONTROLLER
        [WebMethod]
        public Lega CreaLega(String nome, int numeroPartecipanti, String nomeSquadra, Utente utente)
        {
            IGestioneUtenteController gestioneUtenteController = new GestioneUtenteController();
            return gestioneUtenteController.CreaLega(nome, numeroPartecipanti, nomeSquadra, utente);
        }

        [WebMethod]
        public Boolean cambiaPassword(String vecchiaPass, String nuovaPass, String domanda, String risposta, Utente utente)
        {
            IGestioneUtenteController gestioneUtenteController = new GestioneUtenteController();
            return gestioneUtenteController.CambiaPassword(vecchiaPass, nuovaPass, domanda, risposta, utente);
        }

        [WebMethod]
        public List<Lega> GetLeghe(Utente utente)
        {
            IGestioneUtenteController gestioneUtenteController = new GestioneUtenteController();
            return gestioneUtenteController.GetLeghe(utente);
        }

        [WebMethod]
        public Boolean uniscitiAMercato(Mercato mercato, Squadra squadra)
        {
            IGestioneUtenteController gestioneUtenteController = new GestioneUtenteController();
            return gestioneUtenteController.UniscitiAMercato(mercato, squadra);
        }


        //CREAZIONE ASTA CONTROLLER
        [WebMethod]
        public Asta ChiamaGiocatore(Giocatore giocatore, Asta asta)
        {
            ICreazioneAstaController creazioneAstaController = new CreazioneAstaController();
            return creazioneAstaController.ChiamaGiocatore(giocatore, asta);
        }

        [WebMethod]
        public Asta OffriCreditiCreazioneAsta(int offerta, Asta asta, Squadra squadra)
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



        //GESTIONE SVINCOLO CONTROLLER
        [WebMethod]
        public Boolean SvincolaGiocatore(Giocatore g, Squadra s)
        {
            IGestioneSvincoloController gestioneSvincoloController = new GestioneSvincoloController();
            return gestioneSvincoloController.SvincolaGiocatore(g, s);
        }

        //GESTIONE MERCATO CONTROLLER
        [WebMethod]
        public Boolean ChiudiMercato(Mercato mercato)
        {
            IGestioneMercatoController gestioneMercatoController = new GestioneMercatoController();
            return gestioneMercatoController.ChiudiMercato(mercato);
        }

        //GESTIONE LEGA CONTROLLER
        [WebMethod]
        public Lega SetImpostazioni(int sqTot, int creIni, int numPor, int numDif, int numCen, int numAtt, Lega lega)
        {
            IGestioneLegaController gestioneLegaController = new GestioneLegaController();
            return gestioneLegaController.SetImpostazioni(sqTot, creIni, numPor, numDif, numCen, numAtt, lega);
        }


        [WebMethod]
        public Lega CaricaLista(String source, Lega lega)
        {
            IGestioneLegaController gestioneLegaController = new GestioneLegaController();
            return gestioneLegaController.CaricaLista(source, lega);
        }



        //GESTIONE ASTA CONTROLLER


        [WebMethod]
        public Asta CreaAsta(Giocatore giocatore, int offerta, Squadra squadra)
        {
            IGestioneAstaController gestioneAstaController = new GestioneAstaController();
            return gestioneAstaController.CreaAsta(giocatore, offerta, squadra);
        }
         
        [WebMethod]
        public Turno GestisciAsta(Lega lega, Squadra squadra)
        {
            IGestioneAstaController gestioneAstaController = new GestioneAstaController();
            return gestioneAstaController.GestisciAsta(lega, squadra);
        }

        [WebMethod]
        public Asta Offri(int offerta, Squadra squadra)
        {
            IGestioneAstaController gestioneAstaController = new GestioneAstaController();
            return gestioneAstaController.Offri(offerta,squadra);
        }

        [WebMethod]
        public Asta Rialza(Squadra squadra)
        {
            IGestioneAstaController gestioneAstaController = new GestioneAstaController();
            return gestioneAstaController.Rialza(squadra);
        }

        [WebMethod]
        public Asta Abbandona(Squadra squadra)
        {
            IGestioneAstaController gestioneAstaController = new GestioneAstaController();
            return gestioneAstaController.Abbandona(squadra);
        }

        [WebMethod]
        public Boolean InsertUtente (String username, String email)
        {
            SqlConnection conn = null;
            try
            {
                //CAMBIARE IL PATH A SECONDA DEL DB USATO!!
                //JACOPO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\source\repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand insertSquadra = new SqlCommand("INSERT INTO Utente (username, [e-mail] ) VALUES ( '" + username + "', '" + email + "')", conn);
                insertSquadra.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }

            

        }
    }
}

        
 
