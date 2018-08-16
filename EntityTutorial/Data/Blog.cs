using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityTutorial.Data
{
    [Table("Blogs")]
    public class Blog
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BlogId { get; set; }
        public string name { get; set; }

        public Blog()
        {
        }

    }
}
