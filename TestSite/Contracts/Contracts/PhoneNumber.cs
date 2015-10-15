using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Contracts.Contracts
{
    [DataContract]
    public class PhoneNumber
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [ForeignKey("User")]
        [DataMember]
        public int UserKey { get; set; }

        [DataMember]
        public string Number { get; set; }

        public virtual User User { get; set; }
    }
}