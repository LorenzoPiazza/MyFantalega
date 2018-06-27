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
    public partial class CreaAsta : Form
    {
        Lega lega;
        Squadra squadra;

        public CreaAsta(Lega lega, Squadra squadra)
        {
            InitializeComponent();
            this.lega = lega;
            this.squadra = squadra;
            foreach (Giocatore g in lega.ListaSvincolati.Giocatori)
            {
                comboBoxSvincolati.Items.Add(g.Ruolo + "--" + g.Nome + "--" + g.QuotazioneIniziale);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeMercatoAdmin(lega, squadra).Show();
        }

        private void buttonOffri_Click(object sender, EventArgs e)
        {
            int offertaNum = 0;
            Giocatore selezionato = null;
            foreach (Giocatore g in lega.ListaSvincolati.Giocatori)
            {
                if (comboBoxSvincolati.SelectedItem.Equals(g.Nome))
                {
                    selezionato = g;
                    break;
                }
            }
            try
            {
                offertaNum = Int32.Parse(textBoxOfferta.Text);

            }
            catch (Exception exc)
            {
                MessageBox.Show("Hai sbagliato a scrivere l'offerta, deve essere un intero!");
                return;
            }
            if ( (ValidaOfferta(offertaNum,(Giocatore) comboBoxSvincolati.SelectedItem)) && (comboBoxSvincolati.SelectedItem !=null ) && selezionato!= null)
            {
                ServerLega.ServerLegaSoapClient myGestioneAsta = new ServerLegaSoapClient();
                Lega legaPass=myGestioneAsta.CreaAsta(selezionato, offertaNum, squadra);
                lega= legaPass;
                new HomeMercatoAdmin(lega, squadra).Show();
            }
            else
            {
                MessageBox.Show("Offerta non valida o giocatore selezionato non valido, reinserire i dati!");
            }
            
        }


        private Boolean ValidaOfferta(String offerta,Giocatore giocatore)
        {
            int offertaNum = giocatore.QuotazioneIniziale;
            try
            {
                offertaNum = Int32.Parse(offerta);

            } catch (Exception e)
            {
                Console.Write(e.Message);
                return false;
            }
            if(offertaNum < giocatore.QuotazioneIniziale || offertaNum> squadra.CreditResidui)
            {
                return false;
            }
            return true;
        }

        private void comboBoxGiocatore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
