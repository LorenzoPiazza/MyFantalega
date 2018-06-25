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
        private Utente _utenteNav;
        List<Lega> mieLeghe;
        Lega legaScelta;

        public WelcomeHome(Utente utente)
        {
            InitializeComponent();
            _utenteNav = utente;
            buttonAccedi.Enabled = false;
        }


        private void WelcomeHome_Load(object sender, EventArgs e)
        {
           textBoxBenvenuto.Text = "Benvenuto " + _utenteNav.Email;
           Client.ServerLega.ServerLegaSoapClient myGestioneUtenteController = new Client.ServerLega.ServerLegaSoapClient();

            mieLeghe = myGestioneUtenteController.GetLeghe(_utenteNav);

            if (mieLeghe == null)
            {
                groupBoxLeghe.Text = "Non partecipi ancora a nessuna lega, creane una nuova!";
            }

            else
            {

                foreach (Lega l in mieLeghe)
                {
                    comboBoxLeghe.Items.Add(l.NomeLega);
                    textBoxBenvenuto.Text = "Benvenuto" + l.NomeLega;
                }
            }
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
            this.Hide();
            CambioPassword cambioPass = new CambioPassword(_utenteNav);
            cambioPass.BringToFront();
            cambioPass.Show();
        }

        private void WelcomeHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ViewLogin().Show();
        }

        private void buttonAccedi_Click(object sender, EventArgs e)
        {
            foreach (Lega l in mieLeghe)
            {
                if (l.NomeLega.Equals(comboBoxLeghe.SelectedItem))
                {
                    legaScelta = l;
                    break;
                }
            }
            
            if (legaScelta.SquadraAdmin.Utente.Email.Equals(_utenteNav.Email)) //Sta entrando l'admin della lega
            {
                this.Hide();
                HomeLegaAdmin homeLegaAdmin = new HomeLegaAdmin(legaScelta);
                homeLegaAdmin.BringToFront();
                homeLegaAdmin.Show();
            }
            else
            {
                //entra un utente
            }
  
        }

        private void comboBoxLeghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAccedi.Enabled = true;
        }
    }
}
