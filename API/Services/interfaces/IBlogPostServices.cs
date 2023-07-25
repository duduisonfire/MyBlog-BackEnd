using API.Repository;

namespace API;

public interface IBlogPostServices
{
    Task Create(BlogPostModel post);
}
