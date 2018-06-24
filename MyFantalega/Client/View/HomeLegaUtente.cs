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
    public partial class HomeLegaUtente : Form
    {
        private Squadra _squadra;
        public HomeLegaUtente(Squadra squadra)
        {
            InitializeComponent();
            this._squadra = squadra;
        }
        
        private void HomeLegaUtente_Load(object sender, EventArgs e)
        {
            
        }

        private void unioneMercatoButton_Click(object sender, EventArgs e)
        {
            Client.ServerLega.ServerLegaSoapClient myGestioneUtenteController = new Client.ServerLega.ServerLegaSoapClient();
            //myGestioneUtenteController.UniscitiAMercato(_squadra);
        }

        private void squadraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void indietroButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
