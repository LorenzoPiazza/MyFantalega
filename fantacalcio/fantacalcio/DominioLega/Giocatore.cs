using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fantacalcio.DominioLega
{
    public class Giocatore
    {
        private String _nome;
        private int _quotazioneIniziale;
        private String _ruolo;
        private String _club;
        private Stato _stato;
        //field che seguono sono indispensabili per determinare lo stato
        private String _nomeSquadra;    //squadra che ha acquistato il giocatore
        private int _prezzoAcquisto;


        public Giocatore(String nome, int quotazioneI, String ruolo, String club)
        {
            if (nome == null || nome.Length == 0)
            {
                throw new ArgumentException("nome nullo");
            }
            if (quotazioneI <= 0)
            {
                throw new ArgumentException("quotazioneIniziale <= 0");
            }
            if (ruolo == null || ruolo.Length == 0)
            {
                throw new ArgumentException("ruolo nullo");
            }

            _nome = nome;
            _quotazioneIniziale = quotazioneI;
            _ruolo = ruolo;
            _club = club;

            //valori di default assegnati a giocatore con stato Libero
            //Si assume che un giocatore alla creazione sia libero
            _nomeSquadra = null;
            _prezzoAcquisto = 0;
            StateChanged();
        }

        public String Nome { get => _nome; }
        public int QuotazioneIniziale { get => _quotazioneIniziale; }
        public String Ruolo { get => _ruolo; }
        public int Club { get => _numeroPor; }
        public int NumeroDif { get => _numeroDif; set => _numeroDif = value; }

        public string NomeSquadra
        {
            get
            {
                return _stato.NomeSquadra;
            }
            set
            {
                if (value == null || value.Length == 0)
                    throw new ArgumentException("nome Squadra Acquirente nullo");
                if (value != _nomeSquadra)
                {
                    _nomeSquadra = value;
                    StateChanged();
                }
            }
        }

        public int PrezzoAcquisto
        {
            get
            {
                return _stato.PrezzoAcquisto;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("prezzo di Acquisto <= 0");
                if (value!= _prezzoAcquisto)
                {
                    _prezzoAcquisto = value;
                    StateChanged();
                }
            }
        }

        private void StateChanged()
        {
            _stato = Stato.DeterminaStato(this);
        }

    }
}

