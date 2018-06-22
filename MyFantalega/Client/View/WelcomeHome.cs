using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Dominio;

namespace Client.View
{
    public partial class WelcomeHome : Form
    {
        private Utente _utenteNav;
        public WelcomeHome(Utente utente)
        {
            InitializeComponent();
            _utenteNav = utente;
        }


        private void WelcomeHome_Load(object sender, EventArgs e)
        {
            textBoxBenvenuto.Text = "Benvenuto " + _utenteNav.Email;
        }

       
        private void creazioneLegaButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CreazioneLega creazioneLega = new CreazioneLega(_utenteNav);
            creazioneLega.BringToFront();
            creazioneLega.Show();
        }

        private void cambioPassButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CambioPassword cambioPass = new CambioPassword(_utenteNav);
            cambioPass.BringToFront();
            cambioPass.Show();
        }

        private void legheListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lega lega = (Lega) legheListBox.SelectedItem;
            if (lega.SquadraAdmin.Utente.Email.Equals(_utenteNav.Email))
            {
                this.Close();
                HomeLegaAdmin homeLegaAdmin = new HomeLegaAdmin();
                homeLegaAdmin.BringToFront();
                homeLegaAdmin.Show();
            }

        }

        private void textBoxBenvenuto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
