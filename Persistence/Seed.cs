using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post
                    {
                        Title = "First post",
                        Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc volutpat ut lacus sed pulvinar. Etiam feugiat varius pellentesque. Cras at mauris a lacus mattis auctor.",
                        Date = DateTime.Now.AddDays(-10)
                    },
                    new Post
                    {
                        Title = "Second post",
                        Body = "Curabitur viverra ipsum id orci interdum, quis iaculis tellus tincidunt. Cras finibus mauris quis ornare finibus. Aliquam sollicitudin placerat elit.",
                        Date = DateTime.Now.AddDays(-7)
                    },
                    new Post
                    {
                        Title = "Third post",
                        Body = "Etiam et venenatis metus, vitae iaculis nunc. Phasellus tempor condimentum pellentesque. Maecenas enim dui, feugiat sit amet rutrum vitae, finibus nec ipsum. Integer condimentum sit amet arcu imperdiet tristique.",
                        Date = DateTime.Now.AddDays(-4)
                    }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}