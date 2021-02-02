using System.Collections.Generic;

namespace TwitterAPI.Core.Posts
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetPosts();
        PostDto CreatePost(PostRequestModel model);
    }
}
