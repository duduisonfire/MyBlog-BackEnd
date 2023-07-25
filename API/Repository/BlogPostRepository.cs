using API.Context;
using API.Repository.Classes;

namespace API.Repository;

public class BlogPostRepository : IBlogPostRepository
{
    private readonly AppDbContext _dbContext;

    public BlogPostRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<DbMessenger> NewPost(BlogPostModel post)
    {
        var dbMessenger = new DbMessenger();

        try
        {
            await _dbContext.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return dbMessenger;
        }
        catch (Exception e)
        {
            dbMessenger.IsRequestSuccessful = false;
            dbMessenger.ErrorMessage = e.InnerException!.Message;

            Console.WriteLine(e.InnerException!.Message);
            return dbMessenger;
        }
    }
}
