using Microsoft.EntityFrameworkCore;
using MVC_Task1.Models;

namespace MVC_Task1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Mvctask_1;trusted_connection=True;trustServerCertificate=true");
        }
    }
}
