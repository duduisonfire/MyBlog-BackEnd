using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

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

    [HttpPost]
    public async Task<ActionResult> CreatePost([FromBody] BlogPostModel post)
    {
        var isCreated = await _blogPostServices.Create(post);

        if (!isCreated)
            return BadRequest("The database doesn't responding.");

        return Ok(post);
    }
}
