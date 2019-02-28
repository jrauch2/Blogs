using System;
using System.Linq;

namespace Blogs.Models
{
    public interface IBloggingRepository
    {
        IQueryable<Blog> Blogs { get; }
        IQueryable<Post> Posts { get; }

        void AddBlog(Blog blog);
        // TODO: UpdateBlog, DeleteBlog
        // TODO: AddPost, UpdatePost, DeletePost
    }
}
