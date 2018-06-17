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
    public class GestioneLegaController : System.Web.Services.WebService,ServerLega.InterfacceController.IGestioneLegaController
    {
        private ICaricaListaController listaController = new CaricaListaFileController();

        [WebMethod]
        public Boolean SetImpostazioni(int sqTot, int creIni, int numPor, int numDif, int numCen, int numAtt, Lega lega)
        {
            if(sqTot.Equals(null) || creIni.Equals(null) || numPor.Equals(null) || numDif.Equals(null) || numCen.Equals(null) || numAtt.Equals(null) || lega == null)
            {
                return false;
            }
            lega.NumeroSquadreTotali = sqTot;
            lega.CreditiInizialiSquadra = creIni;
            lega.NumeroAtt = numAtt;
            lega.NumeroCen = numCen;
            lega.NumeroDif = numDif;
            lega.NumeroPor = numPor;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                SqlCommand update = new SqlCommand("update Lega set numSquadreTot=" + sqTot + ", creditiIniziali=" + creIni + ", numPor=" + numPor + ", numDif=" + numDif + ", numCen=" + numCen + ", numAtt=" + numAtt + " where nome=" + lega.NomeLega, conn);
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

        [WebMethod]
        public Boolean CaricaLista(String source, Lega lega)
        {
            Boolean result = false;
            if(lega ==null || source.Equals(null))
            {
                return false;
            }
            if (source.Equals("file"))
            {
                result = listaController.CaricaLista(source, lega);
            }
            return result;
        }
    }
}
