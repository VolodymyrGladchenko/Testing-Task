using System.ComponentModel.DataAnnotations.Schema;

// ReSharper disable MissingXmlDoc

namespace DAL.Model
{
    public class Phone
    {
        [ForeignKey("User")]
        public int NumberId { get; set; }

        public int Id { get; set; }

        public string PhoneNumber { get; set; }
    }
}