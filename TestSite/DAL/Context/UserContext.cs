using System.Data.Entity;
using Contracts.Contracts;
using DAL.DataBase;


// ReSharper disable MissingXmlDoc

namespace DAL.Context
{
    public class UserContext : DbContext
    {
        static UserContext ()
        {
            Database.SetInitializer<UserContext>(new DataBaseInitializer());
        }

        public UserContext() : base("LocalDb")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}