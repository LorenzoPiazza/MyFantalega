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
            InitializeComponent();
            buttonGestioneGiocatori.Enabled = false;
            buttonGestionePartecipanti.Enabled = false;
            buttonVisualizzaLog.Enabled = false;
            buttonEliminaLega.Enabled = false;

            //Setto l'output alle impostazioni attuali
            textBoxPor.Text = lega.NumeroPor.ToString();
            textBoxDif.Text = lega.NumeroDif.ToString();
            textBoxCen.Text = lega.NumeroCen.ToString();
            textBoxAtt.Text = lega.NumeroAtt.ToString();
            textBoxCreditiIniz.Text = lega.CreditiInizialiSquadra.ToString();
            trackBarNumPartecipanti.Value = lega.NumeroSquadreTotali;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBarNumPartecipanti.SetRange(4, 12);
        }

       private void buttonConferma_Click(object sender, EventArgs e)
        {

            if (ValidaRichiesta())
            {
                //richiesta al ServerLega mediante il proxy Client
                ServerLega.ServerLegaSoapClient myLegaController = new ServerLega.ServerLegaSoapClient();
                Lega aggiornata;
                aggiornata = myLegaController.SetImpostazioni(trackBarNumPartecipanti.Value, int.Parse(textBoxCreditiIniz.Text), int.Parse(textBoxPor.Text), int.Parse(textBoxDif.Text), int.Parse(textBoxCen.Text), int.Parse(textBoxAtt.Text), lega);

                if (aggiornata == null)
                {
                    MessageBox.Show("Errore della modifica lato server!");
                }
                else
                {
                    lega = aggiornata;
                    MessageBox.Show("Impostazioni modificate correttamente!");
                }
            }
        }

        /*private void textBoxPor_TextChanged(object sender, EventArgs e)
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
        }*/



    private void buttonCaricaLista_Click(object sender, EventArgs e)
    {

            ServerLega.ServerLegaSoapClient myLegaController = new ServerLega.ServerLegaSoapClient();
            lega.ListaSvincolati = null;
            lega = myLegaController.CaricaLista("file", lega);
            if (lega.ListaSvincolati != null)
            {
                MessageBox.Show("Lista caricata correttamente!");
               
            }
            else
            {
                MessageBox.Show("Errore nel caricamento lista!");
            }
           
           
    }
        

        private void buttonIndietro_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeLegaAdmin(lega).Show();
        }



        //Validazione degli Input
        private Boolean ValidaRichiesta()
        {
            if (ValidaPor() && ValidaDif() && ValidaCen() && ValidaAtt() && ValidaCrediti())
                return true;
            else
                return false;
        }

        private Boolean ValidaPor()
        {
            try
            {
                if (textBoxPor.Text == null || textBoxPor.Text.Equals("") || int.Parse(textBoxPor.Text) < 1 || int.Parse(textBoxPor.Text) > 3)
                {
                    MessageBox.Show("numero portieri non consentito (range 1-3)");
                    return false;
                }
            } catch(Exception e)
            {
                MessageBox.Show("numero portieri non consentito (range 1-3)");
                return false;
            }
            return true;

        }

        private Boolean ValidaDif()
        {
            try
            {
                if (textBoxDif.Text == null || textBoxDif.Text.Equals("") || int.Parse(textBoxDif.Text) < 5 || int.Parse(textBoxDif.Text) > 10)
                {
                    MessageBox.Show("numero difensori non consentito (range 5-10)");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("numero difensori non consentito (range 5-10)");
                return false;
            }
            return true;

        }


        private Boolean ValidaCen()
        {
            try
            {
                if (textBoxCen.Text == null || textBoxCen.Text.Equals("") || int.Parse(textBoxCen.Text) < 5 || int.Parse(textBoxCen.Text) > 10)
                {
                    MessageBox.Show("numero centrocampisti non consentito (range 5-10)");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("numero centrocampisti non consentito (range 5-10)");
                return false;
            }
            return true;
        }


        private Boolean ValidaAtt()
        {
            try
            {
                if (textBoxAtt.Text == null || textBoxAtt.Text.Equals("") || int.Parse(textBoxAtt.Text) < 5 || int.Parse(textBoxAtt.Text) > 10)
                {
                    MessageBox.Show("numero attaccanti non consentito (range 5-10)");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("numero attaccanti non consentito (range 5-10)");
                return false;
            }
            return true;
        }

        private Boolean ValidaCrediti()
        {
            try
            {
                if (textBoxCreditiIniz.Text == null || textBoxCreditiIniz.Text.Equals("") || int.Parse(textBoxCreditiIniz.Text) < 0 || int.Parse(textBoxCreditiIniz.Text) > 1000000)
                {
                    MessageBox.Show("numero crediti iniziali non consentito (range 0-1000000)");
                    return false;
                }
            }catch (Exception e)
            {
                MessageBox.Show("numero crediti iniziali non consentito (range 0-1000000)");
                return false;
            }
           return true;
        }

    }
}