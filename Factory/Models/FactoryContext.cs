using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  //Change to Project name
  public class FactoryContext : DbContext
  {
    //Change to class the DB is dealing with
    
    // public DbSet<Item> Item { get; set; }
    // public DbSet<Category> Category { get; set; }
    // public DbSet<CategoryItem> CategoryItem { get; set; }

    //Change to Project name
    public FactoryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}