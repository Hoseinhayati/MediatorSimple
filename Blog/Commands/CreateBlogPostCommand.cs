using MediatR;

namespace Mediator.Blog.Commands
{
    public class CreateBlogPostCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
