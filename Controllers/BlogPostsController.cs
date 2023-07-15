
using Mediator.Blog.Commands;
using Mediator.Blog.Models;
using Mediator.Blog.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Mediator.Controllers
{
    [ApiController]
    [Route("api/blog/posts")]
    public class BlogPostsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogPostsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlogPost(CreateBlogPostCommand command)
        {
            int postId = await _mediator.Send(command);
            return Ok(postId);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogPost(int id)
        {
            var query = new GetBlogPostQuery { PostId = id };
            BlogPost post = await _mediator.Send(query);

            if (post == null)
                return NotFound();

            return Ok(post);
        }
    }
}
