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
    public partial class HomeMercatoAdmin : Form
    {
        Mercato mercato;
        Lega lega;
        Squadra squadra;

        public HomeMercatoAdmin(Lega legaPass, Squadra squadra)
        {
            InitializeComponent();
            lega = legaPass;
            this.squadra = squadra;
            mercato = lega.MercatoAttivo;
            textBoxCrediti.Text = ""+squadra.CreditResidui;
            buttonCrea.Enabled = false;
            buttonPartecipa.Enabled = false;
            foreach (Giocatore g in squadra.Giocatori)
            {
                listBoxAcquisti.Items.Add(g.Nome + "\t\t\t\t\t\tACQUISTATO A:" + g.PrezzoAcquisto);
            }
            if(lega.MercatoAttivo.AstaAttiva != null)
            {
                textBoxGiocatore.Text = lega.MercatoAttivo.AstaAttiva.Giocatore.Nome;
                textBoxOfferta.Text = ""+lega.MercatoAttivo.AstaAttiva.UltimaOfferta;
            }



            ServerLegaSoapClient myGestioneAdminController = new ServerLegaSoapClient();
            Turno result = new Turno();
            result = myGestioneAdminController.GestisciAsta(lega, squadra);

            if(result.Tipo == true)
            {
                labelAttesa.Visible = false;
                buttonCrea.Enabled = true;
            }
            else
            {
                labelAttesa.Visible = false;
                buttonPartecipa.Enabled = true;
            }




        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            new GestioneMercato(mercato).Show();
        }

        private void HomeMercatoAdmin_Load(object sender, EventArgs e)
        {
            
        }



        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeLegaAdmin(lega).Show();
        }

        private void buttonCrea_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreaAsta(lega, squadra).Show();
        }
    }
}
