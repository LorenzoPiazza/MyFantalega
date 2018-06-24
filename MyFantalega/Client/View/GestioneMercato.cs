using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Dominio;

namespace Client.View
{
    public partial class GestioneMercato : Form
    {
       Mercato mercato;
        public GestioneMercato(Mercato mercatoPass)
        {
            mercato = mercatoPass;
            button4.Enabled = false;
            button1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            comboBox1.Items.Add(mercato.Squadre);
            InitializeComponent();
        }

       private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Close();
            new HomeLegaAdmin(mercato.Lega.SquadraAdmin).Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Squadra squadra = (Squadra)comboBox1.SelectedItem;
            textBox1.Text = squadra.Nome;
            textBox2.Text = Convert.ToString(squadra.NumeroPor);
            textBox5.Text = Convert.ToString(squadra.NumeroDif);
            textBox4.Text = Convert.ToString(squadra.NumeroCen);
            textBox6.Text = Convert.ToString(squadra.NumeroAtt);
            textBox7.Text = Convert.ToString(squadra.CreditResidui);
        }

        private void buttonChiudiMercato_Click(object sender, EventArgs e)
        {
            Boolean benFormate = true;
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
                    ServerLegaMercato.GestioneMercatoControllerSoapClient myMercatoController = new ServerLegaMercato.GestioneMercatoControllerSoapClient();
                    Boolean result;
                    result = myMercatoController.ChiudiMercato((Client.ServerLegaMercato.Mercato)mercato);
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
            {
                Client.ServerLegaMercato.GestioneMercatoControllerSoapClient myMercatoController = new Client.ServerLegaMercato.GestioneMercatoControllerSoapClient();
                Boolean result;
                result = myMercatoController.ChiudiMercato(mercato);
                if (result == true)
                {
                    MessageBox.Show("Mercato chiuso correttamente");
                    new HomeLegaAdmin(mercato.Lega).Show();
                }
                else
                {
                    MessageBox.Show("Errore nella chiusura del mercato");
                }
            }
        }
    }
}
