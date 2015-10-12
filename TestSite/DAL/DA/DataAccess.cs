// ReSharper disable MissingXmlDoc

using System.Linq;
using DAL.Context;
using DAL.Model;

namespace DAL.DA
{
    public class DataAccess
    {
        public void GetUsers(int? take, int? skip)
        {
            using (var db = new UserContext())
            {
                var phones = db.Users.AsNoTracking().Select(p => new User
                {
                    Name = p.Name,
                    LastName = p.LastName,
                    Email = p.Email,
                    Phones = p.Phones
                });
            }
        }

        public void GetUser(string name)
        {
            using (var db = new UserContext())
            {
                var phones = db.Users.AsNoTracking().Select(p => new User
                {
                    Name = p.Name,
                    LastName = p.LastName,
                    Email = p.Email,
                    Phones = p.Phones
                });
            }
        }

        public void SaveUser(User user)
        {
            using (var db = new UserContext())
            {
                var phones = db.Users.Select(p => new User
                {
                    Name = p.Name,
                    LastName = p.LastName,
                    Email = p.Email,
                    Phones = p.Phones
                });
            }
        }
    }
}