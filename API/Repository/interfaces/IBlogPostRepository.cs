namespace API;

public interface IBlogPostRepository
{
    Task<bool> NewPost(BlogPostModel post);
}
