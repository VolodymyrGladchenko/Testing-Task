using System.Data.Entity;
using DAL.Model;
// ReSharper disable MissingXmlDoc

namespace DAL.Context
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")
        {
        }

        public DbSet<User> Players { get; set; }
    }
}