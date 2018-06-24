using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerLega.Dominio;

namespace ServerLega.InterfacceController
{
    interface IPartecipaAstaController
    {
        Boolean AbbandonaGiocatore(Asta asta,Squadra squadra);
        Boolean RialzaOfferta(Asta asta, Squadra squadra);
        Boolean OffriCrediti(int offerta, Asta asta, Squadra squadra);
    }
}
