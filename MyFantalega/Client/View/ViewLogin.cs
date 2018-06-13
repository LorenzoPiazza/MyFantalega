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


namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            //richiesta al ServerLogin mediante il proxy Client
            Client.ServerLogin.LoginControllerSoapClient myLoginController = new Client.ServerLogin.LoginControllerSoapClient();
            if (myLoginController.VerificaCredenziali(this.textBoxUsername.Text, this.textBoxPassword.Text)){
                new Client.View.ViewWelcomeHome().ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Credenziali errate");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
