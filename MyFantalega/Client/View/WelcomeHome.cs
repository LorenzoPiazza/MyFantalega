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
    public partial class WelcomeHome : Form
    {
        private Client.ServerLega.Utente _utenteNav;

        public WelcomeHome(Client.ServerLega.Utente utente)
        {
            InitializeComponent();
            _utenteNav = utente;
            buttonAccedi.Enabled = false;
        }


        private void WelcomeHome_Load(object sender, EventArgs e)
        {
            //textBoxBenvenuto.Text = "Benvenuto " + _utenteNav.Email;
           /* Client.ServerLegaUtente.GestioneUtenteControllerSoapClient myGestioneUtenteController = new Client.ServerLegaUtente.GestioneUtenteControllerSoapClient();

            List<Client.ServerLegaUtente.Lega> mieLeghe = myGestioneUtenteController.getLeghe(_utenteNav);

            if (mieLeghe == null)
            {
                groupBoxLeghe.Text = "Non partecipi ancora a nessuna lega, creane una nuova!";
            }
            

            else
            {

                foreach (Client.ServerLegaUtente.Lega l in mieLeghe)
                {
                    Console.WriteLine("trovata Lega {0}", l.NomeLega);
                    listBoxLeghe.Items.Add(l);
                    comboBoxLeghe.Items.Add(l);
                    textBoxBenvenuto.Text = "Benvenuto" + l.NomeLega;
                }
            }*/
        }

       
       private void creazioneLegaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreazioneLega creazioneLega = new CreazioneLega(_utenteNav);
            creazioneLega.BringToFront();
            creazioneLega.Show();
        }

        private void cambioPassButton_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            CambioPassword cambioPass = new CambioPassword(_utenteNav);
            cambioPass.BringToFront();
            cambioPass.Show();*/
        }

       private void legheListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Lega lega = (Lega) legheListBox.SelectedItem;
            if (lega.SquadraAdmin.Utente.Email.Equals(_utenteNav.Email))
            {
                this.Close();
                HomeLegaAdmin homeLegaAdmin = new HomeLegaAdmin();
                homeLegaAdmin.BringToFront();
                homeLegaAdmin.Show();
            }*/

        }

        private void groupBoxLeghe_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBoxLeghe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxLeghe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
