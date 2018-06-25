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
        Asta ChiamaGiocatore(Giocatore giocatore, Asta asta);
        Asta OffriCrediti(int offerta, Asta asta,Squadra squadra);
    }
}
