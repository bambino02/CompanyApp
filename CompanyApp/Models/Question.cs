using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public Answers Answer { get; set; }
        
        public int ModuleId { get; set; }
        public Module Module { get; set; }
        
    }

    public enum Answers
    {
        Yes,
        No
    }
}
