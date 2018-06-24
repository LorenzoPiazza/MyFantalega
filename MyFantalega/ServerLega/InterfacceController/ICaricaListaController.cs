using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ServerLega.Dominio;

namespace ServerLega.InterfacceController
{
    [ServiceContract]
    [ServiceKnownType(typeof(Lega))]
    public interface ICaricaListaController
    {
        [OperationContract]
        Boolean CaricaLista(String source, Lega lega);
    }
}
