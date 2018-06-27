using System;
using System.Collections.Generic;
using System.Text;
using ServerLega.Dominio;
using System.Net;
using System.Web.Services;

namespace ServerLega.Dominio
{
    public class Squadra
    {
        private String _nome;
        private int _creditiResidui;
        private int _numeroPor;
        private int _numeroDif;
        private int _numeroCen;
        private int _numeroAtt;
        private List<Giocatore> _giocatori;
        //private Lega _lega;
        private Utente _utente;

        public Squadra(string nome, Lega lega, Utente utente)
        {
            //valori di default
            _creditiResidui = lega.CreditiInizialiSquadra;
            _numeroPor = 0;
            _numeroDif = 0;
            _numeroCen = 0;
            _numeroAtt = 0;

            _giocatori = new List<Giocatore>();
            _nome = nome;
            //_lega = lega;
            _utente = utente;
        }

        public Squadra()
        {
            //valori di default
            _creditiResidui = 500;
            _numeroPor = 0;
            _numeroDif = 0;
            _numeroCen = 0;
            _numeroAtt = 0;

            //Ai fini dell'esposizione del progetto
            //_lega = new Lega();



            _giocatori = new List<Giocatore>();
        }
        public string Nome { get => _nome; set => _nome = value; }
        public int CreditiResidui { get => _creditiResidui; set => _creditiResidui = value; }
        public int NumeroPor { get => _numeroPor; set => _numeroPor = value; }
        public int NumeroDif { get => _numeroDif; set => _numeroDif = value; }
        public int NumeroCen { get => _numeroCen; set => _numeroCen = value; }
        public int NumeroAtt { get => _numeroAtt; set => _numeroAtt = value; }
        public List<Giocatore> Giocatori { get => _giocatori; }
        //public Lega Lega { get => _lega; set => _lega = value; }
        public Utente Utente { get => _utente; set => _utente = value; }


        //AGGIUNGERE EVENTUALMENTE EXCEPTIONS IN BASE AGLI ERRORI
        public Boolean AggiungiGiocatore(Giocatore toAdd)
        {
            if (toAdd == null)
                return false;

            if (_giocatori.Contains(toAdd))
                return false;

            _giocatori.Add(toAdd);

            return true;
        }

        public Boolean RimuoviGiocatore(Giocatore toRemove)
        {
            if (toRemove == null)
                return false;

            if (_giocatori.Contains(toRemove))
            {
                _giocatori.Remove(toRemove);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Giocatore RicercaGiocatore(String nome)
        {
            foreach (Giocatore g in _giocatori.ToArray())
            {
                if (g.Nome.Equals(nome))
                    return g;
            }

            return null;
        }

        public Boolean VerificaReparto(String reparto,Lega lega)
        {
            switch (reparto)
            {
                case "POR":
                    if (_numeroPor == lega.NumeroPor)
                        return true;
                    break;
                case "DIF":
                    if (_numeroDif == lega.NumeroDif)
                        return true;
                    break;
                case "CEN":
                    if (_numeroCen == lega.NumeroCen)
                        return true;
                    break;
                case "ATT":
                    if (_numeroAtt == lega.NumeroAtt)
                        return true;
                    break;
            }

            return false;
        }

        public Boolean VerificaCompletezza(Lega lega)
        {
            if (_numeroPor == lega.NumeroPor && _numeroDif == lega.NumeroDif && _numeroCen == lega.NumeroCen && _numeroAtt == lega.NumeroAtt)
                return true;

            return false;
        }
    }
}

