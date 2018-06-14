using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServerLogin.InterfacceController
{
    interface IRegistrazioneController
    {
       String RegistraUtente(String username, String password, String email, String domanda, String risposta);
    }
}
