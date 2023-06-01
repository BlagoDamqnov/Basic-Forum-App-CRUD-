using ForumApp.Data.Models;
using ForumApp.Data.Services.Services.PostConracts;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PostService:IPostService
    {
        private readonly PostDbContext dbContext;

        public PostService(PostDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<PostViewModel>> GetAllPostAsync()
        {
            var allPosts = await dbContext.Posts
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToListAsync();

            return allPosts;
        }

        public async Task AddPostAsync(PostFormModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

            await dbContext.Posts.AddAsync(post);
            await dbContext.SaveChangesAsync();
        }

        public async Task<PostFormModel> GetPostById(int id)
        {
           var post =  await dbContext.Posts.FirstOrDefaultAsync(p => p.Id == id);

           return new PostFormModel()
           {
               Title = post.Title,
               Content = post.Content
           };
        }

        public async Task EditedPost(int id, PostFormModel model)
        {
            var postToEdit = await dbContext.Posts.FirstOrDefaultAsync(p => p.Id == id);

            if (postToEdit != null)
            {
                postToEdit.Title = model.Title;
                postToEdit.Content = model.Content;

                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeletePost(int id)
        {
            var post = await dbContext.Posts.FirstOrDefaultAsync(p => p.Id == id);
            
            dbContext.Posts.Remove(post);
           await dbContext.SaveChangesAsync();
        }
    }
}
