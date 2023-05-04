using System.ComponentModel.DataAnnotations;

namespace Labb4_Advanced_API.Models
{
    public class Interests
    {
        [Key]
        public int ID { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<LinksIntrests> LinksPerson { get; set; }
    }
}
