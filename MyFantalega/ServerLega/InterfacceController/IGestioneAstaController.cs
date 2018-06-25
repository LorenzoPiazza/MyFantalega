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
        Turno AssegnaTurnoAsta(Turno turno, String ruolo);
        Turno AssegnaTurnoChiamata(Turno turno,String ruolo);
        Turno GestisciAsta(Lega lega,Squadra squadra);
        Boolean Offri(int offerta,Squadra squadra);
        Boolean Rialza(Squadra squadra);
        Boolean Abbandona(Squadra squadra);
        Asta CreaAsta(Giocatore giocatore, int offerta,Squadra squadra);
        
    }
}
