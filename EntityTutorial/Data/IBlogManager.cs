using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityTutorial.Data
{
    public interface IBlogManager
    {
        //Blogs
        Blog CSCreateBlog();
        void CSInsertBlog(Blog TempBlog);
        void CSUpdateBlog(Blog TempBlog);
        void CSDeleteBlog(int BlogId);
        Blog CSGetBlog(int BlogId);
        bool CSBlogExists(int BlogId);
    }
}
