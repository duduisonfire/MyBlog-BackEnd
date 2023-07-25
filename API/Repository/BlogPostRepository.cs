using API.Context;
using API.Repository;

namespace API.Repository;

public class BlogPostRepository : IBlogPostRepository
{
    private readonly AppDbContext _dbContext;

    public BlogPostRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task NewPost(BlogPostModel post)
    {
        try
        {
            await _dbContext.AddAsync(post);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException!.Message);
            throw new Exception(e.InnerException!.Message);
        }
    }
}
