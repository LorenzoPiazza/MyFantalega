using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fantacalcio.DominioLega;

namespace WindowsFormsApp1
{
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Registrazione_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //richiesta di registrazione al ServerLogin mediante il proxy Client
            Client.ServerLogin1.RegistrazioneControllerSoapClient myRegistrazioneController = new Client.ServerLogin1.RegistrazioneControllerSoapClient();
            String emailEsito = myRegistrazioneController.registraUtente(textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, textBoxDomanda.Text, textBoxPassword.Text);
            if (emailEsito == null)
            {
                MessageBox.Show("Utente già registrato");
            }
            else
            {
                MessageBox.Show("Registrazione avvenuta con successo. Utente con email: " + emailEsito);
                Utente utenteNav = new Utente(emailEsito);
                this.Close();
                WelcomeHome welcomeHome = new WelcomeHome();
                welcomeHome.BringToFront();
                welcomeHome.Show();
            }
        }
    }
}
