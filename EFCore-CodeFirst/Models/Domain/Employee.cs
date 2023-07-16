namespace EFCore_CodeFirst.Models.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ICollection<EmployeeRole> EmployeeRole { get; set; }
    }
}
