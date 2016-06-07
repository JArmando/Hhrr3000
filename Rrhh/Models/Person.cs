namespace Rrhh.Models
{
    public abstract class Person : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GovernmentIssuedId { get; set; }
    }
}
