using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime HeldDate { get; set; }
    }
}
