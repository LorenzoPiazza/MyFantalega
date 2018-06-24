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
            //Il controllo sulla lunghezza di max 20 caratteri viene fatto dalle proprietà della text box
            if (NomeDellaLegatextBox.Text.Equals(""))
                return false;
            return true;
        }

        private void CreazioneLega_Load(object sender, EventArgs e)
        {

        }

        private void NomeDellaLegatextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidaNomeLega())
                CreaButton.Enabled = true;
            else
                CreaButton.Enabled = false;
        }

        private void NPartTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void CreaButton_Click(object sender, EventArgs e)
        {
            //sul numero di partecipanti non viene fatto nessun controllo perche la track bar lascia inserire solo valori dal 4 al 12
            Client.ServerLega.ServerLegaSoapClient myGestioneUtenteController = new Client.ServerLega.ServerLegaSoapClient();
            Lega lega = myGestioneUtenteController.CreaLega(NomeDellaLegatextBox.Text, NPartTrackBar.Value, NomeDellaSquadratextBox.Text, _utenteNav);
            if(lega == null)
            {
                MessageBox.Show("Creazione andata male. Probabilmente esiste già una lega con quel nome!");
            }
            else
            {
                this.Close();
                HomeLegaAdmin homeLegaAdmin = new HomeLegaAdmin(lega);
                homeLegaAdmin.Show();
            }
        }

        private void indietroButton_Click(object sender, EventArgs e)
        {/*
            this.Close();
            WelcomeHome welcomeHome = new WelcomeHome(_utenteNav);
            welcomeHome.BringToFront();
            welcomeHome.Show();
            */
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}


/*
 * VERSIONE CORRETTA
 * 
 * 
 * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServerLegaUtente;

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
            //Il controllo sulla lunghezza di max 20 caratteri viene fatto dalle proprietà della text box
            if (NomeDellaLegatextBox.Text.Equals(""))
                return false;
            return true;
        }

        private void CreazioneLega_Load(object sender, EventArgs e)
        {

        }

        private void NomeDellaLegatextBox_TextChanged(object sender, EventArgs e)
        {
            if (ValidaNomeLega())
                CreaButton.Enabled = true;
            else
                CreaButton.Enabled = false;
        }

        private void NPartTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void CreaButton_Click(object sender, EventArgs e)
        {
            //sul numero di partecipanti non viene fatto nessun controllo perche la track bar lascia inserire solo valori dal 4 al 12
            Client.ServerLegaUtente.GestioneUtenteControllerSoapClient myGestioneUtenteController = new ServerLegaUtente.GestioneUtenteControllerSoapClient();
            Client.ServerLegaUtente.Lega lega = myGestioneUtenteController.CreaLega(NomeDellaLegatextBox.Text, NPartTrackBar.Value, _utenteNav);
            this.Close();
            /*WelcomeHome welcomeHome = new WelcomeHome(_utenteNav);
            welcomeHome.BringToFront();
            welcomeHome.Show();
           
            
        }*/

        /*private void indietroButton_Click(object sender, EventArgs e)
        {
            this.Close();
            WelcomeHome welcomeHome = new WelcomeHome(_utenteNav);
            welcomeHome.BringToFront();
            welcomeHome.Show();
            
        }
    }
}*/
