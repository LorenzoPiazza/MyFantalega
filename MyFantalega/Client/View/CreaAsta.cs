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

            Giocatore selezionato = null;
            foreach (Giocatore g in lega.ListaSvincolati.Giocatori)
            {
                if (comboBoxGiocatore.SelectedItem.Equals(g.Nome))
                {
                    selezionato = g;
                    break;
                }
            }
            if ( (ValidaOfferta(textBoxOfferta.Text)) && (comboBoxGiocatore.SelectedItem !=null ) && selezionato!= null)
            {
                ServerLega.ServerLegaSoapClient myGestioneAsta = new ServerLegaSoapClient();
                myGestioneAsta.CreaAsta(selezionato, Int32.Parse(textBoxOfferta.Text), squadra);
            }
            else
            {
                MessageBox.Show("Offerta non valida o giocatore selezionato non valido!");
            }
            
        }


        private Boolean ValidaOfferta(String offerta)
        {
            try
            {
                int offertaNum = Int32.Parse(offerta);

            } catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
