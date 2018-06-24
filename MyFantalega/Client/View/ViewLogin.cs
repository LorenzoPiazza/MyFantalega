using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Client.ServerLega;

namespace Client.View
{
    public partial class ViewLogin : Form
    {
        String emailUtenteNav;
        Client.ServerLega.Utente utenteNav;
        public ViewLogin()
        {
            InitializeComponent();
            buttonLogin.Enabled = false;
        }

        private Boolean ValidaPassword()
        {
            if (textBoxPassword.Text.Length >= 8)
                return true;
            return false;
        }

        private void AbilitaButtonLogin()
        {
            if (textBoxUsername.Text.Length != 0 && ValidaPassword() )
                buttonLogin.Enabled = true;
            else
                buttonLogin.Enabled = false;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            //richiesta al ServerLogin mediante il proxy Client
            Client.ServerLogin.LoginControllerSoapClient myLoginController = new Client.ServerLogin.LoginControllerSoapClient();
            emailUtenteNav = myLoginController.VerificaCredenziali(textBoxUsername.Text, textBoxPassword.Text);
            if (emailUtenteNav != null){
                utenteNav = new Client.ServerLega.Utente();
                utenteNav.Email = emailUtenteNav;
                this.Hide();
                new WelcomeHome(utenteNav).ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Credenziali errate");
            }
        }

        private void ButtonRegistrazione_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registrazione().ShowDialog();
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text.Length == 0)
            {
                buttonLogin.Enabled = false;
            }

            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (ValidaPassword())
            {
                AbilitaButtonLogin();
            }
            else
            {
                buttonLogin.Enabled = false;
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            //Per evitare che ad ogni cambiamento di ogni singolo carattere vengano invocati i controlli su tutte le altre textBox chiamo prima
            //solo il controllo di questa textBox e poi se questo va a buon fine chiamo la funzione che fa tutti gli altri controlli
            if (textBoxUsername.Text.Length != 0)
                AbilitaButtonLogin();
            else
                buttonLogin.Enabled = false;
        }

        private void ViewLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
