using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServerLegaSvincolo;

namespace Client.View
{
    public partial class SvincolaGiocatore : Form
    {
        Squadra squadra;
        Giocatore giocatore;
        HomeLegaAdmin admin;
        HomeLegaUtente utente;

        public SvincolaGiocatore(Squadra squadraPass,HomeLegaAdmin adminPass)
        {
            InitializeComponent();
            admin = adminPass;
            utente = null;
            giocatore = null;
            listBox1.Items.Add(squadra.Giocatori);
            squadra = squadraPass;
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }
        public SvincolaGiocatore(Squadra squadraPass, HomeLegaUtente utentePass)
        {
            InitializeComponent();
            admin = null;
            utente = utentePass;
            giocatore = null;
            listBox1.Items.Add(squadra.Giocatori);
            squadra = squadraPass;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Giocatore g = (Giocatore)listBox1.SelectedItem;
            giocatore = g;
            textBox1.Text = (g.PrezzoAcquisto / 2).ToString();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler svincolare il giocatore?", giocatore.Nome, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                ServerLegaSvincolo.GestioneSvincoloControllerSoapClient mySvincoloController = new ServerLegaSvincolo.GestioneSvincoloControllerSoapClient();
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
                new HomeLegaUtente(squadra.Lega).Show();
            }
        }
    }
}
