using System.Collections.Generic;

// ReSharper disable MissingXmlDoc

namespace DAL.DataBase
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public ICollection<Phone> Phones { get; set; }
    }
}