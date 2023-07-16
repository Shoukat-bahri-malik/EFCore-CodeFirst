using EFCore_CodeFirst.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst.Data
{
    public class CodeFirstDbContext:DbContext
    {
        public CodeFirstDbContext(DbContextOptions<CodeFirstDbContext>options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Generate Composite PrimaryKey
            modelBuilder.Entity<EmployeeRole>().HasKey(x => new { x.EmployeeId, x.RoleId });

            //Relationship configuration
            modelBuilder.Entity<EmployeeRole>().HasOne(x => x.Employee).WithMany(y => y.EmployeeRole).HasForeignKey(k => k.EmployeeId);
            modelBuilder.Entity<EmployeeRole>().HasOne(x => x.Role).WithMany(y => y.EmployeeRole).HasForeignKey(k => k.RoleId);
        }
    }
}
