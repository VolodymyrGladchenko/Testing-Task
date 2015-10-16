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
            List<User> initialUsers = new List<User>();

            for (int i = 0; i < 55; i++)
            {
                var user = new User
                {
                    FirstName = "Sample name - "+i,
                    Email = "Sample Email - "+i,
                    LastName = "Last Name - "+i,
                    Id = i+1,
                    PhoneNumbers =
                        new List<PhoneNumber>
                        {
                            new PhoneNumber {Id = i, UserKey = i+1, Number = "123-32-23"},
                            new PhoneNumber {Id = i+1, UserKey = i+1, Number = "123-32-23"}
                        }
                };
                initialUsers.Add(user);
            }

            db.Users.AddRange(initialUsers);
            db.SaveChanges();
        }
    }
}