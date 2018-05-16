using INGServer.Models;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace INGServer
{
    [ServiceContract]
    public interface IINGService
    {

        [OperationContract]
        void AddUser(User user);

    }
}
