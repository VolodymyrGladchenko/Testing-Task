using System.Collections.Generic;
using System.Data.Entity;
using Contracts.Contracts;
using DAL.Context;

namespace DAL.DataBase
{
    public class DataBaseInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            var p1 = new User
            {
                FirstName = "Sample name 1",
                Email = "Sample Email1",
                LastName = "Last Name 1",
                Id = 0,
                Phone = new Phone {Id = 0, PhoneNumber = new List<string> {"323-32-23", "123-32-23"}}
            };
            var p2 = new User
            {
                FirstName = "Sample name 2",
                Email = "Sample Email2",
                LastName = "Last Name 2",
                Id = 1,
                Phone = new Phone {Id = 1, PhoneNumber = new List<string> {"923-32-23", "423-32-23"}}
            };

            db.Users.Add(p1);
            db.Users.Add(p2);
            db.SaveChanges();
        }
    }
}