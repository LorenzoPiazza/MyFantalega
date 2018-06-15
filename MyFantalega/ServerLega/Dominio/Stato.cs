using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLega.Dominio
{
    public abstract class Stato
    {
        public abstract string Nome { get; }


        public static Stato DeterminaStato(Giocatore giocatore)
        {
            if (giocatore.PrezzoAcquisto > 0 && giocatore.NomeSquadra != null )
                return new Acquistato();
            else
                return new Libero();
        }

        private class Acquistato : Stato
        {
            public override string Nome
            {
                get { return "Acquistato"; }
            }
        }

        private class Libero : Stato
        {
            public override string Nome
            {
                get { return "Libero"; }
            }

        }

    }
}
