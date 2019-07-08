using Microsoft.EntityFrameworkCore;

namespace WidgetsApp.Models
{

  public class WidgetsContext: DbContext
  {
    public WidgetsContext(DbContextOptions<WidgetsContext> options)
      : base(options) { }

    public DbSet<Widget> Widgets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Widget>().HasData(new Widget {
        Id = 1, Name = "Red Widget", Color = "red", Quantity = 23,
      });
      modelBuilder.Entity<Widget>().HasData(new Widget {
        Id = 2, Name = "Blue Widget", Color = "blue", Quantity = 31,
      });
      modelBuilder.Entity<Widget>().HasData(new Widget {
        Id = 3, Name = "Yellow Widget", Color = "yellow", Quantity = 5,
      });
    }
  }
}