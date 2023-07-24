using API.Repository.Classes;

namespace API;

public interface IBlogPostServices
{
    Task<DbMessenger> Create(BlogPostModel post);
}
