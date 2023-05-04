using System.ComponentModel.DataAnnotations;

namespace Labb4_Advanced_API.Models
{
    public class Person
    {
        [Key]
        public int ID{ get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<LinksIntrests> LinksIntrests { get; set; }

    }
}
