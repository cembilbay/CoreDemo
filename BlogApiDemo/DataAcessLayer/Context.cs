using Microsoft.EntityFrameworkCore;

namespace BlogApiDemo.DataAcessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-IM93EIQA\\SQLEXPRESS;database=CoreBlogApiDb;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
