using Microsoft.EntityFrameworkCore;

namespace API;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public virtual DbSet<BlogPostModel>? Posts { get;}
}
