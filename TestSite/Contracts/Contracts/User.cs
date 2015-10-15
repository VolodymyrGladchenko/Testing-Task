using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// ReSharper disable MissingXmlDoc

namespace Contracts.Contracts
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}