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

            if (lega.MercatoAttivo == null)
            {
                ServerLegaSoapClient myGestioneAdminController = new ServerLegaSoapClient();
                Mercato mercato = myGestioneAdminController.creaMercato(lega);
                List<Squadra> squadre = mercato.Squadre;
                foreach (Squadra s in squadre)
                {
                    if (!s.Equals(squadra))
                        lega.Squadre.Add(s);
                }
                if (mercato != null)
                {
                    lega.MercatoAttivo = mercato;
                    MessageBox.Show("Hai creato un mercato per la lega. Unisciti!");
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
            this.Hide();
            new HomeMercatoAdmin(lega, squadra).Show();
        }

        private void gestioneLegaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GestioneLega(lega).Show() ;
        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WelcomeHome(lega.SquadraAdmin.Utente).Show();
        }
    }
}
