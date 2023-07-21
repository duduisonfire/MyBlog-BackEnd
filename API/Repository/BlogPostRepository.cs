namespace API;

public class BlogPostRepository : IBlogPostRepository
{
    private readonly AppDbContext _dbContext;

    public BlogPostRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> NewPost(BlogPostModel post)
    {
        try
        {
            await _dbContext.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return true;
        } catch (Exception)
        {
            return false;
        }
    }
}
