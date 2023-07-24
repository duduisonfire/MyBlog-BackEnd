namespace API;

public class BlogPostModel
{
    public int? Id { get; set; }
    public required string PostTitle { get; set; }
    public required string PostCategory { get; set; }
    public required string PostDescription { get; set; }
    public required string PostAuthor { get; set; }
    public required string Post { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
