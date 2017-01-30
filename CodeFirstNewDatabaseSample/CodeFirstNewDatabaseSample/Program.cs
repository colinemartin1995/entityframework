using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {


        }



        public class Blog
        {
            public int BlogId { get; set; }
            public string Name { get; set; }
            public virtual List<Post> ListPosts { get; set; }


        }

        public class Post
        {
            public int PostId { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }
            public int BlogId { get; set; }
            public virtual List<Tag> ListTags { get; set; }
            public virtual Blog Blog { get; set; }
        }

        public class Tag
        {
            public int TagId { get; set; }
            public string Intitule { get; set; }

            public virtual List<Post> ListPosts { get; set; }
        }

        public class BloggingContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Tag> Tags { get; set; }
        }



    }

}
