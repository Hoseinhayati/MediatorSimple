using Mediator.Blog.Commands;
using Mediator.Blog.Models;
using Mediator.Blog.Queries;
using MediatR;
using System.Reflection.Metadata.Ecma335;

namespace Mediator.Blog.CommandHandlers
{
    public class CreateBlogPostCommandHandler : IRequestHandler<CreateBlogPostCommand, int>
    {
        public async Task<int> Handle(CreateBlogPostCommand request, CancellationToken cancellationToken)
        {
            // Logic for creating a new blog post
            // Persist the post and return the ID
            return 0;
        }
    }

    public class GetBlogPostQueryHandler : IRequestHandler<GetBlogPostQuery, BlogPost>
    {
        public async Task<BlogPost> Handle(GetBlogPostQuery request, CancellationToken cancellationToken)
        {
            // Logic for retrieving a blog post by ID
            // Fetch the post from the data store and return it
            return new BlogPost();
        }
    }

}
