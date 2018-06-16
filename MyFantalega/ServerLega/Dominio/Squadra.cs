using System;
using System.Collections.Generic;
using System.Text;
using ServerLega.Dominio;


namespace ServerLega.Dominio
{
    public class Squadra
    {
        private String _nome;
        private int _creditResidui;
        private int _numeroPor;
        private int _numeroDif;
        private int _numeroCen;
        private int _numeroAtt;
        private List<Giocatore> _giocatori;
        private Lega _lega;
        private Utente _utente;

        public Squadra(string nome, Lega lega, Utente utente)
        {
            //valori di default
            _creditResidui = lega.CreditiInizialiSquadra;
            _numeroPor = 0;
            _numeroDif = 0;
            _numeroCen = 0;
            _numeroAtt = 0;

            _giocatori = new List<Giocatore>();

            _nome = nome;
            _lega = lega;
            _utente = utente;
        }

        public string Nome { get => _nome; }
        public int CreditResidui { get => _creditResidui; set => _creditResidui = value; }
        public int NumeroPor { get => _numeroPor; set => _numeroPor = value; }
        public int NumeroDif { get => _numeroDif; set => _numeroDif = value; }
        public int NumeroCen { get => _numeroCen; set => _numeroCen = value; }
        public int NumeroAtt { get => _numeroAtt; set => _numeroAtt = value; }
        public List<Giocatore> Giocatori { get => _giocatori; }
        public Lega Lega { get => _lega; }
        public Utente Utente { get => _utente; }


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

        public Boolean VerificaReparto(String reparto)
        {
            switch (reparto)
            {
                case "POR":
                    if (_numeroPor == _lega.NumeroPor)
                        return true;
                    break;
                case "DIF":
                    if (_numeroDif == _lega.NumeroDif)
                        return true;
                    break;
                case "CEN":
                    if (_numeroCen == _lega.NumeroCen)
                        return true;
                    break;
                case "ATT":
                    if (_numeroAtt == _lega.NumeroAtt)
                        return true;
                    break;
            }

            return false;
        }

        public Boolean VerificaCompletezza()
        {
            if (_numeroPor == _lega.NumeroPor && _numeroDif == _lega.NumeroDif && _numeroCen == _lega.NumeroCen && _numeroAtt == _lega.NumeroAtt)
                return true;

            return false;
        }
    }
}

