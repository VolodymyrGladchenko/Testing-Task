// ReSharper disable MissingXmlDoc

using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Contracts.Contracts;
using DAL.Context;

namespace DAL.DA
{
    public class DataAccess
    {
        public List<User> GetUsers(int? take, int? skip)
        {
            List<User> result = new List<User>();

            using (var db = new UserContext())
            {
                var users = db.Users.Include("PhoneNumbers").ToList();
                result = users;
            }
            return result;
        }


        public void SaveOrUpdateUser(User user)
        {
            using (var db = new UserContext())
            {
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
            }
            
        }
    }
}