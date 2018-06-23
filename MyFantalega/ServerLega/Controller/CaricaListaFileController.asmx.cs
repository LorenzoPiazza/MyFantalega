﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServerLega.Dominio;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace ServerLega.Controller
{
    /// <summary>
    /// Descrizione di riepilogo per CaricaListaController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class CaricaListaFileController : System.Web.Services.WebService, ServerLega.InterfacceController.ICaricaListaController
    {

        [WebMethod]
        public Boolean CaricaLista(String source, Lega lega)
        {
            SqlConnection conn = null;
            System.Data.OleDb.OleDbConnection connExcel = null;
            try { 
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\App_Data\DBMyFantalega.mdf;Integrated Security=True");
                conn.Open();
                DateTime data = new DateTime();
                SqlCommand update = new SqlCommand("insert into ListaSvincolati (Id,dataCaricamento) values(100,"+data.Date+")", conn);
                update.ExecuteNonQuery();
                //String club;
                String ruolo;
                String nome;
                int quotazione;
                String strExcel = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Alan\Documents\universita\terzo anno\secondo semestre\progetto\MyFantalega\ServerLega\Quotazioni.xlsx";
                connExcel = new System.Data.OleDb.OleDbConnection(strExcel);
                connExcel.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * From [Tutti]", connExcel);
                DataSet ds = new DataSet();
                da.Fill(ds);
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    nome = (String)dr["Nome"];
                    quotazione = (int)dr["Qt.I"];
                    ruolo = (String)dr["R"];
                    //club = (String)dr["Squadra"];
                    //Giocatore giocatore = new Giocatore(nome, quotazione, ruolo, club);
                    update = new SqlCommand("insert into Giocatore (nome,quotazioneIniziale,lista,ruolo) values("+nome+","+quotazione+",100,"+ruolo+")", conn);
                    update.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                connExcel.Close();
                conn.Close();
            }
            return true;
        }
    }
}
