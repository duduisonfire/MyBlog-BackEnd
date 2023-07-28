namespace API;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Posts")]
public class Posts
{
    [Key]
    public int? Id { get; set; }

    [Required]
    [Column("PostTitle")]
    public required string PostTitle { get; set; }

    [Column("PostCategory")]
    [Required]
    public required string PostCategory { get; set; }

    [Column("PostDescription")]
    [Required]
    public required string PostDescription { get; set; }

    [Column("PostAuthor")]
    [Required]
    public required string PostAuthor { get; set; }

    [Column("Post")]
    [Required]
    public required string Post { get; set; }

    [Column("PostImage")]
    [Required]
    public required string PostImage { get; set; }

    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
