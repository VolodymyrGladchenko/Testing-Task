using System.Collections.Generic;
// ReSharper disable MissingXmlDoc

namespace DAL.Model
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<string> Phones { get; set; }
    }
}