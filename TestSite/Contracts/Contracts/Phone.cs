using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// ReSharper disable MissingXmlDoc

namespace Contracts.Contracts
{
    public class Phone
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }

        public List<string> PhoneNumber { get; set; }

        public virtual User User { get; set; }
    }
}