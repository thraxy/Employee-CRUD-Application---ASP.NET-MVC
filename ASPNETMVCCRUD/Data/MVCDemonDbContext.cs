using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Data
{
    /// MVCDEMO inherits from a base class file from DbContext from the EntityFrameworkCore
    public class MVCDemonDbContext : DbContext
    {
        // constructor for MVCDEMO 
        public MVCDemonDbContext(DbContextOptions options) : base(options)
        {

        }

        // Db of Employee
        public DbSet<Employee> Employees { get; set; }

    }
}
