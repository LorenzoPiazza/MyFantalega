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
    public partial class SvincolaGiocatore : Form
    {
        Squadra squadra;
        Giocatore giocatore;
        HomeLegaAdmin admin;
        HomeLegaUtente utente;
        Lega lega;

        public SvincolaGiocatore(Squadra squadraPass, Lega legaPass)
        {
            InitializeComponent();
            lega = legaPass;
            utente = null;
            giocatore = null;
            squadra = squadraPass;
            textBox1.Enabled = false;
            svincolaButton.Enabled = false;
            button2.Enabled = true;
        }
        public SvincolaGiocatore(Squadra squadraPass, HomeLegaUtente utentePass)
        {
            InitializeComponent();
            admin = null;
            utente = utentePass;
            giocatore = null;
            squadra = squadraPass;
            svincolaButton.Enabled = false;
            button2.Enabled = true;
        }

        private void svincolaButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler svincolare il giocatore?", giocatore.Nome, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Client.ServerLega.ServerLegaSoapClient mySvincoloController = new Client.ServerLega.ServerLegaSoapClient();
                Boolean result;
                result = mySvincoloController.SvincolaGiocatore(giocatore, squadra);
                if (result == true)
                {
                    MessageBox.Show("Giocatore svincolato");
                }
                else
                {
                    MessageBox.Show("Errore nello svincolo del giocatore");
                }
            }
            else
            {
                MessageBox.Show("Giocatore non svincolato scegli un altro giocatore");
            }
        }

       private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            if (admin == null)
            {
                new HomeLegaAdmin(squadra.Lega).Show();
            }
            else
            {
                new HomeLegaUtente(squadra).Show();
            }
        }

        private void SvincolaGiocatore_Load(object sender, EventArgs e)
        {
            List <Giocatore> giocatori = squadra.Giocatori;
            if (giocatori == null)
            {
                comboBoxGiocatori.Text = "Nessuna giocatore disponibile";
            }
            foreach (Giocatore giocatore in giocatori)
            {
                comboBoxGiocatori.Items.Add(giocatore.Nome);
            }
        }

        private void comboBoxGiocatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nome = comboBoxGiocatori.SelectedItem.ToString();
            foreach(Giocatore g in squadra.Giocatori)
            {
                if (nome.Equals(g.Nome))
                {
                    giocatore = g;
                    textBox1.Text = (g.PrezzoAcquisto / 2).ToString();
                    svincolaButton.Enabled = true;
                }

            }
            
        }
    }
}
