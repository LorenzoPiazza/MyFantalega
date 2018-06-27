using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServerLega;

namespace Client.View
{
    public partial class HomeLegaAdmin : Form
    {
        private Squadra squadra;
        private Lega lega;

        public HomeLegaAdmin(Lega lega)
        {
            InitializeComponent();
            this.lega = lega;
            squadra = lega.SquadraAdmin;
        }

        private void HomeLegaAdmin_Load(object sender, EventArgs e)
        {
            squadraTextBox.Text = "Benvenuta " + squadra.Nome;
        }

        private void squadraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreaMercato_Click(object sender, EventArgs e)
        {
            if (lega.ListaSvincolati.Equals(null))
            {
                MessageBox.Show("Caricare prima la lista svincolati");
            }
            if (lega.MercatoAttivo == null)
            {
                ServerLegaSoapClient myGestioneAdminController = new ServerLegaSoapClient();
                Mercato mercato = myGestioneAdminController.creaMercato(lega);
                List<Squadra> squadre = mercato.Squadre;
                if (mercato != null)
                {
                    if (lega.ListaSvincolati.Equals(null))
                    {
                        MessageBox.Show("Caricare prima la lista svincolati");
                    }
                    else
                    {
                        lega.MercatoAttivo = mercato;
                        MessageBox.Show("Hai creato un mercato per la lega. Unisciti!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Errore nella creazione del mercato! Riprova!");
                }
            }

            else
            {
                MessageBox.Show("E' già presente un mercato attivo in questa lega. Unisciti!");
            }

          

        }

        private void buttonUniscitiMercato_Click(object sender, EventArgs e)
        {
            if (lega.MercatoAttivo == null)
            {
                MessageBox.Show("Non esiste ancora un mercato attivo in questa lega. Crealo!");
            }
            else
            {
                //Per l'esposizione se non va CaricaLista
               /* Giocatore g1 = new Giocatore();
                g1.Nome = "TONI";
                g1.Ruolo = "ATT";
                g1.QuotazioneIniziale = 30;

                Giocatore g2 = new Giocatore();
                g2.Nome = "PIRLO";
                g2.Ruolo = "CEN";
                g2.QuotazioneIniziale = 22;

                Giocatore g3 = new Giocatore();
                g3.Nome = "DESTRO";
                g3.Ruolo = "ATT";
                g3.QuotazioneIniziale = 13;

                lega.ListaSvincolati = new ListaSvincolati();
                lega.ListaSvincolati.Giocatori = new List<Giocatore>();
                lega.ListaSvincolati.Giocatori.Add(g1);
                lega.ListaSvincolati.Giocatori.Add(g2);
                lega.ListaSvincolati.Giocatori.Add(g3);*/

                this.Hide();
                new HomeMercatoAdmin(lega, squadra).Show();
            }
            
        }

        private void gestioneLegaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GestioneLega(lega).Show();
        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeHome(lega.SquadraAdmin.Utente).Show();

        }

        private void HomeLegaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
