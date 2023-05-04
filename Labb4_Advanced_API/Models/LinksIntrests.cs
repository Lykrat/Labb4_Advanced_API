using System.ComponentModel.DataAnnotations;

namespace Labb4_Advanced_API.Models
{
    public class LinksIntrests
    {
        [Key]
        public int ID { get; set; }
        public string Link { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int InterestsId { get; set; }
        public Interests Interests { get; set; }
    }
}
