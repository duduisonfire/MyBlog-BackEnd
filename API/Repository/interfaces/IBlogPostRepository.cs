namespace API;

public interface IBlogPostRepository
{
    Task NewPost(Posts post);
    Task<List<Posts>> GetPosts(int numberOfPostToSkip);
}
