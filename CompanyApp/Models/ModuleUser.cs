using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyApp.Models
{
    public class ModuleUser
    {
        public int ModulesId { get; set; }
        public string UsersId { get; set; }
        public bool Completed { get; set; }

    }
}
