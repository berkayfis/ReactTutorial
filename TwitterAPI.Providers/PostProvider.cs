using AutoMapper;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Collections.Generic;
using TwitterAPI.Core.Context;
using TwitterAPI.Core.Posts;

namespace TwitterAPI.Providers
{
    public class PostProvider : IPostProvider
    {
        private IMongoCollection<Post> Posts;
        private IMapper Mapper;
        private IMongoCollection<User> Users;
        private User currentUser;

        public PostProvider(ITwitterDatabaseSettings settings, IMapper mapper)
        {
            Mapper = mapper;
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            Posts = database.GetCollection<Post>("posts");
            Users = database.GetCollection<User>("users");
            currentUser = Users.AsQueryable().Sample(1).FirstOrDefault();
        }
        public IEnumerable<Post> GetPosts()
        {
            return Posts.Find(x => true).ToEnumerable();
        }

        public Post CreatePost(PostRequestModel model)
        {
            var dbPost = Mapper.Map<Post>(model);
            dbPost.User = currentUser;
            Posts.InsertOne(dbPost);
            return dbPost;
        }

    }
}
