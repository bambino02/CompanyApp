using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Surname { get; set; }
        [Column(TypeName = "varchar(200)")]
        public SexTypes? Sex { get; set; }
        public string StatusOfEducation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Hiringdate { get; set; }
        [Column(TypeName = "decimal(7, 2)")]
        public decimal Salary { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

        public int? ProjectId { get; set; }
        public Project Project { get; set; }

        public ICollection<Module> Modules { get; set; }
    }

    public enum SexTypes
    {
        Male,
        Female
    }
}
