using API.Repository;

namespace API;

public interface IBlogPostServices
{
    Task Create(Posts post);
    Task<List<Posts>> GetPosts(int page);
}
