using INGServer.Models;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace INGServer
{
    [ServiceContract]
    public interface IINGService
    {

        [OperationContract]
        bool AddUser(User user);

        [OperationContract]
        bool LogIn(string username, string password);

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        int GetUserIdByUsername(string username);
    }
}
