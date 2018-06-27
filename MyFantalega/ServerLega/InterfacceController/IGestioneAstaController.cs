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
        Turno GestisciAsta(Lega lega,Squadra squadra);
        Asta Offri(int offerta,Squadra squadra);
        Asta Rialza(Squadra squadra);
        Asta Abbandona(Squadra squadra);
        Asta CreaAsta(Giocatore giocatore, int offerta,Squadra squadra);
        
    }
}
