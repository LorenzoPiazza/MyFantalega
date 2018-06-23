using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLega.Dominio
{
    public class Mercato
    {
        private int _idMercato;
        private Lega _lega;
        private List<Asta> _aste;
        private List<Squadra> _squadre;

        public Mercato(int _idMercato, Lega _lega)
        {
            _aste = new List<Asta>();
            _squadre = new List<Squadra>();
            this._idMercato = _idMercato;
            this._lega = _lega;
        }

        public Mercato()
        {
        }

        public int IdMercato
        {
            get
            {
                return _idMercato;
            }
        }

        public Lega Lega
        {
            get
            {
                return _lega;
            }
            set
            {
                _lega = value;
            }
        }

        public List<Asta> Aste
        {
            get
            {
                return _aste;
            }

            set
            {
                _aste = value;
            }
        }

        public List<Squadra> Squadre { get => _squadre; set => _squadre = value; }

        public void addSquadra(Squadra squadra)
        {
            if (squadra != null)
            {
                _squadre.Add(squadra);
            }
        }

        public void AttivaMercato()
        {
            _lega.MercatoAttivo = this;
        }

        public void ChiudiMercato()
        {
            _aste = new List<Asta>();
            _lega.MercatoAttivo = null;
        }
    }
}
