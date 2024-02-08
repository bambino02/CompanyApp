using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
