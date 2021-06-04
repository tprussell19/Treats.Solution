using Microsoft.EntityFrameworkCore;

namespace SweetAndSavory.Models
{
  public class SweetAndSavoryContext : DbContext
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }

    public SweetAndSavoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}