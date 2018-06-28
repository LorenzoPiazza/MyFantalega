using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using ServerLega.InterfacceController;
using ServerLega.Dominio;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per GestioneLegaController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class GestioneLegaController : System.Web.Services.WebService, InterfacceController.IGestioneLegaController
    {
        [WebMethod]
        public Lega CaricaLista(String source, Lega lega)
        {
            Lega result = null;
            if(lega ==null || source.Equals(null))
            {
                return null;
            }
            if (source.Equals("file"))
            {
                ICaricaListaController listaController = new CaricaListaFileController();
                result = listaController.CaricaLista(lega);
            }
            else if (source.Equals("url"))
            {
                //PREDISPOSIZIONE FUTURA: lettura della lista da url
            }
            return result;
        }


        [WebMethod]
        public Lega SetImpostazioni(int sqTot, int creIni, int numPor, int numDif, int numCen, int numAtt, Lega lega)
        {
            Lega aggiornata = lega;

            if (sqTot.Equals(null) || creIni.Equals(null) || numPor.Equals(null) || numDif.Equals(null) || numCen.Equals(null) || numAtt.Equals(null) || lega == null)
            {
                return null;
            }

            //AGGIORNO PRIMA IL DB
            SqlConnection conn = null;
            try
            {
                //JACOPO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand update = new SqlCommand("UPDATE Lega SET numSquadreTot=" + sqTot + ", creditiIniziali=" + creIni + ", numPor=" + numPor + ", numDif=" + numDif + ", numCen=" + numCen + ", numAtt=" + numAtt + " WHERE nome='" + lega.NomeLega +"'", conn);
                update.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

            //SE IL DB E' STATO AGGIORNATO CORRETTAMENTE, AGGIORNO E RITORNO LA LEGA AGGIORNATA
            aggiornata.NumeroSquadreTotali = sqTot;
            aggiornata.CreditiInizialiSquadra = creIni;
            aggiornata.NumeroAtt = numAtt;
            aggiornata.NumeroCen = numCen;
            aggiornata.NumeroDif = numDif;
            aggiornata.NumeroPor = numPor;
            return aggiornata;
        }
    }
}
