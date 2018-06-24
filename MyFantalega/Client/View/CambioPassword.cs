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
    public partial class CambioPassword : Form
    {
        //DA AGGIUNGERE I MESSAGGI DI ERRORE (LABEL) NEL VIEW
        private Utente _utenteNav;

        public CambioPassword(Utente utente)
        {
            InitializeComponent();
            cambiaPassButton.Enabled = false;
            _utenteNav = utente;
        }

        private Boolean ValidaPassword()
        {
            if (nuovaPassTextBox.Text.Length <= 20 && nuovaPassTextBox.Text.Length >= 8)
                return true;
            return false;
        }

        private Boolean ValidaRisposta()
        {
            if (rispostaTextBox.Text.Length <= 30)
                return true;
            return false;
        }
        private void AbilitaButtonCambioPass()
        {
            if (vecchiaPassTextBox.Text.Length != 0 && ValidaPassword() && ValidaRisposta() && domandaTextBox.Text.Length != 0 && rispostaTextBox.Text.Length != 0)
                cambiaPassButton.Enabled = true;
            else
                cambiaPassButton.Enabled = false;
        }

        private void cambiaPassButton_Click(object sender, EventArgs e)
        {
           /* Client.ServerLegaUtente.GestioneUtenteControllerSoapClient myGestioneUtenteController = new Client.ServerLegaUtente.GestioneUtenteControllerSoapClient();
            Boolean cambio = myGestioneUtenteController.CambiaPassword(vecchiaPassTextBox.Text, nuovaPassTextBox.Text, domandaTextBox.Text, rispostaTextBox.Text, _utenteNav);
                
            if (cambio)
            {
                MessageBox.Show("Cambio password avvenuto con successo");
                this.Close();
                WelcomeHome welcomeHome = new WelcomeHome(_utenteNav);
                welcomeHome.BringToFront();
                welcomeHome.Show();
            }
            else
            {
                MessageBox.Show("Errore");
            }*/
        }

        private void vecchiaPassTextBox_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (vecchiaPassTextBox.Text.Length != 0)
                AbilitaButtonCambioPass();
            else
                cambiaPassButton.Enabled = false;
        }

        private void nuovaPassTextBox_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (nuovaPassTextBox.Text.Length != 0)
                AbilitaButtonCambioPass();
            else
                cambiaPassButton.Enabled = false;
        }

        private void domandaTextBox_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (domandaTextBox.Text.Length != 0)
                AbilitaButtonCambioPass();
            else
                cambiaPassButton.Enabled = false;
        }

        private void rispostaTextBox_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (rispostaTextBox.Text.Length != 0)
                AbilitaButtonCambioPass();
            else
                cambiaPassButton.Enabled = false;
        }

       private void buttonIndietro_Click(object sender, EventArgs e)
        {
            /*this.Close();
            WelcomeHome welcomeHome = new WelcomeHome(_utenteNav);
            welcomeHome.BringToFront();
            welcomeHome.Show();*/
        }

        private void CambioPassword_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
