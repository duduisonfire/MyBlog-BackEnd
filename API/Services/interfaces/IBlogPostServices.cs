namespace API;

public interface IBlogPostServices
{
    Task<bool> Create(BlogPostModel post);
}
