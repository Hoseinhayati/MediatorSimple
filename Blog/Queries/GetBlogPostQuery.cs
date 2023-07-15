using Mediator.Blog.Models;
using MediatR;

namespace Mediator.Blog.Queries
{
    public class GetBlogPostQuery : IRequest<BlogPost>
    {
        public int PostId { get; set; }
    }
}
