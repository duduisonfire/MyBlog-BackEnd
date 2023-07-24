using API.Repository.Classes;

namespace API;

public interface IBlogPostRepository
{
    Task<DbMessenger> NewPost(BlogPostModel post);
}
