using System;
using System.Collections.Generic;
using System.Text;
using ServerLega.Dominio;

namespace ServerLega.Dominio
{
    public class Asta
    {
        private int _idAsta;
        private int _ultimaOfferta;
        private Squadra _ultimoOfferente;
        private List<Squadra> _squadre;
        private Giocatore _giocatore;

        public Asta(int idAsta, int ultimaOfferta, Squadra ultimoOfferente, List<Squadra> squadre, Giocatore giocatore)
        {
            _idAsta = idAsta;
            this.UltimaOfferta = ultimaOfferta;
            this.UltimoOfferente = ultimoOfferente;
            this.Squadre = squadre;
            this.Giocatore = giocatore;

            _squadre = new List<Squadra>();
        }

        public Asta()
        {
        }

        public int IdAsta { get => _idAsta; }
        public int UltimaOfferta { get => _ultimaOfferta; set => _ultimaOfferta = value; }
        public Squadra UltimoOfferente { get => _ultimoOfferente; set => _ultimoOfferente = value; }
        public List<Squadra> Squadre { get => _squadre; set => _squadre = value; }
        public Giocatore Giocatore { get => _giocatore; set => _giocatore = value; }

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

        public Boolean isFinita()
        {
            if (_squadre.Count.Equals(1))
                return true;
            return false;
        }
    }
}