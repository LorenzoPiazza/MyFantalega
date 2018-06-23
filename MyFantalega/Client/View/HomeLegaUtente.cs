using Client.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Client.ServerLegaUtente.GestioneUtenteControllerSoapClient myGestioneUtenteController = new Client.ServerLegaUtente.GestioneUtenteControllerSoapClient();
            myGestioneUtenteController.UniscitiAMercato(_squadra);
        }

        private void squadraTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void indietroButton_Click(object sender, EventArgs e)
        {

        }
    }
}
