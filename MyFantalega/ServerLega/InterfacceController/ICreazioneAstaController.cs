using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerLega.Dominio;

namespace ServerLega.InterfacceController
{
    interface ICreazioneAstaController
    {
        Boolean ChiamaGiocatore(Giocatore giocatore, Asta asta);
        Boolean OffriCrediti(int offerta, Asta asta,Squadra squadra);
    }
}
