using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class EmployeeDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=10.0.0.27;Database=SravanthiEmployeeDB_EFCore;Integrated Security=True;TrustServerCertificate=True");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }  
    }
}

