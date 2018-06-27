using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.Dominio;
using System.Data.SqlClient;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per GestioneSvincoloController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class GestioneSvincoloController : System.Web.Services.WebService, InterfacceController.IGestioneSvincoloController
    {

        [WebMethod]
        public Boolean SvincolaGiocatore(Giocatore g,Squadra s)
        {
            if (!s.Giocatori.Contains(g) || g==null || s==null)
            {
                return false;
            }
            s.RimuoviGiocatore(g);
            g.PrezzoAcquisto = 0;
            g.NomeSquadra = "Lista Svincolati";
            s.CreditiResidui = s.CreditiResidui + (g.PrezzoAcquisto / 2);
            SqlConnection conn = null;
            try
            {
                ///JACOPO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand update = new SqlCommand("update Giocatore set quotazioneIniziale=" + g.QuotazioneIniziale + ", lista=" + s.Lega.ListaSvincolati.IdLista + ", legaSquadra=NULL, nomeSquadra=NULL, prezzoAcquisto=NULL, ruolo=" + g.Ruolo + " where nome=" + g.Nome, conn);
                update.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}
