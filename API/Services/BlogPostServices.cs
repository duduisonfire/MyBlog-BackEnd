namespace API.Services;

public class BlogPostServices : IBlogPostServices
{
    private readonly IBlogPostRepository _blogPostRepository;

    public BlogPostServices(IBlogPostRepository blogPostRepository)
    {
        _blogPostRepository = blogPostRepository;
    }

    public async Task Create(BlogPostModel post)
    {
        try
        {
            post.CreatedAt = DateTime.Now;
            post.UpdatedAt = DateTime.Now;

            await _blogPostRepository.NewPost(post);
        }
        catch (Exception e)
        {
            if (e.Message.Contains("IX_Posts_PostTitle"))
                throw new Exception("A post with this title already exists.");

            throw;
        }
    }
}
