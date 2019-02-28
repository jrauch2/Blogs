using System;
using System.Linq;

namespace Blogs.Models
{
    public interface IBloggingRepository
    {
        IQueryable<Blog> Blogs { get; }
        IQueryable<Post> Posts { get; }

        // TODO: AddBlog, UpdateBlog, DeleteBlog
        // TODO: AddPost, UpdatePost, DeletePost
    }
}
