using ServerLega.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.InterfacceController;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per CaricaListaFileController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class CaricaListaFileController : System.Web.Services.WebService, ICaricaListaController 
    {
        public Lega CaricaLista(Lega lega)
        {
            SqlConnection conn = null;
            System.Data.OleDb.OleDbConnection connExcel = null;
            try
            {
                ListaSvincolati listaSvincolati = new ListaSvincolati();
                listaSvincolati.IdLista = new Random().Next(999);
                listaSvincolati.DataCaricamento = DateTime.Now;

                ///JACOPO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();

                SqlCommand insert = new SqlCommand("INSERT INTO ListaSvincolati (Id, dataCaricamento) VALUES ("+listaSvincolati.IdLista+", '" + listaSvincolati.DataCaricamento.Date + "')", conn);
                insert.ExecuteNonQuery();
                
                //String club;
                String ruolo;
                String nome;
                int quotazione;
                String club;
                //JACOPO
                //String strExcel = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\Quotazioni.xlsx";
                //LORENZO
                String strExcel = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\Quotazioni.xlsx";
                //ALAN
                //String strExcel = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\Quotazioni.xlsx";
                connExcel = new OleDbConnection(strExcel);
                connExcel.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Tutti]", connExcel);
                DataSet ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    nome = (String)dr["Nome"];
                    quotazione = (int)dr["Qt.I"];
                    ruolo = (String)dr["R"];
                    club = (String)dr["Squadra"];
                    Giocatore giocatore = new Giocatore(nome, quotazione, ruolo, club);
                    insert = new SqlCommand("INSERT INTO Giocatore (nome, quotazioneIniziale, lista, ruolo) VALUES ('" + nome + "'," + quotazione + ", "+listaSvincolati.IdLista +", '" + ruolo + "')", conn);
                    insert.ExecuteNonQuery();

                    listaSvincolati.Giocatori.Add(giocatore);
                }


                lega.ListaSvincolati = listaSvincolati;
                return lega;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                lega.ListaSvincolati = null;
                return lega;
            }
            finally
            {
                connExcel.Close();
                conn.Close();
            }
        }
    }
}
