using ForumApp.Data.Models;

namespace ForumApp.Data.Services.Services.PostConracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPostService
    {
        Task<IEnumerable<PostViewModel>> GetAllPostAsync();
        Task AddPostAsync(PostFormModel model);

        Task<PostFormModel> GetPostById(int id);

        Task EditedPost(int id, PostFormModel model);

        Task DeletePost(int id);
    }
}
