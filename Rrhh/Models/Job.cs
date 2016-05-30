namespace Rrhh.Models
{
    public class Job : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Department Department { get; set; }
    }
}
