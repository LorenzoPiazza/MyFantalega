using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServerLega.Dominio
{
    public class Lega
    {
        private String _nomeLega;
        private Squadra _squadraAdmin;
        private int _numeroSquadreTotali;
        private int _creditiInizialiSquadra;
        private int _numeroPor;
        private int _numeroDif;
        private int _numeroCen;
        private int _numeroAtt;
        private Mercato _mercatoAttivo;
        private List<Squadra> _squadre;
        private ListaSvincolati _listaSvincolati;
        //private Log log;

        public Lega(string nomeLega, int numeroSquadreTotali)
        {
            if (nomeLega == null || nomeLega.Length == 0)
            {
                throw new ArgumentNullException("nomeLega nullo");
            }

            if (numeroSquadreTotali < 4 || numeroSquadreTotali > 12)
            {
                throw new ArgumentException("numero partecipanti <4 o >12");
            }

          
            _nomeLega = nomeLega;
            _numeroSquadreTotali = numeroSquadreTotali;

            //Parameri di default modificabili tramite set
            _creditiInizialiSquadra = 500;
            _numeroPor = 3;
            _numeroDif = 8;
            _numeroCen = 8;
            _numeroAtt = 6;

            _squadre = new List<Squadra>();
            MercatoAttivo = null;
            ListaSvincolati = null;

        }

        public Lega()
        {
            //Parameri di default modificabili tramite set
            _creditiInizialiSquadra = 500;
            _numeroPor = 3;
            _numeroDif = 8;
            _numeroCen = 8;
            _numeroAtt = 6;

            _squadre = new List<Squadra>();
            MercatoAttivo = null;
            ListaSvincolati = null;

        }

     
        public string NomeLega { get => _nomeLega; set => _nomeLega = value; }
   
        public Squadra SquadraAdmin { get => _squadraAdmin; set => _squadraAdmin = value; }
      
        public int NumeroSquadreTotali { get => _numeroSquadreTotali; set => _numeroSquadreTotali = value; }
     
        public int CreditiInizialiSquadra { get => _creditiInizialiSquadra; set => _creditiInizialiSquadra = value; }
    
        public int NumeroPor { get => _numeroPor; set => _numeroPor = value; }
  
        public int NumeroDif { get => _numeroDif; set => _numeroDif = value; }
   
        public int NumeroCen { get => _numeroCen; set => _numeroCen = value; }

        public int NumeroAtt { get => _numeroAtt; set => _numeroAtt = value; }
   
        public Mercato MercatoAttivo { get => _mercatoAttivo; set => _mercatoAttivo = value; }
    
        public ListaSvincolati ListaSvincolati { get => _listaSvincolati; set => _listaSvincolati = value; }
   
        public List<Squadra> Squadre { get => _squadre; set => _squadre = value; }



        //Metodi di utilità  ---AGGIUNGERE EVENTUALMENTE EXCEPTIONS IN BASE AGLI ERRORI---
        public Boolean IsAdmin(String nomeSquadra)
        {
            if (nomeSquadra.Equals(_squadraAdmin.Nome))
                return true;

            return false;
        }


        public Boolean AggiungiSquadra(Squadra toAdd)
        {
            if (toAdd == null)
                return false;

            if (_squadre.Contains(toAdd))
                return false;

            _squadre.Add(toAdd);
            return true;
        }

        public Boolean RimuoviSquadra(Squadra toRemove)
        {
            if (toRemove == null)
                return false;

            if (_squadre.Contains(toRemove))
            {
                _squadre.Remove(toRemove);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean IsReady()
        {
            if (_squadre.Count == _numeroSquadreTotali)
                return true;

            return false;
        }

    }
}
