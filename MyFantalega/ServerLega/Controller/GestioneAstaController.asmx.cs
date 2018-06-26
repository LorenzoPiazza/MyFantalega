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
        //variabile per mantenere la asta attiva da passare agli altri controller
        private Lega _lega;

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

            _lega = lega;
            Mercato mercatoAttivo = _lega.MercatoAttivo;
            List<Squadra> squadre = _lega.Squadre;
            if (mercatoAttivo.AstaAttiva == null)
            {
                //foreach (Squadra s in _lega.Squadre)
                //per la presentazione sarà sempre la squadra admin a chiamare il giocatore
                Squadra s = _lega.SquadraAdmin;
                {
                    if (!s.VerificaReparto("POR"))
                    {
                        por = false;
                    }
                    if (!s.VerificaReparto("DIF"))
                    {
                        dif = false;
                    }
                    if (!s.VerificaReparto("CEN"))
                    {
                        cen = false;
                    }
                    if (!s.VerificaReparto("ATT"))
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
                //la squadra a cui è assegnato il turno è decisa nella view
                return AssegnaTurnoChiamata(turno,ruolo);
            }
            else
            {
                foreach(Squadra s in _lega.Squadre)
                {
                    if (!s.VerificaReparto("POR"))
                    {
                        por = false;
                    }
                    if (!s.VerificaReparto("DIF"))
                    {
                        dif = false;
                    }
                    if (!s.VerificaReparto("CEN"))
                    {
                        cen = false;
                    }
                    if (!s.VerificaReparto("ATT"))
                    {
                        att = false;
                    } 
                }
                if (por == false)
                {
                    ruolo = "POR";
                }
                else if (dif == false)
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
                    return null;
                }
                foreach (Squadra s in mercatoAttivo.AstaAttiva.Squadre)
                {
                    if (!s.Equals(squadra))
                    {
                        int result;
                        Random r = new Random();
                        result=r.Next(0, 1);
                        if (result == 0)
                        {
                            Asta a;
                            a = Abbandona(s);
                            if (a.Equals(null))
                            {
                                return null;
                            }
                        }
                        else
                        {
                            Asta a;
                            a = Rialza(s);
                            if (a.Equals(null))
                            {
                                return null;
                            }
                        }
                    }
                }
                return AssegnaTurnoAsta(turno, ruolo);
            }
        }

        [WebMethod]
        public Asta CreaAsta(Giocatore giocatore, int offerta, Squadra squadra)
        {
            Asta asta = new Asta(1, _lega.Squadre, giocatore);
            _lega.MercatoAttivo.AstaAttiva = asta;
            ICreazioneAstaController myCreaAsta = new CreazioneAstaController();
            myCreaAsta.ChiamaGiocatore(giocatore, asta);
            myCreaAsta.OffriCrediti(offerta, asta, squadra);
            return asta;
        }

        [WebMethod]
        public Boolean AssegnaGiocatore(Giocatore giocatore, Squadra squadra)
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
                giocatore.NomeSquadra = squadra.Nome;
                //modifico nel Db la squadra di appartenenza al giocatore e il prezzo d'acquisto
                SqlCommand updateGiocatore = new SqlCommand("UPDATE Giocatore SET [nomeSquadra] = '" + squadra.Nome + "' , [prezzoAcquisto] = " + giocatore.PrezzoAcquisto + " WHERE [nome] = '" + giocatore.Nome + "'", conn);
                updateGiocatore.ExecuteNonQuery();
                conn.Close();
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

        [WebMethod]
        public Turno AssegnaTurnoAsta(Turno turno,String ruolo)
        {
            turno.Tipo = false;
            turno.Ruolo = ruolo;
            return turno;
        }

        [WebMethod]
        public Turno AssegnaTurnoChiamata(Turno turno,String ruolo)
        {
            turno.Tipo = true;
            turno.Ruolo = ruolo;
            return turno;
        }

        [WebMethod]
        public Asta Offri(int offerta,Squadra squadra)
        {
            Boolean result;
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            result=myPartecipaAsta.OffriCrediti(offerta, _lega.MercatoAttivo.AstaAttiva, squadra);
            if (result)
            {
                return _lega.MercatoAttivo.AstaAttiva;
            }
            else
            {
                return null;
            }
        }

        [WebMethod]
        public Asta Rialza(Squadra squadra)
        {
            Boolean result;
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            result = myPartecipaAsta.RialzaOfferta(_lega.MercatoAttivo.AstaAttiva, squadra);
            if (result)
            {
                return _lega.MercatoAttivo.AstaAttiva;
            }
            else
            {
                return null;
            }
        }

        [WebMethod]
        public Asta Abbandona(Squadra squadra)
        {
            Boolean result;
            IPartecipaAstaController myPartecipaAsta = new PartecipaAstaController();
            result = myPartecipaAsta.AbbandonaGiocatore(_lega.MercatoAttivo.AstaAttiva, squadra);
            if (_lega.MercatoAttivo.AstaAttiva.isFinita())
            {
                result = AssegnaGiocatore(_lega.MercatoAttivo.AstaAttiva.Giocatore, _lega.MercatoAttivo.AstaAttiva.Squadre.ElementAt(0));
                if(result)
                    _lega.MercatoAttivo.AstaAttiva = null;
            }
            return _lega.MercatoAttivo.AstaAttiva;
           
        }

    }
}
