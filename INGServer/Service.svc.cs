using INGServer.Models;
using System;
using System.Data.Entity.Validation;
using System.Linq;

namespace INGServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IINGService
    {

        private static INGDBEntities _database = new INGDBEntities();

        bool IINGService.AddUser(User user)
        {
            var query = _database.Users.FirstOrDefault(u => u.username == user.username);

            if (query != null) return false;
            user.password = user.password.GetHashCode().ToString();
            _database.Users.Add(user);
            _database.SaveChangesAsync();
            return true;
        }

        bool IINGService.LogIn(string username, string password)
        {
            var query = _database.Users.FirstOrDefault(u => u.username == username);
            if (query == null) return false;
            if (query.password != password.GetHashCode().ToString())
                return false;
            return true;
        }
    }
}

