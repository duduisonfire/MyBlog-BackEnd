using Microsoft.AspNetCore.Mvc;

namespace API;

[ApiController]
[Route("api/posts")]
public class BlogPostController : ControllerBase
{
    private readonly ILogger<BlogPostController> _logger;
    private readonly IBlogPostServices _blogPostServices;

    public BlogPostController(ILogger<BlogPostController> logger, IBlogPostServices blogPostServices)
    {
        _logger = logger;
        _blogPostServices = blogPostServices;
    }

    [HttpGet]
    public async Task<ActionResult> CreatePost([FromBody] BlogPostModel post)
    {
        if (post == null)
            return BadRequest("Empty request.");

        var isCreated = await _blogPostServices.Create(post);

        if (!isCreated)
            return BadRequest("The database doesn't responding.");

        return Ok(post);
    }
}
