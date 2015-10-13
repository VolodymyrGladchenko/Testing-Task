using System.Data.Entity;
using DAL.DataBase;
using User = DAL.DataBase.User;

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
    }
}