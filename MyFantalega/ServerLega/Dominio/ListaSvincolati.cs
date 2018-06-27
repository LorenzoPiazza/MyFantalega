using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLega.Dominio
{
    public class ListaSvincolati
    {
        private DateTime _dataCaricamento;
        private int idLista;
        private List<Giocatore> _giocatori;

        public ListaSvincolati(DateTime _dataCaricamento, int idLista, List<Giocatore> _giocatori)
        {
            this._dataCaricamento = _dataCaricamento;
            this.idLista = idLista;
            this._giocatori = new List<Giocatore>();
            this._giocatori = _giocatori;
        }

        public ListaSvincolati()
        {
            this._giocatori = new List<Giocatore>();
        }

        public DateTime DataCaricamento
        {
            get
            {
                return _dataCaricamento;
            }

            set
            {
                _dataCaricamento = value;
            }
        }

        public int IdLista
        {
            get
            {
                return idLista;
            }

            set
            {
                idLista = value;
            }
        }

        public List<Giocatore> Giocatori
        {
            get
            {
                return _giocatori;
            }

            set
            {
                _giocatori = value;
            }
        }

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
            int count=0;
            if (toRemove == null)
                return false;
            for(int i=0;i<this.Giocatori.Count;i++)
            {
                if (this.Giocatori[i].Nome.Equals(toRemove.Nome))
                {
                    count = i;
                }
            }
            _giocatori.RemoveAt(count);
            return true;

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
    }
}
