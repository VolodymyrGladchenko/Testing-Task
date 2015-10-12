using System.Data.Entity;
using DAL.Context;
using DAL.Model;

namespace DAL.DataBase
{
    public class DataBaseInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            var p1 = new User {Name = "Samsung Galaxy S5", Email = "", LastName = ""};
            var p2 = new User {Name = "Nokia Lumia 630", Email = "", LastName = ""};

            db.Users.Add(p1);
            db.Users.Add(p2);
            db.SaveChanges();
        }
    }
}