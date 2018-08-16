using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityTutorial.Data
{
    public class DataContext: DbContext
    {
        public DataContext()
        {
            this.Database.Connection.ConnectionString = @"Server=.\sqlexpress;Database=Entitydb;User Id=sa;Password=*******;";

            //This blocks the creation of the database
            Database.SetInitializer<DataContext>(null);
        }

        //This defines the database link
        public DbSet<Blog> Blogs { get; set; }
    }
}
