using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServerLegaLega;

namespace Client.View
{
    public partial class GestioneLega : Form
    {
        Lega lega;
        public GestioneLega(Lega legaPass)
        {
            lega = legaPass;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.SetRange(4, 12);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text)<0 || int.Parse(textBox1.Text) > 1000000)
            {
                MessageBox.Show("numero crediti iniziali sbagliato (range 0-1000000)");
                button7.Enabled = false;
            }
            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //richiesta al ServerLega mediante il proxy Client
            ServerLegaLega.GestioneLegaControllerSoapClient myLegaController = new ServerLegaLega.GestioneLegaControllerSoapClient();
            Boolean result;
            result = myLegaController.SetImpostazioni(trackBar1.Value, int.Parse(textBox1.Text), int.Parse(textBox3.Text), int.Parse(textBox5.Text), int.Parse(textBox4.Text), int.Parse(textBox2.Text),lega);
            if (result == true)
            {
                lega.CreditiInizialiSquadra = int.Parse(textBox1.Text);
                lega.NumeroAtt = int.Parse(textBox2.Text);
                lega.NumeroCen = int.Parse(textBox4.Text);
                lega.NumeroDif = int.Parse(textBox5.Text);
                lega.NumeroPor = int.Parse(textBox3.Text);
                lega.NumeroSquadreTotali = trackBar1.Value;
                MessageBox.Show("Impostazioni Modificate");
            }
            else
            {
                MessageBox.Show("Impostazioni errate");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox2.Text) < 3 || int.Parse(textBox2.Text) > 6)
            {
                MessageBox.Show("numero attaccanti sbagliato (range 3-6)");
                button7.Enabled = false;
            }
            button7.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox4.Text) < 5 || int.Parse(textBox4.Text) > 10)
            {
                MessageBox.Show("numero centrocampisti sbagliato (range 5-10)");
                button7.Enabled = false;
            }
            button7.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox5.Text) < 5 || int.Parse(textBox5.Text) > 10)
            {
                MessageBox.Show("numero difensori sbagliato (range 5-10)");
                button7.Enabled = false;
            }
            button7.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(textBox3.Text) < 1 || int.Parse(textBox3.Text) > 3)
            {
                MessageBox.Show("numero centrocampisti sbagliato (range 1-3)");
                button7.Enabled = false;
            }
            button7.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServerLegaLega.GestioneLegaControllerSoapClient myLegaController = new ServerLegaLega.GestioneLegaControllerSoapClient();
            Boolean result;
            result = myLegaController.CaricaLista("file", lega);
            if (result == true)
            {
               //NON MI TORNA NESSUNA LISTA
                MessageBox.Show("Lista aggiornata");
            }
            else
            {
                MessageBox.Show("Errore nel caricamento lista");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new HomeLegaAdmin(lega.SquadraAdmin).Show();
        }
    }
}
