using ServerLega.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLega.InterfacceController
{
    interface IGestioneUtenteController
    {
        Lega CreaLega(String nome, int numeroPartecipanti, Utente utente);
        Boolean cambiaPassword(String vecchiaPass, String nuovaPass, String domanda, String risposta, Utente utente);
        List<Lega> getLeghe(Utente utente);
        Boolean uniscitiAMercato(Mercato mercato, Squadra squadra);
    }
}
