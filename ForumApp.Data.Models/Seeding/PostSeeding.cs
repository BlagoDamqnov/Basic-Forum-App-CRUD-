namespace ForumApp.Data.Models.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class PostSeeding
    {
        public static Post[] SeedPost()
        {
            List<Post> seededPosts = new List<Post>();
            Post post;

            post = new Post()
            {
                Id = 1,
                Title = "First post today!",
                Content = "First content today"
            };

            seededPosts.Add(post);

            post = new Post()
            {
                Id = 2,
                Title = "Second post today!",
                Content = "Second content today"
            };

            seededPosts.Add(post);

            post = new Post()
            {
                Id = 3,
                Title = "Third post today!",
                Content = "Third content today"
            };

            seededPosts.Add(post);

            return seededPosts.ToArray();
        }
    }
}
