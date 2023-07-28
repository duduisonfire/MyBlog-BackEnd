using API.Context;
using Microsoft.EntityFrameworkCore;

namespace API.Repository;

public class BlogPostRepository : IBlogPostRepository
{
    private readonly AppDbContext _dbContext;

    public BlogPostRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Posts>> GetPosts(int numberOfPostToSkip)
    {
        try
        {
            var posts = await _dbContext.Posts!
            .OrderBy(posts => posts.Id)
            .Skip(numberOfPostToSkip)
            .Take(4)
            .ToListAsync();

            return posts;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw new Exception(e.Message);
        }
    }

    public async Task NewPost(Posts post)
    {
        try
        {
            await _dbContext.Posts!.AddAsync(post);
            await _dbContext.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.InnerException!.Message);
            throw new Exception(e.InnerException!.Message);
        }
    }
}
