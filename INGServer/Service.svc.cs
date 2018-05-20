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



        public int GetUserIdByUsername(string username)
        {
            using (var database = new INGDBEntities())
            {

                var query = database.Users.FirstOrDefault(u => u.username == username);
            if (query != null)
                return query.id_user;
            return -1;
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
                user = database.Users.Find(id);
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
    }
}

