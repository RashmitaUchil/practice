using Async_await.Models;
using Async_await.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Async_await.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PostService _postService;

        public IndexModel()
        {
            _postService = new PostService();
        }

        public List<Post> Posts { get; private set; }

        public async Task OnGetAsync()
        {
            Posts = await _postService.GetPostsAsync();
        }
    }
}
