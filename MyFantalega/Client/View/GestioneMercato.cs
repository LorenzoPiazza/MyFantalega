using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServerLegaMercato;

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
            new HomeLegaAdmin().Show();
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
            ServerLegaMercato.GestioneMercatoControllerSoapClient myMercatoControler = new ServerLegaMercato.GestioneMercatoControllerSoapClient();
            Boolean result;
            result = myMercatoControler.ChiudiMercato(mercato);
            if (result == true)
            {
                MessageBox.Show("Mercato Chiuso");
                new HomeLegaAdmin().Show();
            }
            else
            {
                MessageBox.Show("Errore nella chiusura del mercato");
            }
        }
    }
}
