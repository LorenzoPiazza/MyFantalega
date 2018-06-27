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
using System.IO;

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
            //System.Data.OleDb.OleDbConnection connExcel = null;
            try
            {
                ListaSvincolati listaSvincolati = new ListaSvincolati();
                listaSvincolati.IdLista = new Random().Next(999);
                listaSvincolati.DataCaricamento = DateTime.Now.Date;

                ///JACOPO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();


                //INSERISCO NEL DB LA LISTA SVINCOLATI
                SqlCommand insert = new SqlCommand("INSERT INTO ListaSvincolati (Id, dataCaricamento) VALUES ("+listaSvincolati.IdLista+", '" + listaSvincolati.DataCaricamento.ToString(@"MM\/dd\/yyyy") + "')", conn);
                insert.ExecuteNonQuery();
                
               
                String ruolo;
                String nome;
                int quotazione;
                String club;


                /*VERSIONE FILE.TXT*/
           
                //LORI
                String[] lines = File.ReadAllLines(@"C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\Quotazioni.txt");
                //JACOPO
                //String[] lines = File.ReadAllLines(@"C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLogin\registrazioni.txt");
                List<Giocatore> letti = new List<Giocatore>();
                char[] seps = { ':' };

                //LEGGO I GIOCATORI DAL FILE
                foreach (String l in lines)
                {
                    String[] values = l.Split(seps);
                    ruolo = values[0];
                    nome = values[1];
                    club = values[2];
                    quotazione = Int32.Parse(values[3]);
                    Giocatore giocatore = new Giocatore(nome, quotazione, ruolo, club);
                    letti.Add(giocatore);
                }

                //AGGIUNGO I GIOCATORI AL DB  
                if ( AggiungiGiocatoriDB(letti, listaSvincolati.IdLista, lega.NomeLega))
                {

                    //Se la scrittura dei giocatori su db è andata bene aggiungo i giocatori alla lista svincolati
                    foreach(Giocatore g in letti)
                    {
                        listaSvincolati.AggiungiGiocatore(g);
                    }


                    lega.ListaSvincolati = listaSvincolati;
                    return lega;

                }

                return lega;

                /*VERSIONE EXCEL
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
                }*/

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                lega.ListaSvincolati = null;
                return lega;
            }
            finally
            {
                //connExcel.Close();
                conn.Close();
            }
        }

        public Boolean AggiungiGiocatoriDB(List<Giocatore> letti, int idLista, String nomeLega)
        {
            SqlConnection conn = null;

            try
            {
                ///JACOPO
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jacopo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaJacopo.mdf;Integrated Security=True");
                //LORENZO
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lorenzo\Source\Repos\progettoIngegneriaDelSoftware\MyFantalega\ServerLega\App_Data\DBMyFantalegaLori.mdf;Integrated Security=True");
                //ALAN
                //conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();

                
                foreach ( Giocatore g in letti)
                {
                    SqlCommand insertGiocatore = new SqlCommand("INSERT INTO Giocatore (nome, quotazioneIniziale, lista, legaSquadra, nomeSquadra, prezzoAcquisto, ruolo) VALUES ('" + g.Nome + "', " +g.QuotazioneIniziale + ", " + idLista + ", NULL, NULL, "+g.PrezzoAcquisto+", '"+g.Ruolo+"' )", conn);
                    insertGiocatore.ExecuteNonQuery();
                }
                return true;

            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
