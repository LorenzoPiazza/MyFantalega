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
    public partial class GestioneMercato : Form
    {
        Mercato mercato;
        Squadra squadra;
        Lega lega;
        public GestioneMercato(Lega lega, Squadra squadra)
        {
            InitializeComponent();
            mercato = lega.MercatoAttivo;
            this.squadra = squadra;
            buttonVisualizzaReport.Enabled = false;
            buttonCreaPausa.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            foreach ( Squadra s in mercato.Squadre)
            {
                comboBox1.Items.Add(s.Nome);
            }
            
        }

       private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeMercatoAdmin(lega, squadra).Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Squadra squadra = (Squadra)comboBox1.SelectedItem;
            textBox1.Text = squadra.Nome;
            textBox2.Text = Convert.ToString(squadra.NumeroPor);
            textBox5.Text = Convert.ToString(squadra.NumeroDif);
            textBox4.Text = Convert.ToString(squadra.NumeroCen);
            textBox6.Text = Convert.ToString(squadra.NumeroAtt);
            textBox7.Text = Convert.ToString(squadra.CreditiResidui);
        }

        private void buttonChiudiMercato_Click(object sender, EventArgs e)
        {
            /*Boolean benFormate = true;
            for (int i = 0; i < mercato.Squadre.Count(); i++)
            {
                if (!mercato.Squadre.ElementAt(i).VerificaCompletezza())
                {
                    benFormate = false;
                    break;
                }
            }
            if (!benFormate)
            {
                if (MessageBox.Show("Sei sicuro di chiudere un mercato non concluso?", "Mercato", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ServerLegaSoapClient myGestioneAdminController = new ServerLegaSoapClient();
                    Boolean result;
                    result = myGestioneAdminController.ChiudiMercato(mercato);
                    if (result == true)
                    {
                        MessageBox.Show("Mercato chiuso anche se non completo");
                        new HomeLegaAdmin(mercato.Lega).Show();
                    }
                    else
                    {
                        MessageBox.Show("Errore nella chiusura del mercato");
                    }
                }
                else
                {
                    MessageBox.Show("Mercato ancora attivo");
                }
            }
            else
            {*/
                ServerLegaSoapClient myGestioneAdminController = new ServerLegaSoapClient();
                Lega result;
                result = myGestioneAdminController.ChiudiMercato(mercato,lega);
                if (result != null)
                {
                    MessageBox.Show("Mercato chiuso correttamente");
                    lega = result;
                    new HomeLegaAdmin(lega).Show();
                }
                else
                {
                    MessageBox.Show("Errore nella chiusura del mercato");
                }
           /*}*/
        }

        private void GestioneMercato_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
