using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/posts")]
public class BlogPostController : ControllerBase
{
    private readonly ILogger<BlogPostController> _logger;
    private readonly IBlogPostServices _blogPostServices;

    public BlogPostController(
        ILogger<BlogPostController> logger,
        IBlogPostServices blogPostServices
    )
    {
        _logger = logger;
        _blogPostServices = blogPostServices;
    }

    [EnableCors]
    [HttpPost]
    public async Task<ActionResult> CreatePost([FromBody] BlogPostModel post)
    {
        try
        {
            await _blogPostServices.Create(post);
            return Ok(post);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}
