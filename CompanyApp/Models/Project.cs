using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string GeneralInfo { get; set; }
        [Required]
        public string Customer { get; set; }

        public ICollection<ApplicationUser> Users { get; set; }
    }
}
