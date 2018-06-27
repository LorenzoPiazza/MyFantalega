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
        Lega Offri(int offerta,Squadra squadra);
        Lega Rialza(Squadra squadra);
        Lega Abbandona(Squadra squadra);
        Lega CreaAsta(Giocatore giocatore, int offerta,Squadra squadra, Lega lega);
        
    }
}
