using INGServer.Models;
using System.Collections.Generic;
using System.Linq;

namespace INGServer
{
    public class Service : IINGService
    {
        
        int IINGService.GetUserIdByUsername(string username)
        {
            using (var database = new INGDBEntities())
            {

                var query = database.Users.FirstOrDefault(u => u.username == username);
                if (query != null)
                    return query.id_user;
                return -1;
            }
        }

        bool IINGService.AddPayment(Payment payment)
        {
            using (var database = new INGDBEntities())
            {
                var sender = database.Accounts.Find(payment.id_sender);
                var reciever = database.Accounts.Find(payment.id_reciever);
                if (sender == null || reciever == null || sender.balance < payment.amount)
                    return false;
                database.Payments.Add(payment);
                sender.balance -= payment.amount;
                reciever.balance += payment.amount;
                database.SaveChanges();
                return true;
            }
        }

        bool IINGService.AddUser(User user)
        {
            using (var database = new INGDBEntities())
            {
                var query = database.Users.FirstOrDefault(u => u.username == user.username);

                if (query != null) return false;
                user.password = user.password.GetHashCode().ToString();
                database.Users.Add(user);
                database.SaveChangesAsync();
                return true;
            }
        }

        User IINGService.GetUser(int id)
        {
            using (var database = new INGDBEntities())
            {
                User user = new User();
                user = database.Users.Where(u => u.id_user == id).Single();
                return user;
            }
        }

        bool IINGService.LogIn(string username, string password)
        {
            using (var database = new INGDBEntities())
            {
                var query = database.Users.FirstOrDefault(u => u.username == username);
                if (query == null) return false;
                if (query.password != password.GetHashCode().ToString())
                    return false;
                return true;
            }
        }

        void IINGService.CreateAccount(Account account)
        {
            using (var database = new INGDBEntities())
            {
                database.Accounts.Add(account);
                database.SaveChanges();
            }
        }

        List<Account> IINGService.GetAccounts(int id)
        {
            using (var database = new INGDBEntities())
            {
                return database.Accounts.Where(a => a.id_user == id).ToList();
            }
        }

        List<Payment> IINGService.GetSentPayments(int id)
        {
            using (var database = new INGDBEntities())
            {
                return database.Payments.Where(a => a.id_sender == id).ToList();
            }
        }

        List<Payment> IINGService.GetRecievedPayments(int id)
        {
            using (var database = new INGDBEntities())
            {
                return database.Payments.Where(a => a.id_reciever == id).ToList();
            }
        }
    }
}

