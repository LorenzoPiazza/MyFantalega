using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Dominio
{
    public class Mercato
    {
        private int _idMercato;
        private Lega _lega;
        private List<Asta> _aste;

        public Mercato(int _idMercato, Lega _lega)
        {
            _aste = new List<Asta>();
            this._idMercato = _idMercato;
            this._lega = _lega;
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
