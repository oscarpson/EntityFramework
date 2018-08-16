using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityTutorial.Data
{
    public class BlogManager: IBlogManager
    {
        //Blogs
        public Blog CSCreateBlog()
        {
            var TempBlog = new Blog();
            return TempBlog;
        }

        public void CSInsertBlog(Blog TempBlog)
        {
            using (var db = new DataContext())
            {
                db.Blogs.Add(TempBlog);
                db.SaveChanges();
            }
        }

        public void CSUpdateBlog(Blog TempBlog)
        {
            using (var db = new DataContext())
            {
                db.Entry(TempBlog).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void CSDeleteBlog(int BlogId)
        {
            using (var db = new DataContext())
            {
                var TempBlog = db.Blogs.Find(BlogId);
                if (TempBlog != null)
                {
                    db.Entry(TempBlog).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
        }

        public Blog CSGetBlog(int BlogId)
        {
            using (var db = new DataContext())
            {
                return db.Blogs.Find(BlogId);
            }
        }

        public bool CSBlogExists(int BlogId)
        {
            using (var db = new DataContext())
            {
                if (db.Blogs.Find(BlogId) == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

    }
}
