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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
