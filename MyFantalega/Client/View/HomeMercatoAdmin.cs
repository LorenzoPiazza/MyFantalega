﻿using System;
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
    public partial class HomeMercatoAdmin : Form
    {
        Mercato mercato;
        public HomeMercatoAdmin(Lega legaPass, Squadra squadra)
        {
            mercato = legaPass.MercatoAttivo;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         //   new GestioneMercato(mercato).Show();
        }

        private void HomeMercatoAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
