using System;
using System.Linq;

namespace Blogs.Models
{
    public interface IBloggingRepository
    {
        IQueryable<Blog> Blogs { get; }
        IQueryable<Post> Posts { get; }

        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        // TODO: UpdateBlog
        // TODO: AddPost, UpdatePost, DeletePost
    }
}
