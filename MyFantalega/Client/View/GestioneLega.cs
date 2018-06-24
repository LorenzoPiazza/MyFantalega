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
    public partial class GestioneLega : Form
    {
        Lega lega; 
        public GestioneLega(Lega legaPass)
        {
            lega = legaPass;
            buttonGestioneGiocatori.Enabled = false;
            buttonGestionePartecipanti.Enabled = false;
            buttonVisualizzaLog.Enabled = false;
            buttonEliminaLega.Enabled = false;
            buttonConferma.Enabled = false;
            InitializeComponent();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarNumPartecipanti.SetRange(4, 12);
        }

       private void buttonConferma_Click(object sender, EventArgs e)
        {/*
            //richiesta al ServerLega mediante il proxy Client
            ServerLegaLega.GestioneLegaControllerSoapClient myLegaController = new ServerLegaLega.GestioneLegaControllerSoapClient();
            Boolean result;
            result = myLegaController.SetImpostazioni(trackBarNumPartecipanti.Value, int.Parse(textBoxCreditiIniz.Text), int.Parse(textBoxPor.Text), int.Parse(textBoxCen.Text), int.Parse(textBoxDif.Text), int.Parse(textBoxAtt.Text), lega);
            if (result == true)
            {
                lega.CreditiInizialiSquadra = int.Parse(textBoxCreditiIniz.Text);
                lega.NumeroAtt = int.Parse(textBoxAtt.Text);
                lega.NumeroCen = int.Parse(textBoxCen.Text);
                lega.NumeroDif = int.Parse(textBoxCen.Text);
                lega.NumeroPor = int.Parse(textBoxPor.Text);
                lega.NumeroSquadreTotali = trackBarNumPartecipanti.Value;
                MessageBox.Show("Impostazioni Modificate");
            }
            else
            {
                MessageBox.Show("Impostazioni errate");
            }*/
        }

        private void textBoxPor_TextChanged(object sender, EventArgs e)
        {
            //Se il numero di portieri è valido passo controllare tutti gli altri campi
            if (ValidaPor())
                AbilitaButtonConferma();
        }


        private void textBoxDif_TextChanged(object sender, EventArgs e)
        {
            //Se il numero di difensori è valido passo controllare tutti gli altri campi
            if (ValidaDif())
                AbilitaButtonConferma();
        }

        private void textBoxCen_TextChanged(object sender, EventArgs e)
        {
            //Se il numero di centrocampisti è valido passo controllare tutti gli altri campi
            if (ValidaCen())
                AbilitaButtonConferma();
        }

        private void textBoxAtt_TextChanged(object sender, EventArgs e)
        {
            //Se il numero di attaccanti è valido passo controllare tutti gli altri campi
            if (ValidaAtt())
                AbilitaButtonConferma();
        }

        private void textBoxCreditiIniz_TextChanged(object sender, EventArgs e)
        {
            //Se il numero di crediti iniziali è valido passo controllare tutti gli altri campi
            if (ValidaCrediti())
                AbilitaButtonConferma();
        }



        private void buttonCaricaLista_Click(object sender, EventArgs e)
        {
           /* ServerLegaLega.GestioneLegaControllerSoapClient myLegaController = new ServerLegaLega.GestioneLegaControllerSoapClient();
            Boolean result;
            result = myLegaController.CaricaLista("file", lega);
            if (result == true)
            {
                //NON MI TORNA NESSUNA LISTA
                MessageBox.Show("Lista aggiornata");
            }
            else
            {
                MessageBox.Show("Errore nel caricamento lista");
            }*/
        }
        

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            //new HomeLegaAdmin(lega.SquadraAdmin).Show();
        }



        //Validazione degli Input
        private void AbilitaButtonConferma()
        {
            if (ValidaPor() && ValidaDif() && ValidaCen() && ValidaAtt() && ValidaCrediti())
                buttonConferma.Enabled = true;
            else
                buttonConferma.Enabled = false;
        }

        private Boolean ValidaPor()
        {
            if (textBoxPor.Text == null || int.Parse(textBoxPor.Text) < 1 || int.Parse(textBoxPor.Text) > 3)
            {
                MessageBox.Show("numero portieri non consentito (range 1-3)");
                return false;
            }
            return true;

        }

        private Boolean ValidaDif()
        {
            if (textBoxDif.Text == null || int.Parse(textBoxDif.Text) < 5 || int.Parse(textBoxDif.Text) > 10)
            {
                MessageBox.Show("numero difensori non consentito (range 5-10)");
                return false;
            }
            return true;
        }


        private Boolean ValidaCen()
        {
            if (textBoxCen.Text == null || int.Parse(textBoxCen.Text) < 5 || int.Parse(textBoxCen.Text) > 10)
            {
                MessageBox.Show("numero centrocampisti non consentito (range 5-10)");
                return false;
            }
            return true;
        }


        private Boolean ValidaAtt()
        {
            if (textBoxAtt.Text == null || int.Parse(textBoxAtt.Text) < 5 || int.Parse(textBoxAtt.Text) > 10)
            {
                MessageBox.Show("numero attaccanti non consentito (range 5-10)");
                return false;
            }
            return true;
        }

        private Boolean ValidaCrediti()
        {
            if (textBoxCreditiIniz.Text==null || int.Parse(textBoxCreditiIniz.Text) < 0 || int.Parse(textBoxCreditiIniz.Text) > 1000000)
            {
                MessageBox.Show("numero crediti iniziali non consentito (range 0-1000000)");
                return false;
            }
           return true;
        }


    }
}