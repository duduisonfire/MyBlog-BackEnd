namespace API;

public class BlogPostServices : IBlogPostServices
{
    private readonly IBlogPostRepository _BlogPostRepository;

    public BlogPostServices(IBlogPostRepository BlogPostRepository)
    {
        _BlogPostRepository = BlogPostRepository;
    }

    public async Task<bool> Create(BlogPostModel post)
    {
        post.CreatedAt = DateTime.Now;
        post.UpdatedAt = DateTime.Now;

        return await _BlogPostRepository.NewPost(post);
    }
}
