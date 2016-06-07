using System.ComponentModel.DataAnnotations;

namespace Rrhh.Models
{
    public class Job : BaseModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        public Department Department { get; set; } = new Department();
    }
}
