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
    public partial class PartecipaAsta : Form
    {
        Lega lega;
        Squadra squadra;
        public PartecipaAsta(Lega lega, Squadra squadra)
        {
            InitializeComponent();
            this.lega = lega;
            this.squadra = squadra;
            foreach (Squadra s in lega.MercatoAttivo.Squadre)
            {
                comboBox1.Items.Add(s.Nome);
            }
            textBox2.Text = lega.MercatoAttivo.AstaAttiva.UltimoOfferente.Nome;
            textBox5.Text = Convert.ToString(lega.MercatoAttivo.AstaAttiva.UltimaOfferta);
            textBox3.Text = lega.MercatoAttivo.AstaAttiva.Giocatore.Nome;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeMercatoAdmin(lega, squadra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int offertaNum = 0;
            Giocatore selezionato = null;
            foreach (Giocatore g in lega.ListaSvincolati.Giocatori)
            {
                if (textBox3.Text.Equals(g.Nome))
                {
                    selezionato = g;
                    break;
                }
            }
            try
            {
                offertaNum = Int32.Parse(textBox1.Text);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Hai sbagliato a scrivere l'offerta, deve essere un intero!");
                return ;
            }
            if ((ValidaOfferta(offertaNum, selezionato)))
            {
                ServerLega.ServerLegaSoapClient myGestioneAsta = new ServerLegaSoapClient();
                Lega legaPass = myGestioneAsta.Offri(offertaNum, squadra,lega);
                lega = legaPass;
                this.Hide();
                new HomeMercatoAdmin(lega, squadra).Show();
            }
            else
            {
                MessageBox.Show("Offerta non valida, reinserire i dati!");
            }
        }

        private Boolean ValidaOfferta(int offerta, Giocatore giocatore)
        {
            if (offerta < giocatore.QuotazioneIniziale || offerta > squadra.CreditiResidui)
            {
                return false;
            }
            return true;
        }

        private void PartecipaAsta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServerLega.ServerLegaSoapClient myGestioneAsta = new ServerLegaSoapClient();
            Lega legaPass = myGestioneAsta.Rialza(squadra,lega);
            lega = legaPass;
            this.Hide();
            new HomeMercatoAdmin(lega, squadra).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServerLega.ServerLegaSoapClient myGestioneAsta = new ServerLegaSoapClient();
            Lega legaPass = myGestioneAsta.Abbandona(squadra,lega);
            lega = legaPass;
            this.Hide();
            new HomeMercatoAdmin(lega, squadra).Show();
        }
    }
}
