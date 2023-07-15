namespace Mediator.Blog.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        // Add any other properties as needed

        // Optional: You can include behavior/methods specific to the BlogPost entity
        public void Publish()
        {
            // Add logic for publishing a blog post
        }

        // Optional: You can include additional methods, validation, etc.
    }
}
