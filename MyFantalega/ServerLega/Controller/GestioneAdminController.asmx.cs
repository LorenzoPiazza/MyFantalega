using ServerLega.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.InterfacceController;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per GestioneAdminController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class GestioneAdminController : System.Web.Services.WebService, IGestioneAdminController
    {

        [WebMethod]
        public Mercato CreaMercato(Lega lega)
        {
            Random random = new Random();
            int id = random.Next(0, 1000);
            Mercato m = new Mercato(id, lega);
            //aggiungiamo squadre per l'esposizione del progetto
            m.addSquadra( new Squadra("JACOPENSE", lega, new Utente()));
            m.addSquadra( new Squadra("SquareFc", lega, new Utente()));
            m.addSquadra( new Squadra("Juvenilia", lega, new Utente()));
            m.addSquadra( new Squadra("DSGalaxy", lega, new Utente()));
            m.addSquadra( new Squadra("Foizasteam", lega, new Utente()));
            m.addSquadra( new Squadra("TagliesterUnited", lega, new Utente()));
            m.addSquadra( new Squadra("TaglionsporKulubu", lega, new Utente()));
            m.addSquadra( new Squadra("Stefanese1997", lega, new Utente()));
            m.addSquadra( new Squadra("DeportivoAperitivo", lega, new Utente()));
            m.addSquadra( new Squadra("CRFantasia7", lega, new Utente()));
            m.addSquadra( new Squadra("MercedesAMG", lega, new Utente()));
            m.addSquadra( new Squadra("SanGallo", lega, new Utente()));
            return m;
        }
    }
}
