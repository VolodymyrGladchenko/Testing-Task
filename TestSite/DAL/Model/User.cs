using System.Collections.Generic;

namespace DAL.Model
{
    public class User
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<string> phone { get; set; }
    }
}