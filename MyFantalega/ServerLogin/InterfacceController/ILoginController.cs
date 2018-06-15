using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLogin.InterfacceController
{
    interface ILoginController
    {
        String VerificaCredenziali(String username, String password);
    }
}
