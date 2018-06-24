using ServerLega.Dominio;
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
    public partial class HomeLegaAdmin : Form
    {
        //private Squadra _squadra;
        private ServerLega.Lega lega;

        public HomeLegaAdmin(ServerLega.Lega lega)
        {
            InitializeComponent();
            this.lega = lega;
        }

        private void HomeLegaAdmin_Load(object sender, EventArgs e)
        {
            squadraTextBox.Text = "CIAO " + lega.NomeLega;
        }

        private void squadraTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
