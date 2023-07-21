namespace API;

public class BlogPostServices
{
    private readonly AppDbContext _dbContext;

    public BlogPostServices(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> Create(BlogPostModel post)
    {
        post.CreatedAt = DateTime.Now;
        post.UpdatedAt = DateTime.Now;

        try
        {
            await _dbContext.Posts!.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
