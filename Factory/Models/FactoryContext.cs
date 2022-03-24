using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  //Change to Project name
  public class FactoryContext : DbContext
  {
    //Change to class the DB is dealing with
    
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<EngineerMachine> EngineerMachine { get; set; }

    //Change to Project name
    public FactoryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}