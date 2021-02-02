using AutoMapper;
using MongoDB.Driver;
using System.Collections.Generic;
using TwitterAPI.Core.Context;
using TwitterAPI.Core.Posts;

namespace TwitterAPI.Providers
{
    public class PostProvider : IPostProvider
    {
        private IMongoCollection<Post> Posts;
        private IMapper Mapper;
        public PostProvider(ITwitterDatabaseSettings settings, IMapper mapper)
        {
            Mapper = mapper;
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Posts = database.GetCollection<Post>("posts");
        }
        public IEnumerable<Post> GetPosts()
        {
            return Posts.Find(x => true).ToEnumerable();
        }

        public Post CreatePost(PostRequestModel model)
        {
            var dbPost = Mapper.Map<Post>(model);
            Posts.InsertOne(dbPost);
            return dbPost;
        }

    }
}
