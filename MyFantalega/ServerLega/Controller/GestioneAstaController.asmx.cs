using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    public class GestioneAstaController : System.Web.Services.WebService, IGestioneAstaController
    {

        //li creo gia qui perche tanto ai controller non cambia se sono usate su aste diverse
        private IPartecipaAstaController _partecipaAstaController = new PartecipaAstaController();
        private IPartecipaAstaController _creazioneAstaController = new PartecipaAstaController();

        public GestioneAstaController() { 
}
        [WebMethod]
        public Turno GestisciAsta(Lega lega,Squadra squadra)
        {
            Boolean por=true;
            Boolean dif=true;
            Boolean cen=true;
            Boolean att=true;
            String ruolo;
            Turno turno = new Turno();
            Mercato mercatoAttivo = lega.MercatoAttivo;
            List<Squadra> squadre = lega.Squadre;
            if (mercatoAttivo.AstaAttiva == null)
            {
                //foreach (Squadra s in _lega.Squadre)
                //per la presentazione sarà sempre la squadra admin a chiamare il giocatore
                {
                    if (!squadra.VerificaReparto("POR",lega))
                    {
                        por = false;
                    }
                    if (!squadra.VerificaReparto("DIF",lega))
                    {
                        dif = false;
                    }
                    if (!squadra.VerificaReparto("CEN",lega))
                    {
                        cen = false;
                    }
                    if (!squadra.VerificaReparto("ATT",lega))
                    {
                        att = false;
                    }
                }
                if (por == false)
                {
                    ruolo = "POR";
                }else if (dif == false)
                {
                    ruolo = "DIF";
                }
                else if (cen == false)
                {
                    ruolo = "CEN";
                }
                else if (att == false)
                {
                    ruolo = "ATT";
                }
                else
                {
                    ruolo = "FINITO";
                }
                return AssegnaTurnoChiamata(turno,ruolo);
            }
            else
            {
                ruolo = lega.MercatoAttivo.AstaAttiva.Giocatore.Ruolo;
                if (squadra.VerificaReparto(ruolo, lega))
                {
                    ruolo = "ALTRI";
                    foreach (Squadra s in lega.MercatoAttivo.AstaAttiva.Squadre)
                    {
                        if (!s.Equals(squadra))
                        {
                            while (lega.MercatoAttivo.AstaAttiva == null)
                            {
                                int result;
                                Random r = new Random();
                                result = r.Next(0, 1);
                                if (result == 0)
                                {
                                    lega = AbbandonaMock(s, lega);
                                }
                                else
                                {
                                    lega = RialzaMock(s, lega);
                                }
                            }
                        }
                    }
                }
                return AssegnaTurnoAsta(turno, ruolo);
            }
                
        }

        [WebMethod]
        public Lega CreaAsta(Giocatore giocatore, int offerta, Squadra squadra, Lega lega)
        {
            Asta asta = new Asta(1, lega.MercatoAttivo.Squadre, giocatore);
            lega.MercatoAttivo.AstaAttiva = asta;
            ICreazioneAstaController myCreaAsta = new CreazioneAstaController();

            myCreaAsta.ChiamaGiocatore(giocatore, asta);
            myCreaAsta.OffriCrediti(offerta, asta, squadra);
            int count = lega.MercatoAttivo.AstaAttiva.Squadre.Count;
            for (int i = 0; i < count && lega.MercatoAttivo.AstaAttiva != null; i++)
            {
                if (!lega.MercatoAttivo.AstaAttiva.Squadre[i].Nome.Equals(squadra.Nome))
                {
                    int result;
                    Random r = new Random();
                    result = r.Next(2);
                    if (result == 0)
                    {
                        lega = AbbandonaMock(lega.MercatoAttivo.AstaAttiva.Squadre[i], lega);
                    }
                    else
                    {
                        lega = RialzaMock(lega.MercatoAttivo.AstaAttiva.Squadre[i], lega);
                    }
                    if (lega.MercatoAttivo.AstaAttiva != null)
                    {
                        count = lega.MercatoAttivo.AstaAttiva.Squadre.Count;
                    }
                }
            }
            return lega;
        }

        [WebMethod]
        private Lega AssegnaGiocatore(Giocatore giocatore, Squadra squadra,int offertaFinale,Lega lega)
        {
            int creditiSq;
            SqlConnection conn = null;
            try
            {
                //CAMBIARE IL PATH A SECONDA DEL DB USATO!!
                //JACOPO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\source\repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                lega.ListaSvincolati.RimuoviGiocatore(giocatore);
                giocatore.NomeSquadra = squadra.Nome;
                giocatore.PrezzoAcquisto = offertaFinale;
                creditiSq =squadra.CreditiResidui - offertaFinale;
                squadra.CreditiResidui = creditiSq;
                //modifico nel Db la squadra di appartenenza al giocatore e il prezzo d'acquisto
                SqlCommand updateGiocatore = new SqlCommand("UPDATE Giocatore SET nomeSquadra = '" + squadra.Nome + "' , legaSquadra = '"+lega.NomeLega+"' , prezzoAcquisto = " + giocatore.PrezzoAcquisto + " , lista = NULL WHERE nome = '" + giocatore.Nome + "'", conn);
                updateGiocatore.ExecuteNonQuery();
                SqlCommand updateSquadra = new SqlCommand("UPDATE Squadra SET creditiResidui = " + creditiSq + " WHERE nome = '" + squadra.Nome + "'", conn);
                updateSquadra.ExecuteNonQuery();
                conn.Close(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                lega.MercatoAttivo.AstaAttiva = null;
                return lega;
            }
            finally
            {
                conn.Close();
            }
            return lega;
        }

        [WebMethod]
        private Turno AssegnaTurnoAsta(Turno turno,String ruolo)
        {
            turno.Tipo = false;
            turno.Ruolo = ruolo;
            return turno;
        }

        [WebMethod]
        private Turno AssegnaTurnoChiamata(Turno turno,String ruolo)
        {
            turno.Tipo = true;
            turno.Ruolo = ruolo;
            return turno;
        }

        [WebMethod]
        public Lega Offri(int offerta,Squadra squadra,Lega lega)
        {
            Lega result;
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            myPartecipaAsta.OffriCrediti(offerta, lega.MercatoAttivo.AstaAttiva, squadra);
            result = AzioniMock(lega, lega.SquadraAdmin);
            if (result != null)
            {
                return result;
            }
            else
            {
                result.MercatoAttivo.AstaAttiva = null;
                return result;
            }
        }

        [WebMethod]
        public Lega Rialza(Squadra squadra,Lega lega)
        {
            Lega result;
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            myPartecipaAsta.RialzaOfferta(lega.MercatoAttivo.AstaAttiva, squadra);
            result = AzioniMock(lega, lega.SquadraAdmin);
            if (result != null)
            {
                return result;
            }
            else
            {
                result.MercatoAttivo.AstaAttiva = null;
                return result;
            }
        }

        [WebMethod]
        public Lega Abbandona(Squadra squadra,Lega lega)
        {
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            myPartecipaAsta.AbbandonaGiocatore(lega.MercatoAttivo.AstaAttiva, squadra);
            lega = AssegnaGiocatore(lega.MercatoAttivo.AstaAttiva.Giocatore, lega.MercatoAttivo.AstaAttiva.UltimoOfferente, lega.MercatoAttivo.AstaAttiva.UltimaOfferta, lega);
            if(lega != null) {
                lega.MercatoAttivo.AstaAttiva = null;
            }
            return lega;
           
        }

        [WebMethod]
        private Lega AzioniMock(Lega lega,Squadra squadra)
        {
            int count;
            Boolean abbandona = false;
            String ruolo;
            ruolo = lega.MercatoAttivo.AstaAttiva.Giocatore.Ruolo;
            if (squadra.VerificaReparto(ruolo, lega))
            {
                ruolo = "ALTRI";
                foreach (Squadra s in lega.MercatoAttivo.AstaAttiva.Squadre)
                {
                    abbandona = false;
                    if (!s.Equals(squadra))
                    {
                        while (abbandona==false)
                        {
                            int result;
                            Random r = new Random();
                            result = r.Next(2);
                            if (result == 0)
                            {

                                lega = AbbandonaMock(s, lega);
                                abbandona = true;
                            }
                            else
                            {

                                lega = RialzaMock(s, lega);
                            }
                        }
                    }
                }
            }
            else
            {
                count = lega.MercatoAttivo.AstaAttiva.Squadre.Count;
                for (int i=0;i< count && lega.MercatoAttivo.AstaAttiva != null; i++)
                {
                    if (!lega.MercatoAttivo.AstaAttiva.Squadre[i].Nome.Equals(squadra.Nome))
                    {
                        int result;
                        Random r = new Random();
                        result = r.Next(2);
                        if (result == 0)
                        {
                            lega = AbbandonaMock(lega.MercatoAttivo.AstaAttiva.Squadre[i], lega);
                        }
                        else
                        {
                            lega = RialzaMock(lega.MercatoAttivo.AstaAttiva.Squadre[i], lega);
                        }
                        if(lega.MercatoAttivo.AstaAttiva != null)
                        {
                            count = lega.MercatoAttivo.AstaAttiva.Squadre.Count;
                        }
                    }
                }
            }
            return lega;
        }

        [WebMethod]
        private Lega RialzaMock(Squadra squadra, Lega lega)
        {
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            myPartecipaAsta.RialzaOfferta(lega.MercatoAttivo.AstaAttiva, squadra);
            if (lega != null)
            {
                return lega;
            }
            else
            {
                lega.MercatoAttivo.AstaAttiva = null;
                return lega;
            }
        }

        [WebMethod]
        private Lega AbbandonaMock(Squadra squadra, Lega lega)
        {
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            myPartecipaAsta.AbbandonaGiocatore(lega.MercatoAttivo.AstaAttiva, squadra);
            if (lega.MercatoAttivo.AstaAttiva.isFinita())
            {
                lega = AssegnaGiocatore(lega.MercatoAttivo.AstaAttiva.Giocatore, lega.MercatoAttivo.AstaAttiva.UltimoOfferente, lega.MercatoAttivo.AstaAttiva.UltimaOfferta, lega);
                if (lega != null)
                    lega.MercatoAttivo.AstaAttiva = null;
            }
            return lega;

        }
    }
}
