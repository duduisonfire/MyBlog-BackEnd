using API.Repository;

namespace API;

public interface IBlogPostRepository
{
    Task NewPost(BlogPostModel post);
}
