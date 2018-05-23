using INGServer.Models;
using System.Collections.Generic;
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

        [OperationContract]
        bool AddPayment(Payment payment);

        [OperationContract]
        List<Account> GetAccounts(int id);

        [OperationContract]
        List<Payment> GetSentPayments(int id);

        [OperationContract]
        List<Payment> GetRecievedPayments(int id);

        [OperationContract]
        void CreateAccount(Account account);
    }

}
