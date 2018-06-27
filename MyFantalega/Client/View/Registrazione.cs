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
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
            buttonRegistrati.Enabled = false;
            passwordAlert.Visible = false;
            emailAlert.Visible = false;

        }
    
       private Boolean ValidaPassword()
        {
            if (textBoxPassword.Text.Length >= 8)
                return true;
            return false;
        }

        private Boolean ValidaEmail()
        {
            if (textBoxEmail.Text.Contains("@") && (textBoxEmail.Text.EndsWith(".com") || textBoxEmail.Text.EndsWith(".it")) )
                return true;
            return false;
        }
        private void AbilitaButtonRegistrazione()
        {
            if (textBoxUsername.Text.Length != 0 && ValidaPassword() && ValidaEmail() && textBoxDomanda.Text.Length != 0 && textBoxRisposta.Text.Length != 0)
                buttonRegistrati.Enabled = true;
            else
                buttonRegistrati.Enabled = false;
        }

        private void buttonRegistrati_Click(object sender, EventArgs e)
        {
            //richiesta di registrazione al ServerLogin mediante il proxy Client
            Client.ServerLogin1.RegistrazioneControllerSoapClient myRegistrazioneController = new Client.ServerLogin1.RegistrazioneControllerSoapClient();
            String emailEsito = myRegistrazioneController.RegistraUtente(textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text.ToLower().Trim(), textBoxDomanda.Text, textBoxRisposta.Text);
           

            if (emailEsito == null)
            {
                MessageBox.Show("Username già occupato. Prova con un altro");
            }
            else
            {
                MessageBox.Show("Registrazione avvenuta con successo. Utente con email: " + emailEsito);
                ServerLegaSoapClient myServerLega = new ServerLegaSoapClient();
                myServerLega.InsertUtente(textBoxUsername.Text, emailEsito);
                Utente utenteNav = new Utente();
                utenteNav.Email = emailEsito;
                this.Hide();
                WelcomeHome welcomeHome = new WelcomeHome(utenteNav);
                welcomeHome.BringToFront();
                welcomeHome.Show();
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (textBoxUsername.Text.Length != 0)
                AbilitaButtonRegistrazione();
            else
                buttonRegistrati.Enabled = false;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                emailAlert.Visible = false;
                buttonRegistrati.Enabled = false;
            }
            
                
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (ValidaEmail())
            {
                emailAlert.Visible = false;
                AbilitaButtonRegistrazione();
            }
            else
            {
                buttonRegistrati.Enabled = false;
                emailAlert.Visible = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0)
            {
                passwordAlert.Visible = false;
                buttonRegistrati.Enabled = false;
            }
                
            
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (ValidaPassword())
            {
                passwordAlert.Visible = false;
                AbilitaButtonRegistrazione();
            }

            else
            {
                buttonRegistrati.Enabled = false;
                passwordAlert.Visible = true;
            }
                

        }

        private void textBoxDomanda_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (textBoxDomanda.Text.Length != 0)
                AbilitaButtonRegistrazione();
            else
                buttonRegistrati.Enabled = false;
        }

        private void textBoxRisposta_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (textBoxRisposta.Text.Length != 0)
                AbilitaButtonRegistrazione();
            else
                buttonRegistrati.Enabled = false;
        }

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            new ViewLogin().Show();
            this.Hide();
            
        }

        private void Registrazione_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
