namespace ASPNETMVCCRUD.Models.Domain
{
    public class Employee
    {
        // Guid is a unique identifier
        // properties for employee domain model
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Department { get; set; }
       

    }
}
