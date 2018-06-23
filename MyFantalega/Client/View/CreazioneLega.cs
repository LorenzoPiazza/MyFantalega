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
using Client.Dominio;

namespace Client.View
{
    public partial class CreazioneLega : Form
    {
        //DA AGGIUNGERE I MESSAGGI DI ERRORE (LABEL) NEL VIEW
        private Utente _utenteNav;
        public CreazioneLega(Utente utente)
        {
            InitializeComponent();
            CreaButton.Enabled = false;
            _utenteNav = utente;
        }

        private Boolean ValidaNomeLega()
        {
            if (NomeDellaLegatextBox.Text.Length <= 20 && NomeDellaLegatextBox.Text.Length != 0)
                return true;
            return false;
        }

        private void CreazioneLega_Load(object sender, EventArgs e)
        {

        }

        private void NomeDellaLegatextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidaNomeLega())
                CreaButton.Enabled = true;
            CreaButton.Enabled = false;
        }

        private void NPartTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void CreaButton_Click(object sender, EventArgs e)
        {/*
            //sul numero di partecipanti non viene fatto nessun controllo perche la track bar lascia inserire solo valori dal 4 al 12
            int part = NPartTrackBar.Value;
            String lega = NomeDellaLegatextBox.Text;
            //Client.ServerLegaLega.GestioneUtenteControllerSoapClient myGestioneUtenteController = new Client.ServerLogin1.RegistrazioneControllerSoapClient();
            //String emailEsito = myRegistrazioneController.RegistraUtente(textBoxUsername.Text, textBoxPassword.Text,viewGestionePartecipanti)
            this.Close();
            WelcomeHome welcomeHome = new WelcomeHome(_utenteNav);
            welcomeHome.BringToFront();
            welcomeHome.Show();
            */
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {/*
            this.Close();
            WelcomeHome welcomeHome = new WelcomeHome(_utenteNav);
            welcomeHome.BringToFront();
            welcomeHome.Show();
            */
        }
    }
}
