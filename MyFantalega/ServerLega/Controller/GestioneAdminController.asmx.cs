using ServerLega.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.InterfacceController;
using System.Data.SqlClient;

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
            SqlConnection conn = null;
            try
            {
                //JACOPO
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                Random random = new Random();
                int id = random.Next(0, 1000);
                Mercato m = new Mercato(id, lega);
                //aggiungiamo squadre per l'esposizione del progetto
                m.addSquadra(lega.SquadraAdmin);
                Utente a1 = new Utente();
                Squadra s1 = new Squadra("SquareFc", lega, a1);
                SqlCommand insert = new SqlCommand("INSERT INTO Squadra(nome, creditiResidui, lega, utente) VALUES('" + s1.Nome + "' ," + lega.CreditiInizialiSquadra + ", '" + lega.NomeLega + "' ,'" + a1.Email + "')", conn);
                insert.ExecuteNonQuery();
                m.addSquadra(s1);
                Utente a2 = new Utente();
                Squadra s2 = new Squadra("Juvenilia", lega, a2);
                insert = new SqlCommand("INSERT INTO Squadra(nome, creditiResidui, lega, utente) VALUES('" + s2.Nome + "' ," + lega.CreditiInizialiSquadra + ", '" + lega.NomeLega + "' ,'" + a2.Email + "')", conn);
                insert.ExecuteNonQuery();
                m.addSquadra(s2);
                Utente a3 = new Utente();
                Squadra s3 = new Squadra("JACOPENSE", lega, a3);
                insert = new SqlCommand("INSERT INTO Squadra(nome, creditiResidui, lega, utente) VALUES('" + s3.Nome + "' ," + lega.CreditiInizialiSquadra + ", '" + lega.NomeLega + "' ,'" + a3.Email + "')", conn);
                insert.ExecuteNonQuery();
                m.addSquadra(s3);
                /*
                m.addSquadra( new Squadra("Foizasteam", lega, new Utente()));
                m.addSquadra( new Squadra("TagliesterUnited", lega, new Utente()));
                m.addSquadra( new Squadra("TaglionsporKulubu", lega, new Utente()));
                m.addSquadra( new Squadra("Stefanese1997", lega, new Utente()));
                m.addSquadra( new Squadra("DeportivoAperitivo", lega, new Utente()));
                m.addSquadra( new Squadra("CRFantasia7", lega, new Utente()));
                m.addSquadra( new Squadra("MercedesAMG", lega, new Utente()));
                m.addSquadra( new Squadra("SanGallo", lega, new Utente()));
                */
                return m;
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
        }
    }
}
