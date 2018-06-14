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
using fantacalcio.DominioLega;
using WindowsFormsApp1;

namespace Client
{
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //richiesta al ServerLogin mediante il proxy Client
            Client.ServerLogin.LoginControllerSoapClient myLoginController = new Client.ServerLogin.LoginControllerSoapClient();
            if (myLoginController.VerificaCredenziali(this.textBoxUsername.Text, this.textBoxPassword.Text)){
                new WindowsFormsApp1.WelcomeHome().ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Credenziali errate");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrazione_Click(object sender, EventArgs e)
        {
            new WindowsFormsApp1.Registrazione().Show();
        }
    }
}
