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
                PhoneNumbers =
                    new List<PhoneNumber>
                    {
                        new PhoneNumber {Id = 0, UserKey = 0, Number = "323-32-23"},
                        new PhoneNumber {Id = 1, UserKey = 0, Number = "323-32-23"}
                    }
            };
            var p2 = new User
            {
                FirstName = "Sample name 2",
                Email = "Sample Email2",
                LastName = "Last Name 2",
                Id = 1,
                PhoneNumbers =
                    new List<PhoneNumber>
                    {
                        new PhoneNumber {Id = 0, UserKey = 1, Number = "123-32-23"},
                        new PhoneNumber {Id = 1, UserKey = 1, Number = "123-32-23"}
                    }
            };

            db.Users.Add(p1);
            db.Users.Add(p2);
            db.SaveChanges();
        }
    }
}