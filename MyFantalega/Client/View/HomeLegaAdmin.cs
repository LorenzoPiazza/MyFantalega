using Client.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class HomeLegaAdmin : Form
    {
        private Squadra _squadra;
        public HomeLegaAdmin(Squadra squadra)
        {
            InitializeComponent();
            this._squadra = squadra;
        }

        private void HomeLegaAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
