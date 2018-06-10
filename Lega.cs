﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Dominio.DominioLega
{
    public class Lega
    {
        private String _nomeLega;
        private String _squadraAdmin;
        private int _numeroSquadreTotali;
        private int _creditiPerSquadra;
        private int _numeroPor;
        private int _numeroDif;
        private int _numeroCen;
        private int _numeroAtt;
        private Mercato _mercatoAttivo;
        private List<Squadra> _squadre;
        private ListaSvincolati _listaSvincolati;
        //private Log log;

        public Lega(string nomeLega, int numeroSquadreTotali, Squadra squadra)
        {
            //Parameri di default modificabili tramite set
            _creditiPerSquadra = 500;
            _numeroPor = 3;
            _numeroDif = 8;
            _numeroCen = 8;
            _numeroAtt = 6;
            _squadre = new List<Squadra>();
            _squadre.Add(squadra);

            _nomeLega = nomeLega;
            _squadraAdmin = squadra.Nome;
            NumeroSquadreTotali = numeroSquadreTotali;
            MercatoAttivo = null;
            ListaSvincolati = null;

        }

        public string NomeLega { get => _nomeLega; }
        public string SquadraAdmin { get => _squadraAdmin; }
        public int NumeroSquadreTotali { get => NumeroSquadreTotali; set => NumeroSquadreTotali = value; }
        public int CreditiPerSquadra { get => _creditiPerSquadra; set => _creditiPerSquadra = value; }   
        public int NumeroPor { get => _numeroPor; set => _numeroPor = value; }
        public int NumeroDif { get => _numeroDif; set => _numeroDif = value; }
        public int NumeroCen { get => _numeroCen; set => _numeroCen = value; }
        public int NumeroAtt { get => _numeroAtt; set => _numeroAtt = value; }
        public Mercato MercatoAttivo { get => _mercatoAttivo; set => _mercatoAttivo = value; }
        public ListaSvincolati ListaSvincolati { get => _listaSvincolati; set => _listaSvincolati = value; }
        public List<Squadra> squadre { get => _squadre; }

        public Boolean IsAdmin (String nomeSquadra)
        {
            if (nomeSquadra.Equals(_squadraAdmin))
                return true;

            return false;
        }
        //AGGIUNGERE EVENTUALMENTE EXCEPTIONS IN BASE AGLI ERRORI
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
