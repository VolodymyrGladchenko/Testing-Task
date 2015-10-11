using System.Collections.Generic;

namespace DAL.Model
{
    /// <summary>
    /// Code first user model
    /// </summary>
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<string> phone { get; set; }
    }
}