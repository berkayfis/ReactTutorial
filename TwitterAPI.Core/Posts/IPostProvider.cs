using System.Collections.Generic;
using TwitterAPI.Core.Context;

namespace TwitterAPI.Core.Posts
{
    public interface IPostProvider
    {
        IEnumerable<Post> GetPosts();
        Post CreatePost(PostRequestModel model);
    }
}
