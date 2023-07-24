using Microsoft.EntityFrameworkCore;

namespace API.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public virtual DbSet<BlogPostModel>? Posts { get; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<BlogPostModel>().HasIndex(b => b.PostTitle).IsUnique();
    }
}
