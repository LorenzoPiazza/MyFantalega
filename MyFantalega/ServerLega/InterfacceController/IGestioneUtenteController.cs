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
        Lega CreaLega(String nome, int numeroPartecipanti, String nomeSquadra, Utente utente);
        Boolean CambiaPassword(String vecchiaPass, String nuovaPass, String domanda, String risposta, Utente utente);
        List<Lega> GetLeghe(Utente utente);
        Boolean UniscitiAMercato(Mercato mercato, Squadra squadra);
    }
}
