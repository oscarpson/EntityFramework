using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityTutorial.Data;

namespace EntityTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogManager = new BlogManager();

            //Insert new Record
            var TempBlog = blogManager.CSCreateBlog();
            TempBlog.BlogId = 1;
            TempBlog.name = "How to work with Entity";
            blogManager.CSInsertBlog(TempBlog);

            Console.WriteLine("Insert Complete");
            Console.ReadKey();

            /**
            //Update Record
            var BlogToUpdate = blogManager.CSCreateBlog();
            BlogToUpdate.BlogId = 1;
            BlogToUpdate.name = "How to work with entity V6.2.0";
            blogManager.CSUpdateBlog(BlogToUpdate);

            Console.WriteLine("Update Complete");
            Console.ReadKey();

            //Delete Record
            blogManager.CSDeleteBlog(1);
            Console.WriteLine("Delete Complete");
            Console.ReadKey();
             * */

            //Select Record
            var FoundBlog = blogManager.CSGetBlog(1);
            Console.WriteLine("Blog Name: " + FoundBlog.name);

            Console.WriteLine("Record Found");
            Console.ReadKey();
        }
    }
}
