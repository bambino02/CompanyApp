using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Module
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Desctription { get; set; }
        [Required]
        public string Type { get; set; }

        public ICollection<Question> Questions { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
