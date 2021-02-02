using AutoMapper;
using System.Collections.Generic;
using TwitterAPI.Core.Posts;

namespace TwitterAPI.Services
{
    public class PostService : IPostService
    {
        private readonly IPostProvider postProvider;
        private readonly IMapper mapper;

        public PostService(IPostProvider postProvider, IMapper mapper)
        {
            this.postProvider = postProvider;
            this.mapper = mapper;
        }        

        public IEnumerable<PostDto> GetPosts()
        {
            var post = postProvider.GetPosts();
            return mapper.Map<IEnumerable<PostDto>>(post);
        }
        public PostDto CreatePost(PostRequestModel model)
        {
            var post = postProvider.CreatePost(model);
            return mapper.Map<PostDto>(post);
        }
    }
}
