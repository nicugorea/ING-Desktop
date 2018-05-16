using INGServer.Models;
using System;
using System.Data.Entity.Validation;

namespace INGServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IINGService
    {

        private static INGDBEntities _database = new INGDBEntities();

        void IINGService.AddUser(User user)
        {
            user.password= user.password.GetHashCode().ToString();
            _database.Users.Add(user);
            _database.SaveChanges();
        }
    }
}

