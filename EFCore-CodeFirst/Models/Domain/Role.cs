namespace EFCore_CodeFirst.Models.Domain
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<EmployeeRole> EmployeeRole { get; set; }
    }
}
