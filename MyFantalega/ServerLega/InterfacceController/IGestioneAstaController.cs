using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerLega.Dominio;

namespace ServerLega.InterfacceController
{
    interface IGestioneAstaController
    {
        Boolean AssegnaGiocatore(Giocatore giocatore,Squadra squadra);
        Boolean AssegnaTurnoAsta(Turno turno, Asta asta);
        Boolean AssegnaTurnoChiamata(Turno turno, Asta asta);
        void GestisciAsta(Lega lega);
        Boolean Offri(int offerta);
        Boolean Rialza();
        Boolean Abbandona();
        Asta CreaAsta(Giocatore giocatore, int offerta);

    }
}
