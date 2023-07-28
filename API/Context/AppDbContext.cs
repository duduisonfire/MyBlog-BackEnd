using Microsoft.EntityFrameworkCore;

namespace API.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public virtual DbSet<Posts>? Posts { get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Posts>().HasIndex(b => b.PostTitle).IsUnique();
    }
}
