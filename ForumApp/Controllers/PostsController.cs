using ForumApp.Data.Services;
using ForumApp.Data.Services.Services.PostConracts;

namespace ForumApp.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PostsController : Controller
    {
        private readonly IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }
        public async Task<IActionResult> All()
        {
            var posts = await postService.GetAllPostAsync();

            return View(posts);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await postService.AddPostAsync(model);
            }
            catch (Exception)
            {
               ModelState.AddModelError(string.Empty,"Unexpected error occurred while post has been added!");
               return View(model);
            }

            return RedirectToAction("All");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model =  await postService.GetPostById(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,PostFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await postService.EditedPost(id, model);
                return RedirectToAction("All");
            }
            catch (Exception)
            {
              ModelState.AddModelError(string.Empty,"Error");
              return View(model);
            }
        }
        public async Task<IActionResult> Delete(int id)
        {
            await postService.DeletePost(id);

            return RedirectToAction("All");
        }

    }
}
