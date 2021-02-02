using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TwitterAPI.Core.Posts;

namespace TwitterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private ILogger<PostController> logger;
        private IPostService postService;

        public PostController(ILogger<PostController> logger, IPostService postService)
        {
            this.logger = logger;
            this.postService = postService;
        }

        [HttpGet]
        [Route("posts")]
        public ActionResult<IEnumerable<PostDto>> GetPosts()
        {
            var posts = postService.GetPosts();
            return Ok(posts);
        }

        [HttpPost]
        [Route("create")]
        public ActionResult<PostDto> CreatePost([FromBody]PostRequestModel model)
        {
            var post = postService.CreatePost(model);
            return Created("create",post);
        }
    }
}
