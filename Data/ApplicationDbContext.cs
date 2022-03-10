using Microsoft.EntityFrameworkCore;

namespace ge_app.Models
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    { }

    public DbSet<Employee> Employees { get; set; }
  }
}